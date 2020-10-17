using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testCRUDsolution.Models
{
    public class Employee
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Введите ФИО")]

        public string FullName { get; set; }
        [Required(ErrorMessage = "Введите должность")]
        public string Position { get; set; }
        [Required(ErrorMessage = "Введите дату рождения")]
     //   [RegularExpression("(0?[1-9]|[12][0-9]|3[01])\\.(0?[1-9]|1[012])\\.((19|20)[0-9][0-9])", ErrorMessage = "Формат даты рождения дд.мм.гггг")]
        
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Введите текст")]
        public string Text { get; set; }
        [Required(ErrorMessage = "Выберите декрет")]
        public bool Decree { get; set; }
    }
}
