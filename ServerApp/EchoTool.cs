
using ModelContextProtocol.Server;
using System.ComponentModel;

namespace ServerApp;

[McpServerToolType]
public static class EchoTool        
{
    [McpServerTool, Description("Echoes the message back to the client.")]
    public static string Echo(string message) => $"hello there!, {message}";

    [McpServerTool, Description("Finds the length of the message and returns it back to the client.")]
    public static int Length(string message) => message.Length;
}