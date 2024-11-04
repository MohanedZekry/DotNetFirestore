using DotNetFireStore.Application.Features.UserFeatures.Add;
using FluentValidation.TestHelper;

public class AddUserValidatorTests
{
    private readonly AddUserValidator _validator;

    public AddUserValidatorTests()
    {
        _validator = new AddUserValidator();
    }

    [Fact]
    public void Validator_Should_Have_Error_When_Email_Is_Empty()
    {
        var request = new AddUserRequest("", "Mohaned Zekry");

        var result = _validator.TestValidate(request);
        result.ShouldHaveValidationErrorFor(x => x.Email);
    }
}
