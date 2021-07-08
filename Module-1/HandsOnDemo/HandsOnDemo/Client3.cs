using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDemo
{
    class Client3
    {
        public Service service = null;
        public Client3()
        {
            service = new Service();
        }
        public void DO()
        {
            service.AddEmployee();
        }
        static void Main()
        {
            Client3 client = new Client3();
        }
    }
}
