using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    // El Concrete Memento contiene la infraestructura para almacenar el
    // Estado del originador.
    public class ConcreteMemento : IMemento
    {
        private string _state;

        private DateTime _date;

        public ConcreteMemento(string state)
        {
            this._state = state;
            this._date = DateTime.Now;
        }

        // El Originador usa este método al restaurar su estado.
        public string GetState()
        {
            return this._state;
        }

        // El cuidador usa el resto de los métodos para mostrar
        // metadatos.
        public string GetName()
        {
            return $"{this._date} / ({this._state.Substring(0, 9)})...";
        }

        public DateTime GetDate()
        {
            return this._date;
        }
    }
}
