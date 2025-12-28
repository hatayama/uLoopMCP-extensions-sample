# uLoopMCP Extensions Sample

A sample project demonstrating third-party extensions for [uLoopMCP](https://github.com/hatayama/uLoopMCP).

## Sample Tools

### hello-world

A simple tool that returns "Hello World" message. Useful for testing MCP connection.

### get-unity-info

A tool that returns the Unity version.

## Installation

### Prerequisites

- Unity 2022.3 or later
- [uLoopMCP](https://github.com/hatayama/uLoopMCP) installed

### Install via Unity Package Manager

1. Open Unity Editor
2. Go to `Window` > `Package Manager`
3. Click the `+` button in the top-left corner
4. Select `Add package from git URL...`
5. Enter the following URL and click `Add`:

```
https://github.com/hatayama/uLoopMCP-extesnsions-sample.git?path=Assets/Editor
```

### Manual Installation

Add the following to your `Packages/manifest.json`:

```json
{
  "dependencies": {
    "com.hatayama.uloopmcp-extensions-sample": "https://github.com/hatayama/uLoopMCP-extesnsions-sample.git?path=Assets/Editor"
  }
}
```

## Usage

1. Enable **Allow Third Party Tools** in uLoopMCP Security Settings
2. The following tools will be available from your MCP client:
   - `hello-world` - Returns "Hello World" message
   - `get-unity-info` - Returns Unity version

## Creating Your Own Extension

Use this sample as a reference to create your own extensions.

### File Structure

```
Assets/Editor/
├── YourExtension.asmdef          # Assembly Definition (requires uLoopMCP reference)
└── YourTool/
    ├── YourToolSchema.cs         # Parameter definition
    ├── YourToolResponse.cs       # Response definition
    ├── YourToolTool.cs           # Tool implementation
    └── SKILL.md                  # Skill definition (optional)
```

### Implementation Examples

See the following files for reference:

- [HelloWorldTool.cs](Assets/Editor/HelloWorld/HelloWorldTool.cs)
- [GetUnityInfoTool.cs](Assets/Editor/GetUnityInfo/GetUnityInfoTool.cs)

## License

MIT
