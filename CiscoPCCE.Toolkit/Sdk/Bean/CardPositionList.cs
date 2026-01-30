using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("layout")]
    public class CardPositionList : BaseApiBean
    {
        [XmlArray("cards")]
        [XmlArrayItem("card")]
        public List<CardPosition>? Items { get; set; }        [XmlType("results")]
        public class CardPositionListList : BaseApiWrappedList<CardPositionList>
        {
            [XmlArray("layouts")]
            [XmlArrayItem("layout")]
            public new List<CardPositionList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }
        }
    }
}