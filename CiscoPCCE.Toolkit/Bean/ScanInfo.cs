using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class ScanInfo : BaseApiBean {
  private long lastScanDateTime;
  private ScanState scanState;

  public long LastScanDateTime
  {
      get => lastScanDateTime;
      set => lastScanDateTime = value;
  }


  public void setLastScanDateTime(long lastScanDateTime) {
     this.lastScanDateTime = lastScanDateTime;
  }

  public ScanState ScanState
  {
      get => scanState;
      set => scanState = value;
  }


  public void setScanState(ScanState scanState) {
     this.scanState = scanState;
  }


}

}