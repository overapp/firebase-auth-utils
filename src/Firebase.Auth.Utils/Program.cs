using System;
using System.Threading.Tasks;
using CommandLine;

using Firebase.Auth.Utils.Models;
using Firebase.Auth.Utils.Tools;
using AuthTokenTool = Firebase.Auth.Utils.Tools.AuthToken.AuthTokenTool;

namespace Firebase.Auth.Utils
{
    internal static class Program
    {
        public static async Task Main(string[] args)
        {
            await Parser.Default.ParseArguments<ToolArguments>(args).WithParsedAsync(Run);
        }

        private static async Task Run(ToolArguments arg)
        {
            try
            {
                var tool = GetSelectedTool(arg);
                tool.Initialize(arg);
                await tool.Run();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine($"Argument {e.ParamName} was not provided");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static IFirebaseTool GetSelectedTool(ToolArguments arg)
        {
            IFirebaseTool tool = arg.Mode switch
            {
                ApplicationTool.AuthToken => new AuthTokenTool(),
                _ => throw new ArgumentOutOfRangeException()
            };
            return tool;
        }
    }
}
