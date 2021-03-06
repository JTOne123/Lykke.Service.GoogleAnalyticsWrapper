// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Service.GoogleAnalyticsWrapper.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class WithdrawDepositEventModel
    {
        /// <summary>
        /// Initializes a new instance of the WithdrawDepositEventModel class.
        /// </summary>
        public WithdrawDepositEventModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WithdrawDepositEventModel class.
        /// </summary>
        public WithdrawDepositEventModel(double amount, string assetId = default(string), string userId = default(string), string ip = default(string), string userAgent = default(string), string clientInfo = default(string), System.DateTime? createdAt = default(System.DateTime?), string cid = default(string), string traffic = default(string))
        {
            Amount = amount;
            AssetId = assetId;
            UserId = userId;
            Ip = ip;
            UserAgent = userAgent;
            ClientInfo = clientInfo;
            CreatedAt = createdAt;
            Cid = cid;
            Traffic = traffic;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Amount")]
        public double Amount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssetId")]
        public string AssetId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserId")]
        public string UserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Ip")]
        public string Ip { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserAgent")]
        public string UserAgent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ClientInfo")]
        public string ClientInfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreatedAt")]
        public System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Cid")]
        public string Cid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Traffic")]
        public string Traffic { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
