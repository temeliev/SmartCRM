namespace SmartCRM.BOL.Controllers
{
    using System;
    using System.ComponentModel;

    using SmartCRM.BOL.Controllers.Events;
    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Models.Enums;
    using SmartCRM.BOL.Repositories;
    using SmartCRM.BOL.Utilities;
    using SmartCRM.BOL.Validators;

    using Telerik.OpenAccess.Exceptions;

    public class AccountController
    {
        private AccountController()
        {
            this.Users = new BindingList<UserModel>();
            this.Employees = new BindingList<EmployeeModel>();
        }

        public BindingList<UserModel> Users { get; private set; }

        public BindingList<EmployeeModel> Employees { get; private set; }

        public UserModel CurrentUser { get; private set; }

        public EmployeeModel CurrentEmployee { get; private set; }

        public event AccountHandler Changed;

        public delegate void AccountHandler(object sender, AccountChangedEventArgs e);

        public static AccountController Create()
        {
            return new AccountController();
        }

        #region Users

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
            if (this.CurrentUser != null)
            {
                this.CurrentUser.PropertyChanged += this.CurrentAccount_PropertyChanged;
                if (!this.CurrentUser.IsNew)
                {
                    this.CurrentUser.AcceptChanges();
                }
                else
                {
                    this.InvokeAccountChangedEvent();
                }
            }
        }

        private void InvokeAccountChangedEvent()
        {
            if (this.Changed != null)
            {
                bool isDirty = this.CurentEmployeeIsDirty() || this.CurentUserIsDirty();
                AccountChangedEventArgs accArgs = new AccountChangedEventArgs(isDirty);
                this.Changed(this, accArgs);
            }
        }

        void CurrentAccount_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.InvokeAccountChangedEvent();
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
                    this.Users.Add(this.CurrentUser);
                }

                return check;
            }
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
                catch (NullReferenceException nREx)
                {
                    //TODO Log
                    check.Details.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, "", nREx.Message));
                    return check;
                }
                catch (DataStoreException)
                {
                    check.Details.Add(
                        new CheckResultDetail(
                            CheckResultDetail.ErrorType.Error,
                            "InvalidDeletion",
                            Messages.CannotDeleteLinkedItem));
                    return check;
                }
                catch (Exception)
                {
                    //TODO Log
                    check.Details.Add(
                        new CheckResultDetail(
                            CheckResultDetail.ErrorType.Error,
                            "InvalidDeletion",
                            "Deletion failed!"));
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
                if (user != null)
                {
                    user.AcceptChanges();
                }

                return user;
            }
        }

        public bool HasUsers()
        {
            return this.Users.Count > 0;
        }

        public bool CurentUserIsDirty()
        {
            if (this.CurrentUser == null)
            {
                return false;
            }

            return this.CurrentUser.IsDirty;
        }

        public void AddCurrentUserToUsers()
        {
            if (this.CurrentUser != null && !this.Users.Contains(this.CurrentUser))
            {
                this.Users.Add(this.CurrentUser);
            }
        }

        #endregion Users

        #region Employees

        public void LoadAllActiveEmployees()
        {
            this.LoadAllEmployees(true);
        }

        public void LoadAllEmployees()
        {
            this.LoadAllEmployees(false);
        }

        /// <summary>
        /// Sets the current employee and accept changes
        /// </summary>
        /// <param name="employee">Employee</param>
        public void SetEmployee(EmployeeModel employee)
        {
            this.CurrentEmployee = employee;
            if (this.CurrentEmployee != null)
            {
                this.CurrentEmployee.PropertyChanged += this.CurrentAccount_PropertyChanged;
                if (!this.CurrentEmployee.IsNew)
                {
                    this.CurrentEmployee.AcceptChanges();
                }
                else
                {
                    this.InvokeAccountChangedEvent();
                }
            }
        }

        public bool HasEmployees()
        {
            return this.Employees.Count > 0;
        }

        public bool CurentEmployeeIsDirty()
        {
            if (this.CurrentEmployee == null)
            {
                return false;
            }

            return this.CurrentEmployee.IsDirty || this.CurrentEmployee.IsPhotoDirty;
        }

        public CheckResult SaveEmployee()
        {
            CheckResult result = CheckResult.Default;
            using (var db = DbManager.CreateInstance())
            {
                try
                {
                    EmployeeValidator validator = new EmployeeValidator();
                    result = validator.ValidateEmployee(db, this.CurrentEmployee);
                    if (!result.Success)
                    {
                        return result;
                    }

                    EmployeeRepository rep = new EmployeeRepository();
                    rep.SaveEmployee(db, this.CurrentEmployee);
                    db.SaveChanges();
                    this.CurrentEmployee.AcceptChanges();

                    return result;
                }
                catch (Exception ex)
                {
                    db.ClearChanges();
                    result.Details.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, "MessageBox", "Save failed!\n" + ex.Message));
                    return result;
                }
            }
        }

        public CheckResult DeleteEmployee(EmployeeModel focusedEmployee)
        {
            CheckResult check = CheckResult.Default;
            using (var db = DbManager.CreateInstance())
            {
                try
                {
                    EmployeeRepository rep = new EmployeeRepository();
                    rep.DeleteEmployee(db, focusedEmployee);
                    db.SaveChanges();
                    this.Employees.Remove(focusedEmployee);
                }
                catch (NullReferenceException nREx)
                {
                    //TODO Log
                    check.Details.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, "", nREx.Message));
                    return check;
                }
                catch (DataStoreException)
                {
                    check.Details.Add(
                        new CheckResultDetail(
                            CheckResultDetail.ErrorType.Error,
                            "InvalidDeletion",
                            Messages.CannotDeleteLinkedItem));
                    return check;
                }
                catch (Exception)
                {
                    //TODO Log
                    check.Details.Add(
                        new CheckResultDetail(
                            CheckResultDetail.ErrorType.Error,
                            "InvalidDeletion",
                            "Deletion failed!"));
                    return check;
                }

                return check;
            }
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

        public void AddCurrentEmployeeToEmployees()
        {
            if (this.CurrentEmployee != null && !this.Employees.Contains(this.CurrentEmployee))
            {
                this.Employees.Add(this.CurrentEmployee);
            }
        }

        #endregion Employees

        public CheckResult SaveAccount()
        {
            CheckResult result = CheckResult.Default;
            uint employeeId = this.CurrentEmployee.Id;
            using (var db = DbManager.CreateInstance())
            {
                try
                {
                    if (this.CurentEmployeeIsDirty())
                    {
                        EmployeeValidator employeeValidator = new EmployeeValidator();
                        var checkEmployee = employeeValidator.ValidateEmployee(db, this.CurrentEmployee);

                        if (!checkEmployee.Success)
                        {
                            result.Details.AddRange(checkEmployee.Details);
                        }
                        else
                        {
                            EmployeeRepository employeeRepository = new EmployeeRepository();
                            employeeRepository.SaveEmployee(db, this.CurrentEmployee);
                            this.CurrentUser.EmployeeId = this.CurrentEmployee.Id;
                        }
                    }

                    if (this.CurentUserIsDirty())
                    {
                        UserValidator userValidator = new UserValidator();
                        var checkUser = userValidator.ValidateUser(db, this.CurrentUser);
                        if (!checkUser.Success)
                        {
                            result.Details.AddRange(checkUser.Details);
                        }
                        else
                        {
                            checkUser = userValidator.ValidateIfUserExistInDatabase(db, this.CurrentUser);
                            if (!checkUser.Success)
                            {
                                result.Details.AddRange(checkUser.Details);
                            }
                            else
                            {
                                UserRepository userRepository = new UserRepository();
                                userRepository.SaveUser(db, this.CurrentUser);
                            }
                        }
                    }

                    if (!result.Success)
                    {
                        this.CurrentEmployee.Id = employeeId;
                        db.ClearChanges();
                        return result;
                    }

                    db.SaveChanges();

                    this.CurrentUser.AcceptChanges();
                    this.CurrentEmployee.AcceptChanges();
                }
                catch (Exception ex)
                {
                    //TODO Log
                    this.CurrentEmployee.Id = employeeId;
                    db.ClearChanges();
                    result.Details.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, "MessageBox", "Save failed!\n" + ex.Message));
                    return result;
                }
            }


            return result;
        }

        public void RemoveUser(UserModel focusedUser)
        {
            this.Users.Remove(focusedUser);
        }

        public void RemoveEmployee(EmployeeModel focusedEmployee)
        {
            this.Employees.Remove(focusedEmployee);
        }
    }
}
