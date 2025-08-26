using CustomIdentityWithJwt.Dtos;

namespace CustomIdentityWithJwt.Services
{
    public interface IUserServiceV2
    {
        void AddUser(UserAddDto user);

        void DeleteUser(int id);
    }
}
