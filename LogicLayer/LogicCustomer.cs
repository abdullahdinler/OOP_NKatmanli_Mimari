using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicCustomer
    {
        public static List<EntityCustomers> LCustomersList()
        {
            return DALCustomer.CustomersList();
        }

        public static int llCutomerAdd(EntityCustomers C)
        {
            return DALCustomer.CustomerAdd(C);
        }

        public static bool LllCustomerDelet(int e)
        {
            return DALCustomer.CustomerDelet(e);
        }

        public static int llCustomerUpdate(EntityCustomers U)
        {
            return DALCustomer.CustomerUpdate(U);
        }
    }
}
