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


@XmlRootElement(name="sip")
public class SIPServiceConfig extends BaseApiBean {
  private Integer commaDuration;
  private Boolean enableOutboundProxy;
  private Integer incomingPort;
  private Integer incomingSecurePort;
  private String outboundProxyHost;
  private Integer outboundProxyPort;
  private String outgoingTransport;
  private String secureCiphers;
  private Integer sigDigits;
  private List<SipHeader> sipHeaders;
  private String supportedTLSVersion;
  private Integer toneDuration;
  private Boolean useErrorRefer;
  private Boolean useLocalSrv;
  private Boolean useSrv;

  public Integer getCommaDuration() {
     return this.commaDuration;
  }

  public void setCommaDuration(Integer commaDuration) {
     this.commaDuration = commaDuration;
  }

  public Boolean getEnableOutboundProxy() {
     return this.enableOutboundProxy;
  }

  public void setEnableOutboundProxy(Boolean enableOutboundProxy) {
     this.enableOutboundProxy = enableOutboundProxy;
  }

  public Integer getIncomingPort() {
     return this.incomingPort;
  }

  public void setIncomingPort(Integer incomingPort) {
     this.incomingPort = incomingPort;
  }

  public Integer getIncomingSecurePort() {
     return this.incomingSecurePort;
  }

  public void setIncomingSecurePort(Integer incomingSecurePort) {
     this.incomingSecurePort = incomingSecurePort;
  }

  public String getOutboundProxyHost() {
     return this.outboundProxyHost;
  }

  public void setOutboundProxyHost(String outboundProxyHost) {
     this.outboundProxyHost = outboundProxyHost;
  }

  public Integer getOutboundProxyPort() {
     return this.outboundProxyPort;
  }

  public void setOutboundProxyPort(Integer outboundProxyPort) {
     this.outboundProxyPort = outboundProxyPort;
  }

  public String getOutgoingTransport() {
     return this.outgoingTransport;
  }

  public void setOutgoingTransport(String outgoingTransport) {
     this.outgoingTransport = outgoingTransport;
  }

  public String getSecureCiphers() {
     return this.secureCiphers;
  }

  public void setSecureCiphers(String secureCiphers) {
     this.secureCiphers = secureCiphers;
  }

  public Integer getSigDigits() {
     return this.sigDigits;
  }

  public void setSigDigits(Integer sigDigits) {
     this.sigDigits = sigDigits;
  }

  @XmlElementWrapper(name="sipHeaders")
  @XmlElement(name="sipHeader")
  public List<SipHeader> getSipHeaders() {
     return this.sipHeaders;
  }

  public void setSipHeaders(List<SipHeader> sipHeaders) {
     this.sipHeaders = sipHeaders;
  }

  public String getSupportedTLSVersion() {
     return this.supportedTLSVersion;
  }

  public void setSupportedTLSVersion(String supportedTLSVersion) {
     this.supportedTLSVersion = supportedTLSVersion;
  }

  public Integer getToneDuration() {
     return this.toneDuration;
  }

  public void setToneDuration(Integer toneDuration) {
     this.toneDuration = toneDuration;
  }

  public Boolean getUseErrorRefer() {
     return this.useErrorRefer;
  }

  public void setUseErrorRefer(Boolean useErrorRefer) {
     this.useErrorRefer = useErrorRefer;
  }

  public Boolean getUseLocalSrv() {
     return this.useLocalSrv;
  }

  public void setUseLocalSrv(Boolean useLocalSrv) {
     this.useLocalSrv = useLocalSrv;
  }

  public Boolean getUseSrv() {
     return this.useSrv;
  }

  public void setUseSrv(Boolean useSrv) {
     this.useSrv = useSrv;
  }


}
