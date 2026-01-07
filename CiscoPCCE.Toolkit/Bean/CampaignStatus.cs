using System.Xml.Serialization;
using System.Collections.Generic;
using System;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("campaign")
[XmlRoot("runtimeStatus")]
public class CampaignStatus : BaseApiBean {
  private int? abandonDetectCount;
  private int? abandonToIVRCount;
  private int? agentClosedCount;
  private int? agentRejectedCount;
  private int? answeringMachineCount;
  private int? attemptedCount;
  private int? busyCount;
  private int? callBackCount;
  private int? cancelledDetectCount;
  private int? closedCount;
  private int? customerAbandonDetectCount;
  private int? customerNotHomeCount;
  private DateTime? dateTime;
  private int? faxDetectCount;
  private int? networkAnsMachineCount;
  private int? noAnswerDetectCount;
  private int? noDialToneDetectCount;
  private int? noRingBackDetectCount;
  private int? personalCallbackCount;
  private int? sitToneDetectCount;
  private int? talkTimeCount;
  private int? totalCount;
  private int? totalVoiceCount;
  private int? voiceCount;
  private int? wrapupTimeCount;
  private int? wrongNumberCount;

  public int? AbandonDetectCount
  {
      get => abandonDetectCount;
      set => abandonDetectCount = value;
  }

  [XmlElement("abandonToIvrCount")]
  public int? AbandonToIVRCount
  {
      get => abandonToIVRCount;
      set => abandonToIVRCount = value;
  }

  public int? AgentClosedCount
  {
      get => agentClosedCount;
      set => agentClosedCount = value;
  }

  public int? AgentRejectedCount
  {
      get => agentRejectedCount;
      set => agentRejectedCount = value;
  }

  public int? AnsweringMachineCount
  {
      get => answeringMachineCount;
      set => answeringMachineCount = value;
  }

  public int? AttemptedCount
  {
      get => attemptedCount;
      set => attemptedCount = value;
  }

  public int? BusyCount
  {
      get => busyCount;
      set => busyCount = value;
  }

  public int? CallBackCount
  {
      get => callBackCount;
      set => callBackCount = value;
  }

  public int? CancelledDetectCount
  {
      get => cancelledDetectCount;
      set => cancelledDetectCount = value;
  }

  public int? ClosedCount
  {
      get => closedCount;
      set => closedCount = value;
  }

  public int? CustomerAbandonDetectCount
  {
      get => customerAbandonDetectCount;
      set => customerAbandonDetectCount = value;
  }

  public int? CustomerNotHomeCount
  {
      get => customerNotHomeCount;
      set => customerNotHomeCount = value;
  }

  public DateTime? DateTime
  {
      get => dateTime;
      set => dateTime = value;
  }

  public int? FaxDetectCount
  {
      get => faxDetectCount;
      set => faxDetectCount = value;
  }

  public int? NetworkAnsMachineCount
  {
      get => networkAnsMachineCount;
      set => networkAnsMachineCount = value;
  }

  public int? NoAnswerDetectCount
  {
      get => noAnswerDetectCount;
      set => noAnswerDetectCount = value;
  }

  public int? NoDialToneDetectCount
  {
      get => noDialToneDetectCount;
      set => noDialToneDetectCount = value;
  }

  public int? NoRingBackDetectCount
  {
      get => noRingBackDetectCount;
      set => noRingBackDetectCount = value;
  }

  public int? PersonalCallbackCount
  {
      get => personalCallbackCount;
      set => personalCallbackCount = value;
  }

  public int? SitToneDetectCount
  {
      get => sitToneDetectCount;
      set => sitToneDetectCount = value;
  }

  public int? TalkTimeCount
  {
      get => talkTimeCount;
      set => talkTimeCount = value;
  }

  public int? TotalCount
  {
      get => totalCount;
      set => totalCount = value;
  }

  public int? TotalVoiceCount
  {
      get => totalVoiceCount;
      set => totalVoiceCount = value;
  }

  public int? VoiceCount
  {
      get => voiceCount;
      set => voiceCount = value;
  }

  public int? WrapupTimeCount
  {
      get => wrapupTimeCount;
      set => wrapupTimeCount = value;
  }

  public int? WrongNumberCount
  {
      get => wrongNumberCount;
      set => wrongNumberCount = value;
  }

  // Path("campaign")
  [XmlRoot("results")]
  public class CampaignStatusList : BaseApiListBean<CampaignStatus> {    public override List<CampaignStatus>? GetItems() => items;

    public override void SetItems(List<CampaignStatus>? value) => items = value;

  }
}

}