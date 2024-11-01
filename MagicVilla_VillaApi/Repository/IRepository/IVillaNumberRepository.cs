using MagicVilla_VillaApi.Model;
using System.Linq.Expressions;

namespace MagicVilla_VillaApi.Repository.IRepository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {

        Task<VillaNumber> UpdateAsync(VillaNumber entity);

    }
}
