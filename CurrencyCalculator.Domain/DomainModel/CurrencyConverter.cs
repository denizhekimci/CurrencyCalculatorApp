using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CurrencyCalculator.Domain.DomainModel
{
    [Table("CurrencyConverter")]
    public class CurrencyConverter : BaseEntity
    {
        public CurrencyConverter()
        {

        }

        public int input { get; set; }

        [StringLength(3)]
        public string inputCurrency { get; set; }
        [StringLength(3)]
        public string outputCurrency { get; set; }

    }
}
