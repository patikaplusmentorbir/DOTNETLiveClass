using CustomIdentityWithJwt.Context;
using CustomIdentityWithJwt.Dtos;
using CustomIdentityWithJwt.Entities;
using CustomIdentityWithJwt.Repositories;
using CustomIdentityWithJwt.Services;

namespace CustomIdentityWithJwt.Managers
{
    public class UserManagerV2 : IUserServiceV2
    {
        private readonly IRepository<UserEntity> _userRepository;
        
        public UserManagerV2(IRepository<UserEntity> userRepository)
        {
            _userRepository = userRepository;
            
        }

        public void AddUser(UserAddDto user)
        {
            var userEntity = new UserEntity
            {
                Email = user.Email,
                Password = user.Password
            };

            _userRepository.Add(userEntity); 
        }

        public void DeleteUser(int id)
        {
            _userRepository.RemoveUser(id);
        }
    }
}
