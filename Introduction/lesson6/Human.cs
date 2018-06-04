namespace lesson6
{
    public class Human 
    {
        public string Name {get; set;}

        public int Age {get; set;}

        public override string ToString() 
        {
            return $"{Name} {Age}";
        }
    }
}