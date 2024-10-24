using FluentValidation;

namespace DotNetFireStore.Application.Features.UserFeatures.Add
{
    public sealed class AddUserValidator : AbstractValidator<AddUserRequest>
    {
        public AddUserValidator()
        {
            RuleFor(x => x.Email).NotEmpty().MaximumLength(50).EmailAddress();
            RuleFor(x => x.Name).NotEmpty().MinimumLength(2).MaximumLength(50);
        }
    }
}
