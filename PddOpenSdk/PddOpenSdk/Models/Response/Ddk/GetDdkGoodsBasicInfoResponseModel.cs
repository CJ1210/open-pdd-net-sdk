using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public class GoodsList
    {

        /// <summary>
        /// Examples: 10073705
        /// </summary>
        [JsonProperty("goods_id")]
        public int GoodsId { get; set; }

        /// <summary>
        /// Examples: 1300
        /// </summary>
        [JsonProperty("min_normal_price")]
        public int MinNormalPrice { get; set; }

        /// <summary>
        /// Examples: 590
        /// </summary>
        [JsonProperty("min_group_price")]
        public int MinGroupPrice { get; set; }

        /// <summary>
        /// Examples: "http://pddtestimg.yangkeduo.com/test/2017-09-19/ef972ed0e60279164d8fbea31515e238.jpeg"
        /// </summary>
        [JsonProperty("goods_pic")]
        public string GoodsPic { get; set; }

        /// <summary>
        /// Examples: "商品锁定10"
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("goods_type")]
        public int GoodsType { get; set; }
    }

    public class GoodsBasicDetailResponse
    {

        /// <summary>
        /// Examples: [{"goods_id":10073705,"min_normal_price":1300,"min_group_price":590,"goods_pic":"http://pddtestimg.yangkeduo.com/test/2017-09-19/ef972ed0e60279164d8fbea31515e238.jpeg","goods_name":"商品锁定10","goods_type":1}]
        /// </summary>
        [JsonProperty("goods_list")]
        public IList<GoodsList> GoodsList { get; set; }
    }

    public class GetDdkGoodsBasicInfoResponseModel
    {

        /// <summary>
        /// Examples: {"goods_list":[{"goods_id":10073705,"min_normal_price":1300,"min_group_price":590,"goods_pic":"http://pddtestimg.yangkeduo.com/test/2017-09-19/ef972ed0e60279164d8fbea31515e238.jpeg","goods_name":"商品锁定10","goods_type":1}]}
        /// </summary>
        [JsonProperty("goods_basic_detail_response")]
        public GoodsBasicDetailResponse GoodsBasicDetailResponse { get; set; }
    }


}
