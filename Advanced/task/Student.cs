namespace task
{
    public class Student
    {
        public string Name {get; set;}
        public int DateOfBirth {get; set;}
        public string PlaceOfBirth {get; set;}

        public int ID {get; set;}
        public float GPA {get; set;}
        public override string ToString()  
        {
            return($"{Name} {DateOfBirth} {PlaceOfBirth} {ID} {GPA} ");
        }  

        
        
        }
}