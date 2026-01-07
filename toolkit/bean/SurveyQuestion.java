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


@XmlRootElement(name="question")
public class SurveyQuestion extends BaseApiBean {
  private String dispatchId;
  private String questionnaireName;

  public String getDispatchId() {
     return this.dispatchId;
  }

  public void setDispatchId(String dispatchId) {
     this.dispatchId = dispatchId;
  }

  public String getQuestionnaireName() {
     return this.questionnaireName;
  }

  public void setQuestionnaireName(String questionnaireName) {
     this.questionnaireName = questionnaireName;
  }


}
