namespace CiscoPCCE.Toolkit.Bean
{

public enum CallStatusEnum {
  active,
  callbackRequested,
  closed,
  agentRejected,
  maxAttemptsReached,
  pending,
  retry,
  personalCallbackRequested,
  unknown,
  agentNotAvailable,
  dialed,
  invalid,
  @operator,
  fax,
  maintenance
}

}