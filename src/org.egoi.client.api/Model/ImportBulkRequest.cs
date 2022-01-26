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
    /// Contact import bulk request schema
    /// </summary>
    [DataContract]
    public partial class ImportBulkRequest :  IEquatable<ImportBulkRequest>, IValidatableObject
    {
        /// <summary>
        /// Add new contacts only (&#39;add&#39;) or add and replace existing ones (&#39;update&#39;)
        /// </summary>
        /// <value>Add new contacts only (&#39;add&#39;) or add and replace existing ones (&#39;update&#39;)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            /// <summary>
            /// Enum Add for value: add
            /// </summary>
            [EnumMember(Value = "add")]
            Add = 1,

            /// <summary>
            /// Enum Update for value: update
            /// </summary>
            [EnumMember(Value = "update")]
            Update = 2

        }

        /// <summary>
        /// Add new contacts only (&#39;add&#39;) or add and replace existing ones (&#39;update&#39;)
        /// </summary>
        /// <value>Add new contacts only (&#39;add&#39;) or add and replace existing ones (&#39;update&#39;)</value>
        [DataMember(Name="mode", EmitDefaultValue=true)]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportBulkRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImportBulkRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportBulkRequest" /> class.
        /// </summary>
        /// <param name="mode">Add new contacts only (&#39;add&#39;) or add and replace existing ones (&#39;update&#39;) (required).</param>
        /// <param name="compareField">Field ID which will be mapped for comparison to prevent duplicates) (required).</param>
        /// <param name="contacts">Array of contacts to import (required).</param>
        /// <param name="forceEmpty">If &#39;true&#39; accepts empty values and erases those fields (default to false).</param>
        /// <param name="notify">Array of IDs of the users to notify.</param>
        /// <param name="callbackUrl">Url to receive the report.</param>
        public ImportBulkRequest(ModeEnum mode = default(ModeEnum), string compareField = default(string), List<ContactBulk> contacts = default(List<ContactBulk>), bool forceEmpty = false, List<int> notify = default(List<int>), string callbackUrl = default(string))
        {
            // to ensure "mode" is required (not null)
            if (mode == null)
            {
                throw new InvalidDataException("mode is a required property for ImportBulkRequest and cannot be null");
            }
            else
            {
                this.Mode = mode;
            }

            // to ensure "compareField" is required (not null)
            if (compareField == null)
            {
                throw new InvalidDataException("compareField is a required property for ImportBulkRequest and cannot be null");
            }
            else
            {
                this.CompareField = compareField;
            }

            // to ensure "contacts" is required (not null)
            if (contacts == null)
            {
                throw new InvalidDataException("contacts is a required property for ImportBulkRequest and cannot be null");
            }
            else
            {
                this.Contacts = contacts;
            }

            // use default value if no "forceEmpty" provided
            if (forceEmpty == null)
            {
                this.ForceEmpty = false;
            }
            else
            {
                this.ForceEmpty = forceEmpty;
            }
            this.Notify = notify;
            this.CallbackUrl = callbackUrl;
        }


        /// <summary>
        /// Field ID which will be mapped for comparison to prevent duplicates)
        /// </summary>
        /// <value>Field ID which will be mapped for comparison to prevent duplicates)</value>
        [DataMember(Name="compare_field", EmitDefaultValue=true)]
        public string CompareField { get; set; }

        /// <summary>
        /// Array of contacts to import
        /// </summary>
        /// <value>Array of contacts to import</value>
        [DataMember(Name="contacts", EmitDefaultValue=true)]
        public List<ContactBulk> Contacts { get; set; }

        /// <summary>
        /// If &#39;true&#39; accepts empty values and erases those fields
        /// </summary>
        /// <value>If &#39;true&#39; accepts empty values and erases those fields</value>
        [DataMember(Name="force_empty", EmitDefaultValue=false)]
        public bool ForceEmpty { get; set; }

        /// <summary>
        /// Array of IDs of the users to notify
        /// </summary>
        /// <value>Array of IDs of the users to notify</value>
        [DataMember(Name="notify", EmitDefaultValue=false)]
        public List<int> Notify { get; set; }

        /// <summary>
        /// Url to receive the report
        /// </summary>
        /// <value>Url to receive the report</value>
        [DataMember(Name="callback_url", EmitDefaultValue=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportBulkRequest {\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  CompareField: ").Append(CompareField).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  ForceEmpty: ").Append(ForceEmpty).Append("\n");
            sb.Append("  Notify: ").Append(Notify).Append("\n");
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
            return this.Equals(input as ImportBulkRequest);
        }

        /// <summary>
        /// Returns true if ImportBulkRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ImportBulkRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportBulkRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.CompareField == input.CompareField ||
                    (this.CompareField != null &&
                    this.CompareField.Equals(input.CompareField))
                ) && 
                (
                    this.Contacts == input.Contacts ||
                    this.Contacts != null &&
                    input.Contacts != null &&
                    this.Contacts.SequenceEqual(input.Contacts)
                ) && 
                (
                    this.ForceEmpty == input.ForceEmpty ||
                    (this.ForceEmpty != null &&
                    this.ForceEmpty.Equals(input.ForceEmpty))
                ) && 
                (
                    this.Notify == input.Notify ||
                    this.Notify != null &&
                    input.Notify != null &&
                    this.Notify.SequenceEqual(input.Notify)
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
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.CompareField != null)
                    hashCode = hashCode * 59 + this.CompareField.GetHashCode();
                if (this.Contacts != null)
                    hashCode = hashCode * 59 + this.Contacts.GetHashCode();
                if (this.ForceEmpty != null)
                    hashCode = hashCode * 59 + this.ForceEmpty.GetHashCode();
                if (this.Notify != null)
                    hashCode = hashCode * 59 + this.Notify.GetHashCode();
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
