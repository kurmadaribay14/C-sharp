using System.Collections.Generic;

namespace lesson10
{
    public class Company
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public ICollection<Car> Cars{get;set;}
    }
}