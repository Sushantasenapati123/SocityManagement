using Bank.Irepository.Account;
using Bank.Irepository.AccountingOpening;
using Bank.Irepository.AccountType;
using Bank.Irepository.Branch;
using Bank.Irepository.Customer;
using Bank.Irepository.Employee;
using Bank.Irepository.GlGroup;
using Bank.Irepository.Group;
using Bank.Irepository.Login;
using Bank.Irepository.Product;
using Bank.Irepository.Role;
using Bank.Irepository.ServerData;
using Bank.Irepository.User;
using Bank.IRepository.MenuMaster;
using Bank.IRepository.SubMenuMaster;
using Bank.Repository.Account;
using Bank.Repository.AccountOpening;
using Bank.Repository.AccountYpe;
using Bank.Repository.Branch;
using Bank.Repository.Customer;
using Bank.Repository.Employee;
using Bank.Repository.GlGroup;
using Bank.Repository.Group;
using Bank.Repository.Login;
using Bank.Repository.MenuMaster;
using Bank.Repository.Product;
using Bank.Repository.Role;
using Bank.Repository.SerVerData;
using Bank.Repository.User;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MiniBankingSystem.IRepository.Factory;
using MiniBankingSystem.Repository.Factory;
using PathoLab.IRepository.PermissionMaster;
using PathoLab.Repository.PermissionMaster;
using PathoLab.Repository.SubMenuMaster;

namespace PathoLab.Web.DIContainer
{
    public static class CustomContainer
    {
        public static void AddCustomContainer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAntiforgery(o => o.HeaderName = "XSRF-Token");
            IConnectionFactory connectionFactory = new ConnectionFactory(configuration.GetConnectionString("DefaultConnection"));
            services.AddSingleton(connectionFactory);
            services.AddSingleton<IBranchRepository, BranchRepository>();
            services.AddSingleton<IloginRepository, loginRepository>();
            services.AddSingleton<IAccountopeningRepository, AccountopeningRepositor>();
            services.AddSingleton<IglgroupRepository, GlgroupRepository>();
            services.AddSingleton<IGroupRepository, GroupRepository>();
            services.AddSingleton<IRoleRegistation, RoleRepository>();

            services.AddSingleton<IproductRepository, Productrepository>();

            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<IServerDateRepository, ServerDateRepository>();
            services.AddSingleton<IAccountTypeRepository, AccountTypeRepository>();
            services.AddSingleton<IAccountRepository, AccountRepository>();
            services.AddSingleton<ICustmerRepository, CustomerRepository>();
            services.AddSingleton<IEmployee, EmployeeRepo>();

            services.AddSingleton<IMenuRepository, MenuRepository>();
            services.AddSingleton<ISubMenuRepository, SubMenuRepository>();
            services.AddSingleton<IPermissionRepository, PermissionRepository>();



        }
    }
}
