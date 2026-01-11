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


@XmlRootElement(name="WrapUpReason")
public class WrapUpReasonsConfig extends BaseApiBean {
  private String forAll;
  private String label;
  private String uri;

  public String getForAll() {
     return this.forAll;
  }

  public void setForAll(String forAll) {
     this.forAll = forAll;
  }

  public String getLabel() {
     return this.label;
  }

  public void setLabel(String label) {
     this.label = label;
  }

  public String getUri() {
     return this.uri;
  }

  public void setUri(String uri) {
     this.uri = uri;
  }


}
