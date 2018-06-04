using System.ComponentModel.DataAnnotations;

namespace lasttask
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