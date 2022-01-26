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
    /// AutomationAllOf
    /// </summary>
    [DataContract]
    public partial class AutomationAllOf :  IEquatable<AutomationAllOf>, IValidatableObject
    {
        /// <summary>
        /// Automation status
        /// </summary>
        /// <value>Automation status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 2

        }

        /// <summary>
        /// Automation status
        /// </summary>
        /// <value>Automation status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomationAllOf" /> class.
        /// </summary>
        /// <param name="title">Automation title.</param>
        /// <param name="listId">listId.</param>
        /// <param name="status">Automation status.</param>
        /// <param name="allowMultipleContacts">True if the automation allows multiple contacts, false otherwise (default to true).</param>
        /// <param name="contactLimit">Contact limit for the automation. Contact limit value (value &#39;0&#39; is returned if contact                                 limit is not enabled).</param>
        public AutomationAllOf(string title = default(string), int listId = default(int), StatusEnum? status = default(StatusEnum?), bool allowMultipleContacts = true, int contactLimit = default(int))
        {
            this.Title = title;
            this.ListId = listId;
            this.Status = status;
            // use default value if no "allowMultipleContacts" provided
            if (allowMultipleContacts == null)
            {
                this.AllowMultipleContacts = true;
            }
            else
            {
                this.AllowMultipleContacts = allowMultipleContacts;
            }
            this.ContactLimit = contactLimit;
        }

        /// <summary>
        /// Gets or Sets AutomationId
        /// </summary>
        [DataMember(Name="automation_id", EmitDefaultValue=false)]
        public int AutomationId { get; private set; }

        /// <summary>
        /// Automation title
        /// </summary>
        /// <value>Automation title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets ListId
        /// </summary>
        [DataMember(Name="list_id", EmitDefaultValue=false)]
        public int ListId { get; set; }


        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="created_by", EmitDefaultValue=false)]
        public int CreatedBy { get; private set; }

        /// <summary>
        /// True if the automation allows multiple contacts, false otherwise
        /// </summary>
        /// <value>True if the automation allows multiple contacts, false otherwise</value>
        [DataMember(Name="allow_multiple_contacts", EmitDefaultValue=false)]
        public bool AllowMultipleContacts { get; set; }

        /// <summary>
        /// Contact limit for the automation. Contact limit value (value &#39;0&#39; is returned if contact                                 limit is not enabled)
        /// </summary>
        /// <value>Contact limit for the automation. Contact limit value (value &#39;0&#39; is returned if contact                                 limit is not enabled)</value>
        [DataMember(Name="contact_limit", EmitDefaultValue=false)]
        public int ContactLimit { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutomationAllOf {\n");
            sb.Append("  AutomationId: ").Append(AutomationId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  ListId: ").Append(ListId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  AllowMultipleContacts: ").Append(AllowMultipleContacts).Append("\n");
            sb.Append("  ContactLimit: ").Append(ContactLimit).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
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
            return this.Equals(input as AutomationAllOf);
        }

        /// <summary>
        /// Returns true if AutomationAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of AutomationAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutomationAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutomationId == input.AutomationId ||
                    (this.AutomationId != null &&
                    this.AutomationId.Equals(input.AutomationId))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.ListId == input.ListId ||
                    (this.ListId != null &&
                    this.ListId.Equals(input.ListId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.AllowMultipleContacts == input.AllowMultipleContacts ||
                    (this.AllowMultipleContacts != null &&
                    this.AllowMultipleContacts.Equals(input.AllowMultipleContacts))
                ) && 
                (
                    this.ContactLimit == input.ContactLimit ||
                    (this.ContactLimit != null &&
                    this.ContactLimit.Equals(input.ContactLimit))
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
                if (this.AutomationId != null)
                    hashCode = hashCode * 59 + this.AutomationId.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.ListId != null)
                    hashCode = hashCode * 59 + this.ListId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.AllowMultipleContacts != null)
                    hashCode = hashCode * 59 + this.AllowMultipleContacts.GetHashCode();
                if (this.ContactLimit != null)
                    hashCode = hashCode * 59 + this.ContactLimit.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
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


            // AutomationId (int) minimum
            if(this.AutomationId < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AutomationId, must be a value greater than or equal to 1.", new [] { "AutomationId" });
            }



            // ListId (int) minimum
            if(this.ListId < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ListId, must be a value greater than or equal to 1.", new [] { "ListId" });
            }



            // CreatedBy (int) minimum
            if(this.CreatedBy < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreatedBy, must be a value greater than or equal to 1.", new [] { "CreatedBy" });
            }



            // ContactLimit (int) minimum
            if(this.ContactLimit < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContactLimit, must be a value greater than or equal to 0.", new [] { "ContactLimit" });
            }

            yield break;
        }
    }

}
