namespace InfluxDB.LineProtocol.Client
{
    public struct LineProtocolWriteResult
    {
        public bool Success { get; }
        public string ErrorMessage { get; }
        public string ResponseMessage { get; }

        public LineProtocolWriteResult(bool success, string errorMessage, string responseMessage = null)
        {
            Success = success;
            ErrorMessage = errorMessage;
            ResponseMessage = responseMessage;
        }
    }
}
