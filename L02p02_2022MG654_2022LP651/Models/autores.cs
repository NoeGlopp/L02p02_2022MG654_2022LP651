using System.ComponentModel.DataAnnotations;
namespace L02p02_2022MG654_2022LP651.Models
{
    public class autores
    {
        [Key]

        public int id { get; set; }

        public string autor { get; set; }
    }
}