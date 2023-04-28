namespace Dotnetcom.Service
{
    using Dotnetcom.DTO;

    public interface IChangePasswordRepository
    {
        Task<bool> ChangePasswordAsync(ChangePasswordModel model);
    }
}