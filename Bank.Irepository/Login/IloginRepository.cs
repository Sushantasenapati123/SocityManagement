using Bank.Domain.Login;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Irepository.Login
{
    public interface IloginRepository
    {
        // public Task<LoginEntity> GetDetails(LoginEntity obj);
        public List<LoginEntity> GetDetails(LoginEntity adm);
    }
}
