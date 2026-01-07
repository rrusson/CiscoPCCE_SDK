using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("syncStatus")]
public class SyncStatus : BaseApiBean {
  private string? currentSyncStatus;
  private string? lastSyncStats;
  private string? lastSyncStatus;
  private string? lastSyncTime;

  public string? CurrentSyncStatus
  {
      get => currentSyncStatus;
      set => currentSyncStatus = value;
  }


  public void setCurrentSyncStatus(String currentSyncStatus) {
     this.currentSyncStatus = currentSyncStatus;
  }

  public string? LastSyncStats
  {
      get => lastSyncStats;
      set => lastSyncStats = value;
  }


  public void setLastSyncStats(String lastSyncStats) {
     this.lastSyncStats = lastSyncStats;
  }

  public string? LastSyncStatus
  {
      get => lastSyncStatus;
      set => lastSyncStatus = value;
  }


  public void setLastSyncStatus(String lastSyncStatus) {
     this.lastSyncStatus = lastSyncStatus;
  }

  public string? LastSyncTime
  {
      get => lastSyncTime;
      set => lastSyncTime = value;
  }


  public void setLastSyncTime(String lastSyncTime) {
     this.lastSyncTime = lastSyncTime;
  }


}

}