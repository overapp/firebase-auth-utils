using System;
using System.Threading.Tasks;
using Firebase.Auth.Utils.Models;

namespace Firebase.Auth.Utils.Tools.AuthToken
{
    internal partial class AuthTokenTool : IFirebaseTool
    {
        private string _apiKey;
        private string _email;
        private string _password;

        public IFirebaseTool  Initialize(ToolArguments arguments)
        {
            ValidateAndStoreApiKey(arguments);
            ValidateAndStoreEmail(arguments);
            ValidateAndStorePassword(arguments);
            return this;
        }

        public async Task Run()
        {
            var authProvider = new FirebaseAuthProvider(new FirebaseConfig(_apiKey));
            var auth = await authProvider.SignInWithEmailAndPasswordAsync(_email, _password);
            Console.WriteLine(auth.FirebaseToken);
            Console.ReadKey();
        }
    }
}