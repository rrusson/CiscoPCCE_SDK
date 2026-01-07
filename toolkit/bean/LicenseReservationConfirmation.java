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


@XmlRootElement(name="licenseReservation")
public class LicenseReservationConfirmation extends BaseApiBean {
  private String confirmationCode;
  private String installReservationType;

  public String getConfirmationCode() {
     return this.confirmationCode;
  }

  public void setConfirmationCode(String confirmationCode) {
     this.confirmationCode = confirmationCode;
  }

  public String getInstallReservationType() {
     return this.installReservationType;
  }

  public void setInstallReservationType(String installReservationType) {
     this.installReservationType = installReservationType;
  }


}
