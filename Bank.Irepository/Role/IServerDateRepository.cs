using Bank.Domain.ServerData;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Irepository.Role
{
    public interface IServerDateRepository
    {
        Task<IEnumerable<ServerDateEntity>> GetServerDate();
        Task<IEnumerable<ServerDateEntity>> listBranch();
        Task<ServerDateEntity> GetDate(int id);
        Task<ServerDateEntity> GetByBranch(int id);
        int AddServerDate(ServerDateEntity sdEntity);
        //string AddServerDate(ServerDateEntity sdEntity); //For Out Parameter
        int UpdateServerDate(ServerDateEntity sdEntity);
        int DeleteServerDate(int id);
    }
}
