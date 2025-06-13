using System;

namespace Exemplo____DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            IDevice lamp = new Lamp();
            IDevice tomada = new Switch();

            lamp.Operate();
            lamp.Operate();    

            tomada.Operate(); 
            tomada.Operate();  
        }
    }
}
