using System.ComponentModel.DataAnnotations;

namespace Personnel_information_registration_form.Models
{
    public class student
    {
        public int Id { get; set; }
        [Display(Name ="姓名")]
        [StringLength(300,MinimumLength =1)]
        public string Name { get; set; }
        [Display(Name ="性别")]
        [StringLength(1)]
        public string Sex { get; set; }
        [Display(Name ="年龄")]
        [Range(1, 200)]
        public int Age { get; set; }
        [Display(Name ="出生日期")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Display(Name ="手机号")]
        [StringLength(13)]
        public string Phone { get; set; }
        [Display(Name = "体温")]
        [Range(30.0, 50.0)]
        public string BodyTemperature { get; set; }
        [Display(Name = "填表日期")]
        public DateTime FileDate { get; set; }
    }
}
