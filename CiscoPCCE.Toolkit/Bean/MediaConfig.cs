using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("media")]
public class MediaConfig : BaseApiBean {
  private string? codec;
  private string? mRCPVersion;
  private bool? overrideSystemPrompt;

  public string? Codec
  {
      get => codec;
      set => codec = value;
  }


  public void setCodec(String codec) {
     this.codec = codec;
  }

  public string? MRCPVersion
  {
      get => mRCPVersion;
      set => mRCPVersion = value;
  }


  public void setMRCPVersion(String mRCPVersion) {
     this.mRCPVersion = mRCPVersion;
  }

  public bool? OverrideSystemPrompt
  {
      get => overrideSystemPrompt;
      set => overrideSystemPrompt = value;
  }


  public void setOverrideSystemPrompt(Boolean overrideSystemPrompt) {
     this.overrideSystemPrompt = overrideSystemPrompt;
  }


}

}