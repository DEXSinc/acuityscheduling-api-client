// ReSharper disable UnusedMember.Global
// ReSharper disable PartialTypeWithSinglePart
namespace AcuityScheduling.API.Models
{
    /// <summary>Update an appointment details from a white-list of updatable attributes.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class AppointmentPatch 
    {
        /// <summary>AcuityClient first name, may not be removed.</summary>
        [Newtonsoft.Json.JsonProperty("firstName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName { get; set; }
    
        /// <summary>AcuityClient last name, may not be removed.</summary>
        [Newtonsoft.Json.JsonProperty("lastName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName { get; set; }
    
        /// <summary>Package or coupon certificate code. May only be set by admins. Learn more about booking as an admin (https://developers.acuityscheduling.com/reference#section-updating-as-an-admin)</summary>
        [Newtonsoft.Json.JsonProperty("certificate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Certificate { get; set; }
    
        /// <summary>AcuityClient phone. May not be removed for clients depending on account settings, optional for admins.</summary>
        [Newtonsoft.Json.JsonProperty("phone", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Phone { get; set; }
    
        /// <summary>AcuityClient email. May not be removed for clients, optional for admins.</summary>
        [Newtonsoft.Json.JsonProperty("email", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Email { get; set; }
    
        /// <summary>May only be set by admins. Learn more about booking as an admin.</summary>
        [Newtonsoft.Json.JsonProperty("notes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Notes { get; set; }
    
        [Newtonsoft.Json.JsonProperty("fields", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<object> Fields { get; set; }
    
        [Newtonsoft.Json.JsonProperty("labels", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<object> Labels { get; set; }

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new System.Collections.Generic.Dictionary<string, object>();
    }
}