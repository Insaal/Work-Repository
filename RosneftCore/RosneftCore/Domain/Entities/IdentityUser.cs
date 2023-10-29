using System;
using System.ComponentModel.DataAnnotations;

namespace RosneftCore.Domain.Entities
{
    public class IdentityUser
    {
        //Обязательное поле для заполнения идентификатора
        [Required] public string Id {get;set;}
        
        //Обязательное поле для заполнения логина
        [Required] public string UserName {get;set;}

        //Обязательное поле для заполнения пароля
        [Required] public string PasswordHash {get;set;}

    }
}