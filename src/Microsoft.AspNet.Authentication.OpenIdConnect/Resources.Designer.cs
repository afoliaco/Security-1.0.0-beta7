// <auto-generated />
namespace Microsoft.AspNet.Authentication.OpenIdConnect
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources
    {
        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.AspNet.Authentication.OpenIdConnect.Resources", System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Resources)).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        /// <summary>
        /// OIDCH_0101: BackchannelTimeout cannot be less or equal to TimeSpan.Zero.
        /// </summary>
        internal static string OIDCH_0101_BackChallnelLessThanZero
        {
            get { return ResourceManager.GetString("OIDCH_0101_BackChallnelLessThanZero"); }
        }

        /// <summary>
        /// OIDCH0102: An ICertificateValidator cannot be specified at the same time as an HttpMessageHandler unless it is a WebRequestHandler.
        /// </summary>
        internal static string OIDCH_0102_ExceptionValidatorHandlerMismatch
        {
            get { return ResourceManager.GetString("OIDCH_0102_Exception_ValidatorHandlerMismatch"); }
        }

        /// <summary>
        /// OIDCH_0051: The query string for Logout is not a well formed URI. The runtime cannot redirect. Redirect uri: '{0}'.
        /// </summary>
        internal static string OIDCH_0051_RedirectUriLogoutIsNotWellFormed
        {
            get { return ResourceManager.GetString("OIDCH_0051_RedirectUriLogoutIsNotWellFormed"); }
        }

        /// <summary>
        /// OIDCH_0026: Entering: '{0}'
        /// </summary>
        internal static string OIDCH_0026_ApplyResponseChallengeAsync
        {
            get { return ResourceManager.GetString("OIDCH_0026_ApplyResponseChallengeAsync"); }
        }

        /// <summary>
        /// OIDCH_0027: Converted 401 to 403.
        /// </summary>
        internal static string OIDCH_0027_401_ConvertedTo_403
        {
            get { return ResourceManager.GetString("OIDCH_0027_401_ConvertedTo_403"); }
        }

        /// <summary>
        /// OIDCH_0028: Response.StatusCode != 401, StatusCode: '{0}'."
        /// </summary>
        internal static string OIDCH_0028_StatusCodeNot401
        {
            get { return ResourceManager.GetString("OIDCH_0028_StatusCodeNot401"); }
        }

        /// <summary>
        /// OIDCH_0029: ChallengeContext == null AND !Options.AutomaticAuthentication
        /// </summary>
        internal static string OIDCH_0029_ChallengeContextEqualsNull
        {
            get { return ResourceManager.GetString("OIDCH_0029_ChallengeContextEqualsNull"); }
        }

        /// <summary>
        /// OIDCH_0030: Using properties.RedirectUri for 'local redirect' post authentication: '{0}'.
        /// </summary>
        internal static string OIDCH_0030_Using_Properties_RedirectUri
        {
            get { return ResourceManager.GetString("OIDCH_0030_Using_Properties_RedirectUri"); }
        }

        /// <summary>
        /// OIDCH_0031: Using Options.RedirectUri for 'redirect_uri': '{0}'.
        /// </summary>
        internal static string OIDCH_0031_Using_Options_RedirectUri
        {
            get { return ResourceManager.GetString("OIDCH_0031_Using_Options_RedirectUri"); }
        }

        /// <summary>
        /// OIDCH_0032: Using the CurrentUri for 'local redirect' post authentication: '{0}'.
        /// </summary>
        internal static string OIDCH_0032_UsingCurrentUriRedirectUri
        {
            get { return ResourceManager.GetString("OIDCH_0032_UsingCurrentUriRedirectUri"); }
        }

        /// <summary>
        /// OIDCH_0033: ProtocolValidator.RequireNonce == true. The generated nonce already exists: this usually indicates the nonce is not unique or has been used. The nonce is: '{0}'.
        /// </summary>
        internal static string OIDCH_0033_NonceAlreadyExists
        {
             get { return ResourceManager.GetString("OIDCH_0033_NonceAlreadyExists"); }
        }

        /// <summary>
        /// OIDCH_0034: RedirectToIdentityProviderNotification.HandledResponse
        /// </summary>
        internal static string OIDCH_0034_RedirectToIdentityProviderNotificationHandledResponse
        {
            get { return ResourceManager.GetString("OIDCH_0034_RedirectToIdentityProviderNotificationHandledResponse"); }
        }

        /// <summary>
        /// OIDCH_0035: RedirectToIdentityProviderNotification.Skipped
        /// </summary>
        internal static string OIDCH_0035_RedirectToIdentityProviderNotificationSkipped
        {
            get { return ResourceManager.GetString("OIDCH_0035_RedirectToIdentityProviderNotificationSkipped"); }
        }

        /// <summary>
        /// OIDCH_0036: Uri.IsWellFormedUriString(redirectUri, UriKind.Absolute) returned 'false', redirectUri is: {0}'.)
        /// </summary>
        internal static string OIDCH_0036_UriIsNotWellFormed
        {
            get { return ResourceManager.GetString("OIDCH_0036_UriIsNotWellFormed"); }
        }

        /// <summary>
        /// OIDCH_0036: RedirectUri is: '{0}'.
        /// </summary>
        internal static string OIDCH_0037_RedirectUri
        {
            get { return ResourceManager.GetString("OIDCH_0037_RedirectUri"); }
        }

        /// <summary>
        /// OIDCH_0038: Id Token is null. Redeeming code : {0} for tokens.
        /// </summary>
        internal static string OIDCH_0038_Redeeming_Auth_Code
        {
            get { return ResourceManager.GetString("OIDCH_0038_Redeeming_Auth_Code"); }
        }

        /// <summary>
        /// OIDCH_0039: Subject claim received from userinfo endpoint does not match the one in the id token.
        /// </summary>
        internal static string OIDCH_0039_Subject_Claim_Mismatch
        {
            get { return ResourceManager.GetString("OIDCH_0039_Subject_Claim_Mismatch"); }
        }

        /// <summary>
        /// OIDCH_0040: Sending request to user info endpoint for retrieving claims.
        /// </summary>
        internal static string OIDCH_0040_Sending_Request_UIEndpoint
        {
            get { return ResourceManager.GetString("OIDCH_0040_Sending_Request_UIEndpoint"); }
        }

        /// <summary>
        /// OIDCH_0041: Subject claim not found in {0}.
        /// </summary>
        internal static string OIDCH_0041_Subject_Claim_Not_Found
        {
            get { return ResourceManager.GetString("OIDCH_0041_Subject_Claim_Not_Found"); }
        }

        /// <summary>
        /// OIDCH_0042: AuthorizationCode redeemed: '{0}'
        /// </summary>
        internal static string OIDCH_0042_AuthorizationCodeRedeemed
        {
            get { return ResourceManager.GetString("OIDCH_0042_AuthorizationCodeRedeemed"); }
        }

        /// <summary>
        /// OIDCH_0043: AuthorizationCodeRedeemedNotification.HandledResponse
        /// </summary>
        internal static string OIDCH_0043_AuthorizationCodeRedeemedNotificationHandledResponse
        {
            get { return ResourceManager.GetString("OIDCH_0043_AuthorizationCodeRedeemedNotificationHandledResponse"); }
        }

        /// <summary>
        /// OIDCH_0044: AuthorizationCodeRedeemedNotification.Skipped
        /// </summary>
        internal static string OIDCH_0044_AuthorizationCodeRedeemedNotificationSkipped
        {
            get { return ResourceManager.GetString("OIDCH_0044_AuthorizationCodeRedeemedNotificationSkipped"); }
        }

        /// <summary>
        /// OIDCH_0045: Cannot process the message.Both id_token and code are missing.
        /// </summary>
        internal static string OIDCH_0045_Id_Token_Code_Missing
        {
            get { return ResourceManager.GetString("OIDCH_0045_Id_Token_Code_Missing"); }
        }

        /// <summary>
        /// OIDCH_0046: UserInfo endpoint is not set. Request to retrieve claims from userinfo endpoint cannot be completed.
        /// </summary>
        internal static string OIDCH_0046_UserInfo_Endpoint_Not_Set
        {
            get { return ResourceManager.GetString("OIDCH_0046_UserInfo_Endpoint_Not_Set"); }
        }

        /// <summary>
        /// OIDCH_0000: Entering: '{0}'.
        /// </summary>
        internal static string OIDCH_0000_AuthenticateCoreAsync
        {
            get { return ResourceManager.GetString("OIDCH_0000_AuthenticateCoreAsync"); }
        }

        /// <summary>
        /// OIDCH_0001: MessageReceived: '{0}'.
        /// </summary>
        internal static string OIDCH_0001_MessageReceived
        {
            get { return ResourceManager.GetString("OIDCH_0001_MessageReceived"); }
        }

        /// <summary>
        /// OIDCH_0001: MessageReceived: '{0}'.
        /// </summary>
        internal static string FormatOIDCH_0001_MessageReceived(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, ResourceManager.GetString("OIDCH_0001_MessageReceived"), p0);
        }

        /// <summary>
        /// OIDCH_0002: MessageReceivedNotification.HandledResponse
        /// </summary>
        internal static string OIDCH_0002_MessageReceivedNotificationHandledResponse
        {
            get { return ResourceManager.GetString("OIDCH_0002_MessageReceivedNotificationHandledResponse"); }
        }

        /// <summary>
        /// OIDCH_0003: MessageReceivedNotification.Skipped
        /// </summary>
        internal static string OIDCH_0003_MessageReceivedNotificationSkipped
        {
            get { return ResourceManager.GetString("OIDCH_0003_MessageReceivedNotificationSkipped"); }
        }

        /// <summary>
        /// OIDCH_0004: OpenIdConnectAuthenticationHandler: message.State is null or empty.
        /// </summary>
        internal static string OIDCH_0004_MessageStateIsNullOrEmpty
        {
            get { return ResourceManager.GetString("OIDCH_0004_MessageStateIsNullOrEmpty"); }
        }

        /// <summary>
        /// OIDCH_0005: Unable to unprotect the message.State
        /// </summary>
        internal static string OIDCH_0005_MessageStateIsInvalid
        {
            get { return ResourceManager.GetString("OIDCH_0005_MessageStateIsInvalid"); }
        }

        /// <summary>
        /// OIDCH_0006: Message contains error: '{0}', error_description: '{1}', error_uri: '{2}'.
        /// </summary>
        internal static string OIDCH_0006_MessageContainsError
        {
            get { return ResourceManager.GetString("OIDCH_0006_MessageContainsError"); }
        }

        /// <summary>
        /// OIDCH_0007: Updating configuration
        /// </summary>
        internal static string OIDCH_0007_UpdatingConfiguration
        {
            get { return ResourceManager.GetString("OIDCH_0007_UpdatingConfiguration"); }
        }

        /// <summary>
        /// OIDCH_0008: SecurityTokenReceivedNotification.HandledResponse
        /// </summary>
        internal static string OIDCH_0008_SecurityTokenReceivedNotificationHandledResponse
        {
            get { return ResourceManager.GetString("OIDCH_0008_SecurityTokenReceivedNotificationHandledResponse"); }
        }

        /// <summary>
        /// OIDCH_0009: SecurityTokenReceivedNotification.Skipped
        /// </summary>
        internal static string OIDCH_0009_SecurityTokenReceivedNotificationSkipped
        {
            get { return ResourceManager.GetString("OIDCH_0009_SecurityTokenReceivedNotificationSkipped:"); }
        }

        /// <summary>
        /// OIDCH_0010: Validated Security Token must be a JwtSecurityToken was: '{0}'.
        /// </summary>
        internal static string OIDCH_0010_ValidatedSecurityTokenNotJwt
        {
            get { return ResourceManager.GetString("OIDCH_0010_ValidatedSecurityTokenNotJwt"); }
        }

        /// <summary>
        /// OIDCH_0011: Unable to validate the 'id_token', no suitable ISecurityTokenValidator was found for: '{0}'.
        /// </summary>
        internal static string OIDCH_0011_UnableToValidateToken
        {
            get { return ResourceManager.GetString("OIDCH_0011_UnableToValidateToken"); }
        }

        /// <summary>
        /// OIDCH_0012: SecurityTokenValidatedNotification.HandledResponse
        /// </summary>
        internal static string OIDCH_0012_SecurityTokenValidatedNotificationHandledResponse
        {
            get { return ResourceManager.GetString("OIDCH_0012_SecurityTokenValidatedNotificationHandledResponse"); }
        }

        /// <summary>
        /// OIDCH_0013: SecurityTokenValidatedNotification.Skipped
        /// </summary>
        internal static string OIDCH_0013_SecurityTokenValidatedNotificationSkipped
        {
            get { return ResourceManager.GetString("OIDCH_0013_SecurityTokenValidatedNotificationSkipped"); }
        }

        /// <summary>
        /// OIDCH_0014: AuthorizationCode received: '{0}'
        /// </summary>
        internal static string OIDCH_0014_AuthorizationCodeReceived
        {
            get { return ResourceManager.GetString("OIDCH_0014_AuthorizationCodeReceived"); }
        }

        /// <summary>
        /// OIDCH_0015: AuthorizationCodeReceivedNotification.HandledResponse
        /// </summary>
        internal static string OIDCH_0015_AuthorizationCodeReceivedNotificationHandledResponse
        {
            get { return ResourceManager.GetString("OIDCH_0015_AuthorizationCodeReceivedNotificationHandledResponse"); }
        }

        /// <summary>
        /// OIDCH_0016: codeReceivedNotification.Skipped
        /// </summary>
        internal static string OIDCH_0016_AuthorizationCodeReceivedNotificationSkipped
        {
            get { return ResourceManager.GetString("OIDCH_0016_AuthorizationCodeReceivedNotificationSkipped"); }
        }

        /// <summary>
        /// OIDCH_0017: Exception occurred while processing message.
        /// </summary>
        internal static string OIDCH_0017_ExceptionOccurredWhileProcessingMessage
        {
            get { return ResourceManager.GetString("OIDCH_0017_ExceptionOccurredWhileProcessingMessage"); }
        }

        /// <summary>
        /// OIDCH_0018: authenticationFailedNotification.HandledResponse
        /// </summary>
        internal static string OIDCH_0018_AuthenticationFailedNotificationHandledResponse
        {
            get { return ResourceManager.GetString("OIDCH_0018_AuthenticationFailedNotificationHandledResponse"); }
        }

        /// <summary>
        /// OIDCH_0019: authenticationFailedNotification.Skipped
        /// </summary>
        internal static string OIDCH_0019_AuthenticationFailedNotificationSkipped
        {
            get { return ResourceManager.GetString("OIDCH_0019_AuthenticationFailedNotificationSkipped"); }
        }

        /// <summary>
        /// OIDCH_0020: 'id_token' received: '{0}'.
        /// </summary>
        internal static string OIDCH_0020_IdTokenReceived
        {
            get { return ResourceManager.GetString("OIDCH_0020_IdTokenReceived"); }
        }

        /// <summary>
        /// OIDCH_0021: exception of type 'SecurityTokenSignatureKeyNotFoundException' thrown, Options.ConfigurationManager.RequestRefresh() called.
        /// </summary>
        internal static string OIDCH_0021_AutomaticConfigurationRefresh
        {
            get { return ResourceManager.GetString("OIDCH_0021_AutomaticConfigurationRefresh"); }
        }

    }
}