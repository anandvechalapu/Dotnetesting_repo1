namespace Dotnetcom.Service
{
    public class UserChangePasswordService : IUserChangePasswordService
    {
        private readonly DotnetcomDataAccess _dataAccess;

        public UserChangePasswordService(DotnetcomDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<bool> ChangePasswordAsync(ChangePasswordModel model)
        {
            return await _dataAccess.ChangePasswordRepository.ChangePasswordAsync(model);
        }
    }
}