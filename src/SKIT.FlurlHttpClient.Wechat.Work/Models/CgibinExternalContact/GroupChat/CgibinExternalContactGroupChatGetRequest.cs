﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/groupchat/get 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactGroupChatGetRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置客户群 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chat_id")]
        [System.Text.Json.Serialization.JsonPropertyName("chat_id")]
        public string ChatId { get; set; } = string.Empty;
    }
}
