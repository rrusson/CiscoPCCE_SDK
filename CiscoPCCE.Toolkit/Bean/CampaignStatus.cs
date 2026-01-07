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


  public void setAbandonDetectCount(int? abandonDetectCount) {
     this.abandonDetectCount = abandonDetectCount;
  }

  [XmlElement("abandonToIvrCount")]
  public int? AbandonToIVRCount
  {
      get => abandonToIVRCount;
      set => abandonToIVRCount = value;
  }


  public void setAbandonToIVRCount(int? abandonToIVRCount) {
     this.abandonToIVRCount = abandonToIVRCount;
  }

  public int? AgentClosedCount
  {
      get => agentClosedCount;
      set => agentClosedCount = value;
  }


  public void setAgentClosedCount(int? agentClosedCount) {
     this.agentClosedCount = agentClosedCount;
  }

  public int? AgentRejectedCount
  {
      get => agentRejectedCount;
      set => agentRejectedCount = value;
  }


  public void setAgentRejectedCount(int? agentRejectedCount) {
     this.agentRejectedCount = agentRejectedCount;
  }

  public int? AnsweringMachineCount
  {
      get => answeringMachineCount;
      set => answeringMachineCount = value;
  }


  public void setAnsweringMachineCount(int? answeringMachineCount) {
     this.answeringMachineCount = answeringMachineCount;
  }

  public int? AttemptedCount
  {
      get => attemptedCount;
      set => attemptedCount = value;
  }


  public void setAttemptedCount(int? attemptedCount) {
     this.attemptedCount = attemptedCount;
  }

  public int? BusyCount
  {
      get => busyCount;
      set => busyCount = value;
  }


  public void setBusyCount(int? busyCount) {
     this.busyCount = busyCount;
  }

  public int? CallBackCount
  {
      get => callBackCount;
      set => callBackCount = value;
  }


  public void setCallBackCount(int? callBackCount) {
     this.callBackCount = callBackCount;
  }

  public int? CancelledDetectCount
  {
      get => cancelledDetectCount;
      set => cancelledDetectCount = value;
  }


  public void setCancelledDetectCount(int? cancelledDetectCount) {
     this.cancelledDetectCount = cancelledDetectCount;
  }

  public int? ClosedCount
  {
      get => closedCount;
      set => closedCount = value;
  }


  public void setClosedCount(int? closedCount) {
     this.closedCount = closedCount;
  }

  public int? CustomerAbandonDetectCount
  {
      get => customerAbandonDetectCount;
      set => customerAbandonDetectCount = value;
  }


  public void setCustomerAbandonDetectCount(int? customerAbandonDetectCount) {
     this.customerAbandonDetectCount = customerAbandonDetectCount;
  }

  public int? CustomerNotHomeCount
  {
      get => customerNotHomeCount;
      set => customerNotHomeCount = value;
  }


  public void setCustomerNotHomeCount(int? customerNotHomeCount) {
     this.customerNotHomeCount = customerNotHomeCount;
  }

  public DateTime? DateTime
  {
      get => dateTime;
      set => dateTime = value;
  }


  public void setDateTime(Date dateTime) {
     this.dateTime = dateTime;
  }

  public int? FaxDetectCount
  {
      get => faxDetectCount;
      set => faxDetectCount = value;
  }


  public void setFaxDetectCount(int? faxDetectCount) {
     this.faxDetectCount = faxDetectCount;
  }

  public int? NetworkAnsMachineCount
  {
      get => networkAnsMachineCount;
      set => networkAnsMachineCount = value;
  }


  public void setNetworkAnsMachineCount(int? networkAnsMachineCount) {
     this.networkAnsMachineCount = networkAnsMachineCount;
  }

  public int? NoAnswerDetectCount
  {
      get => noAnswerDetectCount;
      set => noAnswerDetectCount = value;
  }


  public void setNoAnswerDetectCount(int? noAnswerDetectCount) {
     this.noAnswerDetectCount = noAnswerDetectCount;
  }

  public int? NoDialToneDetectCount
  {
      get => noDialToneDetectCount;
      set => noDialToneDetectCount = value;
  }


  public void setNoDialToneDetectCount(int? noDialToneDetectCount) {
     this.noDialToneDetectCount = noDialToneDetectCount;
  }

  public int? NoRingBackDetectCount
  {
      get => noRingBackDetectCount;
      set => noRingBackDetectCount = value;
  }


  public void setNoRingBackDetectCount(int? noRingBackDetectCount) {
     this.noRingBackDetectCount = noRingBackDetectCount;
  }

  public int? PersonalCallbackCount
  {
      get => personalCallbackCount;
      set => personalCallbackCount = value;
  }


  public void setPersonalCallbackCount(int? personalCallbackCount) {
     this.personalCallbackCount = personalCallbackCount;
  }

  public int? SitToneDetectCount
  {
      get => sitToneDetectCount;
      set => sitToneDetectCount = value;
  }


  public void setSitToneDetectCount(int? sitToneDetectCount) {
     this.sitToneDetectCount = sitToneDetectCount;
  }

  public int? TalkTimeCount
  {
      get => talkTimeCount;
      set => talkTimeCount = value;
  }


  public void setTalkTimeCount(int? talkTimeCount) {
     this.talkTimeCount = talkTimeCount;
  }

  public int? TotalCount
  {
      get => totalCount;
      set => totalCount = value;
  }


  public void setTotalCount(int? totalCount) {
     this.totalCount = totalCount;
  }

  public int? TotalVoiceCount
  {
      get => totalVoiceCount;
      set => totalVoiceCount = value;
  }


  public void setTotalVoiceCount(int? totalVoiceCount) {
     this.totalVoiceCount = totalVoiceCount;
  }

  public int? VoiceCount
  {
      get => voiceCount;
      set => voiceCount = value;
  }


  public void setVoiceCount(int? voiceCount) {
     this.voiceCount = voiceCount;
  }

  public int? WrapupTimeCount
  {
      get => wrapupTimeCount;
      set => wrapupTimeCount = value;
  }


  public void setWrapupTimeCount(int? wrapupTimeCount) {
     this.wrapupTimeCount = wrapupTimeCount;
  }

  public int? WrongNumberCount
  {
      get => wrongNumberCount;
      set => wrongNumberCount = value;
  }


  public void setWrongNumberCount(int? wrongNumberCount) {
     this.wrongNumberCount = wrongNumberCount;
  }


  // Path("campaign")
  [XmlRoot("results")]
  public class CampaignStatusList : BaseApiListBean<CampaignStatus> {
    [XmlElement("runtimeStatuss")]
    [XmlElement("runtimeStatus")]
   
    public override List<CampaignStatus>? GetItems() => items;

    public override void SetItems(List<CampaignStatus>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<CampaignStatus>? items)
    {
        this.items = items;
    }
  }
}

}