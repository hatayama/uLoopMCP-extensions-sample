using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using io.github.hatayama.uLoopMCP;

namespace uLoopMCPExtensionsSample
{
    [McpTool(Description = "Returns the Unity version")]
    public class GetUnityInfoTool : AbstractUnityTool<GetUnityInfoSchema, GetUnityInfoResponse>
    {
        public override string ToolName => "get-unity-info";

        protected override Task<GetUnityInfoResponse> ExecuteAsync(GetUnityInfoSchema parameters, CancellationToken cancellationToken)
        {
            GetUnityInfoResponse response = new GetUnityInfoResponse(Application.unityVersion);
            return Task.FromResult(response);
        }
    }
}
