using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Nortwing.Models
{
    [Table("Categoria")]
   public class CategoriaModel
    {
        [PrimaryKey, AutoIncrement, Unique]
        public int IDCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }
    }
}
