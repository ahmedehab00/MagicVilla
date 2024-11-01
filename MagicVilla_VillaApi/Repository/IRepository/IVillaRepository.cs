using MagicVilla_VillaApi.Model;
using System.Linq.Expressions;

namespace MagicVilla_VillaApi.Repository.IRepository.IRepository
{
    public interface IVillaRepository : IRepository<Villa> 
    {
    
        Task<Villa> UpdateAsync(Villa villa);
     
    }
}
