using System;
using System.Linq;
using System.Collections.Generic;


namespace EmlpoyeeMgt.Models
{
    public class mockEmployeeRepository:IEmployeeRepository
    {
      
        private List<Employee> _employeeList;
        public mockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){ Id=1, Name="sammy", Department=Dept.HR, Email="sammy@gmail.com"},

                new Employee(){ Id=2, Name="Tonny", Department=Dept.IT, Email="tonny@gmail.com"},

                new Employee() { Id = 3, Name="chris", Department=Dept.Supervisor, Email="chris@gmail.com"}

            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id ==Id);
        }
        
        public IEnumerable<Employee> GetAllEmployee(){
            return _employeeList;
        }
        public Employee Add(Employee employee){
            // to  AUTOgenerate ID
            employee.Id =_employeeList.Max(e=>e.Id)+1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id ==employeeChanges.Id);
            if (employee != null)
            {
               employee.Name=employeeChanges.Name;
               employee.Email=employeeChanges.Email;
               employee.Department=employeeChanges.Department;
            }
            return employee;
        }



        public Employee Delete(int Id)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id ==Id);
            if (employee != null)
            {
                _employeeList.Remove(employee);
            }
            return employee;
        }
    
    }
}