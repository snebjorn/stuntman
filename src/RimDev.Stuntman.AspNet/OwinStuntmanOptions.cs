﻿namespace RimDev.Stuntman.Shared
{
    using System;
    using Microsoft.Owin.Security.OAuth;

    public partial class StuntmanOptions
    {
        /// <summary>
        /// Useful for testing state of IOwinContext post sign-in since the
        /// request is redirected. Therefore, you cannot just add additional OWIN
        /// middleware to check the state.
        /// </summary>
        public Action<OAuthValidateIdentityContext> AfterBearerValidateIdentity { get; set; }
    }
}
