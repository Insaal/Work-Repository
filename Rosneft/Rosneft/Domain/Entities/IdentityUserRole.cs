using System;
using System.ComponentModel.DataAnnotations;

namespace Rosneft.Domain.Entities
{
    public class IdentityUserRole
    {
        [Required] public Guid Id { get; set; }
        //Обязательное поле для заполнения логина

        [Required] public Guid RoleId { get; set; }

        //Обязательное поле для заполнения пароля
        [Required] public Guid UserId { get; set; }

    }
}