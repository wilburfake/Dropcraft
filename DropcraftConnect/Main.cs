using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DropNet;
using System.Diagnostics;

namespace DropcraftConnect
{
    public class Main
    {
        public DropNetClient _client;

        public void Init(string key, string secret)
        {
            _client = new DropNetClient(key, secret);

            _client.GetToken();

            _client.GetTokenAsync((userLogin) =>
            {

            },
            (error) =>
            {

            });

            var url = _client.BuildAuthorizeUrl();
            Process.Start(url);
            //var accessToken = _client.GetAccessToken();
            _client.GetAccessTokenAsync((accessToken) =>
            {

            },
            (error) =>
            {

            });
        }
    }
}
