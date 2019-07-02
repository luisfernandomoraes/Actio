namespace Actio.Common.Auth
{
    using System;
    using Microsoft.IdentityModel.JsonWebTokens;

    public interface IJwtHandler
    {
        JsonWebToken Create(Guid userId);
    }
}