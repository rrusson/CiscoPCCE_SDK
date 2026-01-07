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


  public void setAbandonEnabled(Boolean abandonEnabled) {
     this.abandonEnabled = abandonEnabled;
  }

  public float? AbandonPercent
  {
      get => abandonPercent;
      set => abandonPercent = value;
  }


  public void setAbandonPercent(float? abandonPercent) {
     this.abandonPercent = abandonPercent;
  }

  public AmdTreatmentModeEnum AmdTreatmentMode
  {
      get => amdTreatmentMode;
      set => amdTreatmentMode = value;
  }


  public void setAmdTreatmentMode(AmdTreatmentModeEnum amdTreatmentMode) {
     this.amdTreatmentMode = amdTreatmentMode;
  }

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  [XmlElement("campaignPrefix")]
  public string? CampaignPrefix
  {
      get => campaignPrefix;
      set => campaignPrefix = value;
  }


  public void setCampaignPrefix(String campaignPrefix) {
     this.campaignPrefix = campaignPrefix;
  }

  public CampaignPurposeTypeEnum CampaignPurposeType
  {
      get => campaignPurposeType;
      set => campaignPurposeType = value;
  }


  public void setCampaignPurposeType(CampaignPurposeTypeEnum campaignPurposeType) {
     this.campaignPurposeType = campaignPurposeType;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }


  public void setChangeStamp(int? changeStamp) {
     this.changeStamp = changeStamp;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }


  public void setCorrelationId(String correlationId) {
     this.correlationId = correlationId;
  }

  [XmlElement("callProgressAnalysis")]
  public CampaignCPAFields CpaFields
  {
      get => cpaFields;
      set => cpaFields = value;
  }


  public void setCpaFields(CampaignCPAFields cpaFields) {
     this.cpaFields = cpaFields;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }


  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public string? Description
  {
      get => description;
      set => description = value;
  }


  public void setDescription(String description) {
     this.description = description;
  }

  public DialingMode DialingMode
  {
      get => dialingMode;
      set => dialingMode = value;
  }


  public void setDialingMode(DialingMode dialingMode) {
     this.dialingMode = dialingMode;
  }

  public bool? Enabled
  {
      get => enabled;
      set => enabled = value;
  }


  public void setEnabled(Boolean enabled) {
     this.enabled = enabled;
  }

  public DateTime? EndDate
  {
      get => endDate;
      set => endDate = value;
  }


  public void setEndDate(Date endDate) {
     this.endDate = endDate;
  }

  public string? EndTime
  {
      get => endTime;
      set => endTime = value;
  }


  public void setEndTime(String endTime) {
     this.endTime = endTime;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  [XmlElement("import")]
  public ImportContact ImportContact
  {
      get => importContact;
      set => importContact = value;
  }


  public void setImportContact(ImportContact importContact) {
     this.importContact = importContact;
  }

  public bool? IpAmdEnabled
  {
      get => ipAmdEnabled;
      set => ipAmdEnabled = value;
  }


  public void setIpAmdEnabled(Boolean ipAmdEnabled) {
     this.ipAmdEnabled = ipAmdEnabled;
  }

  public bool? IpTerminatingBeepDetect
  {
      get => ipTerminatingBeepDetect;
      set => ipTerminatingBeepDetect = value;
  }


  public void setIpTerminatingBeepDetect(Boolean ipTerminatingBeepDetect) {
     this.ipTerminatingBeepDetect = ipTerminatingBeepDetect;
  }

  public float? LinesPerAgent
  {
      get => linesPerAgent;
      set => linesPerAgent = value;
  }


  public void setLinesPerAgent(float? linesPerAgent) {
     this.linesPerAgent = linesPerAgent;
  }

  public bool? MarkDeletable
  {
      get => markDeletable;
      set => markDeletable = value;
  }


  public void setMarkDeletable(Boolean markDeletable) {
     this.markDeletable = markDeletable;
  }

  public int? MaxAttempts
  {
      get => maxAttempts;
      set => maxAttempts = value;
  }


  public void setMaxAttempts(int? maxAttempts) {
     this.maxAttempts = maxAttempts;
  }

  public float? MaximumLinesPerAgent
  {
      get => maximumLinesPerAgent;
      set => maximumLinesPerAgent = value;
  }


  public void setMaximumLinesPerAgent(float? maximumLinesPerAgent) {
     this.maximumLinesPerAgent = maximumLinesPerAgent;
  }

  public int? MinimumCallDuration
  {
      get => minimumCallDuration;
      set => minimumCallDuration = value;
  }


  public void setMinimumCallDuration(int? minimumCallDuration) {
     this.minimumCallDuration = minimumCallDuration;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public int? NoAnswerRingLimit
  {
      get => noAnswerRingLimit;
      set => noAnswerRingLimit = value;
  }


  public void setNoAnswerRingLimit(int? noAnswerRingLimit) {
     this.noAnswerRingLimit = noAnswerRingLimit;
  }

  public bool? PersonalizedCallbackEnabled
  {
      get => personalizedCallbackEnabled;
      set => personalizedCallbackEnabled = value;
  }


  public void setPersonalizedCallbackEnabled(Boolean personalizedCallbackEnabled) {
     this.personalizedCallbackEnabled = personalizedCallbackEnabled;
  }

  public int? PredictiveCorrectionPace
  {
      get => predictiveCorrectionPace;
      set => predictiveCorrectionPace = value;
  }


  public void setPredictiveCorrectionPace(int? predictiveCorrectionPace) {
     this.predictiveCorrectionPace = predictiveCorrectionPace;
  }

  public float? PredictiveGain
  {
      get => predictiveGain;
      set => predictiveGain = value;
  }


  public void setPredictiveGain(float? predictiveGain) {
     this.predictiveGain = predictiveGain;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public RescheduleCallbackModeEnum RescheduleCallbackMode
  {
      get => rescheduleCallbackMode;
      set => rescheduleCallbackMode = value;
  }


  public void setRescheduleCallbackMode(RescheduleCallbackModeEnum rescheduleCallbackMode) {
     this.rescheduleCallbackMode = rescheduleCallbackMode;
  }

  public int? ReservationPercentage
  {
      get => reservationPercentage;
      set => reservationPercentage = value;
  }


  public void setReservationPercentage(int? reservationPercentage) {
     this.reservationPercentage = reservationPercentage;
  }

  public CampaignRetryFields Retries
  {
      get => retries;
      set => retries = value;
  }


  public void setRetries(CampaignRetryFields retries) {
     this.retries = retries;
  }

  [XmlElement("skillGroupInfos")]
  [XmlElement("skillGroupInfo")]
  public List<CampaignSkillGroupInfo>? SkillGroupInfos
  {
      get => skillGroupInfos;
      set => skillGroupInfos = value;
  }


  public void setSkillGroupInfos(List<CampaignSkillGroupInfo> skillGroupInfos) {
     this.skillGroupInfos = skillGroupInfos;
  }

  [XmlElement("skillGroupInfosAdded")]
  [XmlElement("skillGroupInfo")]
  public List<CampaignSkillGroupInfo>? SkillGroupInfosAdded
  {
      get => skillGroupInfosAdded;
      set => skillGroupInfosAdded = value;
  }


  public void setSkillGroupInfosAdded(List<CampaignSkillGroupInfo> skillGroupInfosAdded) {
     this.skillGroupInfosAdded = skillGroupInfosAdded;
  }

  [XmlElement("skillGroupInfosRemoved")]
  [XmlElement("skillGroupInfo")]
  public List<CampaignSkillGroupInfo>? SkillGroupInfosRemoved
  {
      get => skillGroupInfosRemoved;
      set => skillGroupInfosRemoved = value;
  }


  public void setSkillGroupInfosRemoved(List<CampaignSkillGroupInfo> skillGroupInfosRemoved) {
     this.skillGroupInfosRemoved = skillGroupInfosRemoved;
  }

  public DateTime? StartDate
  {
      get => startDate;
      set => startDate = value;
  }


  public void setStartDate(Date startDate) {
     this.startDate = startDate;
  }

  public string? StartTime
  {
      get => startTime;
      set => startTime = value;
  }


  public void setStartTime(String startTime) {
     this.startTime = startTime;
  }

  public TimeZoneRef TimeZone
  {
      get => timeZone;
      set => timeZone = value;
  }


  public void setTimeZone(TimeZoneRef timeZone) {
     this.timeZone = timeZone;
  }


  // Path("campaign")
  [XmlRoot("results")]
  public class CampaignList : BaseApiListBean<Campaign> {
    [XmlElement("campaigns")]
    [XmlElement("campaign")]
   
    public override List<Campaign>? GetItems() => items;

    public override void SetItems(List<Campaign>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<Campaign>? items)
    {
        this.items = items;
    }
  }
}

}