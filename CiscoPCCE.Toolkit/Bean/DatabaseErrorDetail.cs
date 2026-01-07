using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("errorDetail")]
public class DatabaseErrorDetail : BaseApiBean {
  private DbType dbType;
  private string? machineName;
  private Side side;

  public DbType DbType
  {
      get => dbType;
      set => dbType = value;
  }


  public void setDbType(DbType dbType) {
     this.dbType = dbType;
  }

  public string? MachineName
  {
      get => machineName;
      set => machineName = value;
  }


  public void setMachineName(String machineName) {
     this.machineName = machineName;
  }

  public Side Side
  {
      get => side;
      set => side = value;
  }


  public void setSide(Side side) {
     this.side = side;
  }


}

}