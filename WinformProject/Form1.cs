using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WinformProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            //logRcrdsTbox.Text = await ExecuteAsync(emailTbox.Text);

            /*var userName = emailTbox.Text;
            var passwd = passTbox.Text;
            var url = "https://github.com/settings/security-log";

            using var client = new HttpClient();

            var authToken = Encoding.ASCII.GetBytes($"{userName}:{passwd}");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(authToken));

            HttpResponseMessage response = await client.GetAsync(url);
            HttpContent content = response.Content;
            var result = await content.ReadAsStringAsync();

            //var content = await result.Content.ReadAsStringAsync();

            logRcrdsTbox.Text = result.ToString();*/

            /*var t = Task.Run(() => GetURI(new Uri("https://github.com/settings/security-log")));
            t.Wait();

            logRcrdsTbox.Text = t.Result;*/

            /*var client = new HttpClient();
            client.BaseAddress = new Uri("https://github.com");
            var request = new HttpRequestMessage(HttpMethod.Post, "/settings/security-log");

            var byteArray = Encoding.ASCII.GetBytes($"{emailTbox.Text}:{ passTbox.Text}");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

            var formData = new List<KeyValuePair<string, string>>();
            formData.Add(new KeyValuePair<string, string>("grant_type", "password"));
            formData.Add(new KeyValuePair<string, string>("username", emailTbox.Text));
            formData.Add(new KeyValuePair<string, string>("password", passTbox.Text));
            formData.Add(new KeyValuePair<string, string>("scope", "all"));

            request.Content = new FormUrlEncodedContent(formData);
            var response = await client.SendAsync(request);

            logRcrdsTbox.Text = response.ToString(); */

            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api.github.com/graphql")
            };

            httpClient.DefaultRequestHeaders.Add("User-Agent", "WinForms");

            string basicValue = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{emailTbox.Text}:0b06823e7bb27cbf06cd4e0c52926d7ce9f4df57"));
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", basicValue);

            var queryObject = new
            {
                query = @"query { 
                viewer{
                    login
                    
                }
}",/*logs{ 
                        event
                        time
                    }*/
                variables = new { }
            };

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                Content = new StringContent(JsonConvert.SerializeObject(queryObject), Encoding.UTF8, "application/json")
            };

            dynamic responseObj;

            using (var response = await httpClient.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();

                var responseString = await response.Content.ReadAsStringAsync();
                responseObj = JsonConvert.DeserializeObject<dynamic>(responseString);


                logRcrdsTbox.Text = responseObj.ToString();
            }

            //Console.WriteLine(responseObj.data.viewer.login);

        }



        /*static async Task<string> GetURI(Uri u)
        {
            var response = string.Empty;
            using (var client = new HttpClient())
            {
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage result = await client.GetAsync(u);
                if (result.IsSuccessStatusCode)
                {
                    response = await result.Content.PostAsync(u);
                }
            }
            return response;
        }*/

        /*public static async Task<String> ExecuteAsync(String username)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.github.com");
            var token = "0b06823e7bb27cbf06cd4e0c52926d7ce9f4df57";

            client.DefaultRequestHeaders.UserAgent.Add(new System.Net.Http.Headers.ProductInfoHeaderValue("AppName", "1.0"));
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Token", token);

            var response = await client.PostAsync("/users" + username + "/events");

            return response.ToString();
        }*/

    }
}
