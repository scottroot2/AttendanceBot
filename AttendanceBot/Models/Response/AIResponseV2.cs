﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using AttendanceBot.Models.Response;
//
//    var aiResponseV2 = AiResponseV2.FromJson(jsonString);

namespace AttendanceBot.Models.Response
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class AiResponseV2
    {
        [JsonProperty("responseId")]
        public Guid ResponseId { get; set; }

        [JsonProperty("session")]
        public string Session { get; set; }

        [JsonProperty("queryResult")]
        public QueryResult QueryResult { get; set; }

        [JsonProperty("originalDetectIntentRequest")]
        public OriginalDetectIntentRequest OriginalDetectIntentRequest { get; set; }
    }

    public partial class OriginalDetectIntentRequest
    {
    }

    public partial class QueryResult
    {
        [JsonProperty("queryText")]
        public string QueryText { get; set; }

        [JsonProperty("parameters")]
        public Parameters Parameters { get; set; }

        [JsonProperty("allRequiredParamsPresent")]
        public bool AllRequiredParamsPresent { get; set; }

        [JsonProperty("fulfillmentText")]
        public string FulfillmentText { get; set; }

        [JsonProperty("fulfillmentMessages")]
        public List<FulfillmentMessage> FulfillmentMessages { get; set; }

        [JsonProperty("outputContexts")]
        public List<OutputContext> OutputContexts { get; set; }

        [JsonProperty("intent")]
        public Intent Intent { get; set; }

        [JsonProperty("intentDetectionConfidence")]
        public long IntentDetectionConfidence { get; set; }

        [JsonProperty("diagnosticInfo")]
        public OriginalDetectIntentRequest DiagnosticInfo { get; set; }

        [JsonProperty("languageCode")]
        public string LanguageCode { get; set; }
    }

    public partial class FulfillmentMessage
    {
        [JsonProperty("text")]
        public Text Text { get; set; }
    }

    public partial class Text
    {
        [JsonProperty("text")]
        public List<string> TextText { get; set; }
    }

    public partial class Intent
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public partial class OutputContext
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lifespanCount")]
        public long LifespanCount { get; set; }

        [JsonProperty("parameters")]
        public Parameters Parameters { get; set; }
    }

    public partial class Parameters
    {
        [JsonProperty("any")]
        public string StudentNumber { get; set; }
    }

    public partial class AiResponseV2
    {
        public static AiResponseV2 FromJson(string json) => JsonConvert.DeserializeObject<AiResponseV2>(json, AttendanceBot.Models.Response.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this AiResponseV2 self) => JsonConvert.SerializeObject(self, AttendanceBot.Models.Response.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
