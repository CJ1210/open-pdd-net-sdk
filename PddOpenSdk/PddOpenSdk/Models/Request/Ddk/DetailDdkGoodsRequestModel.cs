using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class DetailDdkGoodsRequestModel : PddRequestModel
    {
        /// <summary>
        /// 该值为：pdd.ddk.goods.detail
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// 商品ID，仅支持单个查询。例如：[123456]
        /// </summary>
        [JsonProperty("goods_id_list")]
        public string GoodsIdList { get; set; }

    }

}
