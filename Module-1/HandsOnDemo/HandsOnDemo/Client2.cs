using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOnDemo.Repositories;
namespace HandsOnDemo
{
    class Client2
    {
        public IService1 _service1 = null;

        public Client2(IService1 service1)
        {
            _service1 = new Service1();
        }
        public void Task()
        {
            _service1.Task();
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(args[0]);
            Client2 client1 = new Client2(new Service1());
            client1.Task();
           client1 = new Client2(new Service2());
            client1.Task();
        }
    }

}
