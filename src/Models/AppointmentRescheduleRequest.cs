namespace AcuityScheduling.API.Models
{
    /// <summary>The root of the AppointmentCancellationRequest type's schema.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class AppointmentRescheduleRequest 
    {
        /// <summary>Required date and time for the appointment, parsed by strtotime in the business timezone. (http://php.net/manual/en/function.strtotime.php)</summary>
        [Newtonsoft.Json.JsonProperty("datetime", Required = Newtonsoft.Json.Required.Always)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset Datetime { get; set; }
    
        /// <summary>Calendar ID to reschedule to. If not provided we'll leave the appointment on the same calendar. Submit null and we'll try to find an available calendar automatically.</summary>
        [Newtonsoft.Json.JsonProperty("calendarID", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int CalendarID { get; set; }
    
        /// <summary>Client timezone.</summary>
        [Newtonsoft.Json.JsonProperty("timezone", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Timezone { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}