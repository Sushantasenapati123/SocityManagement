using Bank.Domain.Role;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Irepository.ServerData
{
    public interface IRoleRegistation
    {
        Task<IEnumerable<RoleEntity>> listrole();
        int insertrole(RoleEntity rl);
        int updaterol(RoleEntity rl);
        int deleterole(int id);
        public RoleEntity Roleselect(int id);
        public RoleEntity Rolebind(int id);

    }
}
