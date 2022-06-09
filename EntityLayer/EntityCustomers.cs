using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityCustomers
    {
        private int ID;
        private string NAME;
        private string LASTNAME;
        private string CITY;
        private string TASK;
        private short PAYING;

        public int Id { get => ID; set => ID = value; }
        public string Name { get => NAME; set => NAME = value; }
        public string LastName { get => LASTNAME; set => LASTNAME = value; }
        public string City { get => CITY; set => CITY = value; }
        public string Task { get => TASK; set => TASK = value; }
        public short Paying { get => PAYING; set => PAYING = value; }
        
    }
}
