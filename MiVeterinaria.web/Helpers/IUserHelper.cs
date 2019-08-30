using Microsoft.AspNetCore.Identity;
using MiVeterinaria.web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiVeterinaria.web.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);// IdentityResult devuelve el resultado de la creacion de un usuario

        Task CheckRoleAsync(string roleName);// si no existe el rol lo crea

        Task AddUserToRoleAsync(User user, string roleName);// matricula un usuario a un rol

        Task<bool> IsUserInRoleAsync(User user, string roleName);// devuelve si un usuario pertenece a un rol

    }
}
