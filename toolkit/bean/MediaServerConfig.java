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


@XmlRootElement(name="mediaServer")
public class MediaServerConfig extends BaseApiBean {
  private String defaultMediaServer;
  private List<MediaServer> servers;

  public String getDefaultMediaServer() {
     return this.defaultMediaServer;
  }

  public void setDefaultMediaServer(String defaultMediaServer) {
     this.defaultMediaServer = defaultMediaServer;
  }

  @XmlElementWrapper(name="servers")
  @XmlElement(name="server")
  public List<MediaServer> getServers() {
     return this.servers;
  }

  public void setServers(List<MediaServer> servers) {
     this.servers = servers;
  }


}
