using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ddk
{
    public class GoodsDetail
    {

        /// <summary>
        /// Examples: 545922677
        /// </summary>
        [JsonProperty("goods_id")]
        public int GoodsId { get; set; }

        /// <summary>
        /// Examples: "【百草味-夏威夷果150g/300g/多规格可选】 送开口器牛皮纸袋内!"
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// Examples: "【百草味-夏威夷果100g/300g多规格可选】坚果零食干果炒货 奶油味送开口器牛皮纸袋内!  我们的夏威夷果奶香四溢，酥脆爽滑，坚果中的皇后。每袋都附有开果器的!!!附在牛皮纸袋内部!!您收货后仔细找找就能发现了呢。（使用小窍门：您可以把开果器插在果果的裂缝处，然后插深一些，再转一下，这样比较好开哦）"
        /// </summary>
        [JsonProperty("goods_desc")]
        public string GoodsDesc { get; set; }

        /// <summary>
        /// Examples: "http://omsproductionimg.yangkeduo.com/images/2017-11-28/34eba02f3c71f5a269e64e9042d9950d.jpeg"
        /// </summary>
        [JsonProperty("goods_thumbnail_url")]
        public string GoodsThumbnailUrl { get; set; }

        /// <summary>
        /// Examples: "http://omsproductionimg.yangkeduo.com/images/2017-10-17/0b7bca0ff9378f573337f6fb8f0448a8.jpeg"
        /// </summary>
        [JsonProperty("goods_image_url")]
        public string GoodsImageUrl { get; set; }

        /// <summary>
        /// Examples: ["http://omsproductionimg.yangkeduo.com/images/2017-11-28/b8ff55a74b615d06b91bd6a8785f739a.jpeg","http://t04img.yangkeduo.com/images/2018-04-08/04c90c1db3e618eeb7d3b681a53fdfcf.jpeg","http://omsproductionimg.yangkeduo.com/images/2017-10-17/3986d8258d16b4c74e56c2629f41a299.jpeg","http://t08img.yangkeduo.com/images/2018-04-08/8699ad96bfe31e7e39dbf7d233106f91.jpeg","http://t03img.yangkeduo.com/images/2018-04-08/fe4aa08cbc1f6c9a88bb00f66ab86636.jpeg"]
        /// </summary>
        [JsonProperty("goods_gallery_urls")]
        public IList<string> GoodsGalleryUrls { get; set; }

        /// <summary>
        /// Examples: 92
        /// </summary>
        [JsonProperty("sold_quantity")]
        public int SoldQuantity { get; set; }

        /// <summary>
        /// Examples: 1990
        /// </summary>
        [JsonProperty("min_group_price")]
        public int MinGroupPrice { get; set; }

        /// <summary>
        /// Examples: 2990
        /// </summary>
        [JsonProperty("min_normal_price")]
        public int MinNormalPrice { get; set; }

        /// <summary>
        /// Examples: "百草味旗舰店"
        /// </summary>
        [JsonProperty("mall_name")]
        public string MallName { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("category_id")]
        public int CategoryId { get; set; }

        /// <summary>
        /// Examples: "美食"
        /// </summary>
        [JsonProperty("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// Examples: 1
        /// </summary>
        [JsonProperty("opt_id")]
        public int OptId { get; set; }

        /// <summary>
        /// Examples: "美食"
        /// </summary>
        [JsonProperty("opt_name")]
        public string OptName { get; set; }

        /// <summary>
        /// Examples: [2,65,4,0]
        /// </summary>
        [JsonProperty("cat_ids")]
        public IList<int> CatIds { get; set; }

        /// <summary>
        /// Examples: true
        /// </summary>
        [JsonProperty("has_coupon")]
        public bool HasCoupon { get; set; }

        /// <summary>
        /// Examples: 300
        /// </summary>
        [JsonProperty("coupon_min_order_amount")]
        public int CouponMinOrderAmount { get; set; }

        /// <summary>
        /// Examples: 300
        /// </summary>
        [JsonProperty("coupon_discount")]
        public int CouponDiscount { get; set; }

        /// <summary>
        /// Examples: 50000
        /// </summary>
        [JsonProperty("coupon_total_quantity")]
        public int CouponTotalQuantity { get; set; }

        /// <summary>
        /// Examples: 49940
        /// </summary>
        [JsonProperty("coupon_remain_quantity")]
        public int CouponRemainQuantity { get; set; }

        /// <summary>
        /// Examples: 1525536000
        /// </summary>
        [JsonProperty("coupon_start_time")]
        public int CouponStartTime { get; set; }

        /// <summary>
        /// Examples: 1525967999
        /// </summary>
        [JsonProperty("coupon_end_time")]
        public int CouponEndTime { get; set; }

        /// <summary>
        /// Examples: 150
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

        /// <summary>
        /// Examples: 494
        /// </summary>
        [JsonProperty("avg_desc")]
        public int AvgDesc { get; set; }

        /// <summary>
        /// Examples: 494
        /// </summary>
        [JsonProperty("avg_lgst")]
        public int AvgLgst { get; set; }

        /// <summary>
        /// Examples: 494
        /// </summary>
        [JsonProperty("avg_serv")]
        public int AvgServ { get; set; }
    }

    public class GoodsDetailResponse
    {

        /// <summary>
        /// Examples: [{"goods_id":545922677,"goods_name":"【百草味-夏威夷果150g/300g/多规格可选】 送开口器牛皮纸袋内!","goods_desc":"【百草味-夏威夷果100g/300g多规格可选】坚果零食干果炒货 奶油味送开口器牛皮纸袋内!  我们的夏威夷果奶香四溢，酥脆爽滑，坚果中的皇后。每袋都附有开果器的!!!附在牛皮纸袋内部!!您收货后仔细找找就能发现了呢。（使用小窍门：您可以把开果器插在果果的裂缝处，然后插深一些，再转一下，这样比较好开哦）","goods_thumbnail_url":"http://omsproductionimg.yangkeduo.com/images/2017-11-28/34eba02f3c71f5a269e64e9042d9950d.jpeg","goods_image_url":"http://omsproductionimg.yangkeduo.com/images/2017-10-17/0b7bca0ff9378f573337f6fb8f0448a8.jpeg","goods_gallery_urls":["http://omsproductionimg.yangkeduo.com/images/2017-11-28/b8ff55a74b615d06b91bd6a8785f739a.jpeg","http://t04img.yangkeduo.com/images/2018-04-08/04c90c1db3e618eeb7d3b681a53fdfcf.jpeg","http://omsproductionimg.yangkeduo.com/images/2017-10-17/3986d8258d16b4c74e56c2629f41a299.jpeg","http://t08img.yangkeduo.com/images/2018-04-08/8699ad96bfe31e7e39dbf7d233106f91.jpeg","http://t03img.yangkeduo.com/images/2018-04-08/fe4aa08cbc1f6c9a88bb00f66ab86636.jpeg"],"sold_quantity":92,"min_group_price":1990,"min_normal_price":2990,"mall_name":"百草味旗舰店","category_id":1,"category_name":"美食","opt_id":1,"opt_name":"美食","cat_ids":[2,65,4,0],"has_coupon":true,"coupon_min_order_amount":300,"coupon_discount":300,"coupon_total_quantity":50000,"coupon_remain_quantity":49940,"coupon_start_time":1525536000,"coupon_end_time":1525967999,"promotion_rate":150,"goods_eval_score":0,"goods_eval_count":0,"cat_id":null,"avg_desc":494,"avg_lgst":494,"avg_serv":494}]
        /// </summary>
        [JsonProperty("goods_details")]
        public IList<GoodsDetail> GoodsDetails { get; set; }
    }

    public class DetailDdkGoodsResponseModel
    {

        /// <summary>
        /// Examples: {"goods_details":[{"goods_id":545922677,"goods_name":"【百草味-夏威夷果150g/300g/多规格可选】 送开口器牛皮纸袋内!","goods_desc":"【百草味-夏威夷果100g/300g多规格可选】坚果零食干果炒货 奶油味送开口器牛皮纸袋内!  我们的夏威夷果奶香四溢，酥脆爽滑，坚果中的皇后。每袋都附有开果器的!!!附在牛皮纸袋内部!!您收货后仔细找找就能发现了呢。（使用小窍门：您可以把开果器插在果果的裂缝处，然后插深一些，再转一下，这样比较好开哦）","goods_thumbnail_url":"http://omsproductionimg.yangkeduo.com/images/2017-11-28/34eba02f3c71f5a269e64e9042d9950d.jpeg","goods_image_url":"http://omsproductionimg.yangkeduo.com/images/2017-10-17/0b7bca0ff9378f573337f6fb8f0448a8.jpeg","goods_gallery_urls":["http://omsproductionimg.yangkeduo.com/images/2017-11-28/b8ff55a74b615d06b91bd6a8785f739a.jpeg","http://t04img.yangkeduo.com/images/2018-04-08/04c90c1db3e618eeb7d3b681a53fdfcf.jpeg","http://omsproductionimg.yangkeduo.com/images/2017-10-17/3986d8258d16b4c74e56c2629f41a299.jpeg","http://t08img.yangkeduo.com/images/2018-04-08/8699ad96bfe31e7e39dbf7d233106f91.jpeg","http://t03img.yangkeduo.com/images/2018-04-08/fe4aa08cbc1f6c9a88bb00f66ab86636.jpeg"],"sold_quantity":92,"min_group_price":1990,"min_normal_price":2990,"mall_name":"百草味旗舰店","category_id":1,"category_name":"美食","opt_id":1,"opt_name":"美食","cat_ids":[2,65,4,0],"has_coupon":true,"coupon_min_order_amount":300,"coupon_discount":300,"coupon_total_quantity":50000,"coupon_remain_quantity":49940,"coupon_start_time":1525536000,"coupon_end_time":1525967999,"promotion_rate":150,"goods_eval_score":0,"goods_eval_count":0,"cat_id":null,"avg_desc":494,"avg_lgst":494,"avg_serv":494}]}
        /// </summary>
        [JsonProperty("goods_detail_response")]
        public GoodsDetailResponse GoodsDetailResponse { get; set; }
    }


}
