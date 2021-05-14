using System.Collections.Generic;

namespace Skoruba.IdentityServer4.STS.Identity.Configuration
{
    public class OidcProvider
    {
        public bool Enabled { get; set; }

        public bool SaveToken { get; set; }

        public string ClientId { get; set; }

        public string ClientSecret { get; set; }

        public string Authority { get; set; }

        public string DisplayName { get; set; }

        public List<string> Scopes { get; set; }

    }
}