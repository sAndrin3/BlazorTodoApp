using System.ComponentModel.DataAnnotations;

namespace BlazorForms.Models
{
    public class CarDto
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; }=string.Empty;
        [Required]
        public string Color { get; set; } = string.Empty;

        [Required]
        [Range(0,10000)]
        public int Mileage { get; set; }

        public List<Make> makes { get; set; }= new List<Make>();


    }

    public class Make
    {
        public int Id { get; set; }
        [Required]
        public string ModelName { get; set; }
    }
}