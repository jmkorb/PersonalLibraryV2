using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibrary.Data
{
    public class BookRecord
    {
        [ForeignKey(nameof(Owner))]
        public string OwnerId { get; set; }
        public virtual ApplicationUser Owner { get; set; }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        public string Summary { get; set; }

        public bool BestSeller { get; set; }

        public DateTime DatePublished { get; set; }

        [ForeignKey(nameof(Author))]
        public int? AuthorId { get; set; }
        public virtual Author Author { get; set; }


        [ForeignKey(nameof(Genre))]
        public int? GenreId { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
