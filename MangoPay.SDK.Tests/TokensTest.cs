﻿using MangoPay.SDK.Entities;
using NUnit.Framework;

namespace MangoPay.SDK.Tests
{
    [TestFixture]
    public class TokensTest : BaseTest
    {
        [Test]
        public void Test_ForceToken()
        {
            OAuthTokenDTO oldToken = this.Api.OAuthTokenManager.GetToken();
            OAuthTokenDTO newToken = this.Api.AuthenticationManager.CreateToken();

            Assert.IsFalse(oldToken.access_token == newToken.access_token);

            this.Api.OAuthTokenManager.StoreToken(newToken);
            OAuthTokenDTO storedToken = this.Api.OAuthTokenManager.GetToken();

            Assert.AreEqual(newToken.access_token, storedToken.access_token);
        }

        [Test]
        public void Test_StandardUseToken()
        {
            this.Api.Users.GetAll();
            OAuthTokenDTO token = this.Api.OAuthTokenManager.GetToken();
            this.Api.Users.GetAll();

            Assert.AreEqual(token.access_token, this.Api.OAuthTokenManager.GetToken().access_token);
        }

        [Test]
        public void Test_ShareTokenBetweenInstances()
        {
            MangoPayApi api = this.BuildNewMangoPayApi();

            OAuthTokenDTO token1 = this.Api.OAuthTokenManager.GetToken();
            OAuthTokenDTO token2 = api.OAuthTokenManager.GetToken();

            Assert.AreEqual(token1.access_token, token2.access_token);
        }

		[Test]
		public void Test_IsolateTokensBetweenEnvironments()
		{
			MangoPayApi api = new MangoPayApi();
			api.Config.ClientId = "sdk-unit-tests";
			api.Config.ClientPassword = "cqFfFrWfCcb7UadHNxx2C9Lo6Djw8ZduLi7J9USTmu8bhxxpju";
			api.Config.BaseUrl = "https://api.sandbox.mangopay.com";

			OAuthTokenDTO token1 = api.OAuthTokenManager.GetToken();

			api.Config.ClientId = "sdk_example";
			api.Config.ClientPassword = "Vfp9eMKSzGkxivCwt15wE082pTTKsx90vBenc9hjLsf5K46ciF";
			api.Config.BaseUrl = "https://api.sandbox.mangopay.com";

			OAuthTokenDTO token2 = api.OAuthTokenManager.GetToken();

			Assert.AreNotEqual(token1.access_token, token2.access_token);

			api.Config.ClientId = "sdk-unit-tests";
			api.Config.ClientPassword = "cqFfFrWfCcb7UadHNxx2C9Lo6Djw8ZduLi7J9USTmu8bhxxpju";
			api.Config.BaseUrl = "https://api.sandbox.mangopay.com";

			OAuthTokenDTO token3 = api.OAuthTokenManager.GetToken();

			Assert.AreEqual(token1.access_token, token3.access_token);
		}
    }
}
