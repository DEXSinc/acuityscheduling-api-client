namespace AcuityScheduling.API.Models
{
    /// <summary>Appointment Check Time Request</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class AppointmentCheckTimeRequest 
    {
        /// <summary>Required date and time to validate, parsed by strtotime in the business timezone</summary>
        [Newtonsoft.Json.JsonProperty("datetime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset Datetime { get; set; }
    
        /// <summary>Appointment type ID</summary>
        [Newtonsoft.Json.JsonProperty("appointmentTypeID", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int AppointmentTypeID { get; set; }
    
        /// <summary>Calendar ID. If not provided we'll check for any available calendar</summary>
        [Newtonsoft.Json.JsonProperty("calendarID", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int CalendarID { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}