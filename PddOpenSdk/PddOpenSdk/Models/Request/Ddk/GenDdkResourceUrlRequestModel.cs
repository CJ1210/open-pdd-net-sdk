using Newtonsoft.Json;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class GenDdkResourceUrlRequestModel : PddRequestModel
    {
        /// <summary>
        /// 推广位
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }
        /// <summary>
        /// 频道来源：4-限时秒杀；39997-充值中心；
        /// </summary>
        [JsonProperty("resource_type")]
        public int? ResourceType { get; set; }

    }

}
