using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class PermissionInfo : BaseApiBean {
          
  public bool? CanCreate { get; set; }

  public bool? CanDelete { get; set; }

  public bool? CanUpdate { get; set; }

  public bool? DepartmentAdmin { get; set; }

  public string? Role { get; set; }

}

}