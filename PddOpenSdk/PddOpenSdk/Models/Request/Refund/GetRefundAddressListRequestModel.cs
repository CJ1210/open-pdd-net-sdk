using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Refund
{
    public partial class GetRefundAddressListRequestModel : PddRequestModel
    {
        /// <summary>
        /// 该值为：pdd.refund.address.list.get
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

    }

}
