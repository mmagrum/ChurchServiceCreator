using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchServiceCreator.Functions
{
    internal class apiCall
    {
        public string Get(string Url, string AppId, string Secret, string Query)
        {
            string? EmpResponse;
            using var client = new HttpClient();
            client.BaseAddress = new Uri(Url);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var base64String = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{AppId}:{Secret}"));
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", base64String);
            var response = client.GetAsync(Query).Result;
            if (response.IsSuccessStatusCode == true)
            {
                EmpResponse = response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                EmpResponse = response.StatusCode.ToString();
            }
            return EmpResponse;
        }
        public string Post(string Url, string AppId, string Secret, string Service, HttpContent Payload)
        {
            string? EmpResponse;
            using var client = new HttpClient();
            client.BaseAddress = new Uri(Url);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var base64String = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{AppId}:{Secret}"));
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", base64String);
            var response = client.PostAsync(Service, Payload).Result;
            if (response.IsSuccessStatusCode == true)
            {
                EmpResponse = response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                EmpResponse = response.StatusCode.ToString();
            }
            return EmpResponse;
        }
    }
}
