using System;
using System.ComponentModel.DataAnnotations;

namespace RosneftCore.Domain.Entities
{
    public class IdentityUserRole
    {       
        //Обязательное поле для заполнения логина
        [Required] public string RoleId {get;set;}

        //Обязательное поле для заполнения пароля
        [Required] public string UserId {get;set;}

    }
}