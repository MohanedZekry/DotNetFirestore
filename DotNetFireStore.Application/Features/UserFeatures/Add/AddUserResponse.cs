namespace DotNetFireStore.Application.Features.UserFeatures.Add
{
    public sealed record class AddUserResponse
    {
        public Guid ID { get; set; }
        public string Email { get; set; }
    }
}
