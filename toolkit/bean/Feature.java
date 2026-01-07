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


public class Feature extends BaseApiBean {
  private String featureName;
  private boolean systemDefined;

  public String getFeatureName() {
     return this.featureName;
  }

  public void setFeatureName(String featureName) {
     this.featureName = featureName;
  }

  public boolean getSystemDefined() {
     return this.systemDefined;
  }

  public void setSystemDefined(boolean systemDefined) {
     this.systemDefined = systemDefined;
  }


}
