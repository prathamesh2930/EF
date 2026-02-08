using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Model.Models
{
    [Table("tb_genres")]
    public class Genre
    {
        public int GenreId { get; set; }
        [Column("Name")]
        public string GenereName { get; set; }
        public int DisplayOrder { get; set; }
    }
}
