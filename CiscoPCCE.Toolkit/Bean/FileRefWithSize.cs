namespace CiscoPCCE.Toolkit.Bean
{
    public class FileRefWithSize : BaseApiBean
    {
        public new string? RefURL { get; set; }

        public long? Size { get; set; }
    }
}