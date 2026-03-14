using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDemoBook.Models
{
    [Table("tblBooks")]
    public class BookModel
    {
        [Key]
        public int BookModelId { get; set; }

        public string? BookName { get; set; }

        public string? Title { get; set; }

        public int Price { get; set; }
    }
}
