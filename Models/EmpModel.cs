using System.ComponentModel.DataAnnotations;

namespace CRUDUsingMVC.Models
{
    public class EmpModel
    {
        [Display(Name = "Id")]
        public int Empid { get; set; }
        [Display(Name = "نام")]

        [Required(ErrorMessage = "لطفا نام را وارد کنید")]
        public string Name { get; set; }
        [Display(Name = "شهر")]

        [Required(ErrorMessage = "لطفا شهر را وارد کنید")]
        public string City { get; set; }
        [Display(Name = "آدرس")]

        [Required(ErrorMessage = "لطفا آدرس را وارد کنید")]
        public string Address { get; set; }

    }
}