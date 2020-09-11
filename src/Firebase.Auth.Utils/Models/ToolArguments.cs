using System;

using CommandLine;

namespace Firebase.Auth.Utils.Models
{
    internal class ToolArguments
    {
        [Option('t', "tool",
            Default = ApplicationTool.AuthToken,
            HelpText = "Select the tool to be used",
            Group = "Auth Token" 
         )]
        public ApplicationTool Mode { get; set; }

        #region AuthToken Settings

        [Option('k', "apiKey",
            HelpText = "Api Key for the AuthTokenGenerator",
            Group = "Auth Token" 
        )]
        public string ApiKey { get; set; }

        [Option('u', "user",
            HelpText = "Email for the AuthTokenGenerator",
            Group = "Auth Token" 
        )]
        public string Email { get; set; }
        
        [Option('p', "password",
            HelpText = "Email for the AuthTokenGenerator",
            Group = "Auth Token" 
        )]
        public string Password { get; set; }

        #endregion
    }
}
