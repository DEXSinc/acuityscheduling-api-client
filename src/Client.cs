using System;
using System.Net.Http;
using System.Runtime.Serialization;
using AcuityScheduling.API.Models;
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable UnusedMember.Global

namespace AcuityScheduling.API
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.6.0 (NJsonSchema v10.0.23.0 (Newtonsoft.Json v10.0.0.0))")]
    public partial class Client 
    {
        private readonly System.Net.Http.HttpClient _httpClient;
        private readonly Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;

        public Client(System.Net.Http.HttpClient httpClient)
        {
            _httpClient = httpClient; 
            _settings = new Lazy<Newtonsoft.Json.JsonSerializerSettings>(() => 
            {
                var settings = new Newtonsoft.Json.JsonSerializerSettings();
                UpdateJsonSerializerSettings(settings);
                return settings;
            });
        }
    
        public string BaseUrl { get; set; } = "https://virtserver.swaggerhub.com/vic10us/AcuityScheduling/1.0.0";

        protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings => _settings.Value;

        partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url);
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
        partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);

        /// <summary>Get a list of appointments currently scheduled for the authenticated user.</summary>
        /// <param name="max">maximum number of results</param>
        /// <param name="minDate">only get appointments this date and after</param>
        /// <param name="maxDate">only get appointments this date and before</param>
        /// <param name="calendarId">show only appointments on calendar with specified ID</param>
        /// <param name="appointmentTypeId">show only appointments of this type</param>
        /// <param name="canceled">get canceled appointments</param>
        /// <param name="firstName">filter appointments for client first name</param>
        /// <param name="lastName">filter appointments for client last name</param>
        /// <param name="email">filter appointments for client e-mail address</param>
        /// <param name="phone">filter appointments for client phone</param>
        /// <param name="fieldId">filter appointments matching a particular custom intake form field</param>
        /// <param name="addonIDs">only get appointments this date and before</param>
        /// <param name="excludeForms">don't include intake forms in the response object (speeds up the response)</param>
        /// <param name="canClientCancel">get appointments that allow clients to cancel</param>
        /// <param name="canClientReschedule">get appointments that allow clients to reschedule</param>
        /// <param name="direction">ASC or DESC</param>
        /// <returns>appointment results matching criteria</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Appointment>> ListAppointmentsAsync(long? max = null, DateTimeOffset? minDate = null, DateTimeOffset? maxDate = null, int? calendarId = null, long? appointmentTypeId = null, bool? canceled = null, string firstName = null, string lastName = null, string email = null, string phone = null, string fieldId = null, long? addonIDs = null, bool? excludeForms = null, bool? canClientCancel = null, bool? canClientReschedule = null, Direction? direction = null)
        {
            return ListAppointmentsAsync(System.Threading.CancellationToken.None, max, minDate, maxDate, calendarId, appointmentTypeId, canceled, firstName, lastName, email, phone, fieldId, addonIDs, excludeForms, canClientCancel, canClientReschedule, direction);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get a list of appointments currently scheduled for the authenticated user.</summary>
        /// <param name="max">maximum number of results</param>
        /// <param name="minDate">only get appointments this date and after</param>
        /// <param name="maxDate">only get appointments this date and before</param>
        /// <param name="calendarId">show only appointments on calendar with specified ID</param>
        /// <param name="appointmentTypeId">show only appointments of this type</param>
        /// <param name="canceled">get canceled appointments</param>
        /// <param name="firstName">filter appointments for client first name</param>
        /// <param name="lastName">filter appointments for client last name</param>
        /// <param name="email">filter appointments for client e-mail address</param>
        /// <param name="phone">filter appointments for client phone</param>
        /// <param name="fieldId">filter appointments matching a particular custom intake form field</param>
        /// <param name="addonIDs">only get appointments this date and before</param>
        /// <param name="excludeForms">don't include intake forms in the response object (speeds up the response)</param>
        /// <param name="canClientCancel">get appointments that allow clients to cancel</param>
        /// <param name="canClientReschedule">get appointments that allow clients to reschedule</param>
        /// <param name="direction">ASC or DESC</param>
        /// <returns>appointment results matching criteria</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Appointment>> ListAppointmentsAsync(System.Threading.CancellationToken cancellationToken, long? max = null, DateTimeOffset? minDate = null, DateTimeOffset? maxDate = null, int? calendarId = null, long? appointmentTypeId = null, bool? canceled = null, string firstName = null, string lastName = null, string email = null, string phone = null, string fieldId = null, long? addonIDs = null, bool? excludeForms = null, bool? canClientCancel = null, bool? canClientReschedule = null, Direction? direction = null)
        {
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/appointments?");
            if (max != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("max") + "=").Append(Uri.EscapeDataString(ConvertToString(max, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (minDate != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("minDate") + "=").Append(Uri.EscapeDataString(minDate.Value.ToString("s", System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (maxDate != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("maxDate") + "=").Append(Uri.EscapeDataString(maxDate.Value.ToString("s", System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (calendarId != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("calendarID") + "=").Append(Uri.EscapeDataString(ConvertToString(calendarId, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (appointmentTypeId != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("appointmentTypeID") + "=").Append(Uri.EscapeDataString(ConvertToString(appointmentTypeId, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (canceled != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("canceled") + "=").Append(Uri.EscapeDataString(ConvertToString(canceled, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (firstName != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("firstName") + "=").Append(Uri.EscapeDataString(ConvertToString(firstName, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (lastName != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("lastName") + "=").Append(Uri.EscapeDataString(ConvertToString(lastName, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (email != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("email") + "=").Append(Uri.EscapeDataString(ConvertToString(email, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (phone != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("phone") + "=").Append(Uri.EscapeDataString(ConvertToString(phone, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (fieldId != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("field:id") + "=").Append(Uri.EscapeDataString(ConvertToString(fieldId, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (addonIDs != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("addonIDs") + "=").Append(Uri.EscapeDataString(ConvertToString(addonIDs, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (excludeForms != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("excludeForms") + "=").Append(Uri.EscapeDataString(ConvertToString(excludeForms, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (canClientCancel != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("canClientCancel") + "=").Append(Uri.EscapeDataString(ConvertToString(canClientCancel, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (canClientReschedule != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("canClientReschedule") + "=").Append(Uri.EscapeDataString(ConvertToString(canClientReschedule, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (direction != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("direction") + "=").Append(Uri.EscapeDataString(ConvertToString(direction, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder.Length--;
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                request.Method = new System.Net.Http.HttpMethod("GET");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    switch (status)
                    {
                        case "200":
                        {
                            var objectResponse = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<Appointment>>(response, headers).ConfigureAwait(false);
                            return objectResponse.Object;
                        }

                        case "401":
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers).ConfigureAwait(false);
                            throw new ApiException<Error>("Unauthorized", (int)response.StatusCode, objectResponse.Text, headers, objectResponse.Object, null);
                        }

                        default:
                        {
                            if (status != "200" && status != "204")
                            {
                                var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                                throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                            }

                            break;
                        }
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        /// <returns>Newly created appointment</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<Appointment> CreateAppointmentAsync(AppointmentCreationRequest body)
        {
            return CreateAppointmentAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name="body"></param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Newly created appointment</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<Appointment> CreateAppointmentAsync(AppointmentCreationRequest body, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/appointments");
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                var content = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new System.Net.Http.HttpMethod("POST");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<Appointment>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }

        /// <param name="admin">By default appointments are canceled as a client. Canceling an appointment as an admin allows setting the "noShow" field and disables cancellation rules. To cancel as an admin pass the query parameter admin=true.</param>
        /// <param name="noEmail">Skip sending the cancellation e-mail and SMS by canceling the appointment with the noEmail=true query parameter.</param>
        /// <param name="body"></param>
        /// <param name="appointmentId">Appointment ID</param>
        /// <returns>The updated appointment</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<Appointment> CancelAppointmentAsync(AppointmentCancellationRequest body, long appointmentId, bool? admin = null, bool? noEmail = null)
        {
            return CancelAppointmentAsync(body, appointmentId, System.Threading.CancellationToken.None, admin, noEmail);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="admin">By default appointments are canceled as a client. Canceling an appointment as an admin allows setting the "noShow" field and disables cancellation rules. To cancel as an admin pass the query parameter admin=true.</param>
        /// <param name="noEmail">Skip sending the cancellation e-mail and SMS by canceling the appointment with the noEmail=true query parameter.</param>
        /// <param name="body"></param>
        /// <param name="appointmentId">Appointment ID</param>
        /// <returns>The updated appointment</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<Appointment> CancelAppointmentAsync(AppointmentCancellationRequest body, long appointmentId, System.Threading.CancellationToken cancellationToken, bool? admin = null, bool? noEmail = null)
        {
            if (appointmentId == default)
                throw new ArgumentNullException(nameof(appointmentId));
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/appointments/{appointmentId}/cancel?");
            urlBuilder.Replace("{appointmentId}", Uri.EscapeDataString(ConvertToString(appointmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (admin != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("admin") + "=").Append(Uri.EscapeDataString(ConvertToString(admin, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (noEmail != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("noEmail") + "=").Append(Uri.EscapeDataString(ConvertToString(noEmail, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder.Length--;
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                var content = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new System.Net.Http.HttpMethod("PUT");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<Appointment>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        /// <param name="appointmentId">Appointment ID</param>
        /// <returns>Appointment Response</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Payment>> GetAppointmentPaymentsAsync(long appointmentId)
        {
            return GetAppointmentPaymentsAsync(appointmentId, System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="appointmentId">Appointment ID</param>
        /// <returns>Appointment Response</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Payment>> GetAppointmentPaymentsAsync(long appointmentId, System.Threading.CancellationToken cancellationToken)
        {
            if (appointmentId == default)
                throw new ArgumentNullException(nameof(appointmentId));
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/appointments/{appointmentId}/payments");
            urlBuilder.Replace("{appointmentId}", Uri.EscapeDataString(ConvertToString(appointmentId, System.Globalization.CultureInfo.InvariantCulture)));
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                request.Method = new System.Net.Http.HttpMethod("GET");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<Payment>>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }

        /// <summary>Reschedule an appointment to a different date or calendar. Or both!</summary>
        /// <param name="admin">By default appointments are canceled as a client. Canceling an appointment as an admin allows setting the "noShow" field and disables cancellation rules. To cancel as an admin pass the query parameter admin=true.</param>
        /// <param name="noEmail">Skip sending the cancellation e-mail and SMS by canceling the appointment with the noEmail=true query parameter.</param>
        /// <param name="body"></param>
        /// <param name="appointmentId">Appointment ID</param>
        /// <returns>The updated appointment</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<Appointment> RescheduleAppointmentAsync(AppointmentRescheduleRequest body, long appointmentId, bool? admin = null, bool? noEmail = null)
        {
            return RescheduleAppointmentAsync(body, appointmentId, System.Threading.CancellationToken.None, admin, noEmail);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Reschedule an appointment to a different date or calendar. Or both!</summary>
        /// <param name="admin">By default appointments are canceled as a client. Canceling an appointment as an admin allows setting the "noShow" field and disables cancellation rules. To cancel as an admin pass the query parameter admin=true.</param>
        /// <param name="noEmail">Skip sending the cancellation e-mail and SMS by canceling the appointment with the noEmail=true query parameter.</param>
        /// <param name="body"></param>
        /// <param name="appointmentId">Appointment ID</param>
        /// <returns>The updated appointment</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<Appointment> RescheduleAppointmentAsync(AppointmentRescheduleRequest body, long appointmentId, System.Threading.CancellationToken cancellationToken, bool? admin = null, bool? noEmail = null)
        {
            if (appointmentId == default)
                throw new ArgumentNullException(nameof(appointmentId));
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/appointments/{appointmentId}/reschedule?");
            urlBuilder.Replace("{appointmentId}", Uri.EscapeDataString(ConvertToString(appointmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (admin != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("admin") + "=").Append(Uri.EscapeDataString(ConvertToString(admin, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (noEmail != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("noEmail") + "=").Append(Uri.EscapeDataString(ConvertToString(noEmail, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder.Length--;
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                var content = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new System.Net.Http.HttpMethod("PUT");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<Appointment>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        /// <summary>Get a single appointment by ID.</summary>
        /// <param name="pastFormAnswers">includes previous answers given to the intake forms of that appointment</param>
        /// <param name="appointmentId">Appointment ID</param>
        /// <returns>Appointment Response</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<Appointment> GetAppointmentAsync(long appointmentId, bool? pastFormAnswers = null)
        {
            return GetAppointmentAsync(appointmentId, System.Threading.CancellationToken.None, pastFormAnswers);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get a single appointment by ID.</summary>
        /// <param name="pastFormAnswers">includes previous answers given to the intake forms of that appointment</param>
        /// <param name="appointmentId">Appointment ID</param>
        /// <returns>Appointment Response</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<Appointment> GetAppointmentAsync(long appointmentId, System.Threading.CancellationToken cancellationToken, bool? pastFormAnswers = null)
        {
            if (appointmentId == default)
                throw new ArgumentNullException(nameof(appointmentId));
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/appointments/{appointmentId}?");
            urlBuilder.Replace("{appointmentId}", Uri.EscapeDataString(ConvertToString(appointmentId, System.Globalization.CultureInfo.InvariantCulture)));
            if (pastFormAnswers != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("pastFormAnswers") + "=").Append(Uri.EscapeDataString(ConvertToString(pastFormAnswers, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder.Length--;
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                request.Method = new System.Net.Http.HttpMethod("GET");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<Appointment>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }

        /// <summary>Update a single appointment by ID.</summary>
        /// <param name="body"></param>
        /// <param name="appointmentId">Appointment ID</param>
        /// <returns>The updated appointment</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<Appointment> AppointmentsAsync(AppointmentPatch body, long appointmentId)
        {
            return AppointmentsAsync(body, appointmentId, System.Threading.CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Update a single appointment by ID.</summary>
        /// <param name="body"></param>
        /// <param name="appointmentId">Appointment ID</param>
        /// <returns>The updated appointment</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<Appointment> AppointmentsAsync(AppointmentPatch body, long appointmentId, System.Threading.CancellationToken cancellationToken)
        {
            if (appointmentId == default)
                throw new ArgumentNullException(nameof(appointmentId));
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/appointments/{appointmentId}");
            urlBuilder.Replace("{appointmentId}", Uri.EscapeDataString(ConvertToString(appointmentId, System.Globalization.CultureInfo.InvariantCulture)));
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                var content = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new System.Net.Http.HttpMethod("PUT");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<Appointment>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        /// <summary>Get a full list of addons from the authenticated user.</summary>
        /// <returns>List of addons from the authenticated user</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<AppointmentAddon>> ListAppointmentAddonsAsync()
        {
            return ListAppointmentAddonsAsync(System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get a full list of addons from the authenticated user.</summary>
        /// <returns>List of addons from the authenticated user</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<AppointmentAddon>> ListAppointmentAddonsAsync(System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/appointment-addons");
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                request.Method = new System.Net.Http.HttpMethod("GET");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<AppointmentAddon>>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        /// <summary>Retrieves a list of calendars this user has access to.</summary>
        /// <returns>list of calendars this user has access to</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Calendar>> ListCalendarsAsync()
        {
            return ListCalendarsAsync(System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves a list of calendars this user has access to.</summary>
        /// <returns>list of calendars this user has access to</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Calendar>> ListCalendarsAsync(System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/calendars");
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                request.Method = new System.Net.Http.HttpMethod("GET");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<Calendar>>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        /// <summary>Return intake forms.</summary>
        /// <returns>intake forms</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Form>> ListFormsAsync()
        {
            return ListFormsAsync(System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Return intake forms.</summary>
        /// <returns>intake forms</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Form>> ListFormsAsync(System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/forms");
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                request.Method = new System.Net.Http.HttpMethod("GET");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<Form>>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        /// <summary>Get labels</summary>
        /// <returns>List of labels</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Label>> ListLabelsAsync()
        {
            return ListLabelsAsync(System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get labels</summary>
        /// <returns>List of labels</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Label>> ListLabelsAsync(System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/labels");
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                request.Method = new System.Net.Http.HttpMethod("GET");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<Label>>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        /// <summary>Return appointment types</summary>
        /// <param name="includeDeleted">Also include deleted appointment types in the response</param>
        /// <returns>list of appointment types</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<AppointmentType>> ListAppointmentTypesAsync(bool? includeDeleted = null)
        {
            return ListAppointmentTypesAsync(System.Threading.CancellationToken.None, includeDeleted);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Return appointment types</summary>
        /// <param name="includeDeleted">Also include deleted appointment types in the response</param>
        /// <returns>list of appointment types</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<AppointmentType>> ListAppointmentTypesAsync(System.Threading.CancellationToken cancellationToken, bool? includeDeleted = null)
        {
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/appointment-types?");
            if (includeDeleted != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("includeDeleted") + "=").Append(Uri.EscapeDataString(ConvertToString(includeDeleted, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder.Length--;
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                request.Method = new System.Net.Http.HttpMethod("GET");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<AppointmentType>>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        /// <summary>Validate available times for an appointment</summary>
        /// <param name="body">Single appointment time check</param>
        /// <returns>The result of the check</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<AppointmentCheckTimeResult> CheckAppointmentTimesAsync(AppointmentCheckTimeRequest body)
        {
            return CheckAppointmentTimesAsync(body, System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Validate available times for an appointment</summary>
        /// <param name="body">Single appointment time check</param>
        /// <returns>The result of the check</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<AppointmentCheckTimeResult> CheckAppointmentTimesAsync(AppointmentCheckTimeRequest body, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/availability/check-times");
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                var content = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new System.Net.Http.HttpMethod("POST");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<AppointmentCheckTimeResult>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        /// <summary>Return available classes for a given month</summary>
        /// <param name="month">Month to check available classes (must be parsable by strtotime, eg. 2016-02 http://php.net/manual/en/function.strtotime.php)</param>
        /// <param name="appointmentTypeId">Numeric id of the appointment type to check availability for. By default, check availability for all class appointment types.</param>
        /// <param name="calendarId">Numeric id of the calendar to check availability for. By default, check availability for all calendars the appointment type is offered on.</param>
        /// <param name="timezone">Long timezone id for availability time conversion (eg. America/New_York)</param>
        /// <param name="minDate">The earliest date to return classes for. The will be over-ridden by month</param>
        /// <param name="maxDate">The latest date to return classes for. This will be over-ridden by month.</param>
        /// <param name="includeUnavailable">List all classes, including those that are no longer available.</param>
        /// <param name="includePrivate">List all classes, including those marked as private</param>
        /// <returns>Available classes for a given month</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Class>> ListClassesForMonthAsync(string month = null, long? appointmentTypeId = null, int? calendarId = null, string timezone = null, DateTimeOffset? minDate = null, DateTimeOffset? maxDate = null, bool? includeUnavailable = null, bool? includePrivate = null)
        {
            return ListClassesForMonthAsync(System.Threading.CancellationToken.None, month, appointmentTypeId, calendarId, timezone, minDate, maxDate, includeUnavailable, includePrivate);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Return available classes for a given month</summary>
        /// <param name="month">Month to check available classes (must be parsable by strtotime, eg. 2016-02 http://php.net/manual/en/function.strtotime.php)</param>
        /// <param name="appointmentTypeId">Numeric id of the appointment type to check availability for. By default, check availability for all class appointment types.</param>
        /// <param name="calendarId">Numeric id of the calendar to check availability for. By default, check availability for all calendars the appointment type is offered on.</param>
        /// <param name="timezone">Long timezone id for availability time conversion (eg. America/New_York)</param>
        /// <param name="minDate">The earliest date to return classes for. The will be over-ridden by month</param>
        /// <param name="maxDate">The latest date to return classes for. This will be over-ridden by month.</param>
        /// <param name="includeUnavailable">List all classes, including those that are no longer available.</param>
        /// <param name="includePrivate">List all classes, including those marked as private</param>
        /// <returns>Available classes for a given month</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Class>> ListClassesForMonthAsync(System.Threading.CancellationToken cancellationToken, string month = null, long? appointmentTypeId = null, int? calendarId = null, string timezone = null, DateTimeOffset? minDate = null, DateTimeOffset? maxDate = null, bool? includeUnavailable = null, bool? includePrivate = null)
        {
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/availability/classes?");
            if (month != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("month") + "=").Append(Uri.EscapeDataString(ConvertToString(month, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (appointmentTypeId != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("appointmentTypeID") + "=").Append(Uri.EscapeDataString(ConvertToString(appointmentTypeId, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (calendarId != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("calendarID") + "=").Append(Uri.EscapeDataString(ConvertToString(calendarId, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (timezone != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("timezone") + "=").Append(Uri.EscapeDataString(ConvertToString(timezone, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (minDate != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("minDate") + "=").Append(Uri.EscapeDataString(minDate.Value.ToString("s", System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (maxDate != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("maxDate") + "=").Append(Uri.EscapeDataString(maxDate.Value.ToString("s", System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (includeUnavailable != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("includeUnavailable") + "=").Append(Uri.EscapeDataString(ConvertToString(includeUnavailable, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (includePrivate != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("includePrivate") + "=").Append(Uri.EscapeDataString(ConvertToString(includePrivate, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder.Length--;
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                request.Method = new System.Net.Http.HttpMethod("GET");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<Class>>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        /// <summary>Return dates with availability for a month and an appointment type</summary>
        /// <param name="month">Month to check available dates (must be parsable by strtotime, eg. 2016-02 http://php.net/manual/en/function.strtotime.php)</param>
        /// <param name="appointmentTypeId">Numeric id of the appointment type to check availability for.</param>
        /// <param name="calendarId">Numeric id of the calendar to check availability for. By default, check availability for all calendars the appointment type is offered on.</param>
        /// <param name="addonIDs">Addon IDs to use when calculating availability for this appointment type. Addons must be associated with the appointment type</param>
        /// <param name="timezone">Long timezone id for availability time conversion (eg. America/New_York).</param>
        /// <returns>An appointment type's available dates for a particular month. These dates are the same as those shown to the client through the client scheduling page</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<DateObject>> ListAvailabilityDatesAsync(string month, long appointmentTypeId, int? calendarId = null, System.Collections.Generic.IEnumerable<int> addonIDs = null, string timezone = null)
        {
            return ListAvailabilityDatesAsync(month, appointmentTypeId, System.Threading.CancellationToken.None, calendarId, addonIDs, timezone);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Return dates with availability for a month and an appointment type</summary>
        /// <param name="month">Month to check available dates (must be parsable by strtotime, eg. 2016-02 http://php.net/manual/en/function.strtotime.php)</param>
        /// <param name="appointmentTypeId">Numeric id of the appointment type to check availability for.</param>
        /// <param name="calendarId">Numeric id of the calendar to check availability for. By default, check availability for all calendars the appointment type is offered on.</param>
        /// <param name="addonIDs">Addon IDs to use when calculating availability for this appointment type. Addons must be associated with the appointment type</param>
        /// <param name="timezone">Long timezone id for availability time conversion (eg. America/New_York).</param>
        /// <returns>An appointment type's available dates for a particular month. These dates are the same as those shown to the client through the client scheduling page</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<DateObject>> ListAvailabilityDatesAsync(string month, long appointmentTypeId, System.Threading.CancellationToken cancellationToken, int? calendarId = null, System.Collections.Generic.IEnumerable<int> addonIDs = null, string timezone = null)
        {
            if (month == null)
                throw new ArgumentNullException(nameof(month));
    
            if (appointmentTypeId == default)
                throw new ArgumentNullException(nameof(appointmentTypeId));
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/availability/dates?");
            urlBuilder.Append(Uri.EscapeDataString("month") + "=").Append(Uri.EscapeDataString(ConvertToString(month, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            urlBuilder.Append(Uri.EscapeDataString("appointmentTypeID") + "=").Append(Uri.EscapeDataString(ConvertToString(appointmentTypeId, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            if (calendarId != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("calendarID") + "=").Append(Uri.EscapeDataString(ConvertToString(calendarId, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (addonIDs != null) 
            {
                foreach (var item in addonIDs) { urlBuilder.Append(Uri.EscapeDataString("addonIDs") + "=").Append(Uri.EscapeDataString(ConvertToString(item, System.Globalization.CultureInfo.InvariantCulture))).Append("&"); }
            }
            if (timezone != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("timezone") + "=").Append(Uri.EscapeDataString(ConvertToString(timezone, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder.Length--;
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                request.Method = new System.Net.Http.HttpMethod("GET");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<DateObject>>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response.Dispose();
                }
            }
        }
    
        /// <summary>Return available times for a date and appointment type</summary>
        /// <param name="date">Date to check available times (must be parsable by strtotime http://php.net/manual/en/function.strtotime.php)</param>
        /// <param name="appointmentTypeId">Numeric id of the appointment type to check availability for.</param>
        /// <param name="calendarId">Numeric id of the calendar to check availability for. By default, check availability for all calendars the appointment type is offered on.</param>
        /// <param name="addonIDs">Addon IDs to use when calculating availability for this appointment type. Addons must be associated with the appointment type</param>
        /// <param name="timezone">Long timezone id for availability time conversion (eg. America/New_York).</param>
        /// <param name="ignoreAppointmentIDs">Appointment IDs to ignore, allowing slots overlapping the appointment and useful for rescheduling.</param>
        /// <returns>available times for a date and appointment type</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<TimeObject>> ListAvailabilityTimesAsync(DateTimeOffset date, long appointmentTypeId, int? calendarId = null, System.Collections.Generic.IEnumerable<int> addonIDs = null, string timezone = null, System.Collections.Generic.IEnumerable<long> ignoreAppointmentIDs = null)
        {
            return ListAvailabilityTimesAsync(date, appointmentTypeId, System.Threading.CancellationToken.None, calendarId, addonIDs, timezone, ignoreAppointmentIDs);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Return available times for a date and appointment type</summary>
        /// <param name="date">Date to check available times (must be parsable by strtotime http://php.net/manual/en/function.strtotime.php)</param>
        /// <param name="appointmentTypeId">Numeric id of the appointment type to check availability for.</param>
        /// <param name="calendarId">Numeric id of the calendar to check availability for. By default, check availability for all calendars the appointment type is offered on.</param>
        /// <param name="addonIDs">Addon IDs to use when calculating availability for this appointment type. Addons must be associated with the appointment type</param>
        /// <param name="timezone">Long timezone id for availability time conversion (eg. America/New_York).</param>
        /// <param name="ignoreAppointmentIDs">Appointment IDs to ignore, allowing slots overlapping the appointment and useful for rescheduling.</param>
        /// <returns>available times for a date and appointment type</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<TimeObject>> ListAvailabilityTimesAsync(DateTimeOffset date, long appointmentTypeId, System.Threading.CancellationToken cancellationToken, int? calendarId = null, System.Collections.Generic.IEnumerable<int> addonIDs = null, string timezone = null, System.Collections.Generic.IEnumerable<long> ignoreAppointmentIDs = null)
        {
            if (date == null)
                throw new ArgumentNullException(nameof(date));
    
            if (appointmentTypeId == default)
                throw new ArgumentNullException(nameof(appointmentTypeId));
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/availability/times?");
            urlBuilder.Append(Uri.EscapeDataString("date") + "=").Append(Uri.EscapeDataString(date.ToString("s", System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            urlBuilder.Append(Uri.EscapeDataString("appointmentTypeID") + "=").Append(Uri.EscapeDataString(ConvertToString(appointmentTypeId, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            if (calendarId != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("calendarID") + "=").Append(Uri.EscapeDataString(ConvertToString(calendarId, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (addonIDs != null) 
            {
                foreach (var item in addonIDs) { urlBuilder.Append(Uri.EscapeDataString("addonIDs") + "=").Append(Uri.EscapeDataString(ConvertToString(item, System.Globalization.CultureInfo.InvariantCulture))).Append("&"); }
            }
            if (timezone != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("timezone") + "=").Append(Uri.EscapeDataString(ConvertToString(timezone, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (ignoreAppointmentIDs != null) 
            {
                foreach (var item in ignoreAppointmentIDs) { urlBuilder.Append(Uri.EscapeDataString("ignoreAppointmentIDs") + "=").Append(Uri.EscapeDataString(ConvertToString(item, System.Globalization.CultureInfo.InvariantCulture))).Append("&"); }
            }
            urlBuilder.Length--;
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                request.Method = new System.Net.Http.HttpMethod("GET");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<TimeObject>>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response.Dispose();
                }
            }
        }
    
        /// <summary>Get a list of blocks for the authenticated user</summary>
        /// <param name="max">Maximum number of results</param>
        /// <param name="minDate">Only get appointments this date and after (YYYY-MM-DD)</param>
        /// <param name="maxDate">Only get blocks this date and before (YYYY-MM-DD)</param>
        /// <returns>list of blocks for the authenticated user.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Block>> ListUserBlocksAsync(int? max = null, DateTimeOffset? minDate = null, DateTimeOffset? maxDate = null)
        {
            return ListUserBlocksAsync(System.Threading.CancellationToken.None, max, minDate, maxDate);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get a list of blocks for the authenticated user</summary>
        /// <param name="max">Maximum number of results</param>
        /// <param name="minDate">Only get appointments this date and after (YYYY-MM-DD)</param>
        /// <param name="maxDate">Only get blocks this date and before (YYYY-MM-DD)</param>
        /// <returns>list of blocks for the authenticated user.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Block>> ListUserBlocksAsync(System.Threading.CancellationToken cancellationToken, int? max = null, DateTimeOffset? minDate = null, DateTimeOffset? maxDate = null)
        {
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/blocks?");
            if (max != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("max") + "=").Append(Uri.EscapeDataString(ConvertToString(max, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (minDate != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("minDate") + "=").Append(Uri.EscapeDataString(minDate.Value.ToString("s", System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (maxDate != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("maxDate") + "=").Append(Uri.EscapeDataString(maxDate.Value.ToString("s", System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder.Length--;
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                request.Method = new System.Net.Http.HttpMethod("GET");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<Block>>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response.Dispose();
                }
            }
        }
    
        /// <summary>POST request to block off time on your calendar</summary>
        /// <returns>the response of the block creation request</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<Block> CreateBlockAsync(BlockCreationRequest body)
        {
            return CreateBlockAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name="body"></param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>POST request to block off time on your calendar</summary>
        /// <returns>the response of the block creation request</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<Block> CreateBlockAsync(BlockCreationRequest body, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/blocks");
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                var content = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new System.Net.Http.HttpMethod("POST");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<Block>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status == "422") 
                    {
                        var responseText = ( response.Content == null ) ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("error 422 Unprocessable Entity if not able to parse data, or invalid parameter passed", (int)response.StatusCode, responseText, headers, null);
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        /// <summary>Given an ID of a blocked off time get the details about it</summary>
        /// <param name="id">Blocked time ID</param>
        /// <returns>The requested Block by ID</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<Block> GetBlockByIdAsync(int id)
        {
            return GetBlockByIdAsync(id, System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Given an ID of a blocked off time get the details about it</summary>
        /// <param name="id">Blocked time ID</param>
        /// <returns>The requested Block by ID</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<Block> GetBlockByIdAsync(int id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == default)
                throw new ArgumentNullException(nameof(id));
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/blocks/{id}");
            urlBuilder.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                request.Method = new System.Net.Http.HttpMethod("GET");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<Block>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        /// <summary>Delete a blocked off time Given an ID</summary>
        /// <param name="id">Blocked time ID</param>
        /// <returns>Successfully deleted Block of Time</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task BlocksAsync(int id)
        {
            return BlocksAsync(id, System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Delete a blocked off time Given an ID</summary>
        /// <param name="id">Blocked time ID</param>
        /// <returns>Successfully deleted Block of Time</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task BlocksAsync(int id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == default)
                throw new ArgumentNullException(nameof(id));
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/blocks/{id}");
            urlBuilder.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                request.Method = new System.Net.Http.HttpMethod("DELETE");
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    switch (status)
                    {
                        case "200":
                            return;
                        case "404":
                        {
                            var responseText = ( response.Content == null ) ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("Block of time not found", (int)response.StatusCode, responseText, headers, null);
                        }

                        default:
                        {
                            if (status != "200" && status != "204")
                            {
                                var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                                throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                            }

                            break;
                        }
                    }
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        /// <summary>Get package certificates.</summary>
        /// <param name="productId">Get certificate codes for a particular product.</param>
        /// <param name="orderId">Get certificate codes for a particular order.</param>
        /// <param name="appointmentTypeId">Get certificate codes for a particular appointment type.</param>
        /// <param name="email">Get valid codes for a particular email address. Combine this with appointment type to suggest certificates to a client!</param>
        /// <returns>list of package certificates</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Certificate>> ListCertificatesAsync(int? productId = null, int? orderId = null, long? appointmentTypeId = null, string email = null)
        {
            return ListCertificatesAsync(System.Threading.CancellationToken.None, productId, orderId, appointmentTypeId, email);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get package certificates.</summary>
        /// <param name="productId">Get certificate codes for a particular product.</param>
        /// <param name="orderId">Get certificate codes for a particular order.</param>
        /// <param name="appointmentTypeId">Get certificate codes for a particular appointment type.</param>
        /// <param name="email">Get valid codes for a particular email address. Combine this with appointment type to suggest certificates to a client!</param>
        /// <returns>list of package certificates</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Certificate>> ListCertificatesAsync(System.Threading.CancellationToken cancellationToken, int? productId = null, int? orderId = null, long? appointmentTypeId = null, string email = null)
        {
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/certificates?");
            if (productId != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("productID") + "=").Append(Uri.EscapeDataString(ConvertToString(productId, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (orderId != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("orderID") + "=").Append(Uri.EscapeDataString(ConvertToString(orderId, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (appointmentTypeId != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("appointmentTypeID") + "=").Append(Uri.EscapeDataString(ConvertToString(appointmentTypeId, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (email != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("email") + "=").Append(Uri.EscapeDataString(ConvertToString(email, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder.Length--;
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                request.Method = new System.Net.Http.HttpMethod("GET");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<Certificate>>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response.Dispose();
                }
            }
        }
    
        /// <param name="body">Certificate to create</param>
        /// <returns>Created certificate</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<Certificate> CreateCertificateAsync(CertificateCreationRequest body)
        {
            return CreateCertificateAsync(body, System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <param name="body">Certificate to create</param>
        /// <returns>Created certificate</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<Certificate> CreateCertificateAsync(CertificateCreationRequest body, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/certificates");
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                var content = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new System.Net.Http.HttpMethod("POST");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<Certificate>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        /// <summary>Delete a certificate code.</summary>
        /// <param name="id">The certificate Id</param>
        /// <returns>Certificate successfully deleted.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task DeleteCertificateAsync(int id)
        {
            return DeleteCertificateAsync(id, System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Delete a certificate code.</summary>
        /// <param name="id">The certificate Id</param>
        /// <returns>Certificate successfully deleted.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task DeleteCertificateAsync(int id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == default)
                throw new ArgumentNullException(nameof(id));
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/certificates/{id}");
            urlBuilder.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                request.Method = new System.Net.Http.HttpMethod("DELETE");
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200")
                    {
                        // return;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        /// <summary>Check that a certificate code is valid for a particular appointment type.</summary>
        /// <param name="certificate">The certificate code to check.</param>
        /// <param name="appointmentTypeId">The appointment type ID to check.</param>
        /// <param name="email">An optional email address to check if the certificate is valid for (eg. for coupon use).</param>
        /// <returns>Certificate</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<Certificate> CheckCertificateAsync(string certificate, long appointmentTypeId, string email = null)
        {
            return CheckCertificateAsync(certificate, appointmentTypeId, System.Threading.CancellationToken.None, email);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Check that a certificate code is valid for a particular appointment type.</summary>
        /// <param name="certificate">The certificate code to check.</param>
        /// <param name="appointmentTypeId">The appointment type ID to check.</param>
        /// <param name="email">An optional email address to check if the certificate is valid for (eg. for coupon use).</param>
        /// <returns>Certificate</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<Certificate> CheckCertificateAsync(string certificate, long appointmentTypeId, System.Threading.CancellationToken cancellationToken, string email = null)
        {
            if (certificate == null)
                throw new ArgumentNullException(nameof(certificate));
    
            if (appointmentTypeId == default)
                throw new ArgumentNullException(nameof(appointmentTypeId));
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/certificates/check?");
            urlBuilder.Append(Uri.EscapeDataString("certificate") + "=").Append(Uri.EscapeDataString(ConvertToString(certificate, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            urlBuilder.Append(Uri.EscapeDataString("appointmentTypeID") + "=").Append(Uri.EscapeDataString(ConvertToString(appointmentTypeId, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            if (email != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("email") + "=").Append(Uri.EscapeDataString(ConvertToString(email, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder.Length--;
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                request.Method = new System.Net.Http.HttpMethod("GET");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<Certificate>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        /// <summary>Get list of Clients</summary>
        /// <param name="search">Filter client list by first name, last name, phone number.</param>
        /// <returns>A single client result</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<Client> ListClientsAsync(string search = null)
        {
            return ListClientsAsync(System.Threading.CancellationToken.None, search);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get list of Clients</summary>
        /// <param name="search">Filter client list by first name, last name, phone number.</param>
        /// <returns>A single client result</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<Client> ListClientsAsync(System.Threading.CancellationToken cancellationToken, string search = null)
        {
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients?");
            if (search != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("search") + "=").Append(Uri.EscapeDataString(ConvertToString(search, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder.Length--;
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                request.Method = new System.Net.Http.HttpMethod("GET");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<Client>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        /// <summary>Update a current client</summary>
        /// <param name="firstName">Client first name</param>
        /// <param name="lastName">Client last name</param>
        /// <param name="phone">Client phone number</param>
        /// <param name="body">The fields to update</param>
        /// <returns>The updated client</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<Client> UpdateClientAsync(string firstName, string lastName, Client body, string phone = null)
        {
            return UpdateClientAsync(firstName, lastName, body, System.Threading.CancellationToken.None, phone);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Update a current client</summary>
        /// <param name="firstName">Client first name</param>
        /// <param name="lastName">Client last name</param>
        /// <param name="phone">Client phone number</param>
        /// <param name="body">The fields to update</param>
        /// <returns>The updated client</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<Client> UpdateClientAsync(string firstName, string lastName, Client body, System.Threading.CancellationToken cancellationToken, string phone = null)
        {
            if (firstName == null)
                throw new ArgumentNullException(nameof(firstName));
    
            if (lastName == null)
                throw new ArgumentNullException(nameof(lastName));
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients?");
            urlBuilder.Append(Uri.EscapeDataString("firstName") + "=").Append(Uri.EscapeDataString(ConvertToString(firstName, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            urlBuilder.Append(Uri.EscapeDataString("lastName") + "=").Append(Uri.EscapeDataString(ConvertToString(lastName, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            if (phone != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("phone") + "=").Append(Uri.EscapeDataString(ConvertToString(phone, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder.Length--;
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                var content = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new System.Net.Http.HttpMethod("PUT");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<Client>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        /// <returns>The newly created Client</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<Client> CreateClientAsync(Client body)
        {
            return CreateClientAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name="body"></param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The newly created Client</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<Client> CreateClientAsync(Client body, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients");
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                var content = new System.Net.Http.StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value));
                content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new System.Net.Http.HttpMethod("POST");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<Client>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        /// <summary>Delete an existing client</summary>
        /// <param name="firstName">Client first name</param>
        /// <param name="lastName">Client last name</param>
        /// <param name="phone">Client phone number</param>
        /// <returns>Client successfully deleted</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task DeleteClientAsync(string firstName, string lastName, string phone = null)
        {
            return DeleteClientAsync(firstName, lastName, System.Threading.CancellationToken.None, phone);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Delete an existing client</summary>
        /// <param name="firstName">Client first name</param>
        /// <param name="lastName">Client last name</param>
        /// <param name="phone">Client phone number</param>
        /// <returns>Client successfully deleted</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task DeleteClientAsync(string firstName, string lastName, System.Threading.CancellationToken cancellationToken, string phone = null)
        {
            if (firstName == null)
                throw new ArgumentNullException(nameof(firstName));
    
            if (lastName == null)
                throw new ArgumentNullException(nameof(lastName));
    
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/clients?");
            urlBuilder.Append(Uri.EscapeDataString("firstName") + "=").Append(Uri.EscapeDataString(ConvertToString(firstName, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            urlBuilder.Append(Uri.EscapeDataString("lastName") + "=").Append(Uri.EscapeDataString(ConvertToString(lastName, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            if (phone != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("phone") + "=").Append(Uri.EscapeDataString(ConvertToString(phone, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder.Length--;
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                request.Method = new System.Net.Http.HttpMethod("DELETE");
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    switch (status)
                    {
                        case "200":
                            return;
                        case "400":
                        {
                            var objectResponse = await ReadObjectResponseAsync<Error>(response, headers).ConfigureAwait(false);
                            throw new ApiException<Error>("Client does not exist", (int)response.StatusCode, objectResponse.Text, headers, objectResponse.Object, null);
                        }

                        default:
                        {
                            if (status != "200" && status != "204")
                            {
                                var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                                throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                            }

                            break;
                        }
                    }
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        /// <summary>Get basic account information</summary>
        /// <returns>basic account information</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<Me> GetMeAsync()
        {
            return GetMeAsync(System.Threading.CancellationToken.None);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get basic account information</summary>
        /// <returns>basic account information</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<Me> GetMeAsync(System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/me");
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                request.Method = new System.Net.Http.HttpMethod("GET");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<Me>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        /// <summary>Retrieves a list of orders from the online store with most recent first.</summary>
        /// <param name="max">maximum number of results</param>
        /// <returns>list of orders</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Order>> ListOrdersAsync(int? max = null)
        {
            return ListOrdersAsync(System.Threading.CancellationToken.None, max);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves a list of orders from the online store with most recent first.</summary>
        /// <param name="max">maximum number of results</param>
        /// <returns>list of orders</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Order>> ListOrdersAsync(System.Threading.CancellationToken cancellationToken, int? max = null)
        {
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/orders?");
            if (max != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("max") + "=").Append(Uri.EscapeDataString(ConvertToString(max, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder.Length--;
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                request.Method = new System.Net.Http.HttpMethod("GET");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<Order>>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        /// <summary>Get details about a single order by ID</summary>
        /// <returns>the requested Order</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<Order> GetOrderAsync(int id)
        {
            return GetOrderAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name="id"></param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get details about a single order by ID</summary>
        /// <returns>the requested Order</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<Order> GetOrderAsync(int id, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/orders/{id}");
            urlBuilder.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                request.Method = new System.Net.Http.HttpMethod("GET");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<Order>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        /// <summary>Get a list of products and packages.</summary>
        /// <param name="deleted">Retrieve deleted products.</param>
        /// <returns>list of products and packages</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Product>> ListProductsAsync(bool? deleted = null)
        {
            return ListProductsAsync(System.Threading.CancellationToken.None, deleted);
        }
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Get a list of products and packages.</summary>
        /// <param name="deleted">Retrieve deleted products.</param>
        /// <returns>list of products and packages</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Product>> ListProductsAsync(System.Threading.CancellationToken cancellationToken, bool? deleted = null)
        {
            var urlBuilder = new System.Text.StringBuilder();
            urlBuilder.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/products?");
            if (deleted != null) 
            {
                urlBuilder.Append(Uri.EscapeDataString("deleted") + "=").Append(Uri.EscapeDataString(ConvertToString(deleted, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder.Length--;
    
            var client = _httpClient;
            using (var request = new System.Net.Http.HttpRequestMessage())
            {
                request.Method = new System.Net.Http.HttpMethod("GET");
                request.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
    
                PrepareRequest(client, request, urlBuilder);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                PrepareRequest(client, request, url);
    
                var response = await client.SendAsync(request, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                try
                {
                    var headers = System.Linq.Enumerable.ToDictionary(response.Headers, h => h.Key, h => h.Value);
                    if (response.Content?.Headers != null)
                    {
                        foreach (var item in response.Content.Headers)
                            headers[item.Key] = item.Value;
                    }
    
                    ProcessResponse(client, response);
    
                    var status = ((int)response.StatusCode).ToString();
                    if (status == "200") 
                    {
                        var objectResponse = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<Product>>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }
                    else
                    if (status != "200" && status != "204")
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response.StatusCode + ").", (int)response.StatusCode, responseData, headers, null);
                    }
            
                    return default;
                }
                finally
                {
                    response?.Dispose();
                }
            }
        }
    
        protected struct ObjectResponseResult<T>
        {
            public ObjectResponseResult(T responseObject, string responseText)
            {
                Object = responseObject;
                Text = responseText;
            }
    
            public T Object { get; }
    
            public string Text { get; }
        }
    
        public bool ReadResponseAsString { get; set; }
        
        protected virtual async System.Threading.Tasks.Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(System.Net.Http.HttpResponseMessage response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers)
        {
            if (response?.Content == null)
            {
                return new ObjectResponseResult<T>(default, string.Empty);
            }
        
            if (ReadResponseAsString)
            {
                var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    var typedBody = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseText, JsonSerializerSettings);
                    return new ObjectResponseResult<T>(typedBody, responseText);
                }
                catch (Newtonsoft.Json.JsonException exception)
                {
                    var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
                }
            }

            try
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                using (var streamReader = new System.IO.StreamReader(responseStream))
                using (var jsonTextReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                {
                    var serializer = Newtonsoft.Json.JsonSerializer.Create(JsonSerializerSettings);
                    var typedBody = serializer.Deserialize<T>(jsonTextReader);
                    return new ObjectResponseResult<T>(typedBody, string.Empty);
                }
            }
            catch (Newtonsoft.Json.JsonException exception)
            {
                var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                throw new ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
            }
        }
    
        private static string ConvertToString(object value, IFormatProvider cultureInfo)
        {
            switch (value)
            {
                case Enum _:
                {
                    var name = Enum.GetName(value.GetType(), value);
                    if (name == null) return Convert.ToString(value, cultureInfo);
                    var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                    if (field == null) return Convert.ToString(value, cultureInfo);
                    if (System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(EnumMemberAttribute)) is EnumMemberAttribute attribute)
                    {
                        return attribute.Value ?? name;
                    }

                    break;
                }

                case bool _:
                    return Convert.ToString(value, cultureInfo)?.ToLowerInvariant();
                case byte[] bytes:
                    return Convert.ToBase64String(bytes);
                default:
                {
                    if (value != null && value.GetType().IsArray)
                    {
                        var array = System.Linq.Enumerable.OfType<object>((Array) value);
                        return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
                    }

                    break;
                }
            }

            return Convert.ToString(value, cultureInfo);
        }
    }
}