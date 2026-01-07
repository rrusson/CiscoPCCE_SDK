using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class CallGlobalSetting : BaseApiBean {
  private Short abandonCallWaitTime;
  private int? answeredShortCallThreshold;
  private string? baseUrl;
  private ReferenceBean defaultBucketInterval;
  private ReferenceBean defaultCallType;
  private int? serviceLevelThreshold;
  private Short serviceLevelType;

  public Short AbandonCallWaitTime
  {
      get => abandonCallWaitTime;
      set => abandonCallWaitTime = value;
  }


  public void setAbandonCallWaitTime(Short abandonCallWaitTime) {
     this.abandonCallWaitTime = abandonCallWaitTime;
  }

  public int? AnsweredShortCallThreshold
  {
      get => answeredShortCallThreshold;
      set => answeredShortCallThreshold = value;
  }


  public void setAnsweredShortCallThreshold(int? answeredShortCallThreshold) {
     this.answeredShortCallThreshold = answeredShortCallThreshold;
  }

  public string? BaseUrl
  {
      get => baseUrl;
      set => baseUrl = value;
  }


  public void setBaseUrl(String baseUrl) {
     this.baseUrl = baseUrl;
  }

  public ReferenceBean DefaultBucketInterval
  {
      get => defaultBucketInterval;
      set => defaultBucketInterval = value;
  }


  public void setDefaultBucketInterval(ReferenceBean defaultBucketInterval) {
     this.defaultBucketInterval = defaultBucketInterval;
  }

  public ReferenceBean DefaultCallType
  {
      get => defaultCallType;
      set => defaultCallType = value;
  }


  public void setDefaultCallType(ReferenceBean defaultCallType) {
     this.defaultCallType = defaultCallType;
  }

  public int? ServiceLevelThreshold
  {
      get => serviceLevelThreshold;
      set => serviceLevelThreshold = value;
  }


  public void setServiceLevelThreshold(int? serviceLevelThreshold) {
     this.serviceLevelThreshold = serviceLevelThreshold;
  }

  public Short ServiceLevelType
  {
      get => serviceLevelType;
      set => serviceLevelType = value;
  }


  public void setServiceLevelType(Short serviceLevelType) {
     this.serviceLevelType = serviceLevelType;
  }


}

}