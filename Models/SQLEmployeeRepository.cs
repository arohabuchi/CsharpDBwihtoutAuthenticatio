using System;
using System.Linq;
using System.Collections.Generic;

namespace EmlpoyeeMgt.Models
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext Context;
        public SQLEmployeeRepository(AppDbContext Context){
            this.Context=Context;
        }
        public Employee Add(Employee employee){
            Context.Employees.Add(employee);
            Context.SaveChanges();
            return employee;
        }
        public Employee Delete(int id){
            Employee employee = Context.Employees.Find(id);
            if (employee != null)
            {
                
                Context.Employees.Remove(employee);
                Context.SaveChanges();
            }
            return employee;
        }
        public IEnumerable<Employee> GetAllEmployee(){
            return Context.Employees;
        }
        public Employee GetEmployee(int Id)
        {
            return Context.Employees.Find(Id);
        }
        public Employee Update(Employee employeeChanges)
        {
            var employee = Context.Employees.Attach(employeeChanges);
            employee.State=Microsoft.EntityFrameworkCore.EntityState.Modified;
            Context.SaveChanges();
            return employeeChanges;
        }

    }
}