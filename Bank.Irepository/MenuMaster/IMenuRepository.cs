using Bank.Domain.MenuMaster;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bank.IRepository.MenuMaster
{
    public interface IMenuRepository
    {
        Task<List<MenuClass>> MenuSelectAll(MenuClass menuclass);
        Task<MenuClass> MenuSelectOne(int MenuId);
        Task<int> MenuInsertAndUpdate(MenuClass entity);
        Task<int> MenuDelete(int MenuId);
    }
}
