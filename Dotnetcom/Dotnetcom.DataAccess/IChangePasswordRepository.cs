namespace Dotnetcom.Repository
{
    using Dotnetcom.Models;
    using Dotnetcom.DTO;
    using System.Threading.Tasks;

    public interface IChangePasswordRepository
    {
        Task<ChangePasswordDTO> ChangePassword(ChangePasswordModel model);
    }

    public class ChangePasswordRepository : IChangePasswordRepository
    {
        public async Task<ChangePasswordDTO> ChangePassword(ChangePasswordModel model)
        {
            ChangePasswordDTO result = null;
            //Add your code here
            return result;
        }
    }
}