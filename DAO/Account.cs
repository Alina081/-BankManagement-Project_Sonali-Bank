using System;
using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table(name: "Account")]
    public class Account
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]

        public string FullName { get; set; }
        [Required]

        public string Pnumber { get; set; }
        [Required]

        public string Branch { get; set; }
        [Required]

        public string AccountType { get; set; }
        [Required]

        public string OpeningAmount { get; set; }
        

    }
}
