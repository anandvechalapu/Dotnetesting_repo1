namespace Dotnetcom.Service
{
    public interface IService
    {
        string GetErrorMessage(string requestId);
    }
}

using Dotnetcom.DTO;

namespace Dotnetcom.Service
{
    public interface IService
    {
        string GetErrorMessage(string requestId);
        ResponseDTO GetResponse(string requestId);
    }
}