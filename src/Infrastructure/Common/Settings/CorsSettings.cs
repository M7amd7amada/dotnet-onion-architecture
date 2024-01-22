namespace Infrastructure.Common.Settings;

public class CorsSettings
{
    public string PolicyName { get; set; } = string.Empty;

    public string[] Origins { get; set; } = [];
    public string[] Headers { get; set; } = [];
    public string[] Methods { get; set; } = [];
}