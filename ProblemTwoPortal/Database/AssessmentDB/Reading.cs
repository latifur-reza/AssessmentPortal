using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemTwoPortal.Database.AssessmentDB
{
    public class Reading
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public int BuildingId { get; set; }
        [Required]
        public int ObjectId { get; set; }
        [Required]
        public int DataFieldId { get; set; }
        [Required]
        public decimal Value { get; set; }
        [Required]
        public DateTime Timestamp { get; set; }
    }
}
