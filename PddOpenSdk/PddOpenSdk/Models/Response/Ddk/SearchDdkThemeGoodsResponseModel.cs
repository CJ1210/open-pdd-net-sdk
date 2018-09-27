using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public class DdkThemeGoodsList
    {

        /// <summary>
        /// Examples: 10071886
        /// </summary>
        [JsonProperty("goods_id")]
        public int GoodsId { get; set; }

        /// <summary>
        /// Examples: "企业海淘"
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("goods_desc")]
        public object GoodsDesc { get; set; }

        /// <summary>
        /// Examples: "http://pddtestimg.yangkeduo.com/test/2017-12-30/4148a9a51cc9a37cfa11325646134d77.jpeg"
        /// </summary>
        [JsonProperty("goods_thumbnail_url")]
        public string GoodsThumbnailUrl { get; set; }

        /// <summary>
        /// Examples: ""
        /// </summary>
        [JsonProperty("goods_image_url")]
        public string GoodsImageUrl { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("goods_gallery_urls")]
        public object GoodsGalleryUrls { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("sold_quantity")]
        public int SoldQuantity { get; set; }

        /// <summary>
        /// Examples: 2300
        /// </summary>
        [JsonProperty("min_group_price")]
        public int MinGroupPrice { get; set; }

        /// <summary>
        /// Examples: 4400
        /// </summary>
        [JsonProperty("min_normal_price")]
        public int MinNormalPrice { get; set; }

        /// <summary>
        /// Examples: "刚刚哈哈哈"
        /// </summary>
        [JsonProperty("mall_name")]
        public string MallName { get; set; }

        /// <summary>
        /// Examples: 18
        /// </summary>
        [JsonProperty("category_id")]
        public int CategoryId { get; set; }

        /// <summary>
        /// Examples: "电器"
        /// </summary>
        [JsonProperty("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// Examples: 18
        /// </summary>
        [JsonProperty("opt_id")]
        public int OptId { get; set; }

        /// <summary>
        /// Examples: "电器"
        /// </summary>
        [JsonProperty("opt_name")]
        public string OptName { get; set; }

        /// <summary>
        /// Examples: [194,2578,2580,0]
        /// </summary>
        [JsonProperty("cat_ids")]
        public IList<int> CatIds { get; set; }

        /// <summary>
        /// Examples: false
        /// </summary>
        [JsonProperty("has_coupon")]
        public bool HasCoupon { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("coupon_min_order_amount")]
        public int CouponMinOrderAmount { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("coupon_discount")]
        public int CouponDiscount { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("coupon_total_quantity")]
        public int CouponTotalQuantity { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("coupon_remain_quantity")]
        public int CouponRemainQuantity { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("coupon_start_time")]
        public int CouponStartTime { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("coupon_end_time")]
        public int CouponEndTime { get; set; }

        /// <summary>
        /// Examples: 100
        /// </summary>
        [JsonProperty("promotion_rate")]
        public int PromotionRate { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("goods_eval_score")]
        public int GoodsEvalScore { get; set; }

        /// <summary>
        /// Examples: 0
        /// </summary>
        [JsonProperty("goods_eval_count")]
        public int GoodsEvalCount { get; set; }

        /// <summary>
        /// Examples: null
        /// </summary>
        [JsonProperty("cat_id")]
        public object CatId { get; set; }
    }

    public class DdkThemeListGetResponse
    {

        /// <summary>
        /// Examples: 2
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// Examples: [{"goods_id":10071886,"goods_name":"企业海淘","goods_desc":null,"goods_thumbnail_url":"http://pddtestimg.yangkeduo.com/test/2017-12-30/4148a9a51cc9a37cfa11325646134d77.jpeg","goods_image_url":"","goods_gallery_urls":null,"sold_quantity":0,"min_group_price":2300,"min_normal_price":4400,"mall_name":"刚刚哈哈哈","category_id":18,"category_name":"电器","opt_id":18,"opt_name":"电器","cat_ids":[194,2578,2580,0],"has_coupon":false,"coupon_min_order_amount":0,"coupon_discount":0,"coupon_total_quantity":0,"coupon_remain_quantity":0,"coupon_start_time":0,"coupon_end_time":0,"promotion_rate":100,"goods_eval_score":0,"goods_eval_count":0,"cat_id":null}]
        /// </summary>
        [JsonProperty("goods_list")]
        public IList<DdkThemeGoodsList> GoodsList { get; set; }
    }

    public class SearchDdkThemeGoodsResponseModel
    {

        /// <summary>
        /// Examples: {"total":2,"goods_list":[{"goods_id":10071886,"goods_name":"企业海淘","goods_desc":null,"goods_thumbnail_url":"http://pddtestimg.yangkeduo.com/test/2017-12-30/4148a9a51cc9a37cfa11325646134d77.jpeg","goods_image_url":"","goods_gallery_urls":null,"sold_quantity":0,"min_group_price":2300,"min_normal_price":4400,"mall_name":"刚刚哈哈哈","category_id":18,"category_name":"电器","opt_id":18,"opt_name":"电器","cat_ids":[194,2578,2580,0],"has_coupon":false,"coupon_min_order_amount":0,"coupon_discount":0,"coupon_total_quantity":0,"coupon_remain_quantity":0,"coupon_start_time":0,"coupon_end_time":0,"promotion_rate":100,"goods_eval_score":0,"goods_eval_count":0,"cat_id":null}]}
        /// </summary>
        [JsonProperty("theme_list_get_response")]
        public DdkThemeListGetResponse ThemeListGetResponse { get; set; }
    }


}
