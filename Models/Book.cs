using Microsoft.Win32.SafeHandles;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Andriesei_Tudor_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s-]*$", ErrorMessage =
           "Titlul trebuie sa inceapa cu majuscula (ex.Baltagul sau Nu strivi corola de minuni a lumii")]
        [StringLength(150,MinimumLength =3)]
        public string? Title { get; set; }
       
        public int? AuthorID { get; set; }
        public  Author? Author { get; set; }


        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 500)]
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }

        public ICollection<BookCategory>BookCategories { get; set; }
    }
}
