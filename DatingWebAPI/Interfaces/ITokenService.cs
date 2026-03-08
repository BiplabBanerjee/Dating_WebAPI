using DatingWebAPI.Entities;

namespace DatingWebAPI.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}