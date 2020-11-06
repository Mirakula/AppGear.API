using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGear.API.Models
{
    [Table(("Lorawan"))]
    public class Lorawan
    {
        [Column("LorawanId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("Longitude")]
        public double Longitude { get; set; }

        [Column("Latitude")]
        public double Latitude { get; set; }

        [Column("Counter")]
        public int  Counter { get; set; }
        
        [Column("IpAddress")]
        public string IpAddress { get; set; }
    }
}