using System;

namespace UcAsp.WebSocket
{
  /// <summary>
  /// The exception that is thrown when a fatal error occurs in
  /// the WebSocket communication.
  /// </summary>
  public class WebSocketException : Exception
  {
    #region 私有字段

    private CloseStatusCode _code;

    #endregion

    #region 内部构造函数

    internal WebSocketException ()
      : this (CloseStatusCode.Abnormal, null, null)
    {
    }

    internal WebSocketException (Exception innerException)
      : this (CloseStatusCode.Abnormal, null, innerException)
    {
    }

    internal WebSocketException (string message)
      : this (CloseStatusCode.Abnormal, message, null)
    {
    }

    internal WebSocketException (CloseStatusCode code)
      : this (code, null, null)
    {
    }

    internal WebSocketException (string message, Exception innerException)
      : this (CloseStatusCode.Abnormal, message, innerException)
    {
    }

    internal WebSocketException (CloseStatusCode code, Exception innerException)
      : this (code, null, innerException)
    {
    }

    internal WebSocketException (CloseStatusCode code, string message)
      : this (code, message, null)
    {
    }

    internal WebSocketException (
      CloseStatusCode code, string message, Exception innerException
    )
      : base (message ?? code.GetMessage (), innerException)
    {
      _code = code;
    }

    #endregion

    #region 属性

    /// <summary>
    /// Gets the status code indicating the cause of the exception.
    /// </summary>
    /// <value>
    /// One of the <see cref="CloseStatusCode"/> enum values that represents
    /// the status code indicating the cause of the exception.
    /// </value>
    public CloseStatusCode Code {
      get {
        return _code;
      }
    }

    #endregion
  }
}
