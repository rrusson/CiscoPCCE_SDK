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

  public DbType DatabaseType
  {
      get => databaseType;
      set => databaseType = value;
  }

  public string? Drive
  {
      get => drive;
      set => drive = value;
  }

  public int? LogFileSizeMB
  {
      get => logFileSizeMB;
      set => logFileSizeMB = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public Side Side
  {
      get => side;
      set => side = value;
  }

  // Path("database")
  [XmlRoot("results")]
  public class DatabaseList : BaseApiListBean<Database> {    public override List<Database>? GetItems() => items;

    public override void SetItems(List<Database>? value) => items = value;

  }
}

}