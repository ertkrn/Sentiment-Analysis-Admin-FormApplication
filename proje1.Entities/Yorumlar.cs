using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proje1.Entities
{
    [Table("Yorumlar")]
    public class Yorumlar
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long yorumId { get; set; }

        public string yorumlar { get; set; }
    }
}
