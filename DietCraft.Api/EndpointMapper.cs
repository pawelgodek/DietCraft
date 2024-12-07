using DietCraft.Endpoints.Probes;

namespace DietCraft;

public static class EndpointMapper
{
    public static void MapEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapPost("ping", ProbesEndpoints.LivenessCheckAsync)
            .Produces<string>();
    }
}