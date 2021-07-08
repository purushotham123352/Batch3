using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Demo2
{
    class MethodInjection
    {
        private IService _service;
        public void Start(IService service)
        {
            service.Serve();
        }
        static void Main()
        {
            //creating object
            Service1 s1 = new Service1();

            MethodInjection client = new MethodInjection();
            client.Start(s1); //passing dependency
                            
            Service2 s2 = new Service2();
            client.Start(s2); //passing dependency
        }
    }
}
