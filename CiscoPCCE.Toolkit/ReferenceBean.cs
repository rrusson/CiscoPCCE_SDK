namespace CiscoPCCE.Toolkit
{
    /// <summary>
    /// Reference Bean for associating one bean type with another.
    /// </summary>
    public class ReferenceBean : BaseBean
    {
        public ReferenceBean()
        {
        }

        public ReferenceBean(string refURL)
        {
            RefURL = refURL;
        }

        public string? Name { get; set; }

        public string? RefURL { get; set; }
    }
}
