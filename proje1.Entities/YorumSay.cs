using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proje1.Entities
{
    [Table("YorumSay")]
    public class YorumSay
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public long olumluSayisi { get; set; }
        public long olumsuzSayisi { get; set; }
    }
}
