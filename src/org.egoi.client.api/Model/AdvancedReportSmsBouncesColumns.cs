/*
 * APIv3 (New)
 *
 *  # Introduction This is our new version of API. We invite you to start using it and give us your feedback # Getting Started  E-goi can be integrated with many environments and programming languages via our REST API. We've created a developer focused portal to give your organization a clear and quick overview of how to integrate with E-goi. The developer portal focuses on scenarios for integration and flow of events. We recommend familiarizing yourself with all of the content in the developer portal, before start using our rest API.  The E-goi  APIv3 is served over HTTPS. To ensure data privacy, unencrypted HTTP is not supported.  Request data is passed to the API by POSTing JSON objects to the API endpoints with the appropriate parameters.      BaseURL = api.egoiapp.com  # RESTful Services This API supports 5 HTTP methods:  * <b>GET</b>: The HTTP GET method is used to **read** (or retrieve) a representation of a resource. * <b>POST</b>: The POST verb is most-often utilized to **create** new resources. * <b>PATCH</b>: PATCH is used for **modify** capabilities. The PATCH request only needs to contain the changes to the resource, not the complete resource * <b>PUT</b>: PUT is most-often utilized for **update** capabilities, PUT-ing to a known resource URI with the request body containing the newly-updated representation of the original resource. * <b>DELETE</b>: DELETE is pretty easy to understand. It is used to **delete** a resource identified by a URI.  # Authentication  We use a custom authentication method, you will need a apikey that you can find in your account settings. Below you will see a curl example to get your account information:     #!/bin/bash     curl -X GET 'https://api.egoiapp.com/my-account' \\     -H 'accept: application/json' \\     -H 'Apikey: <YOUR_APY_KEY>'  Here you can see a curl Post example with authentication:     #!/bin/bash     curl -X POST 'http://api.egoiapp.com/tags' \\     -H 'accept: application/json' \\     -H 'Apikey: <YOUR_APY_KEY>' \\     -H 'Content-Type: application/json' \\     -d '{`name`:`Your custom tag`,`color`:`#FFFFFF`}'  # SDK Get started quickly with E-goi with our integration tools. Our SDK is a modern open source library that makes it easy to integrate your application with E-goi services.  * <a href='https://github.com/E-goi/sdk-java'>Java</a>  * <a href='https://github.com/E-goi/sdk-php'>PHP</a>  * <a href='https://github.com/E-goi/sdk-python'>Python</a>  * <a href='https://github.com/E-goi/sdk-ruby'>Ruby</a>  * <a href='https://github.com/E-goi/sdk-javascript'>Javascript</a>  * <a href='https://github.com/E-goi/sdk-csharp'>C#</a>  # Stream Limits Stream limits are security mesures we have to make sure our API have a fair use policy, for this reason, any request that creates or modifies data (**POST**, **PATCH** and **PUT**) is limited to a maximum of **20MB** of content length. If you arrive to this limit in one of your request, you'll receive a HTTP code **413 (Request Entity Too Large)** and the request will be ignored. To avoid this error in importation's requests, it's advised the request's division in batches that have each one less than 20MB.  # Timeouts Timeouts set a maximum waiting time on a request's response. Our API, sets a default timeout for each request and when breached, you'll receive an HTTP **408 (Request Timeout)** error code. You should take into consideration that response times can vary widely based on the complexity of the request, amount of data being analyzed, and the load on the system and workspace at the time of the query. When dealing with such errors, you should first attempt to reduce the complexity and amount of data under analysis, and only then, if problems are still occurring ask for support.  For all these reasons, the default timeout for each request is **10 Seconds** and any request that creates or modifies data (**POST**, **PATCH** and **PUT**) will have a timeout of **60 Seconds**. Specific timeouts may exist for specific requests, these can be found in the request's documentation.  <security-definitions/>
 *
 * The version of the OpenAPI document: 3.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = org.egoi.client.api.Client.OpenAPIDateConverter;

namespace org.egoi.client.api.Model
{
    /// <summary>
    /// Columns of the report
    /// </summary>
    [DataContract]
    public partial class AdvancedReportSmsBouncesColumns :  IEquatable<AdvancedReportSmsBouncesColumns>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedReportSmsBouncesColumns" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdvancedReportSmsBouncesColumns() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedReportSmsBouncesColumns" /> class.
        /// </summary>
        /// <param name="listBaseFields">Array of base fields (required).</param>
        /// <param name="listExtraFields">listExtraFields (required).</param>
        /// <param name="listStatsFields">listStatsFields (required).</param>
        /// <param name="campaignFields">campaignFields (required).</param>
        public AdvancedReportSmsBouncesColumns(List<string> listBaseFields = default(List<string>), List<Object> listExtraFields = default(List<Object>), SmsBouncesListStatsFields listStatsFields = default(SmsBouncesListStatsFields), SmsBouncesCampaignFields campaignFields = default(SmsBouncesCampaignFields))
        {
            // to ensure "listBaseFields" is required (not null)
            if (listBaseFields == null)
            {
                throw new InvalidDataException("listBaseFields is a required property for AdvancedReportSmsBouncesColumns and cannot be null");
            }
            else
            {
                this.ListBaseFields = listBaseFields;
            }

            // to ensure "listExtraFields" is required (not null)
            if (listExtraFields == null)
            {
                throw new InvalidDataException("listExtraFields is a required property for AdvancedReportSmsBouncesColumns and cannot be null");
            }
            else
            {
                this.ListExtraFields = listExtraFields;
            }

            // to ensure "listStatsFields" is required (not null)
            if (listStatsFields == null)
            {
                throw new InvalidDataException("listStatsFields is a required property for AdvancedReportSmsBouncesColumns and cannot be null");
            }
            else
            {
                this.ListStatsFields = listStatsFields;
            }

            // to ensure "campaignFields" is required (not null)
            if (campaignFields == null)
            {
                throw new InvalidDataException("campaignFields is a required property for AdvancedReportSmsBouncesColumns and cannot be null");
            }
            else
            {
                this.CampaignFields = campaignFields;
            }

        }

        /// <summary>
        /// Array of base fields
        /// </summary>
        /// <value>Array of base fields</value>
        [DataMember(Name="list_base_fields", EmitDefaultValue=true)]
        public List<string> ListBaseFields { get; set; }

        /// <summary>
        /// Gets or Sets ListExtraFields
        /// </summary>
        [DataMember(Name="list_extra_fields", EmitDefaultValue=true)]
        public List<Object> ListExtraFields { get; set; }

        /// <summary>
        /// Gets or Sets ListStatsFields
        /// </summary>
        [DataMember(Name="list_stats_fields", EmitDefaultValue=true)]
        public SmsBouncesListStatsFields ListStatsFields { get; set; }

        /// <summary>
        /// Gets or Sets CampaignFields
        /// </summary>
        [DataMember(Name="campaign_fields", EmitDefaultValue=true)]
        public SmsBouncesCampaignFields CampaignFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvancedReportSmsBouncesColumns {\n");
            sb.Append("  ListBaseFields: ").Append(ListBaseFields).Append("\n");
            sb.Append("  ListExtraFields: ").Append(ListExtraFields).Append("\n");
            sb.Append("  ListStatsFields: ").Append(ListStatsFields).Append("\n");
            sb.Append("  CampaignFields: ").Append(CampaignFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdvancedReportSmsBouncesColumns);
        }

        /// <summary>
        /// Returns true if AdvancedReportSmsBouncesColumns instances are equal
        /// </summary>
        /// <param name="input">Instance of AdvancedReportSmsBouncesColumns to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvancedReportSmsBouncesColumns input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ListBaseFields == input.ListBaseFields ||
                    this.ListBaseFields != null &&
                    input.ListBaseFields != null &&
                    this.ListBaseFields.SequenceEqual(input.ListBaseFields)
                ) && 
                (
                    this.ListExtraFields == input.ListExtraFields ||
                    this.ListExtraFields != null &&
                    input.ListExtraFields != null &&
                    this.ListExtraFields.SequenceEqual(input.ListExtraFields)
                ) && 
                (
                    this.ListStatsFields == input.ListStatsFields ||
                    (this.ListStatsFields != null &&
                    this.ListStatsFields.Equals(input.ListStatsFields))
                ) && 
                (
                    this.CampaignFields == input.CampaignFields ||
                    (this.CampaignFields != null &&
                    this.CampaignFields.Equals(input.CampaignFields))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ListBaseFields != null)
                    hashCode = hashCode * 59 + this.ListBaseFields.GetHashCode();
                if (this.ListExtraFields != null)
                    hashCode = hashCode * 59 + this.ListExtraFields.GetHashCode();
                if (this.ListStatsFields != null)
                    hashCode = hashCode * 59 + this.ListStatsFields.GetHashCode();
                if (this.CampaignFields != null)
                    hashCode = hashCode * 59 + this.CampaignFields.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
