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
    public class ClientTests
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

        public ClientTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _config = GetConfiguration();
        }

        [Fact]
        public async Task CanCreateAcuityClient()
        {
            var httpClient = new HttpClient();
            var byteArray = Encoding.ASCII.GetBytes($"{_config["AcuityScheduling:Authentication:Username"]}:{_config["AcuityScheduling:Authentication:Password"]}");
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(_config["AcuityScheduling:Authentication:Scheme"], Convert.ToBase64String(byteArray));
            var client = new Client(httpClient)
            {
                BaseUrl = "https://acuityscheduling.com/api/v1/"
            };
            var x = await client.ListAppointmentsAsync(appointmentTypeId: 11314604);
            _testOutputHelper.WriteLine(JsonConvert.SerializeObject(x, Formatting.Indented));
        }

        [Fact]
        public async Task CanCancelAppointment()
        {
            var httpClient = new HttpClient();
            var byteArray = Encoding.ASCII.GetBytes($"{_config["AcuityScheduling:Authentication:Username"]}:{_config["AcuityScheduling:Authentication:Password"]}");
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(_config["AcuityScheduling:Authentication:Scheme"], Convert.ToBase64String(byteArray));
            var client = new Client(httpClient)
            {
                BaseUrl = "https://acuityscheduling.com/api/v1/"
            };
            var cr = await client.CancelAppointmentAsync(new Models.AppointmentCancellationRequest()
            {
                CancelNote = "Appointment canceled from CRM",
                NoShow = true
            }, appointmentId: 319760023);
        }
    }
}
