using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("database")
[XmlRoot("database")]
public class Database : BaseApiBean {
  private int? dataFileSizeMB;
  private DbType databaseType;
  private string? drive;
  private int? logFileSizeMB;
  private string? refURL;
  private Side side;

  public int? DataFileSizeMB
  {
      get => dataFileSizeMB;
      set => dataFileSizeMB = value;
  }


  public void setDataFileSizeMB(int? dataFileSizeMB) {
     this.dataFileSizeMB = dataFileSizeMB;
  }

  public DbType DatabaseType
  {
      get => databaseType;
      set => databaseType = value;
  }


  public void setDatabaseType(DbType databaseType) {
     this.databaseType = databaseType;
  }

  public string? Drive
  {
      get => drive;
      set => drive = value;
  }


  public void setDrive(String drive) {
     this.drive = drive;
  }

  public int? LogFileSizeMB
  {
      get => logFileSizeMB;
      set => logFileSizeMB = value;
  }


  public void setLogFileSizeMB(int? logFileSizeMB) {
     this.logFileSizeMB = logFileSizeMB;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public Side Side
  {
      get => side;
      set => side = value;
  }


  public void setSide(Side side) {
     this.side = side;
  }


  // Path("database")
  [XmlRoot("results")]
  public class DatabaseList : BaseApiListBean<Database> {
    [XmlElement("databases")]
    [XmlElement("database")]
   
    public override List<Database>? GetItems() => items;

    public override void SetItems(List<Database>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<Database>? items)
    {
        this.items = items;
    }
  }
}

}