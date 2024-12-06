using Microsoft.AspNetCore.Http;

namespace DietCraft.Endpoints.Probes;

public class ProbesEndpoints
{
    public static async Task<IResult> LivenessCheckAsync()
    {
        return await Task.FromResult(Results.Ok("pong"));
    }
}