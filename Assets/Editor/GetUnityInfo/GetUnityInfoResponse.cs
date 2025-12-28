using io.github.hatayama.uLoopMCP;

namespace uLoopMCPExtensionsSample
{
    public class GetUnityInfoResponse : BaseToolResponse
    {
        public string UnityVersion { get; set; }

        public GetUnityInfoResponse(string unityVersion)
        {
            UnityVersion = unityVersion;
        }

        public GetUnityInfoResponse()
        {
        }
    }
}
