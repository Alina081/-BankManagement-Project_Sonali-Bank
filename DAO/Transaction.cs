using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    [Table(name: "Transaction")]
    [Serializable]
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public string TransactionDate { get; set; }
        public string TransactionNature { get; set; }
        public decimal? Amount { get; set; }
        public string Mode { get; set; }
        public string ChecqueDate { get; set; }

    }
}
