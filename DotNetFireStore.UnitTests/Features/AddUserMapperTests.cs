using AutoMapper;
using DotNetFireStore.Application.Features.UserFeatures.Add;
using DotNetFireStore.Domain.Entities;

public class AddUserMapperTests
{
    private readonly IMapper _mapper;

    public AddUserMapperTests()
    {
        var config = new MapperConfiguration(cfg => cfg.AddProfile<AddUserMapper>());
        _mapper = config.CreateMapper();
    }

    [Fact]
    public void Should_Map_AddUserRequest_To_User()
    {
        var request = new AddUserRequest("test@example.com", "Mohaned Zekry");

        var user = _mapper.Map<User>(request);

        Assert.Equal(request.Email, user.Email);
        Assert.Equal(request.Name, user.Name);
    }

    [Fact]
    public void Should_Map_User_To_AddUserResponse()
    {
        var user = new User
        {
            ID = Guid.NewGuid().ToString(),
            Email = "test@example.com"
        };

        var response = _mapper.Map<AddUserResponse>(user);

        Assert.Equal(user.ID, response.ID.ToString());
        Assert.Equal(user.Email, response.Email);
    }
}
