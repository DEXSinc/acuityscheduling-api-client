// ReSharper disable PartialTypeWithSinglePart
namespace AcuityScheduling.API.Models
{
    /// <summary>The root of the AppointmentCreationRequest type's schema.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class AppointmentCreationRequest 
    {
        /// <summary>Required date and time for the appointment, parsed by strtotime in the business timezone. (http://php.net/manual/en/function.strtotime.php)</summary>
        [Newtonsoft.Json.JsonProperty("datetime", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset Datetime { get; set; }
    
        /// <summary>Appointment type id.</summary>
        [Newtonsoft.Json.JsonProperty("appointmentTypeID", Required = Newtonsoft.Json.Required.Always)]
        public int AppointmentTypeId { get; set; }
    
        /// <summary>AcuityClient first name.</summary>
        [Newtonsoft.Json.JsonProperty("firstName", Required = Newtonsoft.Json.Required.Always)]
        public string FirstName { get; set; }
    
        /// <summary>AcuityClient last name.</summary>
        [Newtonsoft.Json.JsonProperty("lastName", Required = Newtonsoft.Json.Required.Always)]
        public string LastName { get; set; }
    
        /// <summary>AcuityClient e-mail address. Optional for admins.</summary>
        [Newtonsoft.Json.JsonProperty("email", Required = Newtonsoft.Json.Required.Always)]
        public string Email { get; set; }
    
        /// <summary>Package or coupon certificate code.</summary>
        [Newtonsoft.Json.JsonProperty("certificate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Certificate { get; set; }
    
        /// <summary>A special field for setting form field values.</summary>
        [Newtonsoft.Json.JsonProperty("fields", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<object> Fields { get; set; }
    
        /// <summary>An array of label objects. Currently only accepts an array of length 1.</summary>
        [Newtonsoft.Json.JsonProperty("labels", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Label> Labels { get; set; }
    
        /// <summary>AcuityClient timezone.</summary>
        [Newtonsoft.Json.JsonProperty("timezone", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Timezone { get; set; }
    
        /// <summary>Settable when booking as an admin.</summary>
        [Newtonsoft.Json.JsonProperty("notes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Notes { get; set; }
    
        /// <summary>By default appointments are created as if they are being booked by a client. Booking as an admin disables availability and attribute validations, and allows setting the notes attribute. To book as an admin pass the query parameter admin=true.</summary>
        [Newtonsoft.Json.JsonProperty("admin", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Admin { get; set; }

        [Newtonsoft.Json.JsonExtensionData]
        // ReSharper disable once UnusedMember.Global
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new System.Collections.Generic.Dictionary<string, object>();
    }
}