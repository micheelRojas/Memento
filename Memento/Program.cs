using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        { // Client code.
            Originator originator = new Originator("Super-duper-super-puper-super.");
            Caretaker caretaker = new Caretaker(originator);

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            Console.WriteLine();
            caretaker.ShowHistory();

            Console.WriteLine("\nCliente: ¡Ahora, retrocedamos!\n");
            caretaker.Undo();

            Console.WriteLine("\n\nCliente: Una vez más!\n");
            caretaker.Undo();

            Console.WriteLine();
            Console.WriteLine("\n\nCliente: Una vez más!\n");
            caretaker.Undo();
            Console.WriteLine();
        }
    }
}
