
using Bank.Domain.EmployeeRegistration;
using Bank.Domain.PermissionMaster;
using Bank.Domain.SubMenuMaster;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PathoLab.IRepository.PermissionMaster
{
     public interface IPermissionRepository
    {
        Task<int> PermissionInsert(Permission entity);
        Task<int> PermissionUpdateToDelete(int DesignationId, int UserId);
        Task<List<EmployeeEntity>> DesignationDDL();
        Task<List<SubMenuClass>> GetSelectedSubMenus(int DesignationId, int UserId); 
        Task<List<SubMenuClass>> GetSelectedMenuByDesig(int DesignationId, int UserId);
        Task<List<SubMenuClass>> GetSelectedSubMenuByDesig(int DesignationId, int UserId);

    }
}
