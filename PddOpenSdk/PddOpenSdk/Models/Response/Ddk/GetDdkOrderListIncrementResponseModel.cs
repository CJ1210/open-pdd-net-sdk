using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public class OrderList
    {

        /// <summary>
        /// Examples: "180123-401424225280479", "180302-535304849920681"
        /// </summary>
        [JsonProperty("order_sn")]
        public string OrderSn { get; set; }

        /// <summary>
        /// Examples: 10071567, 623762
        /// </summary>
        [JsonProperty("goods_id")]
        public int GoodsId { get; set; }

        /// <summary>
        /// Examples: "话费优惠28", "黄山毛尖0"
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// Examples: "www.123.com"
        /// </summary>
        [JsonProperty("goods_thumbnail_url")]
        public string GoodsThumbnailUrl { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("goods_quantity")]
        public int GoodsQuantity { get; set; }

        /// <summary>
        /// Examples: 1, 0
        /// </summary>
        [JsonProperty("goods_price")]
        public int GoodsPrice { get; set; }

        /// <summary>
        /// Examples: 10000
        /// </summary>
        [JsonProperty("order_amount")]
        public int OrderAmount { get; set; }

        /// <summary>
        /// Examples: 1521184942
        /// </summary>
        [JsonProperty("order_create_time")]
        public int OrderCreateTime { get; set; }

        /// <summary>
        /// Examples: 1521184942
        /// </summary>
        [JsonProperty("order_receive_time")]
        public int OrderReceiveTime { get; set; }

        /// <summary>
        /// Examples: 1521475200
        /// </summary>
        [JsonProperty("order_verify_time")]
        public int OrderVerifyTime { get; set; }

        /// <summary>
        /// Examples: 1516695225
        /// </summary>
        [JsonProperty("order_pay_time")]
        public int OrderPayTime { get; set; }

        /// <summary>
        /// Examples: 50, 100
        /// </summary>
        [JsonProperty("promotion_rate")]
        public int PromotionRate { get; set; }

        /// <summary>
        /// Examples: 500, 1000
        /// </summary>
        [JsonProperty("promotion_amount")]
        public int PromotionAmount { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("order_status")]
        public int OrderStatus { get; set; }

        /// <summary>
        /// Examples: "已成团"
        /// </summary>
        [JsonProperty("order_status_desc")]
        public string OrderStatusDesc { get; set; }

        /// <summary>
        /// Examples: 1521184942
        /// </summary>
        [JsonProperty("order_group_success_time")]
        public int OrderGroupSuccessTime { get; set; }

        /// <summary>
        /// Examples: 1518161603, 1518075203
        /// </summary>
        [JsonProperty("order_modify_at")]
        public int OrderModifyAt { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// Examples: "60005_1"
        /// </summary>
        [JsonProperty("p_id")]
        public string PId { get; set; }
    }

    public class OrderListGetResponse
    {

        /// <summary>
        /// Examples: [{"order_sn":"180123-401424225280479","goods_id":10071567,"goods_name":"话费优惠28","goods_thumbnail_url":"www.123.com","goods_quantity":1,"goods_price":1,"order_amount":10000,"order_create_time":1521184942,"order_receive_time":1521184942,"order_verify_time":1521475200,"order_pay_time":1516695225,"promotion_rate":50,"promotion_amount":500,"order_status":1,"order_status_desc":"已成团","order_group_success_time":1521184942,"order_modify_at":1518161603,"type":1,"p_id":"60005_1"},{"order_sn":"180302-535304849920681","goods_id":623762,"goods_name":"黄山毛尖0","goods_thumbnail_url":"www.123.com","goods_quantity":1,"goods_price":0,"order_amount":10000,"order_create_time":1521184942,"order_receive_time":1521184942,"order_verify_time":1521475200,"promotion_rate":100,"promotion_amount":1000,"order_status":1,"order_status_desc":"已成团","order_group_success_time":1521184942,"order_modify_at":1518075203,"type":1,"p_id":"60005_1"}]
        /// </summary>
        [JsonProperty("order_list")]
        public IList<OrderList> OrderList { get; set; }

        /// <summary>
        /// Examples: 2
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class GetDdkOrderListIncrementResponseModel
    {

        /// <summary>
        /// Examples: {"order_list":[{"order_sn":"180123-401424225280479","goods_id":10071567,"goods_name":"话费优惠28","goods_thumbnail_url":"www.123.com","goods_quantity":1,"goods_price":1,"order_amount":10000,"order_create_time":1521184942,"order_receive_time":1521184942,"order_verify_time":1521475200,"order_pay_time":1516695225,"promotion_rate":50,"promotion_amount":500,"order_status":1,"order_status_desc":"已成团","order_group_success_time":1521184942,"order_modify_at":1518161603,"type":1,"p_id":"60005_1"},{"order_sn":"180302-535304849920681","goods_id":623762,"goods_name":"黄山毛尖0","goods_thumbnail_url":"www.123.com","goods_quantity":1,"goods_price":0,"order_amount":10000,"order_create_time":1521184942,"order_receive_time":1521184942,"order_verify_time":1521475200,"promotion_rate":100,"promotion_amount":1000,"order_status":1,"order_status_desc":"已成团","order_group_success_time":1521184942,"order_modify_at":1518075203,"type":1,"p_id":"60005_1"}],"total_count":2}
        /// </summary>
        [JsonProperty("order_list_get_response")]
        public OrderListGetResponse OrderListGetResponse { get; set; }
    }


}
