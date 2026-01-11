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


@XmlRootElement(name="errorDetail")
public class DatabaseErrorDetail extends BaseApiBean {
  private DbType dbType;
  private String machineName;
  private Side side;

  public DbType getDbType() {
     return this.dbType;
  }

  public void setDbType(DbType dbType) {
     this.dbType = dbType;
  }

  public String getMachineName() {
     return this.machineName;
  }

  public void setMachineName(String machineName) {
     this.machineName = machineName;
  }

  public Side getSide() {
     return this.side;
  }

  public void setSide(Side side) {
     this.side = side;
  }


}
