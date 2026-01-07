namespace CiscoPCCE.Toolkit.Bean
{
    public class Status : BaseApiBean
    {
        public required ApiError ApiError { get; set; }

        public State State { get; set; }
    }
}