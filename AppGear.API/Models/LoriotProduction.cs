using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppGear.API.Models
{
    [Table("LoriotProduction")]
    public class LoriotProduction
    {
        [Column("LoriotId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("cmd")]
        public string cmd { get; set; }

        [Column("EUI")]
        public string EUI { get; set; }

        [Column("ts")]
        public long ts { get; set; }

        [Column("ack")]
        public bool ack { get; set; }

        [Column("bat")]
        public int bat { get; set; }

        [Column("fcnt")]
        public int fcnt { get; set; }

        [Column("port")]
        public int port { get; set; }

        [Column("encdata")]
        public string encdata { get; set; }

        [Column("data")]
        public string data { get; set; }
    }
}
