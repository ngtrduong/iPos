using Application.Models.Category;
using Core.Entities;

namespace Application.Mapping;
public class CategoryMapping : Profile
{
    public CategoryMapping()
    {
        CreateMap<Category, CategoryDto>();
    }
}
