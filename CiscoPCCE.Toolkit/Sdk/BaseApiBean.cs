using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Sdk
{
    /// <summary>
    /// Base Bean for making REST API calls.
    /// </summary>
    public abstract class BaseApiBean : BaseBean
    {
        [XmlElement("changeStamp")]
        public int? ChangeStamp { get; set; }

        [XmlElement("refURL")]
        public string? RefURL { get; set; }

        public void SetPath(string path)
        {
            RefURL = CiscoRestClient.BaseUrl + path;
        }

        public void InitRefURL()
        {
            // In C#, we'll need to use a different approach for getting the Path attribute
            // This will be handled in derived classes
        }
    }
}
