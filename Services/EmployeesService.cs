using AutoMapper;
using Database;
using Repository.Interface;
using Repository.UOW;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViewModel;

namespace Services
{
    public class EmployeesService : IEmployees
    {
        private readonly IGenericRepostory<Temployee> _employeeRepo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public EmployeesService(IGenericRepostory<Temployee> employeeRepo, IMapper mapper, IUnitOfWork unitOfWork) {
            _employeeRepo = employeeRepo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public bool AddEmployee(EmployeesModel emp)
        {
            Temployee x = _mapper.Map<Temployee> (emp);
            _employeeRepo.Add(x);
            _unitOfWork.SaveChanges();
            return true;
        }

        public bool DeleteEmployee(int id)
        {
            Temployee emp = _employeeRepo.GetByID(id);
            _employeeRepo.Delete(emp);
            _unitOfWork.SaveChanges();
            return true;
        }

        public IEnumerable<EmployeesModel> GetAllEmployee()
        {
            IEnumerable<Temployee> emps = _employeeRepo.Get().AsQueryable();
            IEnumerable<EmployeesModel> x=_mapper.Map<IEnumerable<EmployeesModel>>(emps);
            return x;
        }

        public EmployeesModel GetEmployee(int id)
        {
            Temployee emps = _employeeRepo.GetByID(id);
            EmployeesModel x = _mapper.Map<EmployeesModel>(emps);
            return x;
        }

        public bool UpdateEmployee(EmployeesModel emp)
        {
            Temployee x = _mapper.Map<Temployee>(emp);
            _employeeRepo.Update(x);
            _unitOfWork.SaveChanges();
            return true;
        }
    }
}
