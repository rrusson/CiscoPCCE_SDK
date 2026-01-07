using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class CampaignCPAFields : BaseApiBean {
  private int? analysisPeriod;
  private bool? enableRecordWaveFile;
  private bool? enabled;
  private int? maxTermToneAnalysis;
  private int? maxTimeAnalysis;
  private int? minSilencePeriod;
  private int? minimumValidSpeech;

  public int? AnalysisPeriod
  {
      get => analysisPeriod;
      set => analysisPeriod = value;
  }


  public void setAnalysisPeriod(int? analysisPeriod) {
     this.analysisPeriod = analysisPeriod;
  }

  [XmlElement("record")]
  public bool? EnableRecordWaveFile
  {
      get => enableRecordWaveFile;
      set => enableRecordWaveFile = value;
  }


  public void setEnableRecordWaveFile(Boolean enableRecordWaveFile) {
     this.enableRecordWaveFile = enableRecordWaveFile;
  }

  public bool? Enabled
  {
      get => enabled;
      set => enabled = value;
  }


  public void setEnabled(Boolean enabled) {
     this.enabled = enabled;
  }

  public int? MaxTermToneAnalysis
  {
      get => maxTermToneAnalysis;
      set => maxTermToneAnalysis = value;
  }


  public void setMaxTermToneAnalysis(int? maxTermToneAnalysis) {
     this.maxTermToneAnalysis = maxTermToneAnalysis;
  }

  public int? MaxTimeAnalysis
  {
      get => maxTimeAnalysis;
      set => maxTimeAnalysis = value;
  }


  public void setMaxTimeAnalysis(int? maxTimeAnalysis) {
     this.maxTimeAnalysis = maxTimeAnalysis;
  }

  public int? MinSilencePeriod
  {
      get => minSilencePeriod;
      set => minSilencePeriod = value;
  }


  public void setMinSilencePeriod(int? minSilencePeriod) {
     this.minSilencePeriod = minSilencePeriod;
  }

  public int? MinimumValidSpeech
  {
      get => minimumValidSpeech;
      set => minimumValidSpeech = value;
  }


  public void setMinimumValidSpeech(int? minimumValidSpeech) {
     this.minimumValidSpeech = minimumValidSpeech;
  }


}

}