// ----------------------------------------------
package com.cisco.ccbu.cce.unifiedconfig.toolkit.bean;

import com.cisco.ccbu.cce.unifiedconfig.toolkit.BaseApiBean;
import javax.xml.bind.annotation.XmlSeeAlso;
import javax.ws.rs.Path;
import javax.xml.bind.annotation.XmlRootElement;
import java.util.List;
import com.cisco.ccbu.cce.unifiedconfig.toolkit.ReferenceBean;
import java.util.Date;
import com.cisco.ccbu.cce.unifiedconfig.toolkit.BaseApiListBean;

import javax.xml.bind.annotation.XmlElement;

import javax.xml.bind.annotation.XmlElementWrapper;


@Path("applicationgatewayglobalsetting")
@XmlRootElement(name="applicationGatewayGlobalSetting")
public class ApplicationGatewayGlobals extends BaseApiBean {
  private String baseUrlfromRefUrl;
  private ConnectionParametersGlobal connectionParameters;
  private String correlationId;
  private ReferenceBean department;
  private String idFromRefUrl;
  private ApplicationGatewayType type;

  public String getBaseUrlfromRefUrl() {
     return this.baseUrlfromRefUrl;
  }

  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public ConnectionParametersGlobal getConnectionParameters() {
     return this.connectionParameters;
  }

  public void setConnectionParameters(ConnectionParametersGlobal connectionParameters) {
     this.connectionParameters = connectionParameters;
  }

  public String getCorrelationId() {
     return this.correlationId;
  }

  public void setCorrelationId(String correlationId) {
     this.correlationId = correlationId;
  }

  public ReferenceBean getDepartment() {
     return this.department;
  }

  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public String getIdFromRefUrl() {
     return this.idFromRefUrl;
  }

  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public ApplicationGatewayType getType() {
     return this.type;
  }

  public void setType(ApplicationGatewayType type) {
     this.type = type;
  }


  @Path("applicationgatewayglobalsetting")
  @XmlRootElement(name = "results")
  public static class ApplicationGatewayGlobalsList extends BaseApiListBean<ApplicationGatewayGlobals> {
    @XmlElementWrapper(name = "applicationGatewayGlobalSettings")
    @XmlElement(name = "applicationGatewayGlobalSetting")
    public List<ApplicationGatewayGlobals> getItems() {
      return items;
    }

    public void setItems(List<ApplicationGatewayGlobals> items) {
      this.items = items;
    }
  }
}
