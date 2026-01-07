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


@XmlRootElement(name="##default")
public class Collection extends BaseApiBean {
  private List<CollectionValue> collectionValues;
  private String description;
  private String groupPermission;
  private String id;
  private String name;
  private String origin;
  private String type;
  private Integer version;

  public List<CollectionValue> getCollectionValues() {
     return this.collectionValues;
  }

  public void setCollectionValues(List<CollectionValue> collectionValues) {
     this.collectionValues = collectionValues;
  }

  public String getDescription() {
     return this.description;
  }

  public void setDescription(String description) {
     this.description = description;
  }

  public String getGroupPermission() {
     return this.groupPermission;
  }

  public void setGroupPermission(String groupPermission) {
     this.groupPermission = groupPermission;
  }

  public String getId() {
     return this.id;
  }

  public void setId(String id) {
     this.id = id;
  }

  public String getName() {
     return this.name;
  }

  public void setName(String name) {
     this.name = name;
  }

  public String getOrigin() {
     return this.origin;
  }

  public void setOrigin(String origin) {
     this.origin = origin;
  }

  public String getType() {
     return this.type;
  }

  public void setType(String type) {
     this.type = type;
  }

  public Integer getVersion() {
     return this.version;
  }

  public void setVersion(Integer version) {
     this.version = version;
  }


}
