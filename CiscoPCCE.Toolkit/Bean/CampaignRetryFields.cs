using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class CampaignRetryFields : BaseApiBean {
            
  public int? AnsweringMachineDelay { get; set; }

  public int? BusySignalDelay { get; set; }

  public int? CustomerAbandonedDelay { get; set; }

  public int? CustomerNotHomeDelay { get; set; }

  public int? DialerAbandonedDelay { get; set; }

  public int? NoAnswerDelay { get; set; }

}

}