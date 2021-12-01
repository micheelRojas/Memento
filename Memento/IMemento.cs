using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    // La interfaz de Memento proporciona una forma de recuperar los metadatos del recuerdo,
    // como la fecha de creación o el nombre. Sin embargo, no expone el
    // Estado del originador.
    public interface IMemento
    {
        string GetName();

        string GetState();

        DateTime GetDate();
    }
}
