using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("pageInfo")]
public class PageInfo : BaseApiBean {
              
  public string? FirstPage { get; set; }

  public string? LastPage { get; set; }

  public string? NextPage { get; set; }

  public string? PrevPage { get; set; }

  public int? ResultsPerPage { get; set; }

  public int? StartIndex { get; set; }

  public int? TotalResults { get; set; }

}

}