using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class CongestionControlPermissionInfo : BaseApiBean {
            
  public bool? CanChangeDeploymentType { get; set; }

  public bool? CanCreate { get; set; }

  public bool? CanDelete { get; set; }

  public bool? CanUpdate { get; set; }

  public bool? DepartmentAdmin { get; set; }

  public string? Role { get; set; }

}

}