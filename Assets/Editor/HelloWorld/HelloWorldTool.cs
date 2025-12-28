using System.Threading;
using System.Threading.Tasks;
using io.github.hatayama.uLoopMCP;

namespace uLoopMCPExtensionsSample
{
    [McpTool(Description = "Returns 'Hello World' message")]
    public class HelloWorldTool : AbstractUnityTool<HelloWorldSchema, HelloWorldResponse>
    {
        public override string ToolName => "hello-world";

        protected override Task<HelloWorldResponse> ExecuteAsync(HelloWorldSchema parameters, CancellationToken cancellationToken)
        {
            HelloWorldResponse response = new HelloWorldResponse("Hello World");
            return Task.FromResult(response);
        }
    }
}
