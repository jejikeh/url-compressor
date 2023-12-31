namespace UrlCompressor.Application.Common.Configuration;

public struct ApplicationConfiguration
{
    public bool RequireUniqueUrls { get; set; }
    public bool AllowSearchByInitialUrl { get; set; }
    public bool ChangeSmallUrlOnUpdate { get; set; }
    public string Host { get; set; }
}