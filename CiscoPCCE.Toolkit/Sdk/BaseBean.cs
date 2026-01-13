namespace CiscoPCCE.Toolkit.Sdk
{
    /// <summary>
    /// Base for simplifying bean integration
    /// </summary>
    public class BaseBean
    {
        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize(this, new System.Text.Json.JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase,
                UnknownTypeHandling = System.Text.Json.Serialization.JsonUnknownTypeHandling.JsonElement
            });
        }
    }
}
