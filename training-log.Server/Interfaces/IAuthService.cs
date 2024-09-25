namespace training_log.Server.Interfaces
{
    public interface IAuthService
    {
        string GenerateJwtToken(string userId);
    }
}
