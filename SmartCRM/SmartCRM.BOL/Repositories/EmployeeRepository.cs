namespace SmartCRM.BOL.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;

    using AutoMapper;

    using SmartCRM.BOL.Models;
    using SmartCRM.BOL.Models.Enums;
    using SmartCRM.BOL.Utilities;
    using SmartCRM.DAL;
    using SmartCRM.Resources;

    public class EmployeeRepository
    {
        public EmployeeModel GetEmployeeById(SmartCRMEntitiesModel db, uint employeeId)
        {
            Employee employee = db.Employees.FirstOrDefault(x => x.Id == employeeId);
            if (employee == null)
            {
                return null;
            }

            EmployeeModel model = EmployeeModel.Create();
            MapHelper.Map(employee, model);
            return model;
        }

        public BindingList<EmployeeModel> LoadAllEmployees(SmartCRMEntitiesModel db, bool isActive)
        {
            List<Employee> pocoEmployees;
            if (isActive)
            {
                pocoEmployees = db.Employees.Where(x => !x.IsDeleted).ToList();
            }
            else
            {
                pocoEmployees = db.Employees.ToList();
            }

            var modelEmployees = new BindingList<EmployeeModel>();
            foreach (var poco in pocoEmployees)
            {
                EmployeeModel model = EmployeeModel.Create();
                MapHelper.Map(poco, model);
                model.AcceptChanges();
                modelEmployees.Add(model);
            }

            return modelEmployees;
        }

        public void SaveEmployee(SmartCRMEntitiesModel db, EmployeeModel employeeModel)
        {
            if (employeeModel.Id == 0)
            {
                this.InsertEmployee(db, employeeModel);
            }
            else
            {
                this.UpdateEmployee(db, employeeModel);
            }
        }

        private void UpdateEmployee(SmartCRMEntitiesModel db, EmployeeModel employeeModel)
        {
            var pocoEmployee = db.Employees.FirstOrDefault(x => x.Id.Equals(employeeModel.Id));
            if (pocoEmployee == null)
            {
                throw new NullReferenceException("Missing employee!");
            }

            MapHelper.Map(employeeModel, pocoEmployee);
        }

        private void InsertEmployee(SmartCRMEntitiesModel db, EmployeeModel employeeModel)
        {
            Employee pocoEmployee = new Employee();
            MapHelper.Map(employeeModel, pocoEmployee);

            db.Add(pocoEmployee);
            db.FlushChanges();
            employeeModel.Id = pocoEmployee.Id;
        }

        public void DeleteEmployee(SmartCRMEntitiesModel db, EmployeeModel employeeModel)
        {
            Employee pocoEmployee = db.Employees.FirstOrDefault(x => x.Id == employeeModel.Id);
            if (pocoEmployee == null)
            {
                throw new NullReferenceException("Missing employee in database!");
            }

            db.Delete(pocoEmployee);
        }
    }
}
