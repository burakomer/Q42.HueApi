using System.Text.Json.Serialization;

namespace HueApi.Models.Sensors
{
  public class LightLevel : HueResource
  {
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; } = default!;

    [JsonPropertyName("light")]
    public Light Light { get; set; } = default!;

    [JsonPropertyName("owner")]
    public ResourceIdentifier? Owner { get; set; }
  }

  public class Light
  {
    [JsonPropertyName("light_level")]
    public int LightLevel { get; set; } = default!;

    [JsonPropertyName("light_level_valid")]
    public bool LightLevelValid { get; set; }
  }
}