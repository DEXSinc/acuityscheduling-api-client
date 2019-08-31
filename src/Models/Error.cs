namespace AcuityScheduling.API.Models
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v10.0.0.0)")]
    public partial class Error 
    {
        /// <summary>HTTP Status Code</summary>
        [Newtonsoft.Json.JsonProperty("status_code", Required = Newtonsoft.Json.Required.Always)]
        public long Status_code { get; set; }
    
        /// <summary>Internal Error Code</summary>
        [Newtonsoft.Json.JsonProperty("error", Required = Newtonsoft.Json.Required.Always)]
        public string Error1 { get; set; }
    
        /// <summary>Descriptive message about what went wrong (if possible)</summary>
        [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Message { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}