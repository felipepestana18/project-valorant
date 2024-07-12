using System.Text.Json.Nodes;
using valorant_app_api.Data.ValueObject;

namespace valorant_app_api.Repository
{
    public interface ICharacterRepository
    {

        Task<IEnumerable<CharacterVO>> GetAll();

        Task<IEnumerable<CharacterVO>> Get(int id);

        Task<CharacterVO> Create(CharacterVO vo);

        Task<CharacterVO> Update(CharacterVO vo);

        Task<bool> Delete(int id);

        Task<JsonObject> GetAgent();

        Task<JsonObject> GetAgentByUid(string uid);
    }
}
