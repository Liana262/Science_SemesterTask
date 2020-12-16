using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace Science_WebSite.Models
{
    public class User 
    {
        [Required]
        public int ID { get; set; }
        [Required(ErrorMessage = "Не указано имя пользователя")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Имя пользователя должно содержать только латинские буквы")]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required(ErrorMessage ="Не указан Email")]
        [RegularExpression(@"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$", 
            ErrorMessage = "Введите корректный адрес электронной почты!")]
        [MaxLength(20)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Не указан пароль")]
        [StringLength(20, MinimumLength = 8,ErrorMessage = "Недопустимая длина пароля")]
        public string Password { get; set; }

    }
}
