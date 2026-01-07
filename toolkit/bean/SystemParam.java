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


@XmlRootElement(name="systemParam")
public class SystemParam extends BaseApiBean {
  private Media media;
  private Security security;

  public Media getMedia() {
     return this.media;
  }

  public void setMedia(Media media) {
     this.media = media;
  }

  public Security getSecurity() {
     return this.security;
  }

  public void setSecurity(Security security) {
     this.security = security;
  }


}
