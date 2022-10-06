using Hench.Template.Application.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace Hench.Template.Application.Interfaces
{

    public interface IUserAppService : IDisposable
    {
        Task<IEnumerable<UserViewModel>> GetAll();
        Task<UserViewModel> GetById(Guid id);

        Task<ValidationResult> Register(UserViewModel customerViewModel);
        Task<ValidationResult> Update(UserViewModel customerViewModel);
        Task<ValidationResult> Remove(Guid id);
    }
}
