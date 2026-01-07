using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class Term : BaseApiBean {
            
  public ReferenceBean Attribute { get; set; }

  public int? AttributeRelation { get; set; }

  public int? ParenCount { get; set; }

  public string? RefURL { get; set; }

  public int? TermRelation { get; set; }

  public string? Value1 { get; set; }

}

}