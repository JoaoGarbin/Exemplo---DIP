using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo____DIP
{
    public class Lamp(State State)
    {
        public void Operate()
        {
            State = State == State.On ? State.Off : State.On;
            Console.WriteLine($"Luz " + (State == State.On ? "Ligada" : "Desligada"));
        }
    }
}
