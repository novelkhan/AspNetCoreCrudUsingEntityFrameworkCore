using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AspNetCoreCrudUsingEntityFrameworkCore.Models
{
    public class BookViewModel
    {
        [Key]
        public int bookId { get; set; }
        [DisplayName("Title")]
        public string title { get; set; }
        [DisplayName("Author")]
        public string author { get; set; }
        [DisplayName("Price")]
        public int price { get; set; }
    }
}
