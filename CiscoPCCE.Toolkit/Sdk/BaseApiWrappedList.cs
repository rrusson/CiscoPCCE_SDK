using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Bean;

namespace CiscoPCCE.Toolkit.Sdk
{
    /// <summary>
    /// Base class for List Beans that include pagination and permission information.
    /// </summary>
    public abstract class BaseApiWrappedList<T> : BaseApiList<T> where T : BaseApiBean
    {
        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }
    }
}
