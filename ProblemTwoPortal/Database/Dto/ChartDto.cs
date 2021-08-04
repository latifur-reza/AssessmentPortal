using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemTwoPortal.Database.Dto
{
    public class ChartDto
    {
        [Required]
        public decimal Value { get; set; }
        [Required]
        public DateTime Timestamp { get; set; }
    }
}
