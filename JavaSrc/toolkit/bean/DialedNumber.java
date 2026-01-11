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


@Path("dialednumber")
@XmlRootElement(name="dialedNumber")
public class DialedNumber extends BaseApiBean {
  private String baseUrlfromRefUrl;
  private ReferenceBean callType;
  private Integer changeStamp;
  private String correlationId;
  private ReferenceBean datacenter;
  private ReferenceBean department;
  private String description;
  private List<DialedNumberRecord> dialedNumberRecords;
  private String dialedNumberString;
  private String idFromRefUrl;
  private Boolean markDeletable;
  private ReferenceBean mediaRoutingDomain;
  private String name;
  private String pcsEnabledDialedNumberPattern;
  private ReferenceBean peripheralSet;
  private String refURL;
  private String ringtoneName;
  private Integer routingType;

  public String getBaseUrlfromRefUrl() {
     return this.baseUrlfromRefUrl;
  }

  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public ReferenceBean getCallType() {
     return this.callType;
  }

  public void setCallType(ReferenceBean callType) {
     this.callType = callType;
  }

  public Integer getChangeStamp() {
     return this.changeStamp;
  }

  public void setChangeStamp(Integer changeStamp) {
     this.changeStamp = changeStamp;
  }

  public String getCorrelationId() {
     return this.correlationId;
  }

  public void setCorrelationId(String correlationId) {
     this.correlationId = correlationId;
  }

  public ReferenceBean getDatacenter() {
     return this.datacenter;
  }

  public void setDatacenter(ReferenceBean datacenter) {
     this.datacenter = datacenter;
  }

  public ReferenceBean getDepartment() {
     return this.department;
  }

  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public String getDescription() {
     return this.description;
  }

  public void setDescription(String description) {
     this.description = description;
  }

  @XmlElementWrapper(name="dialedNumberRecords")
  @XmlElement(name="dialedNumberRecord")
  public List<DialedNumberRecord> getDialedNumberRecords() {
     return this.dialedNumberRecords;
  }

  public void setDialedNumberRecords(List<DialedNumberRecord> dialedNumberRecords) {
     this.dialedNumberRecords = dialedNumberRecords;
  }

  public String getDialedNumberString() {
     return this.dialedNumberString;
  }

  public void setDialedNumberString(String dialedNumberString) {
     this.dialedNumberString = dialedNumberString;
  }

  public String getIdFromRefUrl() {
     return this.idFromRefUrl;
  }

  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public Boolean getMarkDeletable() {
     return this.markDeletable;
  }

  public void setMarkDeletable(Boolean markDeletable) {
     this.markDeletable = markDeletable;
  }

  public ReferenceBean getMediaRoutingDomain() {
     return this.mediaRoutingDomain;
  }

  public void setMediaRoutingDomain(ReferenceBean mediaRoutingDomain) {
     this.mediaRoutingDomain = mediaRoutingDomain;
  }

  public String getName() {
     return this.name;
  }

  public void setName(String name) {
     this.name = name;
  }

  public String getPcsEnabledDialedNumberPattern() {
     return this.pcsEnabledDialedNumberPattern;
  }

  public void setPcsEnabledDialedNumberPattern(String pcsEnabledDialedNumberPattern) {
     this.pcsEnabledDialedNumberPattern = pcsEnabledDialedNumberPattern;
  }

  @XmlElement(name="peripheralSet")
  public ReferenceBean getPeripheralSet() {
     return this.peripheralSet;
  }

  public void setPeripheralSet(ReferenceBean peripheralSet) {
     this.peripheralSet = peripheralSet;
  }

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public String getRingtoneName() {
     return this.ringtoneName;
  }

  public void setRingtoneName(String ringtoneName) {
     this.ringtoneName = ringtoneName;
  }

  public Integer getRoutingType() {
     return this.routingType;
  }

  public void setRoutingType(Integer routingType) {
     this.routingType = routingType;
  }


  @Path("dialednumber")
  @XmlRootElement(name = "results")
  public static class DialedNumberList extends BaseApiListBean<DialedNumber> {
    @XmlElementWrapper(name = "dialedNumbers")
    @XmlElement(name = "dialedNumber")
    public List<DialedNumber> getItems() {
      return items;
    }

    public void setItems(List<DialedNumber> items) {
      this.items = items;
    }
  }
}
