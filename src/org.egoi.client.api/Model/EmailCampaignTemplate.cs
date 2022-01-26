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
    /// Email campaign template schema
    /// </summary>
    [DataContract]
    public partial class EmailCampaignTemplate :  IEquatable<EmailCampaignTemplate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailCampaignTemplate" /> class.
        /// </summary>
        /// <param name="internalName">Campaign internal name.</param>
        /// <param name="senderData">senderData.</param>
        /// <param name="image">Template image.</param>
        /// <param name="messageHtmlVersion">Html message.</param>
        /// <param name="messageTextVersion">Text message.</param>
        /// <param name="replyToData">replyToData.</param>
        public EmailCampaignTemplate(string internalName = default(string), EmailCampaignTemplateAllOfSenderData senderData = default(EmailCampaignTemplateAllOfSenderData), string image = default(string), string messageHtmlVersion = default(string), string messageTextVersion = default(string), EmailCampaignTemplateAllOfReplyToData replyToData = default(EmailCampaignTemplateAllOfReplyToData))
        {
            this.InternalName = internalName;
            this.SenderData = senderData;
            this.Image = image;
            this.MessageHtmlVersion = messageHtmlVersion;
            this.MessageTextVersion = messageTextVersion;
            this.ReplyToData = replyToData;
        }

        /// <summary>
        /// Gets or Sets TemplateId
        /// </summary>
        [DataMember(Name="template_id", EmitDefaultValue=false)]
        public int TemplateId { get; private set; }

        /// <summary>
        /// Gets or Sets TemplateHash
        /// </summary>
        [DataMember(Name="template_hash", EmitDefaultValue=false)]
        public string TemplateHash { get; private set; }

        /// <summary>
        /// Campaign internal name
        /// </summary>
        /// <value>Campaign internal name</value>
        [DataMember(Name="internal_name", EmitDefaultValue=false)]
        public string InternalName { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=true)]
        public DateTime Created { get; private set; }

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name="updated", EmitDefaultValue=true)]
        public DateTime Updated { get; private set; }

        /// <summary>
        /// Gets or Sets SenderData
        /// </summary>
        [DataMember(Name="sender_data", EmitDefaultValue=false)]
        public EmailCampaignTemplateAllOfSenderData SenderData { get; set; }

        /// <summary>
        /// Template image
        /// </summary>
        /// <value>Template image</value>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }

        /// <summary>
        /// Html message
        /// </summary>
        /// <value>Html message</value>
        [DataMember(Name="message_html_version", EmitDefaultValue=false)]
        public string MessageHtmlVersion { get; set; }

        /// <summary>
        /// Text message
        /// </summary>
        /// <value>Text message</value>
        [DataMember(Name="message_text_version", EmitDefaultValue=false)]
        public string MessageTextVersion { get; set; }

        /// <summary>
        /// Gets or Sets ReplyToData
        /// </summary>
        [DataMember(Name="reply_to_data", EmitDefaultValue=false)]
        public EmailCampaignTemplateAllOfReplyToData ReplyToData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailCampaignTemplate {\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  TemplateHash: ").Append(TemplateHash).Append("\n");
            sb.Append("  InternalName: ").Append(InternalName).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  SenderData: ").Append(SenderData).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  MessageHtmlVersion: ").Append(MessageHtmlVersion).Append("\n");
            sb.Append("  MessageTextVersion: ").Append(MessageTextVersion).Append("\n");
            sb.Append("  ReplyToData: ").Append(ReplyToData).Append("\n");
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
            return this.Equals(input as EmailCampaignTemplate);
        }

        /// <summary>
        /// Returns true if EmailCampaignTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailCampaignTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailCampaignTemplate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.TemplateHash == input.TemplateHash ||
                    (this.TemplateHash != null &&
                    this.TemplateHash.Equals(input.TemplateHash))
                ) && 
                (
                    this.InternalName == input.InternalName ||
                    (this.InternalName != null &&
                    this.InternalName.Equals(input.InternalName))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
                ) && 
                (
                    this.SenderData == input.SenderData ||
                    (this.SenderData != null &&
                    this.SenderData.Equals(input.SenderData))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.MessageHtmlVersion == input.MessageHtmlVersion ||
                    (this.MessageHtmlVersion != null &&
                    this.MessageHtmlVersion.Equals(input.MessageHtmlVersion))
                ) && 
                (
                    this.MessageTextVersion == input.MessageTextVersion ||
                    (this.MessageTextVersion != null &&
                    this.MessageTextVersion.Equals(input.MessageTextVersion))
                ) && 
                (
                    this.ReplyToData == input.ReplyToData ||
                    (this.ReplyToData != null &&
                    this.ReplyToData.Equals(input.ReplyToData))
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
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.TemplateHash != null)
                    hashCode = hashCode * 59 + this.TemplateHash.GetHashCode();
                if (this.InternalName != null)
                    hashCode = hashCode * 59 + this.InternalName.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.SenderData != null)
                    hashCode = hashCode * 59 + this.SenderData.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.MessageHtmlVersion != null)
                    hashCode = hashCode * 59 + this.MessageHtmlVersion.GetHashCode();
                if (this.MessageTextVersion != null)
                    hashCode = hashCode * 59 + this.MessageTextVersion.GetHashCode();
                if (this.ReplyToData != null)
                    hashCode = hashCode * 59 + this.ReplyToData.GetHashCode();
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


            // TemplateId (int) minimum
            if(this.TemplateId < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TemplateId, must be a value greater than or equal to 1.", new [] { "TemplateId" });
            }



            // TemplateHash (string) pattern
            Regex regexTemplateHash = new Regex(@"[a-zA-Z0-9_-]*", RegexOptions.CultureInvariant);
            if (false == regexTemplateHash.Match(this.TemplateHash).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TemplateHash, must match a pattern of " + regexTemplateHash, new [] { "TemplateHash" });
            }

            yield break;
        }
    }

}
