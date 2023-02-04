namespace CommanderEngine
{
    public interface ISettings
    {
        public string? ClientId { get; set; }
        public string? ClientSecret { get; set; }
        public string? TenantId { get; set; }
        public string? AuthTenant { get; set; }
        public string? TemplateFilePath { get; set; }
        public string[]? GraphUserScopes { get; set; }
        public string? Version { get; set; }

        public string? DefaultUser { get; set; }

    }
}
