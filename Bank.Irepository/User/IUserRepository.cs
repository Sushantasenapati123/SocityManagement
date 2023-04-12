using Bank.Domain.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Irepository.User
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserEntity>> getusers();
        Task<IEnumerable<UserEntity>> getrollids();
        Task<IEnumerable<UserEntity>> getbranchids();
        Task<UserEntity> GetUser(int id);
        int AddUser(UserEntity usr);
        int UpdateUser(UserEntity usr);
        int DeleteUser(int ID);
    }
}
