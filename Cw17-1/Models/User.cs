using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cw17_1.Models
{
    [Table("Members")]
    public class User
    {
        [Key]
        [Display(Name ="ردیف")]
        public int Id { get; set; }
        [Display(Name = "نام کاربری")]
        public string FullName { get; set; } = string.Empty;
        [Display(Name = "موبایل")]
        public string Mobile { get; set; }


        public Adrress? Adrress { get; set; }

    }
}
