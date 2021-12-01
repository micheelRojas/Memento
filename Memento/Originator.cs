using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Memento
{
   public class Originator
    {
        // El originador tiene un estado importante que puede cambiar con el tiempo. Eso
        // también define un método para guardar el estado dentro de un recuerdo y otro
        // método para restaurar el estado a partir de él.
        private string _state;

        public Originator(string state)
        {
            this._state = state;
            Console.WriteLine("Originador: Mi estado inicial es: " + state);
        }

        // La lógica empresarial del Originador puede afectar su estado interno.
        // Por lo tanto, el cliente debe hacer una copia de seguridad del estado antes de iniciar
        // métodos de la lógica empresarial mediante el método save ().

        //DoSomething-->Haceer algo
        public void DoSomething()
        {
            Console.WriteLine("Originador: Estoy haciendo algo importante.");
            this._state = this.GenerateRandomString(30);
            Console.WriteLine($"Originador: y mi estado ha cambiado a: {_state}");
        }

        private string GenerateRandomString(int length = 10)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = string.Empty;

            while (length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];

                Thread.Sleep(12);

                length--;
            }

            return result;
        }


        // Guarda el estado actual dentro de un recuerdo(memento).
        public IMemento Save()
        {
            return new ConcreteMemento(this._state);
        }

        //Restaura el estado del autor de un objeto de recuerdo(memento).
        public void Restore(IMemento memento)
        {
            if (!(memento is ConcreteMemento))
            {
                throw new Exception("Clase de memento desconocida" + memento.ToString());
            }

            this._state = memento.GetState();
            Console.Write($"Originador: Mi estado ha cambiado a: {_state}");
        }
    }
}
