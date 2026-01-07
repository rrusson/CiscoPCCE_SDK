using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("import")]
public class ImportContact : BaseApiBean {
  private string? delimiter;
  private string? fileContent;
  private bool? overwriteData;

  public string? Delimiter
  {
      get => delimiter;
      set => delimiter = value;
  }


  public void setDelimiter(String delimiter) {
     this.delimiter = delimiter;
  }

  public string? FileContent
  {
      get => fileContent;
      set => fileContent = value;
  }


  public void setFileContent(String fileContent) {
     this.fileContent = fileContent;
  }

  public bool? OverwriteData
  {
      get => overwriteData;
      set => overwriteData = value;
  }


  public void setOverwriteData(bool? overwriteData) {
     this.overwriteData = overwriteData;
  }


}

}