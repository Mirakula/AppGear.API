using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGear.API.Models
{
    public class LoriotDevice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("DEV_ID")]
        public string DEV_ID { get; set; }
        [Column("PCB_ID")]
        public string PCB_ID { get; set; }
        [Column("DEV_EUI")]
        public string DEV_EUI { get; set; }
        [Column("APP_EUI")]
        public string APP_EUI { get; set; }
        [Column("APP_KEY")]
        public string APP_KEY { get; set; }
    }
}