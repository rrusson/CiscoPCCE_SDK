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


@Path("businesshourstatusreason")
@XmlRootElement(name="businessHourStatusReasons")
public class BusinessHourStatusReasons extends BaseApiBean {
  private List<BusinessHourStatusReason> businessHourStatusReason;

  public List<BusinessHourStatusReason> getBusinessHourStatusReason() {
     return this.businessHourStatusReason;
  }

  public void setBusinessHourStatusReason(List<BusinessHourStatusReason> businessHourStatusReason) {
     this.businessHourStatusReason = businessHourStatusReason;
  }


  @Path("businesshourstatusreason")
  @XmlRootElement(name = "results")
  public static class BusinessHourStatusReasonsList extends BaseApiListBean<BusinessHourStatusReasons> {
    @XmlElementWrapper(name = "businessHourStatusReasonss")
    @XmlElement(name = "businessHourStatusReasons")
    public List<BusinessHourStatusReasons> getItems() {
      return items;
    }

    public void setItems(List<BusinessHourStatusReasons> items) {
      this.items = items;
    }
  }
}
