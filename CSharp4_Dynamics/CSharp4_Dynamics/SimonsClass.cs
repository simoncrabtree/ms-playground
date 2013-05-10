namespace CSharp4_Dynamics
{
    public class SimonsClass
    {
        public SimonsClass()
        {
            this.Name = "";
        }

        public string Name { get; set; }

        public string DoSomething(string name, string address)
        {
            return "Hello " + name + " from " + address;
        }

        public string SayHello(string greeting = "Hello", string name = "Everyone")
        {
            return greeting + " " + name;
        }
    }
}
