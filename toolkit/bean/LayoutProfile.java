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


@XmlRootElement(name="layoutprofile")
public class LayoutProfile extends BaseApiBean {
  private String layoutXml;
  private String layoutXmlName;

  public String getLayoutXml() {
     return this.layoutXml;
  }

  public void setLayoutXml(String layoutXml) {
     this.layoutXml = layoutXml;
  }

  public String getLayoutXmlName() {
     return this.layoutXmlName;
  }

  public void setLayoutXmlName(String layoutXmlName) {
     this.layoutXmlName = layoutXmlName;
  }


}
