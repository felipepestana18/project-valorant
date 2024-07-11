using valorant_app_api.Data.ValueObject;
using valorant_app_api.Model;

namespace valorant_app_api.Repository
{
    public interface IMatchRepository
    {


        Task<IEnumerable<MatchVO>> GetAll();

        Task<Match> Get(int id);

        Task<MatchVO> Create(MatchVO vo);

        Task<MatchVO> Update(MatchVO vo);

        Task<bool> Delete(int id);
    }
}
