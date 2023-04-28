namespace Dotnetcom.Service
{
    using Dotnetcom.DTO;
    public interface IUserChangePasswordService
    {
        Task<bool> ChangePasswordAsync(ChangePasswordModel model);
    }
}