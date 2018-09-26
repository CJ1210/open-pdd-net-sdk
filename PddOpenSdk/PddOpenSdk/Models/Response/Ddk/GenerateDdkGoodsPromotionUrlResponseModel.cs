using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public class GoodsPromotionUrlList
    {

        /// <summary>
        /// Examples: "http://m.hutaojie.com/xxx.html?goods_id=10060234&pid=81_1812886&t=8yOvLw9Qjf9MhoZd8MmOS457aKLZUvx_WWYosfUHsPE="
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Examples: "http://apiv2.hutaojie.com/api/d/dCBnwc"
        /// </summary>
        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }
    }

    public class GoodsPromotionUrlGenerateResponse
    {

        /// <summary>
        /// Examples: [{"url":"http://m.hutaojie.com/xxx.html?goods_id=10060234&pid=81_1812886&t=8yOvLw9Qjf9MhoZd8MmOS457aKLZUvx_WWYosfUHsPE=","short_url":"http://apiv2.hutaojie.com/api/d/dCBnwc"}]
        /// </summary>
        [JsonProperty("goods_promotion_url_list")]
        public IList<GoodsPromotionUrlList> GoodsPromotionUrlList { get; set; }
    }

    public class GenerateDdkGoodsPromotionUrlResponseModel
    {

        /// <summary>
        /// Examples: {"goods_promotion_url_list":[{"url":"http://m.hutaojie.com/xxx.html?goods_id=10060234&pid=81_1812886&t=8yOvLw9Qjf9MhoZd8MmOS457aKLZUvx_WWYosfUHsPE=","short_url":"http://apiv2.hutaojie.com/api/d/dCBnwc"}]}
        /// </summary>
        [JsonProperty("goods_promotion_url_generate_response")]
        public GoodsPromotionUrlGenerateResponse GoodsPromotionUrlGenerateResponse { get; set; }
    }


}
