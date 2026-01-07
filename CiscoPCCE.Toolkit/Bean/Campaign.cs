using System.Xml.Serialization;
using System.Collections.Generic;
using System;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("campaign")
[XmlRoot("campaign")]
public class Campaign : BaseApiBean {
  private bool? abandonEnabled;
  private float? abandonPercent;
  private AmdTreatmentModeEnum amdTreatmentMode;
  private string? baseUrlfromRefUrl;
  private string? campaignPrefix;
  private CampaignPurposeTypeEnum campaignPurposeType;
  private int? changeStamp;
  private string? correlationId;
  private CampaignCPAFields cpaFields;
  private ReferenceBean department;
  private string? description;
  private DialingMode dialingMode;
  private bool? enabled;
  private DateTime? endDate;
  private string? endTime;
  private string? idFromRefUrl;
  private ImportContact importContact;
  private bool? ipAmdEnabled;
  private bool? ipTerminatingBeepDetect;
  private float? linesPerAgent;
  private bool? markDeletable;
  private int? maxAttempts;
  private float? maximumLinesPerAgent;
  private int? minimumCallDuration;
  private string? name;
  private int? noAnswerRingLimit;
  private bool? personalizedCallbackEnabled;
  private int? predictiveCorrectionPace;
  private float? predictiveGain;
  private string? refURL;
  private RescheduleCallbackModeEnum rescheduleCallbackMode;
  private int? reservationPercentage;
  private CampaignRetryFields retries;
  private List<CampaignSkillGroupInfo>? skillGroupInfos;
  private List<CampaignSkillGroupInfo>? skillGroupInfosAdded;
  private List<CampaignSkillGroupInfo>? skillGroupInfosRemoved;
  private DateTime? startDate;
  private string? startTime;
  private TimeZoneRef timeZone;

  public bool? AbandonEnabled
  {
      get => abandonEnabled;
      set => abandonEnabled = value;
  }

  public float? AbandonPercent
  {
      get => abandonPercent;
      set => abandonPercent = value;
  }

  public AmdTreatmentModeEnum AmdTreatmentMode
  {
      get => amdTreatmentMode;
      set => amdTreatmentMode = value;
  }

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }

  [XmlElement("campaignPrefix")]
  public string? CampaignPrefix
  {
      get => campaignPrefix;
      set => campaignPrefix = value;
  }

  public CampaignPurposeTypeEnum CampaignPurposeType
  {
      get => campaignPurposeType;
      set => campaignPurposeType = value;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }

  [XmlElement("callProgressAnalysis")]
  public CampaignCPAFields CpaFields
  {
      get => cpaFields;
      set => cpaFields = value;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }

  public string? Description
  {
      get => description;
      set => description = value;
  }

  public DialingMode DialingMode
  {
      get => dialingMode;
      set => dialingMode = value;
  }

  public bool? Enabled
  {
      get => enabled;
      set => enabled = value;
  }

  public DateTime? EndDate
  {
      get => endDate;
      set => endDate = value;
  }

  public string? EndTime
  {
      get => endTime;
      set => endTime = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  [XmlElement("import")]
  public ImportContact ImportContact
  {
      get => importContact;
      set => importContact = value;
  }

  public bool? IpAmdEnabled
  {
      get => ipAmdEnabled;
      set => ipAmdEnabled = value;
  }

  public bool? IpTerminatingBeepDetect
  {
      get => ipTerminatingBeepDetect;
      set => ipTerminatingBeepDetect = value;
  }

  public float? LinesPerAgent
  {
      get => linesPerAgent;
      set => linesPerAgent = value;
  }

  public bool? MarkDeletable
  {
      get => markDeletable;
      set => markDeletable = value;
  }

  public int? MaxAttempts
  {
      get => maxAttempts;
      set => maxAttempts = value;
  }

  public float? MaximumLinesPerAgent
  {
      get => maximumLinesPerAgent;
      set => maximumLinesPerAgent = value;
  }

  public int? MinimumCallDuration
  {
      get => minimumCallDuration;
      set => minimumCallDuration = value;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }

  public int? NoAnswerRingLimit
  {
      get => noAnswerRingLimit;
      set => noAnswerRingLimit = value;
  }

  public bool? PersonalizedCallbackEnabled
  {
      get => personalizedCallbackEnabled;
      set => personalizedCallbackEnabled = value;
  }

  public int? PredictiveCorrectionPace
  {
      get => predictiveCorrectionPace;
      set => predictiveCorrectionPace = value;
  }

  public float? PredictiveGain
  {
      get => predictiveGain;
      set => predictiveGain = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public RescheduleCallbackModeEnum RescheduleCallbackMode
  {
      get => rescheduleCallbackMode;
      set => rescheduleCallbackMode = value;
  }

  public int? ReservationPercentage
  {
      get => reservationPercentage;
      set => reservationPercentage = value;
  }

  public CampaignRetryFields Retries
  {
      get => retries;
      set => retries = value;
  }

  [XmlElement("skillGroupInfos")]
  [XmlElement("skillGroupInfo")]
  public List<CampaignSkillGroupInfo>? SkillGroupInfos
  {
      get => skillGroupInfos;
      set => skillGroupInfos = value;
  }

  [XmlElement("skillGroupInfosAdded")]
  [XmlElement("skillGroupInfo")]
  public List<CampaignSkillGroupInfo>? SkillGroupInfosAdded
  {
      get => skillGroupInfosAdded;
      set => skillGroupInfosAdded = value;
  }

  [XmlElement("skillGroupInfosRemoved")]
  [XmlElement("skillGroupInfo")]
  public List<CampaignSkillGroupInfo>? SkillGroupInfosRemoved
  {
      get => skillGroupInfosRemoved;
      set => skillGroupInfosRemoved = value;
  }

  public DateTime? StartDate
  {
      get => startDate;
      set => startDate = value;
  }

  public string? StartTime
  {
      get => startTime;
      set => startTime = value;
  }

  public TimeZoneRef TimeZone
  {
      get => timeZone;
      set => timeZone = value;
  }

  // Path("campaign")
  [XmlRoot("results")]
  public class CampaignList : BaseApiListBean<Campaign> {    public override List<Campaign>? GetItems() => items;

    public override void SetItems(List<Campaign>? value) => items = value;

  }
}

}