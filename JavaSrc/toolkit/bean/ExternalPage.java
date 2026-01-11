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


@Path("externalpage")
@XmlRootElement(name="externalpage")
public class ExternalPage extends BaseApiBean {
  private String baseData;
  private String baseUrlfromRefUrl;
  private ReferenceBean card;
  private String correlationId;
  private ReferenceBean department;
  private String description;
  private String dynamicData;
  private Integer featureId;
  private Boolean gadget;
  private Integer id;
  private String idFromRefUrl;
  private String ipAddress;
  private ReferenceBean menu;
  private String name;
  private String refURL;
  private Integer tabPosition;
  private String url;

  public String getBaseData() {
     return this.baseData;
  }

  public void setBaseData(String baseData) {
     this.baseData = baseData;
  }

  public String getBaseUrlfromRefUrl() {
     return this.baseUrlfromRefUrl;
  }

  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public ReferenceBean getCard() {
     return this.card;
  }

  public void setCard(ReferenceBean card) {
     this.card = card;
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

  public String getDynamicData() {
     return this.dynamicData;
  }

  public void setDynamicData(String dynamicData) {
     this.dynamicData = dynamicData;
  }

  public Integer getFeatureId() {
     return this.featureId;
  }

  public void setFeatureId(Integer featureId) {
     this.featureId = featureId;
  }

  public Boolean getGadget() {
     return this.gadget;
  }

  public void setGadget(Boolean gadget) {
     this.gadget = gadget;
  }

  public Integer getId() {
     return this.id;
  }

  public void setId(Integer id) {
     this.id = id;
  }

  public String getIdFromRefUrl() {
     return this.idFromRefUrl;
  }

  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public String getIpAddress() {
     return this.ipAddress;
  }

  public void setIpAddress(String ipAddress) {
     this.ipAddress = ipAddress;
  }

  public ReferenceBean getMenu() {
     return this.menu;
  }

  public void setMenu(ReferenceBean menu) {
     this.menu = menu;
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

  public Integer getTabPosition() {
     return this.tabPosition;
  }

  public void setTabPosition(Integer tabPosition) {
     this.tabPosition = tabPosition;
  }

  public String getUrl() {
     return this.url;
  }

  public void setUrl(String url) {
     this.url = url;
  }


  @Path("externalpage")
  @XmlRootElement(name = "results")
  public static class ExternalPageList extends BaseApiListBean<ExternalPage> {
    @XmlElementWrapper(name = "externalpages")
    @XmlElement(name = "externalpage")
    public List<ExternalPage> getItems() {
      return items;
    }

    public void setItems(List<ExternalPage> items) {
      this.items = items;
    }
  }
}
