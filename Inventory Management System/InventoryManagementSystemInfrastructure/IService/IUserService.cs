using Inventory_Management_System.InventoryManagementSystemDomain.Entity;
using Inventory_Management_System.InventoryManagementSystemDomain.Entity;

namespace InventoryManagementSystemInfrastructure.IService
{
    public interface IUserService : IBaseService<AppUser>
    {
        Task<AppUser> CheckIfExist(string userName);
        Task Update(AppUser user);
    }
}
