using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit
{
    /// <summary>
    /// Base class for all List Beans.
    /// </summary>
    public abstract class BaseApiList<T> where T : BaseApiBean
    {
        /// <summary>
        /// List of items of the implementing type
        /// </summary>
        protected List<T>? Items;
    }
}
