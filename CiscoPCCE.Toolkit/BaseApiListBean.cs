using System.Collections.Generic;

namespace CiscoPCCE.Toolkit
{
    /// <summary>
    /// Base class for all List Beans.
    /// </summary>
    public abstract class BaseApiListBean<T> where T : BaseApiBean
    {
        /// <summary>
        /// List of items of the implementing type
        /// </summary>
        protected List<T>? items;

        /// <summary>
        /// Override and add the appropriate XML attributes in derived classes.
        /// </summary>
        /// <returns>List of items of the implementing type</returns>
        public abstract List<T>? GetItems();

        /// <summary>
        /// Sets the items into the list.
        /// Needed for unmarshalling
        /// </summary>
        /// <param name="items">The items to set</param>
        public abstract void SetItems(List<T>? items);
    }
}
