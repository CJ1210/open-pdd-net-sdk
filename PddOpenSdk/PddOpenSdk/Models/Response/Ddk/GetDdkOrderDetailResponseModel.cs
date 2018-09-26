using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public class OrderDetailResponse
    {

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("order_sn")]
        public object OrderSn { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("goods_id")]
        public object GoodsId { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("goods_name")]
        public object GoodsName { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("goods_thumbnail_url")]
        public object GoodsThumbnailUrl { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("goods_quantity")]
        public object GoodsQuantity { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("goods_price")]
        public object GoodsPrice { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("order_amount")]
        public object OrderAmount { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("promotion_rate")]
        public object PromotionRate { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("promotion_amount")]
        public object PromotionAmount { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("batch_no")]
        public object BatchNo { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("order_status")]
        public object OrderStatus { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("order_status_desc")]
        public object OrderStatusDesc { get; set; }

        /// <summary>
        /// Examples: 1535546872
        /// </summary>
        [JsonProperty("order_create_time")]
        public int OrderCreateTime { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("order_pay_time")]
        public object OrderPayTime { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("order_group_success_time")]
        public object OrderGroupSuccessTime { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("order_receive_time")]
        public object OrderReceiveTime { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("order_verify_time")]
        public object OrderVerifyTime { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("order_settle_time")]
        public object OrderSettleTime { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("order_modify_at")]
        public object OrderModifyAt { get; set; }

        /// <summary>
        /// Examples: 5
        /// </summary>
        [JsonProperty("match_channel")]
        public int MatchChannel { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("group_id")]
        public object GroupId { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("auth_duo_id")]
        public object AuthDuoId { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("zs_duo_id")]
        public object ZsDuoId { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("custom_parameters")]
        public object CustomParameters { get; set; }

        /// <summary>
        /// Examples: "CC210035_735_12b26d652b895c8ae77a8a0b7553919b"
        /// </summary>
        [JsonProperty("cps_sign")]
        public string CpsSign { get; set; }

        /// <summary>
        /// Examples: 1535618102
        /// </summary>
        [JsonProperty("url_last_generate_time")]
        public int UrlLastGenerateTime { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("point_time")]
        public object PointTime { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("return_status")]
        public object ReturnStatus { get; set; }

        /// <summary>
        /// Examples: "210035_735"
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }
    }

    public class GetDdkOrderDetailResponseModel
    {

        /// <summary>
        /// Examples: {"order_sn":null,"goods_id":null,"goods_name":null,"goods_thumbnail_url":null,"goods_quantity":null,"goods_price":null,"order_amount":null,"promotion_rate":null,"promotion_amount":null,"batch_no":null,"order_status":null,"order_status_desc":null,"order_create_time":1535546872,"order_pay_time":null,"order_group_success_time":null,"order_receive_time":null,"order_verify_time":null,"order_settle_time":null,"order_modify_at":null,"match_channel":5,"type":0,"group_id":null,"auth_duo_id":null,"zs_duo_id":null,"custom_parameters":null,"cps_sign":"CC210035_735_12b26d652b895c8ae77a8a0b7553919b","url_last_generate_time":1535618102,"point_time":null,"return_status":null,"pid":"210035_735"}
        /// </summary>
        [JsonProperty("order_detail_response")]
        public OrderDetailResponse OrderDetailResponse { get; set; }
    }


}
