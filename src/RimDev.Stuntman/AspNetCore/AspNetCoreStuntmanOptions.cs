#if NETSTANDARD1_4
namespace RimDev.Stuntman.Core
{
    using System;
    using Microsoft.AspNetCore.Authentication.JwtBearer;

    public partial class StuntmanOptions
    {
        /// <summary>
        /// Useful for testing state of IOwinContext post sign-in since the
        /// request is redirected. Therefore, you cannot just add additional 
        /// middleware to check the state.
        /// </summary>
        public Action<MessageReceivedContext> AfterBearerValidateIdentity { get; set; }
    }
}
#endif
