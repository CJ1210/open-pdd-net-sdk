using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class SearchDdkThemeGoodsRequestModel : PddRequestModel
    {
        /// <summary>
        /// 该值为:pdd.ddk.theme.goods.search
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// 主题ID
        /// </summary>
        [JsonProperty("theme_id")]
        public int ThemeId { get; set; }

    }

}
