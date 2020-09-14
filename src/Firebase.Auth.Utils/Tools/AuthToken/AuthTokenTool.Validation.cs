using System;
using Firebase.Auth.Utils.Models;

namespace Firebase.Auth.Utils.Tools.AuthToken
{
    internal partial class AuthTokenTool
    {
        private void ValidateAndStorePassword(ToolArguments arguments)
        {
            if (string.IsNullOrEmpty(arguments.Password))
                throw new ArgumentNullException(nameof(arguments.Password));

            _password = arguments.Password;
        }

        private void ValidateAndStoreApiKey(ToolArguments arguments)
        {
            if (string.IsNullOrEmpty(arguments.ApiKey))
                throw new ArgumentNullException(nameof(arguments.ApiKey));

            _apiKey = arguments.ApiKey;
        }

        private void ValidateAndStoreEmail(ToolArguments arguments)
        {
            if (string.IsNullOrEmpty(arguments.Email))
                throw new ArgumentNullException(nameof(arguments.Email));

            _email = arguments.Email;
        }
    }
}