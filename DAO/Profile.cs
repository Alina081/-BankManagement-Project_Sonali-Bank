using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   
    [Table(name: "Profile")]
      [Serializable]
    public  class Profile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Required")]
        public string UserName { get; set; }

       

        [Required(ErrorMessage = "Required")]
        public string Address { get; set; }

        

        [Required(ErrorMessage = "Required")]
        [Phone]
        public string Pnumber { get; set; }

        [Required(ErrorMessage = "Required")]
        [EmailAddress]
        public string Email { get; set; }

      

        [Required(ErrorMessage = "Required")]
        public string ProfileImage { get; set; }



        [Required(ErrorMessage = "Required")]
        public string AccountType { get; set; }


        [Required(ErrorMessage = "Required")]
        public string AccountNumber { get; set; }




    }
}
