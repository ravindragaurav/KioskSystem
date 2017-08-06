using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database
{
    [Table("QuantityType")]
    public partial class QuantityType
    {
        public int Id { get; set; }

        [Column("Type")]
        [Required]
        public string Type { get; set; }
    }
}
