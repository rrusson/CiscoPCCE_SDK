using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class Media : BaseApiBean {
  private string? codec;
  private string? mrcpVersion;
  private bool? overrideSystemPrompt;

  public string? Codec
  {
      get => codec;
      set => codec = value;
  }


  public void setCodec(String codec) {
     this.codec = codec;
  }

  public string? MrcpVersion
  {
      get => mrcpVersion;
      set => mrcpVersion = value;
  }


  public void setMrcpVersion(String mrcpVersion) {
     this.mrcpVersion = mrcpVersion;
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