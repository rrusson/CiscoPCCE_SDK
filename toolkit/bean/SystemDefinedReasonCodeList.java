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


@Path("reasoncode")
@XmlRootElement(name="systemDefinedReasonCodes")
public class SystemDefinedReasonCodeList extends BaseApiBean {
  private List<ReasonCode> reasonCode;

  public List<ReasonCode> getReasonCode() {
     return this.reasonCode;
  }

  public void setReasonCode(List<ReasonCode> reasonCode) {
     this.reasonCode = reasonCode;
  }


  @Path("reasoncode")
  @XmlRootElement(name = "results")
  public static class SystemDefinedReasonCodeListList extends BaseApiListBean<SystemDefinedReasonCodeList> {
    @XmlElementWrapper(name = "systemDefinedReasonCodess")
    @XmlElement(name = "systemDefinedReasonCodes")
    public List<SystemDefinedReasonCodeList> getItems() {
      return items;
    }

    public void setItems(List<SystemDefinedReasonCodeList> items) {
      this.items = items;
    }
  }
}
