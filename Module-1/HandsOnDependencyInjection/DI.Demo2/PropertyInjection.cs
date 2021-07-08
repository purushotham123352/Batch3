using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Demo2
{
    class PropertyInjection
    {
        private IService _service;
        public IService Service
        {
            set { this._service = value; }
        }
        public void ServeMethod() { this._service.Serve(); }
        static void Main()
        {
            //creating object
            Service1 s1 = new Service1();

            PropertyInjection client = new PropertyInjection();
            client.Service = s1; //passing dependency
                                 

            Service2 s2 = new Service2();
            client.Service = s2; //passing dependency
                               
        }
    }
    }
}
