namespace CiscoPCCE.Toolkit
{
    /// <summary>
    /// Reference Bean for associating one bean type with another.
    /// </summary>
    public class ReferenceBean : BaseBean
    {
        private string? refURL;
        private string? name;

        public ReferenceBean()
        {
        }

        public ReferenceBean(string refURL)
        {
            this.refURL = refURL;
        }

        public string? Name
        {
            get => name;
            set => name = value;
        }

        public string? RefURL
        {
            get => refURL;
            set => refURL = value;
        }
    }
}
