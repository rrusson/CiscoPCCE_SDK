using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class CampaignRetryFields : BaseApiBean {
  private int? answeringMachineDelay;
  private int? busySignalDelay;
  private int? customerAbandonedDelay;
  private int? customerNotHomeDelay;
  private int? dialerAbandonedDelay;
  private int? noAnswerDelay;

  public int? AnsweringMachineDelay
  {
      get => answeringMachineDelay;
      set => answeringMachineDelay = value;
  }


  public void setAnsweringMachineDelay(int? answeringMachineDelay) {
     this.answeringMachineDelay = answeringMachineDelay;
  }

  public int? BusySignalDelay
  {
      get => busySignalDelay;
      set => busySignalDelay = value;
  }


  public void setBusySignalDelay(int? busySignalDelay) {
     this.busySignalDelay = busySignalDelay;
  }

  public int? CustomerAbandonedDelay
  {
      get => customerAbandonedDelay;
      set => customerAbandonedDelay = value;
  }


  public void setCustomerAbandonedDelay(int? customerAbandonedDelay) {
     this.customerAbandonedDelay = customerAbandonedDelay;
  }

  public int? CustomerNotHomeDelay
  {
      get => customerNotHomeDelay;
      set => customerNotHomeDelay = value;
  }


  public void setCustomerNotHomeDelay(int? customerNotHomeDelay) {
     this.customerNotHomeDelay = customerNotHomeDelay;
  }

  public int? DialerAbandonedDelay
  {
      get => dialerAbandonedDelay;
      set => dialerAbandonedDelay = value;
  }


  public void setDialerAbandonedDelay(int? dialerAbandonedDelay) {
     this.dialerAbandonedDelay = dialerAbandonedDelay;
  }

  public int? NoAnswerDelay
  {
      get => noAnswerDelay;
      set => noAnswerDelay = value;
  }


  public void setNoAnswerDelay(int? noAnswerDelay) {
     this.noAnswerDelay = noAnswerDelay;
  }


}

}