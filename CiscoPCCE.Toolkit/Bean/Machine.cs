namespace CiscoPCCE.Toolkit.Bean
{
    public class Machine : BaseApiBean
    {
        public string? Host { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        public MachineType Type { get; set; }
    }
}