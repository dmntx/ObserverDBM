using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
        interface subject{
            void registrarObservador();
            void deleteObserver();

            void notifyObserver();
        }
        interface observer
        {
            void update();
        }

    class tienda : subject
    {
        int i = 0;
        private string[] reg = new string[10];
        public void registrarObservador()
        {
            Console.WriteLine("Observador Registrado");
        }
        public void registrarObservador(cliente _cliente)
        {
            if (reg[i] == null)
            {
                reg[i] = _cliente.Dato;
            }
            else
            {
                i++;
                reg[i] = _cliente.Dato;
            }
            Console.WriteLine("Observador Registrado");
        }
        public void deleteObserver() {
            Console.WriteLine("Observador Eliminado");
        }
        public void deleteObserver(cliente _cliente)
        {
            for(int j = 0; j < reg.Length; j++)
            {
                if(reg[j] == _cliente.Dato)
                {
                    reg[j] = "";
                }
            }
            Console.WriteLine("Observador " + _cliente.Dato + " Eliminado");
        }

        public void notifyObserver()
        {
            for(int j = 0; j<reg.Length; j++)
            {
                if(reg[j] != "" && reg[j] != null)
                {
                    Console.WriteLine("Notificacion Enviada a " + reg[j]);
                }   
            }
        }
    }

    class cliente : observer
    {
        private string nombre;
        public string Dato { get => nombre; set => nombre = value; }

        public cliente(){

        }
        public cliente(string _nombre)
        {
            nombre = _nombre;
        }
    public void update()
        {
            Console.WriteLine("Actualizado");
        }
    }
 
}
