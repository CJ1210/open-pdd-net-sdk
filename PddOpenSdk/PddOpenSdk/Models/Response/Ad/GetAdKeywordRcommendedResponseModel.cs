using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public class RecommendedKeywordList
    {

        /// <summary>
        /// Examples: "胡"
        /// </summary>
        [JsonProperty("word")]
        public string Word { get; set; }

        /// <summary>
        /// Examples: 12306
        /// </summary>
        [JsonProperty("score")]
        public int Score { get; set; }

        /// <summary>
        /// Examples: 5
        /// </summary>
        [JsonProperty("relevance")]
        public int Relevance { get; set; }

        /// <summary>
        /// Examples: 4.4
        /// </summary>
        [JsonProperty("heat")]
        public double Heat { get; set; }

        /// <summary>
        /// Examples: 4.5
        /// </summary>
        [JsonProperty("trend")]
        public double Trend { get; set; }

        /// <summary>
        /// Examples: 4.6
        /// </summary>
        [JsonProperty("compete")]
        public double Compete { get; set; }

        /// <summary>
        /// Examples: 230.1
        /// </summary>
        [JsonProperty("avg_bid")]
        public double AvgBid { get; set; }
    }

    public class AdRecommendedKeywordListResponse
    {

        /// <summary>
        /// Examples: [{"word":"胡","score":12306,"relevance":5,"heat":4.4,"trend":4.5,"compete":4.6,"avg_bid":230.1}]
        /// </summary>
        [JsonProperty("recommended_keyword_list")]
        public IList<RecommendedKeywordList> RecommendedKeywordList { get; set; }
    }

    public class GetAdKeywordRcommendedResponseModel
    {

        /// <summary>
        /// Examples: {"recommended_keyword_list":[{"word":"胡","score":12306,"relevance":5,"heat":4.4,"trend":4.5,"compete":4.6,"avg_bid":230.1}]}
        /// </summary>
        [JsonProperty("ad_recommended_keyword_list_response")]
        public AdRecommendedKeywordListResponse AdRecommendedKeywordListResponse { get; set; }
    }


}
