namespace SmartCRM.BOL.Controllers
{
    using System;
    using System.ComponentModel;

    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Repositories;
    using SmartCRM.BOL.Utilities;
    using SmartCRM.BOL.Validators;

    public class EmployeeController
    {
        private EmployeeController()
        {
            this.Employees = new BindingList<EmployeeModel>();
        }

        public BindingList<EmployeeModel> Employees { get; private set; }

        public EmployeeModel CurrentEmployee { get; private set; }

        public static EmployeeController CreateIntance()
        {
            return new EmployeeController();
        }

        public void LoadAllActiveUsers()
        {
            this.LoadAllEmployees(true);
        }

        public void LoadAllUsers()
        {
            this.LoadAllEmployees(false);
        }

        public void SetEmployee(EmployeeModel employee)
        {
            this.CurrentEmployee = employee;
        }

        public CheckResult SaveEmployee()
        {
            using (var db = DbManager.CreateInstance())
            {
                CheckResult check = CheckResult.Default;
                //UserValidator validator = new UserValidator();
                //check = validator.ValidateUser(db, this.CurrentUser);
                //if (!check.Success)
                //{
                //    return check;
                //}

                //if (this.CurrentUser.UserId == 0)
                //{
                //    check = validator.ValidateIfUserExistInDatabase(db, this.CurrentUser);
                //    if (!check.Success)
                //    {
                //        return check;
                //    }
                //}

                //UserRepository rep = new UserRepository();
                //rep.SaveUser(db, this.CurrentUser);
                //db.SaveChanges();
                //this.CurrentUser.AcceptChanges();

                //if (this.CurrentUser.UserId == 0)
                //{
                //    this.AddUser();
                //}

                return check;
            }
        }

        public void AddEmployee()
        {
            this.Employees.Add(this.CurrentEmployee);
        }

        public CheckResult DeleteEmployee(EmployeeModel focusedUser)
        {
            CheckResult check = CheckResult.Default;
            //using (var db = DbManager.CreateInstance())
            //{
            //    try
            //    {
            //        UserRepository rep = new UserRepository();
            //        rep.DeleteUser(db, focusedUser);
            //        db.SaveChanges();
            //        this.Users.Remove(focusedUser);
            //    }
            //    catch (Exception ex)
            //    {
            //        check.Details.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, "InvalidDeletion", "Cannot delete this user!"));
            //        return check;
            //    }

            //    return check;
            //}
            return check;
        }

        private void LoadAllEmployees(bool isActive)
        {
            using (var db = DbManager.CreateInstance())
            {
                EmployeeRepository rep = new EmployeeRepository();
                this.Employees = rep.LoadAllEmployees(db, isActive);
            }
        }

        public EmployeeModel GetEmbloyeeById(uint employeeId)
        {
            using (var db = DbManager.CreateInstance())
            {
                EmployeeRepository rep = new EmployeeRepository();
                var employee = rep.GetEmployeeById(db, employeeId);
                return employee;
            }
        }
    }
}
