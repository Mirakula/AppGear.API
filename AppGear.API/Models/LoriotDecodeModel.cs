using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppGear.API.Models
{
    [Table("LoriotDecoded")]
    public class LoriotDecodeModel
    {
        [Column("LoriotDecodedId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("DailyCyclesCount")]
        public UInt16 DailyCyclesCount { get; set; }
        [Column("CycleEventsCount")]
        public UInt16 CycleEventsCount { get; set; }
        [Column("DailyEventsCount")]
        public UInt16 DailyEventsCount { get; set; }
        [Column("CyclePeriod")]
        public sbyte CyclePeriod { get; set; }
        [Column("TimeStamp")]
        public UInt32 TimeStamp { get; set; }
        [Column("Date")]
        public DateTimeOffset ToDate { get; set; }
    }
}