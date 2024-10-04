using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Domain;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   
    [Table(name: "Registration")]
      [Serializable]
    public  class Registration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Fname { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Lname { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Required")]
        public string Praddress { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Peaddress { get; set; }

        [Required(ErrorMessage = "Required")]
        [Phone]
        public string Pnumber { get; set; }

        [Required(ErrorMessage = "Required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required")]
        
        public string Dob { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Required")]
        public string ProfileImage { get; set; }

        [Required(ErrorMessage = "Required")]
        public string BankA_CNo { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Nid { get; set; }

        [Required(ErrorMessage = "Required")]
       
        public string Password { get; set; }

        [Required(ErrorMessage = "Required")]

        public string Cpassword { get; set; }

        public int RoleId { get; set; }


    }
}
