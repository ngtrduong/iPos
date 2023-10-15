using Application.Models.Category;

namespace Application.Validators.Category;
public class CreateCategoryValidator : AbstractValidator<CreateCategoryModel>
{
    public CreateCategoryValidator()
    {
        RuleFor(x => x.Name)
            .MaximumLength(50)
            .NotEmpty();
    }
}
