using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chirper_2._0.Models
{
    public class Post
    {
        // TODO: Question. Signed or unsigned for Id 
        [Key]
        public int Id { get; set; }
        public virtual User Author { get; set; }
        public virtual User OriginalAuthor { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
