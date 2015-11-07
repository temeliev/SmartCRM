namespace SmartCRM.BOL.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;

    using AutoMapper;

    using SmartCRM.BOL.Models;
    using SmartCRM.DAL;

    public class EmployeeRepository
    {
        public Employee GetEmployeeById(SmartCRMEntitiesModel db, Employee model)
        {
            Employee user = db.Employees.FirstOrDefault(x => x.Id == model.Id);

            return user;
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
                Mapper.Map(poco, model);
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

            Mapper.Map(employeeModel, pocoEmployee);
        }

        private void InsertEmployee(SmartCRMEntitiesModel db, EmployeeModel employeeModel)
        {
            Employee pocoEmployee = new Employee();
            Mapper.Map(employeeModel, pocoEmployee);
            db.Add(pocoEmployee);
        }

        public void DeleteEmployee(SmartCRMEntitiesModel db, Employee employeeModel)
        {
            Employee pocoEmployee = db.Employees.FirstOrDefault(x => x.Id == employeeModel.Id);
            if (pocoEmployee == null)
            {
                throw new NullReferenceException("Missing user in database!");
            }

            db.Delete(pocoEmployee);
        }
    }
}
