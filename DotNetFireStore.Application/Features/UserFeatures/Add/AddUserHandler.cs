using AutoMapper;
using DotNetFireStore.Application.Repo.ICommon;
using DotNetFireStore.Domain.Entities;
using MediatR;

namespace DotNetFireStore.Application.Features.UserFeatures.Add
{
    public sealed class AddUserHandler : IRequestHandler<AddUserRequest, AddUserResponse>
    {
        private readonly IBaseRepository<User> _userRepository;
        private readonly IMapper _mapper;

        public AddUserHandler(IBaseRepository<User> userRepository,
             IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<AddUserResponse> Handle(AddUserRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request);
            await _userRepository.AddAsync(user);

            return _mapper.Map<AddUserResponse>(user);
        }
    }
}
