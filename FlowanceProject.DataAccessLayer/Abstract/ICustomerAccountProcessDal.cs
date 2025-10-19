using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowanceProject.EntityLayer.Concrete;

namespace FlowanceProject.DataAccessLayer.Abstract
{
    public interface ICustomerAccountProcessDal : IGenericDal<CustomerAccountProcess>
    {
        CustomerAccountProcess GetByID(int id);
        List<CustomerAccountProcess> GetList();
    }
}
