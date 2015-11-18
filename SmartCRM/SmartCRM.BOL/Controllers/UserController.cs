namespace SmartCRM.BOL.Controllers
{
    using System;
    using System.ComponentModel;

    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Repositories;
    using SmartCRM.BOL.Utilities;
    using SmartCRM.BOL.Validators;

    public class UserController
    {
        private UserController()
        {
            this.Users = new BindingList<UserModel>();
        }

        public BindingList<UserModel> Users { get; private set; }

        public UserModel CurrentUser { get; private set; }

        public static UserController CreateIntance()
        {
            return new UserController();
        }

        public void LoadAllActiveUsers()
        {
            this.LoadAllUsers(true);
        }

        public void LoadAllUsers()
        {
            this.LoadAllUsers(false);
        }

        public void SetUser(UserModel user)
        {
            this.CurrentUser = user;
        }

        public CheckResult SaveUser()
        {
            using (var db = DbManager.CreateInstance())
            {
                UserValidator validator = new UserValidator();
                CheckResult check = validator.ValidateUser(db, this.CurrentUser);
                if (!check.Success)
                {
                    return check;
                }

                if (this.CurrentUser.UserId == 0)
                {
                    check = validator.ValidateIfUserExistInDatabase(db, this.CurrentUser);
                    if (!check.Success)
                    {
                        return check;
                    }
                }

                UserRepository rep = new UserRepository();
                rep.SaveUser(db, this.CurrentUser);
                db.SaveChanges();
                this.CurrentUser.AcceptChanges();

                if (this.CurrentUser.UserId == 0)
                {
                    this.AddUser();
                }

                return check;
            }
        }

        public void AddUser()
        {
            this.Users.Add(this.CurrentUser);
        }

        public CheckResult DeleteUser(UserModel focusedUser)
        {
            CheckResult check = CheckResult.Default;
            using (var db = DbManager.CreateInstance())
            {
                try
                {
                    UserRepository rep = new UserRepository();
                    rep.DeleteUser(db, focusedUser);
                    db.SaveChanges();
                    this.Users.Remove(focusedUser);
                }
                catch (Exception ex)
                {
                    check.Details.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, "InvalidDeletion", "Cannot delete this user!"));
                    return check;
                }

                return check;
            }
        }

        private void LoadAllUsers(bool isActive)
        {
            using (var db = DbManager.CreateInstance())
            {
                UserRepository rep = new UserRepository();
                this.Users = rep.LoadAllUsers(db, isActive);
            }
        }

        public UserModel GetUserByEmployeeId(uint employeeId)
        {
            using (var db = DbManager.CreateInstance())
            {
                UserRepository rep = new UserRepository();
                var user = rep.GetUserByEmployeeId(db, employeeId);
                return user;
            }
        }
    }
}
