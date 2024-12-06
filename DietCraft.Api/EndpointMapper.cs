using DietCraft.Endpoints.Probes;

namespace DietCraft;

public static class EndpointMapper
{
    public static void MapEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("ping", ProbesEndpoints.LivenessCheckAsync)
            .Produces<string>();
    }
}