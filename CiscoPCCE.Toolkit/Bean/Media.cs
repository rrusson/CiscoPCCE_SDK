using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class Media : BaseApiBean {
  private string? codec;
  private string? mrcpVersion;
  private bool? overrideSystemPrompt;

  public string? Codec { get; set; }

  public string? MrcpVersion { get; set; }

  public bool? OverrideSystemPrompt { get; set; }

}

}