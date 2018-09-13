using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class GenDdkOauthWeappQrcodeUrlResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("weapp_qrcode_generate_response")]
public object WeappQrcodeGenerateResponse {get;set;}
/// <summary>
/// 单品推广小程序二维码url
/// </summary>
[JsonProperty("url")]
public object Url {get;set;}

    public partial class WeappQrcodeGenerateResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 单品推广小程序二维码url
/// </summary>
[JsonProperty("url")]
public object Url {get;set;}

}

}
}