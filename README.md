# Acuity Scheduling API - C# Library

Welcome to the Acuity Scheduling C# SDK.  This SDK provides examples and a standard library for integrating with the [Acuity Scheduling API](https://acuityscheduling.com/) using .Net.  You can learn more about developing for Acuity Scheduling at [developers.acuityscheduling.com](https://developers.acuityscheduling.com/).

## Installation

This package can be installed via the nuget package manager.

### For dotnet core applictions
```sh
$ dotnet add package AcuityScheduling.API
```

### Package Manager Console
```powershell
PS C:\ProjectDir\> Install-Package AcuityScheduling.API
```

## Examples

### Getting a list of Appointments
```csharp
var httpClient = new HttpClient();
var byteArray = Encoding.ASCII.GetBytes("username:password");
httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
var client = new Client(httpClient)
{
    BaseUrl = "https://acuityscheduling.com/api/v1/"
};
var x = await client.ListAppointmentsAsync();
Console.WriteLine(JsonConvert.SerializeObject(x, Formatting.Indented));
```