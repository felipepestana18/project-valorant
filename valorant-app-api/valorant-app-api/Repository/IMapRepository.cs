using System.Threading.Tasks;
using valorant_app_api.Data.ValueObject;

namespace valorant_app_api.Repository
{
    public interface IMapRepository
    {

        Task<IEnumerable<MapVO>> GetAll();

        Task<IEnumerable<MapVO>> Get(int id);

        Task<MapVO> Create(MapVO vo);

        Task<MapVO> Update(MapVO vo);

        Task<bool> Delete(int id);
    }
}
