using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemTwoPortal.Database.Dto
{
    public class ReadingDto
    {
        [Required]
        public int BuildingId { get; set; }
        [Required]
        public int ObjectId { get; set; }
        [Required]
        public int DataFieldId { get; set; }
        [Required]
        public DateTime StartTimestamp { get; set; }
        [Required]
        public DateTime EndTimestamp { get; set; }
    }
}
