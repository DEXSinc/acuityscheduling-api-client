using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Xunit;
using Xunit.Abstractions;

namespace AcuityScheduling.API.Tests
{
    public class AcuityClientTests
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly IConfiguration _config;

        private static IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder();
            var config = builder
                .AddJsonFile("appsettings.json", true)
                .AddJsonFile("appsettings.Development.json", true)
                .Build();
            return config;
        }

        public AcuityClientTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _config = GetConfiguration();
        }

        [Fact]
        public void CanCreateAcuityClient()
        {
            var httpClient = new HttpClient();
            var byteArray = Encoding.ASCII.GetBytes($"{_config["AcuityScheduling:Authentication:Username"]}:{_config["AcuityScheduling:Authentication:Password"]}");
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(_config["AcuityScheduling:Authentication:Scheme"], Convert.ToBase64String(byteArray));
            var client = new AcuityClient(httpClient)
            {
                BaseUrl = "https://acuityscheduling.com/api/v1/"
            };
        }

        // [Theory]
        // [InlineData(319762785)]
        // public async Task CanCancelAppointment(long appointmentId)
        // {
        //     var httpClient = new HttpClient();
        //     var byteArray = Encoding.ASCII.GetBytes($"{_config["AcuityScheduling:Authentication:Username"]}:{_config["AcuityScheduling:Authentication:Password"]}");
        //     httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(_config["AcuityScheduling:Authentication:Scheme"], Convert.ToBase64String(byteArray));
        //     var client = new AcuityClient(httpClient)
        //     {
        //         BaseUrl = "https://acuityscheduling.com/api/v1/"
        //     };
        //     await client.CancelAppointmentAsync(new Models.AppointmentCancellationRequest()
        //     {
        //         CancelNote = "Appointment canceled from CRM",
        //         NoShow = true
        //     }, appointmentId: appointmentId);
        // }
    }
}
