using JWTRepeat.Application.Abstractions;
using JWTRepeat.Domain.DataTransferObjects;
using JWTRepeat.Domain.Entities;
using System.IO.Pipes;
using System.Linq.Expressions;

namespace JWTRepeat.Application.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _uR;

        public UserService(IUserRepository uR)
        {
            _uR = uR;
        }

        public Task<User> Create(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Expression<Func<User, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAll()
        {
           return await _uR.GetAll();
        }

        public Task<User> GetByAny(Expression<Func<User, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<User> Update(int Id, UserDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}
