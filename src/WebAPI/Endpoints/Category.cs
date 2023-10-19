namespace WebAPI.Endpoints;

public class Category : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapGet("{id}", GetCategory);
    }

    private IResult GetCategory(int id)
    {
        return TypedResults.Ok("Hello world");
    }
}
