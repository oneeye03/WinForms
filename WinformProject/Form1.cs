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
using System.Net;
using System.Web;
using System.IO;

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


            //-----------------------------------------------------------------------------------------


            /*var client = new HttpClient();
            client.BaseAddress = new Uri("https://github.com/login");
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

            logRcrdsTbox.Text = response.ToString();*/

            //-----------------------------------------------------------------------------------------

            /*var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api.github.com/graphql")
            };

            httpClient.DefaultRequestHeaders.Add("User-Agent", "WinForms");
            httpClient.DefaultRequestHeaders.Add("Accept", "application/vnd.github.audit-log-preview+json");

            string basicValue = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{emailTbox.Text}:3a2566bf853e0a1100b3c831ae17b95879ee245b"));
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", basicValue);

            var queryObject = new
            {
                query = @"query { 
                viewer{
                    login
                    
                }
            }",

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
*/
            //-----------------------------------------------------------------------------------------



            /*var username = Encoding.Default.GetBytes("oneeye03");
            var password = Encoding.Default.GetBytes("0Neye13");
            var baseAddress = new Uri("https://github.com/login");
            var cookieContainer = new CookieContainer();
            using (var handler = new HttpClientHandler() { CookieContainer = cookieContainer })
            using (var client = new HttpClient(handler) { BaseAddress = baseAddress })
            {
                string basicValue = Convert.ToBase64String(Encoding.UTF8.GetBytes($"oneeye03:0Neye13"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("User-Agent", basicValue);

                var homePageResult = client.GetAsync("/");
                homePageResult.Result.EnsureSuccessStatusCode();

                *//*var formData = new List<KeyValuePair<string, string>>();
                formData.Add(new KeyValuePair<string, string>("login", "oneeye03"));
                formData.Add(new KeyValuePair<string, string>("password", "0Neye13"));

                var requestContent = string.Format("login={0}&password={1}", "oneeye03", "0Neye13");
                var content = new StringContent(HttpUtility.UrlEncode(requestContent), Encoding.UTF8, "application/vnd.github.v3+json");*//*

                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("login", username.ToString()),
                    new KeyValuePair<string, string>("password", password.ToString()),
                });
                var loginResult = client.PutAsync("/session", content).Result;


                loginResult.EnsureSuccessStatusCode();

                logRcrdsTbox.Text = await loginResult.Content.ReadAsStringAsync();

            }*/

            CookieContainer cookieJar = new CookieContainer();
            HttpClientHandler handler = new HttpClientHandler()
            {
                CookieContainer = cookieJar
            };
            handler.UseCookies = true;
            handler.UseDefaultCredentials = false;
            HttpClient client = new HttpClient(handler as HttpMessageHandler)
            {
                BaseAddress = new Uri("http://github.com/login")
            };
            //client.BaseAddress = new Uri("http://github.com");
            var request = new HttpRequestMessage(HttpMethod.Post, "http://github.com/login");

            var byteArray = new UTF8Encoding().GetBytes("Iv1.814699d10d90ebfc:aa40b6d36d0627cd736c7d39611863ec1e8d28a3");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("User-Agent", Convert.ToBase64String(byteArray));

            var formData = new List<KeyValuePair<string, string>>();
            formData.Add(new KeyValuePair<string, string>("login", "oneeye03"));
            formData.Add(new KeyValuePair<string, string>("password", "0Neye13"));

            request.Content = new FormUrlEncodedContent(formData);
            var response = await client.PostAsync("http://github.com/login", request.Content);

            //logRcrdsTbox.Text = response.ToString();
            if (response.IsSuccessStatusCode)
            {
                var read = await client.GetAsync("http://github.com/settings/security-log");
                logRcrdsTbox.Text = await read.Content.ReadAsStringAsync();

                /*var formLogsData = new List<KeyValuePair<string, string>>();
                formLogsData.Add(new KeyValuePair<string, string>("authenticity_token", "NN66sWcb5TFPEmvOtOc49o4q2C5XNe9FbmZ8+VmHPrSx9BumqxjqvBEwi57+rOOcUgHV/KpQolz7iPiSECBJLQ=="));

                request.Content = new FormUrlEncodedContent(formData);
                var responseLogs = await client.PostAsync("/settings/security-log/export.json", request.Content);


                logRcrdsTbox.Text = responseLogs.ToString();*/
            }




            /*const string uri = "https://github.com/settings/security-log";
            using (var client = new HttpClient())
            {
                var byteArray = Encoding.ASCII.GetBytes("oneeye03:0Neye13");
                var header = new AuthenticationHeaderValue(
                           "Basic", Convert.ToBase64String(byteArray));
                client.DefaultRequestHeaders.Authorization = header;

                var result = await client.GetAsync(uri);

                logRcrdsTbox.Text = result.ToString();
            }*/



            /*CookieContainer cookieJar = new CookieContainer();
            HttpClientHandler handler = new HttpClientHandler()
            {
                CookieContainer = cookieJar
            };
            handler.UseCookies = true;
            handler.UseDefaultCredentials = false;
            HttpClient client = new HttpClient(handler as HttpMessageHandler)
            {
                BaseAddress = new Uri("https://github.com/login")
            };

            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            Stream responseStream = await response.Content.ReadAsStreamAsync();
            using (StreamReader responseReader = new StreamReader(responseStream))
            {
                //String sLine = responseReader.ReadLine();
                String sResponse = responseReader.ReadToEnd();
                logRcrdsTbox.Text = sResponse;
                String sWait = "wait";
            }

            HttpContent content = new FormUrlEncodedContent(new[]
                {
        new KeyValuePair<string, string>("login", "oneeye03"),
        new KeyValuePair<string, string>("password", "0Neye13"),
    });

            response = await client.PostAsync("/session", content);
            responseStream = await response.Content.ReadAsStreamAsync();
            using (StreamReader responseReader = new StreamReader(responseStream))
            {
                //String sLine = responseReader.ReadLine();
                String sResponse = responseReader.ReadToEnd();

                String sWait = "wait";
            }*/

        }



        async void HTTP_GET()
        {
            var TARGETURL = "https://github.com/login";

            HttpClientHandler handler = new HttpClientHandler()
            {
                Proxy = new WebProxy("http://127.0.0.1:8888"),
                UseProxy = true,
            };

            Console.WriteLine("GET: + " + TARGETURL);

            // ... Use HttpClient.            
            HttpClient client = new HttpClient(handler);

            var byteArray = Encoding.ASCII.GetBytes("oneeye03:0Neye13");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("User-Agent", Convert.ToBase64String(byteArray));

            HttpResponseMessage response = await client.GetAsync(TARGETURL);
            HttpContent content = response.Content;

            // ... Check Status Code                                
            Console.WriteLine("Response StatusCode: " + (int)response.StatusCode);

            // ... Read the string.
            string result = await content.ReadAsStringAsync();

            // ... Display the result.
            if (result != null &&
            result.Length >= 50)
            {
                logRcrdsTbox.Text = result.Substring(0, 50) + "...";
            }
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





