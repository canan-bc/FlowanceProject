using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowanceProject.BusinessLayer.Abstract;
using FlowanceProject.DataAccessLayer.Abstract;
using FlowanceProject.EntityLayer.Concrete;

namespace FlowanceProject.BusinessLayer.Concrete
{
    public class CustomerAccountProcessManager : ICustomerAccountProcessService
    {
        private readonly ICustomerAccountProcessDal _customerAccountProcessDal;
        public CustomerAccountProcessManager(ICustomerAccountProcessDal customerAccountProcessDal)
        {
            _customerAccountProcessDal = customerAccountProcessDal;
        }

        public void TDelete(CustomerAccountProcess t)
        {
            _customerAccountProcessDal.Delete(t); 
        }

        public CustomerAccountProcess TGetByID(int id)
        {
            return _customerAccountProcessDal.TGetByID(id);
        }

        public List<CustomerAccountProcess> TGetList()
        {
            return _customerAccountProcessDal.TetList();
        }

        public void TInsert(CustomerAccountProcess t)
        {
            _customerAccountProcessDal.Insert(t);
        }

        public void TUpdate(CustomerAccountProcess t)
        {
            _customerAccountProcessDal.Update(t);

        }
    }
}
