using Grpc.Core;
using Users_Service;

namespace Users_Service.Services
{
    public class UserService : User.UserBase
    {
        private readonly ILogger<UserService> _logger;
        public UserService(ILogger<UserService> logger)
        {
            _logger = logger;
        }

        public override Task<UserResponse> GetUserById(UserRequest request, ServerCallContext context)
        {
            UserResponse response = new UserResponse
            {
                Id = request.Id,
                Name = "John Doe",
                Email = "johndoe@email.com"
            };
            return Task.FromResult(response);
        }
    }
}