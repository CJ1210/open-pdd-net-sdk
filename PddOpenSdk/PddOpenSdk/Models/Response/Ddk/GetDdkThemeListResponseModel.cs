using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public class ThemeList
    {

        /// <summary>
        /// Examples: 123, 124
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Examples: null, "http://pddtestimg.yangkeduo.com/test/2017-07-05/642d21666a693f478cd540fad4e4e855.jpeg"
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Examples: "个人主题活动测试2", "个人主题活动测试4"
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Examples: 9, 2
        /// </summary>
        [JsonProperty("goods_num")]
        public int GoodsNum { get; set; }
    }

    public class ThemeListGetResponse
    {

        /// <summary>
        /// Examples: 77
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// Examples: [{"id":123,"image_url":null,"name":"个人主题活动测试2","goods_num":9},{"id":124,"image_url":"http://pddtestimg.yangkeduo.com/test/2017-07-05/642d21666a693f478cd540fad4e4e855.jpeg","name":"个人主题活动测试4","goods_num":2}]
        /// </summary>
        [JsonProperty("theme_list")]
        public IList<ThemeList> ThemeList { get; set; }
    }

    public class GetDdkThemeListResponseModel
    {

        /// <summary>
        /// Examples: {"total":77,"theme_list":[{"id":123,"image_url":null,"name":"个人主题活动测试2","goods_num":9},{"id":124,"image_url":"http://pddtestimg.yangkeduo.com/test/2017-07-05/642d21666a693f478cd540fad4e4e855.jpeg","name":"个人主题活动测试4","goods_num":2}]}
        /// </summary>
        [JsonProperty("theme_list_get_response")]
        public ThemeListGetResponse ThemeListGetResponse { get; set; }
    }


}
