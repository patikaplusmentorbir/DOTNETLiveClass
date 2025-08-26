using CustomIdentityWithJwt.Dtos;
using CustomIdentityWithJwt.Types;

namespace CustomIdentityWithJwt.Services
{
    public interface IUserService
    {

        Task<ServiceMessage> AddUser(UserAddDto user);
        // ServiceMessage diye bir class açarak bool + string değer geri döneceğim.

        Task<ServiceMessage<UserInfoDto>> LoginUser(LoginUserDto user);


    }
}
