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
    /// Contact stats of the list
    /// </summary>
    [DataContract]
    public partial class ComplexListAllOfStats :  IEquatable<ComplexListAllOfStats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexListAllOfStats" /> class.
        /// </summary>
        /// <param name="totalContacts">Number of total contacts in the list.</param>
        /// <param name="totalActive">Number of total active contacts in the list.</param>
        /// <param name="totalInactive">Number of total inactive contacts in the list.</param>
        /// <param name="totalRemoved">Number of total removed contacts in the list.</param>
        /// <param name="totalUnconfirmed">Number of total unconfirmed contacts in the list.</param>
        /// <param name="totalWaitingNewConfirmation">Number of total contacts waiting for new confirmation in the list.</param>
        public ComplexListAllOfStats(int totalContacts = default(int), int totalActive = default(int), int totalInactive = default(int), int totalRemoved = default(int), int totalUnconfirmed = default(int), int totalWaitingNewConfirmation = default(int))
        {
            this.TotalContacts = totalContacts;
            this.TotalActive = totalActive;
            this.TotalInactive = totalInactive;
            this.TotalRemoved = totalRemoved;
            this.TotalUnconfirmed = totalUnconfirmed;
            this.TotalWaitingNewConfirmation = totalWaitingNewConfirmation;
        }

        /// <summary>
        /// Number of total contacts in the list
        /// </summary>
        /// <value>Number of total contacts in the list</value>
        [DataMember(Name="total_contacts", EmitDefaultValue=false)]
        public int TotalContacts { get; set; }

        /// <summary>
        /// Number of total active contacts in the list
        /// </summary>
        /// <value>Number of total active contacts in the list</value>
        [DataMember(Name="total_active", EmitDefaultValue=false)]
        public int TotalActive { get; set; }

        /// <summary>
        /// Number of total inactive contacts in the list
        /// </summary>
        /// <value>Number of total inactive contacts in the list</value>
        [DataMember(Name="total_inactive", EmitDefaultValue=false)]
        public int TotalInactive { get; set; }

        /// <summary>
        /// Number of total removed contacts in the list
        /// </summary>
        /// <value>Number of total removed contacts in the list</value>
        [DataMember(Name="total_removed", EmitDefaultValue=false)]
        public int TotalRemoved { get; set; }

        /// <summary>
        /// Number of total unconfirmed contacts in the list
        /// </summary>
        /// <value>Number of total unconfirmed contacts in the list</value>
        [DataMember(Name="total_unconfirmed", EmitDefaultValue=false)]
        public int TotalUnconfirmed { get; set; }

        /// <summary>
        /// Number of total contacts waiting for new confirmation in the list
        /// </summary>
        /// <value>Number of total contacts waiting for new confirmation in the list</value>
        [DataMember(Name="total_waiting_new_confirmation", EmitDefaultValue=false)]
        public int TotalWaitingNewConfirmation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComplexListAllOfStats {\n");
            sb.Append("  TotalContacts: ").Append(TotalContacts).Append("\n");
            sb.Append("  TotalActive: ").Append(TotalActive).Append("\n");
            sb.Append("  TotalInactive: ").Append(TotalInactive).Append("\n");
            sb.Append("  TotalRemoved: ").Append(TotalRemoved).Append("\n");
            sb.Append("  TotalUnconfirmed: ").Append(TotalUnconfirmed).Append("\n");
            sb.Append("  TotalWaitingNewConfirmation: ").Append(TotalWaitingNewConfirmation).Append("\n");
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
            return this.Equals(input as ComplexListAllOfStats);
        }

        /// <summary>
        /// Returns true if ComplexListAllOfStats instances are equal
        /// </summary>
        /// <param name="input">Instance of ComplexListAllOfStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComplexListAllOfStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalContacts == input.TotalContacts ||
                    (this.TotalContacts != null &&
                    this.TotalContacts.Equals(input.TotalContacts))
                ) && 
                (
                    this.TotalActive == input.TotalActive ||
                    (this.TotalActive != null &&
                    this.TotalActive.Equals(input.TotalActive))
                ) && 
                (
                    this.TotalInactive == input.TotalInactive ||
                    (this.TotalInactive != null &&
                    this.TotalInactive.Equals(input.TotalInactive))
                ) && 
                (
                    this.TotalRemoved == input.TotalRemoved ||
                    (this.TotalRemoved != null &&
                    this.TotalRemoved.Equals(input.TotalRemoved))
                ) && 
                (
                    this.TotalUnconfirmed == input.TotalUnconfirmed ||
                    (this.TotalUnconfirmed != null &&
                    this.TotalUnconfirmed.Equals(input.TotalUnconfirmed))
                ) && 
                (
                    this.TotalWaitingNewConfirmation == input.TotalWaitingNewConfirmation ||
                    (this.TotalWaitingNewConfirmation != null &&
                    this.TotalWaitingNewConfirmation.Equals(input.TotalWaitingNewConfirmation))
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
                if (this.TotalContacts != null)
                    hashCode = hashCode * 59 + this.TotalContacts.GetHashCode();
                if (this.TotalActive != null)
                    hashCode = hashCode * 59 + this.TotalActive.GetHashCode();
                if (this.TotalInactive != null)
                    hashCode = hashCode * 59 + this.TotalInactive.GetHashCode();
                if (this.TotalRemoved != null)
                    hashCode = hashCode * 59 + this.TotalRemoved.GetHashCode();
                if (this.TotalUnconfirmed != null)
                    hashCode = hashCode * 59 + this.TotalUnconfirmed.GetHashCode();
                if (this.TotalWaitingNewConfirmation != null)
                    hashCode = hashCode * 59 + this.TotalWaitingNewConfirmation.GetHashCode();
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
