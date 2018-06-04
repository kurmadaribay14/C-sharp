namespace lesson6
{
    public class Student:Human 
    { 
        public string University {get; set;}
        public override string ToString()
        {
            return $"{Name} {Age} {University}";
        }
    }
}