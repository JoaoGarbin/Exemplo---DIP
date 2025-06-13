namespace Exemplo____DIP
{
    public class Switch : IDevice
    {
        private State State { get; set; }
        public Switch()
        {
            State = State.Off;
        }
        public void Operate()
        {
            State = State == State.On ? State.Off : State.On;
            Console.WriteLine($"Tomada {(State == State.On ? "Ligada" : "Desligada")}");
        }
    }
}