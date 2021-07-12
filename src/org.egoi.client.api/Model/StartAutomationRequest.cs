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
    /// Start automation to the provided contacts
    /// </summary>
    [DataContract]
    public partial class StartAutomationRequest :  IEquatable<StartAutomationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartAutomationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StartAutomationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StartAutomationRequest" /> class.
        /// </summary>
        /// <param name="automationId">automationId (required).</param>
        /// <param name="actionId">actionId (required).</param>
        /// <param name="contacts">Array of contact IDs to start automation (required).</param>
        public StartAutomationRequest(int? automationId = default(int?), int? actionId = default(int?), List<string> contacts = default(List<string>))
        {
            // to ensure "automationId" is required (not null)
            if (automationId == null)
            {
                throw new InvalidDataException("automationId is a required property for StartAutomationRequest and cannot be null");
            }
            else
            {
                this.AutomationId = automationId;
            }
            // to ensure "actionId" is required (not null)
            if (actionId == null)
            {
                throw new InvalidDataException("actionId is a required property for StartAutomationRequest and cannot be null");
            }
            else
            {
                this.ActionId = actionId;
            }
            // to ensure "contacts" is required (not null)
            if (contacts == null)
            {
                throw new InvalidDataException("contacts is a required property for StartAutomationRequest and cannot be null");
            }
            else
            {
                this.Contacts = contacts;
            }
        }
        
        /// <summary>
        /// Gets or Sets AutomationId
        /// </summary>
        [DataMember(Name="automation_id", EmitDefaultValue=false)]
        public int? AutomationId { get; set; }

        /// <summary>
        /// Gets or Sets ActionId
        /// </summary>
        [DataMember(Name="action_id", EmitDefaultValue=false)]
        public int? ActionId { get; set; }

        /// <summary>
        /// Array of contact IDs to start automation
        /// </summary>
        /// <value>Array of contact IDs to start automation</value>
        [DataMember(Name="contacts", EmitDefaultValue=false)]
        public List<string> Contacts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartAutomationRequest {\n");
            sb.Append("  AutomationId: ").Append(AutomationId).Append("\n");
            sb.Append("  ActionId: ").Append(ActionId).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
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
            return this.Equals(input as StartAutomationRequest);
        }

        /// <summary>
        /// Returns true if StartAutomationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of StartAutomationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StartAutomationRequest input)
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
                    this.ActionId == input.ActionId ||
                    (this.ActionId != null &&
                    this.ActionId.Equals(input.ActionId))
                ) && 
                (
                    this.Contacts == input.Contacts ||
                    this.Contacts != null &&
                    this.Contacts.SequenceEqual(input.Contacts)
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
                if (this.ActionId != null)
                    hashCode = hashCode * 59 + this.ActionId.GetHashCode();
                if (this.Contacts != null)
                    hashCode = hashCode * 59 + this.Contacts.GetHashCode();
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
            // AutomationId (int?) minimum
            if(this.AutomationId < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AutomationId, must be a value greater than or equal to 1.", new [] { "AutomationId" });
            }

            // ActionId (int?) minimum
            if(this.ActionId < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ActionId, must be a value greater than or equal to 1.", new [] { "ActionId" });
            }

            yield break;
        }
    }

}
