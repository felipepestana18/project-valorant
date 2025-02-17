﻿using System.Threading.Tasks;
using valorant_app_api.Data.ValueObject;
using valorant_app_api.Model;

namespace valorant_app_api.Repository
{
    public interface IMapRepository
    {

        Task<IEnumerable<MapVO>> GetAll();

        Task<IEnumerable<MapVO>> Get(int id);

        Task<MapVO> Create(MapVO vo);

        Task<MapVO> Update(MapVO vo);

        Task<bool> Delete(int id);

        Task<MapsApi> GetMapsApi();

        Task<InformationMap> GetMapApiByUid(string uid);
    }
}
