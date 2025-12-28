using io.github.hatayama.uLoopMCP;

namespace uLoopMCPExtensionsSample
{
    public class HelloWorldResponse : BaseToolResponse
    {
        public string Message { get; set; }

        public HelloWorldResponse(string message)
        {
            Message = message;
        }

        public HelloWorldResponse()
        {
        }
    }
}
