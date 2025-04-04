using System.ComponentModel.DataAnnotations;

namespace L02p02_2022MG654_2022LP651.Models
{
    public class comentarios_libros
    {
        [Key]
        public int id { get; set; }

        public int id_libro { get; set; }

        public string comentarios { get; set; }

        public string usuario { get; set; }

        public DateTime created_at { get; set; }
    }
}