using CustomIdentityWithJwt.Context;
using CustomIdentityWithJwt.Dtos;
using CustomIdentityWithJwt.Entities;
using CustomIdentityWithJwt.Services;
using CustomIdentityWithJwt.Types;

namespace CustomIdentityWithJwt.Managers
{
    public class UserManager : IUserService
    {
        private readonly CustomIdentityDbContext _context;

        public UserManager(CustomIdentityDbContext context)
        {
            _context = context;
        }
        public async Task<ServiceMessage> AddUser(UserAddDto user)
        {
            var userEntity = new UserEntity
            {
                Email = user.Email,
                Password = user.Password
            };

            _context.Users.Add(userEntity);
            _context.SaveChanges();

            return new ServiceMessage
            {
                IsSucceed = true,
                Message = "Kullanıcı kaydı gerçekleşti."
            };


           
        }

        public async Task<ServiceMessage<UserInfoDto>> LoginUser(LoginUserDto user)
        {
            var userEntity = _context.Users.Where(x => x.Email.ToLower() == user.Email.ToLower()).FirstOrDefault();

            if(userEntity is null)
            {

                return new ServiceMessage<UserInfoDto>
                {
                    IsSucceed = false,
                    Message = "Kullanıcı adı veya şifre hatalı."
                };

            }

           
            if(userEntity.Password == user.Password)
            {

                return new ServiceMessage<UserInfoDto>
                {

                    IsSucceed = true,
                    Message = "Giriş başarılı.",

                    Data = new UserInfoDto
                    {
                        Id = userEntity.Id,
                        Email = userEntity.Email,
                        UserType = userEntity.UserType
                    }



                };

            }
            else
            {
                return new ServiceMessage<UserInfoDto>
                {
                    IsSucceed = false,
                    Message = "Kullanıcı adı veya şifre hatalı."
                };
            }

        }
    }
}
