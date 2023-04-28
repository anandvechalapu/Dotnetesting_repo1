using Dotnetcom.Repository;
using Dotnetcom.DTO;

namespace Dotnetcom.Service
{
    public interface IChangePasswordService
    {
        Task<ChangePasswordDTO> ChangePassword(ChangePasswordModel model);
    }

    public class ChangePasswordService : IChangePasswordService
    {
        private IChangePasswordRepository _changePasswordRepository;

        public ChangePasswordService(IChangePasswordRepository changePasswordRepository)
        {
            _changePasswordRepository = changePasswordRepository;
        }

        public async Task<ChangePasswordDTO> ChangePassword(ChangePasswordModel model)
        {
            return await _changePasswordRepository.ChangePassword(model);
        }
    }
}