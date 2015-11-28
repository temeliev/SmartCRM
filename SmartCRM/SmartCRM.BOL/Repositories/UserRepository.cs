namespace SmartCRM.BOL.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;

    using AutoMapper;

    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Utilities;
    using SmartCRM.DAL;
    using SmartCRM.Resources;

    public class UserRepository
    {
        public UserModel GetUserByModel(SmartCRMEntitiesModel db, UserModel model)
        {
            User user = db.Users.FirstOrDefault(x => x.Username == model.Username && x.Password == model.Password && x.IsEnabled);

            if (user != null)
            {
                UserModel userModel = UserModel.Create();
                MapHelper.Map(user, userModel);
                return userModel;
            }

            return null;
        }

        public BindingList<UserModel> LoadAllUsers(SmartCRMEntitiesModel db, bool isActive)
        {
            List<User> pocoUsers;
            if (isActive)
            {
                pocoUsers = db.Users.Where(x => x.IsEnabled).ToList();
            }
            else
            {
                pocoUsers = db.Users.ToList();
            }

            var modelUsers = new BindingList<UserModel>();
            foreach (var poco in pocoUsers)
            {
                UserModel model = UserModel.Create();
                MapHelper.Map(poco, model);
                model.AcceptChanges();
                modelUsers.Add(model);
            }

            return modelUsers;
        }

        public void SaveAccount(SmartCRMEntitiesModel db, UserModel userModel, EmployeeModel employeeModel)
        {
            if (userModel.IsNew)
            {
                this.InsertAccount(db, userModel, employeeModel);
            }
            else
            {
                this.UpdateAccount(db, userModel, employeeModel);
            }
        }

        private void UpdateAccount(SmartCRMEntitiesModel db, UserModel userModel, EmployeeModel employeeModel)
        {
            var pocoUser = db.Users.FirstOrDefault(x => x.UserId.Equals(userModel.UserId));
            if (pocoUser == null)
            {
                throw new NullReferenceException("Missing user!");
            }

            MapHelper.Map(userModel, pocoUser);
            MapHelper.Map(employeeModel, pocoUser.Employee);
        }

        private void InsertAccount(SmartCRMEntitiesModel db, UserModel userModel, EmployeeModel employeeModel)
        {
            User pocoUser = new User();
            MapHelper.Map(userModel, pocoUser);
            Employee pocoEmployee = new Employee();
            MapHelper.Map(employeeModel, pocoEmployee);
            pocoUser.Employee = pocoEmployee;
            db.Add(pocoUser);
        }

        public void SaveUser(SmartCRMEntitiesModel db, UserModel userModel)
        {
            if (userModel.UserId == 0)
            {
                this.InsertUser(db, userModel);
            }
            else
            {
                this.UpdateUser(db, userModel);
            }
        }

        private void UpdateUser(SmartCRMEntitiesModel db, UserModel userModel)
        {
            var pocoUser = db.Users.FirstOrDefault(x => x.UserId.Equals(userModel.UserId));
            if (pocoUser == null)
            {
                throw new NullReferenceException("Missing user!");
            }

            Mapper.Map(userModel, pocoUser);
        }

        private void InsertUser(SmartCRMEntitiesModel db, UserModel userModel)
        {
            User pocoUser = new User();
            Mapper.Map(userModel, pocoUser);
            db.Add(pocoUser);
        }

        public void DeleteUser(SmartCRMEntitiesModel db, UserModel userModel)
        {
            User pocoUser = db.Users.FirstOrDefault(x => x.UserId == userModel.UserId);
            if (pocoUser == null)
            {
                throw new NullReferenceException("Missing user in database!");
            }

            db.Delete(pocoUser);
        }

        public UserModel GetUserByEmployeeId(SmartCRMEntitiesModel db, uint employeeId)
        {
            User pocoUser = db.Users.FirstOrDefault(x => x.EmployeeId == employeeId);
            if (pocoUser == null)
            {
                return null;
            }

            UserModel model = UserModel.Create();
            Mapper.Map(pocoUser, model);
            return model;
        }
    }
}
