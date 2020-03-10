using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MicroRabbit.Transfer.Domain.Models
{
    public class TransferLog
    {
        public int Id { get; set; }
        public int From { get; set; }
        public int To { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Amount { get; set; }
    }
}
