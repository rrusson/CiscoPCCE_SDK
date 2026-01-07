using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("##default")]
public class JMSConnectionParams : BaseApiBean {
  private string? brokerUrl;
  private int? maxPoolSize;
  private int? minPoolSize;
  private string? password;
  private string? topicSchemaUrl;
  private string? topicSchemaUrlPassword;
  private string? topicSchemaUrlUserId;
  private string? userId;

  public string? BrokerUrl
  {
      get => brokerUrl;
      set => brokerUrl = value;
  }


  public void setBrokerUrl(String brokerUrl) {
     this.brokerUrl = brokerUrl;
  }

  public int? MaxPoolSize
  {
      get => maxPoolSize;
      set => maxPoolSize = value;
  }


  public void setMaxPoolSize(int? maxPoolSize) {
     this.maxPoolSize = maxPoolSize;
  }

  public int? MinPoolSize
  {
      get => minPoolSize;
      set => minPoolSize = value;
  }


  public void setMinPoolSize(int? minPoolSize) {
     this.minPoolSize = minPoolSize;
  }

  public string? Password
  {
      get => password;
      set => password = value;
  }


  public void setPassword(String password) {
     this.password = password;
  }

  public string? TopicSchemaUrl
  {
      get => topicSchemaUrl;
      set => topicSchemaUrl = value;
  }


  public void setTopicSchemaUrl(String topicSchemaUrl) {
     this.topicSchemaUrl = topicSchemaUrl;
  }

  public string? TopicSchemaUrlPassword
  {
      get => topicSchemaUrlPassword;
      set => topicSchemaUrlPassword = value;
  }


  public void setTopicSchemaUrlPassword(String topicSchemaUrlPassword) {
     this.topicSchemaUrlPassword = topicSchemaUrlPassword;
  }

  public string? TopicSchemaUrlUserId
  {
      get => topicSchemaUrlUserId;
      set => topicSchemaUrlUserId = value;
  }


  public void setTopicSchemaUrlUserId(String topicSchemaUrlUserId) {
     this.topicSchemaUrlUserId = topicSchemaUrlUserId;
  }

  public string? UserId
  {
      get => userId;
      set => userId = value;
  }


  public void setUserId(String userId) {
     this.userId = userId;
  }


}

}