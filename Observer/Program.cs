using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            cliente[] obs = new cliente[10];

            cliente Cliente1 = new cliente("Cliente1");
            cliente Cliente2 = new cliente("Cliente2");
            tienda tienda1 = new tienda();
            tienda1.registrarObservador(Cliente1);
            tienda1.registrarObservador(Cliente2);
            tienda1.notifyObserver();
            tienda1.deleteObserver(Cliente2);
            Cliente1.update();
            Cliente2.update();
            tienda1.notifyObserver();

            Console.ReadKey();
        }
    }
}
