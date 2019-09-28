using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Alberto.Models
{
    public enum Wishes
    {
        Carro,
        Casa,
        Computadora
    }
    public class Fairy
    {
        [Key]
        public int FairyID { get; set; }

        [Required] 
        [Display(Name ="Nombre Completo")]
        [StringLength(24, MinimumLength = 2)]
        public string Nickname { get; set; }

        [Required]
        public Wishes wishes { get; set; }

        [RegularExpression(@"^\w+([-+.']\w+)@\w+([-.]\w+)\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string email { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }
    }
}