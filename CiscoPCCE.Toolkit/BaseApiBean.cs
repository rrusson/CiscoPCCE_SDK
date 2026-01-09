namespace CiscoPCCE.Toolkit
{
    /// <summary>
    /// Base Bean for making REST API calls.
    /// </summary>
    public abstract class BaseApiBean : BaseBean
    {
        public int? ChangeStamp { get; set; }

        public string? RefURL { get; set; }

        public void SetPath(string path)
        {
            RefURL = RestClient.BaseUrl + path;
        }

        public void InitRefURL()
        {
            // In C#, we'll need to use a different approach for getting the Path attribute
            // This will be handled in derived classes
        }
    }
}
