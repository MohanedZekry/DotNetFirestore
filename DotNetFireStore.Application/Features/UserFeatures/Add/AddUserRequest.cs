using MediatR;

namespace DotNetFireStore.Application.Features.UserFeatures.Add
{
    public sealed record AddUserRequest(string Email, string Name) : IRequest<AddUserResponse>;
}
