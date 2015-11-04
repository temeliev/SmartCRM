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

    public class UserRepository
    {
        public User GetUserByModel(SmartCRMEntitiesModel db, UserModel model)
        {
            User user = db.Users.FirstOrDefault(x => x.Username == model.Username && x.Password == model.Password && x.IsEnabled);

            return user;
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
                Mapper.Map(poco, model);
                model.AcceptChanges();
                modelUsers.Add(model);
            }

            return modelUsers;
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
            User pocoUser = db.Users.FirstOrDefault(x => x.UserId==userModel.UserId);
            if (pocoUser == null)
            {
                throw new NullReferenceException("Missing user in database!");
            }

            db.Delete(pocoUser);
        }
    }
}
