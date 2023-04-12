using Bank.Domain.Group;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Irepository.Group
{
    public interface IGroupRepository
    {
        Task<IEnumerable<group_entity>> getgroups();
        Task<group_entity> GetGroup(int id);
        int AddGroup(group_entity gr);
        int UpdateGroup(group_entity gr);
        int DeleteGroup(int id);
    }
}
