namespace AcuityScheduling.API.Models
{
    /// <summary>Appointment Check Time Result</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class AppointmentCheckTimeResult 
    {
        /// <summary>date and time validated, in the business timezone</summary>
        [Newtonsoft.Json.JsonProperty("datetime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset Datetime { get; set; }
    
        /// <summary>Appointment type ID</summary>
        [Newtonsoft.Json.JsonProperty("appointmentTypeID", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int AppointmentTypeID { get; set; }
    
        /// <summary>Calendar ID</summary>
        [Newtonsoft.Json.JsonProperty("calendarID", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int CalendarID { get; set; }
    
        /// <summary>Validation result</summary>
        [Newtonsoft.Json.JsonProperty("valid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Valid { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}