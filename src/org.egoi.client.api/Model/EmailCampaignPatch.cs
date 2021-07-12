/* 
 * APIv3 (New)
 *
 *  # Introduction This is our new version of API. We invite you to start using it and give us your feedback # Getting Started  E-goi can be integrated with many environments and programming languages via our REST API. We've created a developer focused portal to give your organization a clear and quick overview of how to integrate with E-goi. The developer portal focuses on scenarios for integration and flow of events. We recommend familiarizing yourself with all of the content in the developer portal, before start using our rest API.   The E-goi  APIv3 is served over HTTPS. To ensure data privacy, unencrypted HTTP is not supported.  Request data is passed to the API by POSTing JSON objects to the API endpoints with the appropriate parameters.   BaseURL = api.egoiapp.com  # RESTful Services This API supports 5 HTTP methods:  * <b>GET</b>: The HTTP GET method is used to **read** (or retrieve) a representation of a resource. * <b>POST</b>: The POST verb is most-often utilized to **create** new resources. * <b>PATCH</b>: PATCH is used for **modify** capabilities. The PATCH request only needs to contain the changes to the resource, not the complete resource * <b>PUT</b>: PUT is most-often utilized for **update** capabilities, PUT-ing to a known resource URI with the request body containing the newly-updated representation of the original resource. * <b>DELETE</b>: DELETE is pretty easy to understand. It is used to **delete** a resource identified by a URI.  # Authentication   We use a custom authentication method, you will need a apikey that you can find in your account settings. Below you will see a curl example to get your account information:  #!/bin/bash  curl -X GET 'https://api.egoiapp.com/my-account' \\  -H 'accept: application/json' \\  -H 'Apikey: <YOUR_APY_KEY>'  Here you can see a curl Post example with authentication:  #!/bin/bash  curl -X POST 'http://api.egoiapp.com/tags' \\  -H 'accept: application/json' \\  -H 'Apikey: <YOUR_APY_KEY>' \\  -H 'Content-Type: application/json' \\  -d '{`name`:`Your custom tag`,`color`:`#FFFFFF`}'  # SDK Get started quickly with E-goi with our integration tools. Our SDK is a modern open source library that makes it easy to integrate your application with E-goi services.  * <a href='https://github.com/E-goi/sdk-java'>Java</a>  * <a href='https://github.com/E-goi/sdk-php'>PHP</a>  * <a href='https://github.com/E-goi/sdk-python'>Python</a>  * <a href='https://github.com/E-goi/sdk-ruby'>Ruby</a>  * <a href='https://github.com/E-goi/sdk-javascript'>Javascript</a>  * <a href='https://github.com/E-goi/sdk-csharp'>C#</a>  # Stream Limits Stream limits are security mesures we have to make sure our API have a fair use policy, for this reason, any request that creates or modifies data (**POST**, **PATCH** and **PUT**) is limited to a maximum of **20MB** of content length. If you arrive to this limit in one of your request, you'll receive a HTTP code **413 (Request Entity Too Large)** and the request will be ignored. To avoid this error in importation's requests, it's advised the request's division in batches that have each one less than 20MB.  # Timeouts Timeouts set a maximum waiting time on a request's response. Our API, sets a default timeout for each request and when breached, you'll receive an HTTP **408 (Request Timeout)** error code. You should take into consideration that response times can vary widely based on the complexity of the request, amount of data being analyzed, and the load on the system and workspace at the time of the query. When dealing with such errors, you should first attempt to reduce the complexity and amount of data under analysis, and only then, if problems are still occurring ask for support.  For all these reasons, the default timeout for each request is **10 Seconds** and any request that creates or modifies data (**POST**, **PATCH** and **PUT**) will have a timeout of **60 Seconds**. Specific timeouts may exist for specific requests, these can be found in the request's documentation.  <security-definitions/>
 *
 * OpenAPI spec version: 3.0.0
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
    /// Email campaign schema
    /// </summary>
    [DataContract]
    public partial class EmailCampaignPatch :  IEquatable<EmailCampaignPatch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailCampaignPatch" /> class.
        /// </summary>
        /// <param name="internalName">Campaign internal name.</param>
        /// <param name="subject">Campaign subject. If no value is sent, defaults to &#39;internal_name&#39; property value.</param>
        /// <param name="content">content.</param>
        /// <param name="senderId">senderId.</param>
        /// <param name="replyTo">replyTo.</param>
        /// <param name="headerFooter">headerFooter.</param>
        public EmailCampaignPatch(string internalName = default(string), string subject = default(string), CampaignEmailContentHtmlPatch content = default(CampaignEmailContentHtmlPatch), int? senderId = default(int?), int? replyTo = default(int?), HeaderFooter headerFooter = default(HeaderFooter))
        {
            this.InternalName = internalName;
            this.Subject = subject;
            this.Content = content;
            this.SenderId = senderId;
            this.ReplyTo = replyTo;
            this.HeaderFooter = headerFooter;
        }
        
        /// <summary>
        /// Campaign internal name
        /// </summary>
        /// <value>Campaign internal name</value>
        [DataMember(Name="internal_name", EmitDefaultValue=false)]
        public string InternalName { get; set; }

        /// <summary>
        /// Campaign subject. If no value is sent, defaults to &#39;internal_name&#39; property value
        /// </summary>
        /// <value>Campaign subject. If no value is sent, defaults to &#39;internal_name&#39; property value</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public CampaignEmailContentHtmlPatch Content { get; set; }

        /// <summary>
        /// Gets or Sets SenderId
        /// </summary>
        [DataMember(Name="sender_id", EmitDefaultValue=false)]
        public int? SenderId { get; set; }

        /// <summary>
        /// Gets or Sets ReplyTo
        /// </summary>
        [DataMember(Name="reply_to", EmitDefaultValue=false)]
        public int? ReplyTo { get; set; }

        /// <summary>
        /// Gets or Sets HeaderFooter
        /// </summary>
        [DataMember(Name="header_footer", EmitDefaultValue=false)]
        public HeaderFooter HeaderFooter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailCampaignPatch {\n");
            sb.Append("  InternalName: ").Append(InternalName).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  SenderId: ").Append(SenderId).Append("\n");
            sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
            sb.Append("  HeaderFooter: ").Append(HeaderFooter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EmailCampaignPatch);
        }

        /// <summary>
        /// Returns true if EmailCampaignPatch instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailCampaignPatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailCampaignPatch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InternalName == input.InternalName ||
                    (this.InternalName != null &&
                    this.InternalName.Equals(input.InternalName))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.SenderId == input.SenderId ||
                    (this.SenderId != null &&
                    this.SenderId.Equals(input.SenderId))
                ) && 
                (
                    this.ReplyTo == input.ReplyTo ||
                    (this.ReplyTo != null &&
                    this.ReplyTo.Equals(input.ReplyTo))
                ) && 
                (
                    this.HeaderFooter == input.HeaderFooter ||
                    (this.HeaderFooter != null &&
                    this.HeaderFooter.Equals(input.HeaderFooter))
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
                if (this.InternalName != null)
                    hashCode = hashCode * 59 + this.InternalName.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.SenderId != null)
                    hashCode = hashCode * 59 + this.SenderId.GetHashCode();
                if (this.ReplyTo != null)
                    hashCode = hashCode * 59 + this.ReplyTo.GetHashCode();
                if (this.HeaderFooter != null)
                    hashCode = hashCode * 59 + this.HeaderFooter.GetHashCode();
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
            // SenderId (int?) minimum
            if(this.SenderId < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SenderId, must be a value greater than or equal to 1.", new [] { "SenderId" });
            }

            // ReplyTo (int?) minimum
            if(this.ReplyTo < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReplyTo, must be a value greater than or equal to 1.", new [] { "ReplyTo" });
            }

            yield break;
        }
    }

}
