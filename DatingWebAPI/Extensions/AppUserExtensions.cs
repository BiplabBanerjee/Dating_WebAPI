using DatingWebAPI.DTOs;
using DatingWebAPI.Entities;
using DatingWebAPI.Interfaces;

namespace DatingWebAPI.Extensions
{
    public static class AppUserExtensions
    {
        public static UserDto ToDto(this AppUser user, ITokenService tokenService)
        {
            return new UserDto
            {
                UId = user.UId,
                Email = user.Email,
                DisplayName = user.DisplayName,
                Token = tokenService.CreateToken(user)
            };
        }
    }
}