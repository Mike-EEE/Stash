using Newtonsoft.Json;

namespace AzureFunctionsV2Authentication
{
	public class Authentication // structure based on sample here: https://github.com/stuartleeks/AzureFunctionsEasyAuth/blob/master/src/FunctionWithAuth/AuthInfo.cs which was based on sample here: https://cgillum.tech/2016/03/07/app-service-token-store/
	{
		[JsonProperty("access_token", NullValueHandling = NullValueHandling.Ignore)]
		public string AccessToken { get; set; }
		[JsonProperty("provider_name", NullValueHandling = NullValueHandling.Ignore)]
		public string ProviderName { get; set; }
		[JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
		public string UserId { get; set; }
		[JsonProperty("user_claims", NullValueHandling = NullValueHandling.Ignore)]
		public AuthenticationClaim[] UserClaims { get; set; }
		[JsonProperty("access_token_secret", NullValueHandling = NullValueHandling.Ignore)]
		public string AccessTokenSecret { get; set; }
		[JsonProperty("authentication_token", NullValueHandling = NullValueHandling.Ignore)]
		public string AuthenticationToken { get; set; }
		[JsonProperty("expires_on", NullValueHandling = NullValueHandling.Ignore)]
		public string ExpiresOn { get; set; }
		[JsonProperty("id_token", NullValueHandling = NullValueHandling.Ignore)]
		public string IdToken { get; set; }
		[JsonProperty("refresh_token", NullValueHandling = NullValueHandling.Ignore)]
		public string RefreshToken { get; set; }
	}
}