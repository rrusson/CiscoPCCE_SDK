using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("pageInfo")]
    public class PageInfo : BaseApiBean
    {
        [XmlElement("firstPage")]
        public string? FirstPage { get; set; }

        [XmlElement("lastPage")]
        public string? LastPage { get; set; }

        [XmlElement("nextPage")]
        public string? NextPage { get; set; }

        [XmlElement("prevPage")]
        public string? PrevPage { get; set; }

        [XmlElement("resultsPerPage")]
        public int? ResultsPerPage { get; set; }

        [XmlElement("startIndex")]
        public int? StartIndex { get; set; }

        [XmlElement("totalResults")]
        public int? TotalResults { get; set; }
    }
}