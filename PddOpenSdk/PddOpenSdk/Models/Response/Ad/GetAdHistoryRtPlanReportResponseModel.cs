using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public class PlanRealTimeReportList
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
        /// Examples: 2236482
        /// </summary>
        [JsonProperty("plan_id")]
        public int PlanId { get; set; }

        /// <summary>
        /// Examples: "计划-搜索1-改"
        /// </summary>
        [JsonProperty("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// Examples: 1000000000
        /// </summary>
        [JsonProperty("max_cost")]
        public int MaxCost { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("operate_status")]
        public int OperateStatus { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("account_status")]
        public int AccountStatus { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("is_deleted")]
        public object IsDeleted { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("ad_unit_num")]
        public object AdUnitNum { get; set; }
    }

    public class AdPlanRealTimeReportResponse
    {

        /// <summary>
        /// Examples: [{"impression":0,"click":0,"ctr":0,"spend":0,"cpc":0,"order_num":0,"gmv":0,"roi":0,"cpm":null,"plan_id":2236482,"plan_name":"计划-搜索1-改","max_cost":1000000000,"operate_status":1,"account_status":1,"status":1,"is_deleted":null,"ad_unit_num":null}]
        /// </summary>
        [JsonProperty("plan_real_time_report_list")]
        public IList<PlanRealTimeReportList> PlanRealTimeReportList { get; set; }
    }

    public class GetAdHistoryRtPlanReportResponseModel
    {

        /// <summary>
        /// Examples: {"plan_real_time_report_list":[{"impression":0,"click":0,"ctr":0,"spend":0,"cpc":0,"order_num":0,"gmv":0,"roi":0,"cpm":null,"plan_id":2236482,"plan_name":"计划-搜索1-改","max_cost":1000000000,"operate_status":1,"account_status":1,"status":1,"is_deleted":null,"ad_unit_num":null}]}
        /// </summary>
        [JsonProperty("ad_plan_real_time_report_response")]
        public AdPlanRealTimeReportResponse AdPlanRealTimeReportResponse { get; set; }
    }


}
