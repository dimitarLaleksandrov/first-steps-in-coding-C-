// See https://aka.ms/new-console-template for more information
internal class Program
{

    public abstract class Animal
    {
        public string Name { get; set; }
        public int NumVisitsToVet { get; set; }
        //public virtual string? AnimalVest { get; set; }
    }

    // we shud create a interface class 
    public interface IVest
    {
        string? AnimalVest { get; set; }

    }

    public class Dog : Animal, IVest
    {
       //public override string? AnimalVest => throw new NotImplementedException();
        public string? AnimalVest
        {
            get; set;
        }
    }
    public class Cat : Animal, IVest
    {
        //public override string? AnimalVest => throw new NotImplementedException();
        public string? AnimalVest
        {
            get; set;
        }
    }
}
