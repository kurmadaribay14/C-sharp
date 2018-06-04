using System.Collections.Generic;

namespace lasttask
{
    public class Company
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public ICollection<Car> Cars{get;set;}
    }
}