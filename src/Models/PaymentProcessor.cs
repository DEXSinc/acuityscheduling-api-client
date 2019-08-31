namespace AcuityScheduling.API.Models
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.23.0 (Newtonsoft.Json v10.0.0.0)")]
    public enum PaymentProcessor
    {
        [System.Runtime.Serialization.EnumMember(Value = @"stripe")]
        Stripe = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"paypal")]
        Paypal = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"paypal_pro")]
        Paypal_pro = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"braintree")]
        Braintree = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"authoriznet")]
        Authoriznet = 4,
    
    }
}