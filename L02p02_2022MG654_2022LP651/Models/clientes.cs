using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace L02p02_2022MG654_2022LP651.Models
{
    public class clientes
    {
        [Key]

        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public DateTime created_at { get; set; }
    }
}