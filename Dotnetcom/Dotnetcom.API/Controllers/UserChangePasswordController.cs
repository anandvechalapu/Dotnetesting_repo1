using System.Threading.Tasks;
using Dotnetcom.API.DTO;
using Dotnetcom.API.Service;
using Microsoft.AspNetCore.Mvc;

namespace Dotnetcom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserChangePasswordController : ControllerBase
    {
        private readonly UserChangePasswordService _userChangePasswordService;

        public UserChangePasswordController(UserChangePasswordService userChangePasswordService)
        {
            _userChangePasswordService = userChangePasswordService;
        }

        [HttpPost]
        public async Task<IActionResult> ChangePasswordAsync(ChangePasswordModel model)
        {
            var result = await _userChangePasswordService.ChangePasswordAsync(model);
            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}