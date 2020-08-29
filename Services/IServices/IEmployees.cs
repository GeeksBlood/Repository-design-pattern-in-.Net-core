using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViewModel;

namespace Services.IServices
{
    public interface IEmployees
    {
        IEnumerable<EmployeesModel> GetAllEmployee();

        EmployeesModel GetEmployee(int id);

        bool AddEmployee(EmployeesModel emp);

        bool UpdateEmployee( EmployeesModel emp);
        bool DeleteEmployee(int id);
    }
}
