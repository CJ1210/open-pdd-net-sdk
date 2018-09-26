using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public class AdMallRealTimeReportResponse
    {

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("ad_impr_num")]
        public int AdImprNum { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("ad_clk_num")]
        public int AdClkNum { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("spend")]
        public int Spend { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("pay_order_num")]
        public int PayOrderNum { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("pay_gmv")]
        public int PayGmv { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("roi")]
        public int Roi { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("click_rate")]
        public int ClickRate { get; set; }
    }

    public class GetAdHistoryRtReportResponseModel
    {

        /// <summary>
        /// Examples: {"ad_impr_num":0,"ad_clk_num":0,"spend":0,"pay_order_num":0,"pay_gmv":0,"roi":0,"click_rate":0}
        /// </summary>
        [JsonProperty("ad_mall_real_time_report_response")]
        public AdMallRealTimeReportResponse AdMallRealTimeReportResponse { get; set; }
    }


}
