namespace Exemplo____DIP
{
    public class Lamp : IDevice
    {
        private State State { get; set; }

        public Lamp()
        {
            State = State.Off;
        }

        public void Operate()
        {
            State = State == State.On ? State.Off : State.On;
            Console.WriteLine($"Luz {(State == State.On ? "Ligada" : "Desligada")}");
        }
    }
}