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


@Path("businesshour")
@XmlRootElement(name="businessHour")
public class BusinessHour extends BaseApiBean {
  private String baseUrlfromRefUrl;
  private Integer changeStamp;
  private BusinessHourConfiguredStatus configuredStatus;
  private String correlationId;
  private ReferenceBean department;
  private String description;
  private String idFromRefUrl;
  private String name;
  private String refURL;
  private Integer runTimeStatus;
  private String runTimeStatusReason;
  private List<SpecialDaySchedule> specialDaySchedules;
  private ReferenceBean timezone;
  private Integer type;
  private List<WeekDaySchedule> weekDaySchedules;

  public String getBaseUrlfromRefUrl() {
     return this.baseUrlfromRefUrl;
  }

  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public Integer getChangeStamp() {
     return this.changeStamp;
  }

  public void setChangeStamp(Integer changeStamp) {
     this.changeStamp = changeStamp;
  }

  public BusinessHourConfiguredStatus getConfiguredStatus() {
     return this.configuredStatus;
  }

  public void setConfiguredStatus(BusinessHourConfiguredStatus configuredStatus) {
     this.configuredStatus = configuredStatus;
  }

  public String getCorrelationId() {
     return this.correlationId;
  }

  public void setCorrelationId(String correlationId) {
     this.correlationId = correlationId;
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

  public String getIdFromRefUrl() {
     return this.idFromRefUrl;
  }

  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public String getName() {
     return this.name;
  }

  public void setName(String name) {
     this.name = name;
  }

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public Integer getRunTimeStatus() {
     return this.runTimeStatus;
  }

  public void setRunTimeStatus(Integer runTimeStatus) {
     this.runTimeStatus = runTimeStatus;
  }

  public String getRunTimeStatusReason() {
     return this.runTimeStatusReason;
  }

  public void setRunTimeStatusReason(String runTimeStatusReason) {
     this.runTimeStatusReason = runTimeStatusReason;
  }

  @XmlElementWrapper(name="specialDaySchedules")
  @XmlElement(name="specialDaySchedule")
  public List<SpecialDaySchedule> getSpecialDaySchedules() {
     return this.specialDaySchedules;
  }

  public void setSpecialDaySchedules(List<SpecialDaySchedule> specialDaySchedules) {
     this.specialDaySchedules = specialDaySchedules;
  }

  public ReferenceBean getTimezone() {
     return this.timezone;
  }

  public void setTimezone(ReferenceBean timezone) {
     this.timezone = timezone;
  }

  public Integer getType() {
     return this.type;
  }

  public void setType(Integer type) {
     this.type = type;
  }

  @XmlElementWrapper(name="weekDaySchedules")
  @XmlElement(name="weekDaySchedule")
  public List<WeekDaySchedule> getWeekDaySchedules() {
     return this.weekDaySchedules;
  }

  public void setWeekDaySchedules(List<WeekDaySchedule> weekDaySchedules) {
     this.weekDaySchedules = weekDaySchedules;
  }


  @Path("businesshour")
  @XmlRootElement(name = "results")
  public static class BusinessHourList extends BaseApiListBean<BusinessHour> {
    @XmlElementWrapper(name = "businessHours")
    @XmlElement(name = "businessHour")
    public List<BusinessHour> getItems() {
      return items;
    }

    public void setItems(List<BusinessHour> items) {
      this.items = items;
    }
  }
}
