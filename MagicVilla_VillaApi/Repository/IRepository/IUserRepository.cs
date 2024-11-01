using MagicVilla_VillaApi.Model;
using MagicVilla_VillaApi.Model.DTO;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MagicVilla_VillaApi.Repository.IRepository
{
    public interface IUserRepository
    {
        bool ISUniqueUser(string username);
         Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<LocalUser> Register(RegisterationRequestDTO registerationRequestDTO);
    }
}
