namespace CiscoPCCE.Toolkit.Sdk
{
    /// <summary>
    /// Base for simplifying bean integration.
    /// </summary>
    public class BaseBean
    {
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return this.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return System.Text.Json.JsonSerializer.Serialize(this, new System.Text.Json.JsonSerializerOptions
            {
                WriteIndented = true
            });
        }
    }
}
