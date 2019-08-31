namespace AcuityScheduling.API.Models
{
    /// <summary>Class</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class Class 
    {
        /// <summary>the class ID</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id { get; set; }
    
        /// <summary>the ID of the appointment type of the class offering</summary>
        [Newtonsoft.Json.JsonProperty("appointmentTypeID", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int AppointmentTypeID { get; set; }
    
        /// <summary>the ID of the calendar the class is offered on</summary>
        [Newtonsoft.Json.JsonProperty("calendarID", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int CalendarID { get; set; }
    
        /// <summary>the name of the appointment type</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        /// <summary>the time of the class offering</summary>
        [Newtonsoft.Json.JsonProperty("time", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset Time { get; set; }
    
        /// <summary>the name of the calendar</summary>
        [Newtonsoft.Json.JsonProperty("calendar", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Calendar { get; set; }
    
        /// <summary>the duration of the class in minutes</summary>
        [Newtonsoft.Json.JsonProperty("duration", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Duration { get; set; }
    
        /// <summary>whether or not the class is a series (a series is a class which the client should book all times offered)</summary>
        [Newtonsoft.Json.JsonProperty("isSeries", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool IsSeries { get; set; }
    
        /// <summary>the maximum number of attendees in the class</summary>
        [Newtonsoft.Json.JsonProperty("slots", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Slots { get; set; }
    
        /// <summary>the remaining slots still available</summary>
        [Newtonsoft.Json.JsonProperty("slotsAvailable", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int SlotsAvailable { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}