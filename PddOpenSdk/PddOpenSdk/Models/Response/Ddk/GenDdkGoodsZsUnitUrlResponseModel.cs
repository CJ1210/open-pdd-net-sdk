using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public class GoodsZsUnitGenerateResponse
    {

        /// <summary>
        /// Examples: "https://mobile.yangkeduo.com/duo_coupon_landing.html?goods_id=31336303&pid=1891141_23347637&cpsSign=CC8a292c67c7ca5204f8cdcb00af1c9e2a&duoduo_type=2"
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Examples: "https://a.toutiaonanren.com/api/d/y8nijT"
        /// </summary>
        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        /// <summary>
        /// Examples: "https://mobile.yangkeduo.com/app.html?launch_url=duo_coupon_landing.html?goods_id=31336303&pid=1891141_23347637&cpsSign=CC8a292c67c7ca5204f8cdcb00af1c9e2a&duoduo_type=2"
        /// </summary>
        [JsonProperty("mobile_url")]
        public string MobileUrl { get; set; }

        /// <summary>
        /// Examples: "https://a.toutiaonanren.com/api/d/y8nijU"
        /// </summary>
        [JsonProperty("mobile_short_url")]
        public string MobileShortUrl { get; set; }

        /// <summary>
        /// Examples: "https://mobile.yangkeduo.com/duo_coupon_landing.html?goods_id=31336303&pid=1891141_23347637&cpsSign=CC8a292c67c7ca5204f8cdcb00af1c9e2a&duoduo_type=3"
        /// </summary>
        [JsonProperty("multi_group_url")]
        public string MultiGroupUrl { get; set; }

        /// <summary>
        /// Examples: "https://a.toutiaonanren.com/api/d/y8nijW"
        /// </summary>
        [JsonProperty("multi_group_short_url")]
        public string MultiGroupShortUrl { get; set; }

        /// <summary>
        /// Examples: "https://mobile.yangkeduo.com/app.html?launch_url=duo_coupon_landing.html?goods_id=31336303&pid=1891141_23347637&cpsSign=CC8a292c67c7ca5204f8cdcb00af1c9e2a&duoduo_type=3"
        /// </summary>
        [JsonProperty("multi_group_mobile_url")]
        public string MultiGroupMobileUrl { get; set; }

        /// <summary>
        /// Examples: "https://a.toutiaonanren.com/api/d/y8niIp"
        /// </summary>
        [JsonProperty("multi_group_mobile_short_url")]
        public string MultiGroupMobileShortUrl { get; set; }
    }

    public class GenDdkGoodsZsUnitUrlResponseModel
    {

        /// <summary>
        /// Examples: {"url":"https://mobile.yangkeduo.com/duo_coupon_landing.html?goods_id=31336303&pid=1891141_23347637&cpsSign=CC8a292c67c7ca5204f8cdcb00af1c9e2a&duoduo_type=2","short_url":"https://a.toutiaonanren.com/api/d/y8nijT","mobile_url":"https://mobile.yangkeduo.com/app.html?launch_url=duo_coupon_landing.html?goods_id=31336303&pid=1891141_23347637&cpsSign=CC8a292c67c7ca5204f8cdcb00af1c9e2a&duoduo_type=2","mobile_short_url":"https://a.toutiaonanren.com/api/d/y8nijU","multi_group_url":"https://mobile.yangkeduo.com/duo_coupon_landing.html?goods_id=31336303&pid=1891141_23347637&cpsSign=CC8a292c67c7ca5204f8cdcb00af1c9e2a&duoduo_type=3","multi_group_short_url":"https://a.toutiaonanren.com/api/d/y8nijW","multi_group_mobile_url":"https://mobile.yangkeduo.com/app.html?launch_url=duo_coupon_landing.html?goods_id=31336303&pid=1891141_23347637&cpsSign=CC8a292c67c7ca5204f8cdcb00af1c9e2a&duoduo_type=3","multi_group_mobile_short_url":"https://a.toutiaonanren.com/api/d/y8niIp"}
        /// </summary>
        [JsonProperty("goods_zs_unit_generate_response")]
        public GoodsZsUnitGenerateResponse GoodsZsUnitGenerateResponse { get; set; }
    }


}
