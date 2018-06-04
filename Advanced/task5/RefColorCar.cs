using System.ComponentModel.DataAnnotations;

namespace task5
{
    public class RefColorCar
    {
        
        public int Id { get; set; }
        [Key]
        public Car RefCar { get; set; }
        [Key]
        public Color RefColor { get; set; }
    }
}