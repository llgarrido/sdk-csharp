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
    /// Generate email clicks by contact report schema
    /// </summary>
    [DataContract]
    public partial class GenerateEmailClicksByContactReport :  IEquatable<GenerateEmailClicksByContactReport>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateEmailClicksByContactReport" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GenerateEmailClicksByContactReport() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateEmailClicksByContactReport" /> class.
        /// </summary>
        /// <param name="title">Advanced report title (required).</param>
        /// <param name="range">range (required).</param>
        /// <param name="campaigns">Campaigns of the report (required).</param>
        /// <param name="columns">columns (required).</param>
        /// <param name="options">options (required).</param>
        /// <param name="callbackUrl">URL which will receive the information of the report.</param>
        public GenerateEmailClicksByContactReport(string title = default(string), AdvancedReportRange range = default(AdvancedReportRange), List<AdvancedReportCampaignsObject> campaigns = default(List<AdvancedReportCampaignsObject>), AdvancedReportEmailClicksByContactColumns columns = default(AdvancedReportEmailClicksByContactColumns), AdvancedReportEmailClicksByContactOptions options = default(AdvancedReportEmailClicksByContactOptions), string callbackUrl = default(string))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for GenerateEmailClicksByContactReport and cannot be null");
            }
            else
            {
                this.Title = title;
            }

            // to ensure "range" is required (not null)
            if (range == null)
            {
                throw new InvalidDataException("range is a required property for GenerateEmailClicksByContactReport and cannot be null");
            }
            else
            {
                this.Range = range;
            }

            // to ensure "campaigns" is required (not null)
            if (campaigns == null)
            {
                throw new InvalidDataException("campaigns is a required property for GenerateEmailClicksByContactReport and cannot be null");
            }
            else
            {
                this.Campaigns = campaigns;
            }

            // to ensure "columns" is required (not null)
            if (columns == null)
            {
                throw new InvalidDataException("columns is a required property for GenerateEmailClicksByContactReport and cannot be null");
            }
            else
            {
                this.Columns = columns;
            }

            // to ensure "options" is required (not null)
            if (options == null)
            {
                throw new InvalidDataException("options is a required property for GenerateEmailClicksByContactReport and cannot be null");
            }
            else
            {
                this.Options = options;
            }

            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Advanced report title
        /// </summary>
        /// <value>Advanced report title</value>
        [DataMember(Name="title", EmitDefaultValue=true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Range
        /// </summary>
        [DataMember(Name="range", EmitDefaultValue=true)]
        public AdvancedReportRange Range { get; set; }

        /// <summary>
        /// Campaigns of the report
        /// </summary>
        /// <value>Campaigns of the report</value>
        [DataMember(Name="campaigns", EmitDefaultValue=true)]
        public List<AdvancedReportCampaignsObject> Campaigns { get; set; }

        /// <summary>
        /// Gets or Sets Columns
        /// </summary>
        [DataMember(Name="columns", EmitDefaultValue=true)]
        public AdvancedReportEmailClicksByContactColumns Columns { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=true)]
        public AdvancedReportEmailClicksByContactOptions Options { get; set; }

        /// <summary>
        /// URL which will receive the information of the report
        /// </summary>
        /// <value>URL which will receive the information of the report</value>
        [DataMember(Name="callback_url", EmitDefaultValue=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenerateEmailClicksByContactReport {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
            sb.Append("  Campaigns: ").Append(Campaigns).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
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
            return this.Equals(input as GenerateEmailClicksByContactReport);
        }

        /// <summary>
        /// Returns true if GenerateEmailClicksByContactReport instances are equal
        /// </summary>
        /// <param name="input">Instance of GenerateEmailClicksByContactReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateEmailClicksByContactReport input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Range == input.Range ||
                    (this.Range != null &&
                    this.Range.Equals(input.Range))
                ) && 
                (
                    this.Campaigns == input.Campaigns ||
                    this.Campaigns != null &&
                    input.Campaigns != null &&
                    this.Campaigns.SequenceEqual(input.Campaigns)
                ) && 
                (
                    this.Columns == input.Columns ||
                    (this.Columns != null &&
                    this.Columns.Equals(input.Columns))
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
                ) && 
                (
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Range != null)
                    hashCode = hashCode * 59 + this.Range.GetHashCode();
                if (this.Campaigns != null)
                    hashCode = hashCode * 59 + this.Campaigns.GetHashCode();
                if (this.Columns != null)
                    hashCode = hashCode * 59 + this.Columns.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.CallbackUrl != null)
                    hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
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
