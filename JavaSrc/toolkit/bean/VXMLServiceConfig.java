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


@XmlRootElement(name="vxml")
public class VXMLServiceConfig extends BaseApiBean {
  private Boolean enableAppDetailsReporting;
  private Boolean enableReporting;
  private String exclusiveFilters;
  private String inclusiveFilters;

  public Boolean getEnableAppDetailsReporting() {
     return this.enableAppDetailsReporting;
  }

  public void setEnableAppDetailsReporting(Boolean enableAppDetailsReporting) {
     this.enableAppDetailsReporting = enableAppDetailsReporting;
  }

  public Boolean getEnableReporting() {
     return this.enableReporting;
  }

  public void setEnableReporting(Boolean enableReporting) {
     this.enableReporting = enableReporting;
  }

  public String getExclusiveFilters() {
     return this.exclusiveFilters;
  }

  public void setExclusiveFilters(String exclusiveFilters) {
     this.exclusiveFilters = exclusiveFilters;
  }

  public String getInclusiveFilters() {
     return this.inclusiveFilters;
  }

  public void setInclusiveFilters(String inclusiveFilters) {
     this.inclusiveFilters = inclusiveFilters;
  }


}
