
namespace apiAlberto.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Fairy
    {
        public enum Wishes
        {
            Carro,
            Casa,
            Computadora
        }

        [Key]
        public int FairyID { get; set; }

        [Required]
        [Display(Name = "Nombre Completo")]
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