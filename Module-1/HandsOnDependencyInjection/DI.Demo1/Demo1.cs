using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Demo1
{
    public interface Itext
    {
        void print();
    }
    class format : Itext
    {
        public void print()
        {
            Console.WriteLine(" here is text format");
        }
    }
    // constructor injection
    public class constructorinjection
    {
        private Itext _text;
        public constructorinjection(Itext t1)
        {
            this._text = t1;
        }
        public void print()
        {
            _text.print();
        }
    }
    class constructor
    {
        static void Main(string[] args)
        {
            constructorinjection cs = new constructorinjection(new format());
            cs.print();
            Console.ReadKey();
        }
    }
    class Demo1
    {
    }
}
