namespace AcuityScheduling.API.Models
{
    /// <summary>The root of the AppointmentCancellationRequest type's schema.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class AppointmentCancellationRequest 
    {
        /// <summary>A message to send with cancellation notifications</summary>
        [Newtonsoft.Json.JsonProperty("cancelNote", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CancelNote { get; set; }
    
        /// <summary>Whether the appointment was a no show, settable by admins.</summary>
        [Newtonsoft.Json.JsonProperty("noShow", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool NoShow { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}