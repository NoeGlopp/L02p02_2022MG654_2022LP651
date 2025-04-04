﻿using System.ComponentModel.DataAnnotations;

namespace L02p02_2022MG654_2022LP651.Models
{
    public class libros
    {
        [Key]

        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string url_imagen { get; set; }
        public int id_autor { get; set; }

        public int id_categoria { get; set; }
        public decimal precio { get; set; }
        public string estado { get; set; }
    }
}