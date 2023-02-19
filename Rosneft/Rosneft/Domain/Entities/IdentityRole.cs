using System;
using System.ComponentModel.DataAnnotations;

namespace Rosneft.Domain.Entities
{
    public class IdentityRole
    {
        //Обязательное поле для заполнения идентификатора
        [Key]
        [Required] public Guid Id {get;set;}
        
        //Обязательное поле для заполнения логина
        [Required] public string Name {get;set;}

    }
}