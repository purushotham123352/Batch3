using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDemo.Repositories
{
    class Service2:IService1
    {
        public void Task()
        {
            Console.WriteLine("Service2_Task is Running");
        }
    }
}
