using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public class UnitRealTimeReportList
    {

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("impression")]
        public int Impression { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("click")]
        public int Click { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("ctr")]
        public int Ctr { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("spend")]
        public int Spend { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("cpc")]
        public int Cpc { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("order_num")]
        public int OrderNum { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("gmv")]
        public int Gmv { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("roi")]
        public int Roi { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("cpm")]
        public object Cpm { get; set; }

        /// <summary>
        /// Examples: 5949471
        /// </summary>
        [JsonProperty("unit_id")]
        public int UnitId { get; set; }

        /// <summary>
        /// Examples: 2236482
        /// </summary>
        [JsonProperty("plan_id")]
        public int PlanId { get; set; }

        /// <summary>
        /// Examples: 10088079
        /// </summary>
        [JsonProperty("goods_id")]
        public int GoodsId { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("operate_status")]
        public int OperateStatus { get; set; }

        /// <summary>
        /// Examples: "测试新增商品测试新增商品测试新增商品测试新增198"
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// Examples: "http://pddtestimg.yangkeduo.com/test/2018-06-08/5d8328338f9725693ea93e1555188f29.jpeg"
        /// </summary>
        [JsonProperty("thumb_url")]
        public string ThumbUrl { get; set; }

        /// <summary>
        /// Examples: 80000
        /// </summary>
        [JsonProperty("min_group_price")]
        public int MinGroupPrice { get; set; }

        /// <summary>
        /// Examples: 80000
        /// </summary>
        [JsonProperty("max_group_price")]
        public int MaxGroupPrice { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }
    }

    public class AdUnitRealTimeReportResponse
    {

        /// <summary>
        /// Examples: [{"impression":0,"click":0,"ctr":0,"spend":0,"cpc":0,"order_num":0,"gmv":0,"roi":0,"cpm":null,"unit_id":5949471,"plan_id":2236482,"goods_id":10088079,"operate_status":1,"goods_name":"测试新增商品测试新增商品测试新增商品测试新增198","thumb_url":"http://pddtestimg.yangkeduo.com/test/2018-06-08/5d8328338f9725693ea93e1555188f29.jpeg","min_group_price":80000,"max_group_price":80000,"status":1}]
        /// </summary>
        [JsonProperty("unit_real_time_report_list")]
        public IList<UnitRealTimeReportList> UnitRealTimeReportList { get; set; }
    }

    public class GetAdHistoryRtUnitReportResponseModel
    {

        /// <summary>
        /// Examples: {"unit_real_time_report_list":[{"impression":0,"click":0,"ctr":0,"spend":0,"cpc":0,"order_num":0,"gmv":0,"roi":0,"cpm":null,"unit_id":5949471,"plan_id":2236482,"goods_id":10088079,"operate_status":1,"goods_name":"测试新增商品测试新增商品测试新增商品测试新增198","thumb_url":"http://pddtestimg.yangkeduo.com/test/2018-06-08/5d8328338f9725693ea93e1555188f29.jpeg","min_group_price":80000,"max_group_price":80000,"status":1}]}
        /// </summary>
        [JsonProperty("ad_unit_real_time_report_response")]
        public AdUnitRealTimeReportResponse AdUnitRealTimeReportResponse { get; set; }
    }


}
