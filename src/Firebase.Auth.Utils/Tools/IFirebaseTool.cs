using System.Threading.Tasks;
using Firebase.Auth.Utils.Models;

namespace Firebase.Auth.Utils.Tools
{
    internal interface IFirebaseTool
    {
        IFirebaseTool Initialize(ToolArguments arguments);
        Task Run();
    }
}