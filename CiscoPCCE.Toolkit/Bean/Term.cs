using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class Term : BaseApiBean {
  private ReferenceBean attribute;
  private int? attributeRelation;
  private int? parenCount;
  private string? refURL;
  private int? termRelation;
  private string? value1;

  public ReferenceBean Attribute
  {
      get => attribute;
      set => attribute = value;
  }


  public void setAttribute(ReferenceBean attribute) {
     this.attribute = attribute;
  }

  public int? AttributeRelation
  {
      get => attributeRelation;
      set => attributeRelation = value;
  }


  public void setAttributeRelation(int? attributeRelation) {
     this.attributeRelation = attributeRelation;
  }

  public int? ParenCount
  {
      get => parenCount;
      set => parenCount = value;
  }


  public void setParenCount(int? parenCount) {
     this.parenCount = parenCount;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public int? TermRelation
  {
      get => termRelation;
      set => termRelation = value;
  }


  public void setTermRelation(int? termRelation) {
     this.termRelation = termRelation;
  }

  public string? Value1
  {
      get => value1;
      set => value1 = value;
  }


  public void setValue1(String value1) {
     this.value1 = value1;
  }


}

}