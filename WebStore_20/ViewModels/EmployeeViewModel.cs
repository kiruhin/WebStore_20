using System.ComponentModel.DataAnnotations;

namespace WebStore.ViewModels
{
    public class EmployeeViewModel
    {
        [Display(Name = "Код")]
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Имя  является обязательынм")]
        [Display(Name = "Имя")]
        [StringLength(maximumLength:200,MinimumLength = 2,ErrorMessage ="Длина имени не меньше 2 и " +
            "не больше 200")]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Имя  является обязательынм")]
        [Display(Name = "Фамилия")]
        [StringLength(maximumLength: 200, MinimumLength = 2, ErrorMessage = "Длина фамилии не меньше 2 и " +
            "не больше 200")]
        public string SurName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Имя  является обязательынм")]
        [Display(Name = "Отчество")]
        [StringLength(maximumLength: 200, MinimumLength = 2, ErrorMessage = "Длина отчества не меньше 2 и " +
            "не больше 200")]
        public string Patronymic { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Имя  является обязательынм")]
        [Range(minimum:18,maximum:70,ErrorMessage = "Возраст от 18 до 70")]
        [Display(Name = "Возраст")]
        public int Age { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Имя  является обязательынм")]
        [Display(Name = "Должность")]
        public string Position { get; set; }
    }

}