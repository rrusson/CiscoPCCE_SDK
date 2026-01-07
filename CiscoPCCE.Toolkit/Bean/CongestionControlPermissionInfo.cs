using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class CongestionControlPermissionInfo : BaseApiBean {
  private bool? canChangeDeploymentType;
  private bool? canCreate;
  private bool? canDelete;
  private bool? canUpdate;
  private bool? departmentAdmin;
  private string? role;

  public bool? CanChangeDeploymentType
  {
      get => canChangeDeploymentType;
      set => canChangeDeploymentType = value;
  }


  public void setCanChangeDeploymentType(Boolean canChangeDeploymentType) {
     this.canChangeDeploymentType = canChangeDeploymentType;
  }

  public bool? CanCreate
  {
      get => canCreate;
      set => canCreate = value;
  }


  public void setCanCreate(Boolean canCreate) {
     this.canCreate = canCreate;
  }

  public bool? CanDelete
  {
      get => canDelete;
      set => canDelete = value;
  }


  public void setCanDelete(Boolean canDelete) {
     this.canDelete = canDelete;
  }

  public bool? CanUpdate
  {
      get => canUpdate;
      set => canUpdate = value;
  }


  public void setCanUpdate(Boolean canUpdate) {
     this.canUpdate = canUpdate;
  }

  public bool? DepartmentAdmin
  {
      get => departmentAdmin;
      set => departmentAdmin = value;
  }


  public void setDepartmentAdmin(Boolean departmentAdmin) {
     this.departmentAdmin = departmentAdmin;
  }

  public string? Role
  {
      get => role;
      set => role = value;
  }


  public void setRole(String role) {
     this.role = role;
  }


}

}