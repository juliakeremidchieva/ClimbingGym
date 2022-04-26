using ClimbingGym.Core.Models;
using ClimbingGym.Infrastructure.Data.Identity;

namespace ClimbingGym.Core.Contracts
{
    public interface IUserService
    {
        Task<IEnumerable<UserListViewModel>> GetUsers();

        Task<UserEditViewModel> GetUserForEdit(string id);

        Task<bool> UpdateUser(UserEditViewModel model);
        //Task<bool> DeleteUser(UserListViewModel model);

        Task<ApplicationUser> GetUserById(string id);
    }
}
