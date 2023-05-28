using System;
using System.ComponentModel.DataAnnotations;

namespace Rosneft.Domain.Entities
{
    public class IdentityUser
    {
        //Обязательное поле для заполнения идентификатора
        [Key]
        [Required] public Guid Id { get; set; }

        //Обязательное поле для заполнения логина
        [Required] public string Login { get; set; }

        //Обязательное поле для заполнения пароля
        [Required] public string Password { get; set; }

        //Обязательное поле для заполнения имени пользователя
        [Required] public Guid UserName { get; set; }

    }
}