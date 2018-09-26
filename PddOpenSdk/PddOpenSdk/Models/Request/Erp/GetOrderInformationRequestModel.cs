using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Erp
{
    public partial class GetOrderInformationRequestModel : PddRequestModel
    {
        /// <summary>
        /// 该值为：pdd.order.information.get
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }

    }

}
