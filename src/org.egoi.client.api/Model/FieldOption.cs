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
    /// Field option schema
    /// </summary>
    [DataContract]
    public partial class FieldOption :  IEquatable<FieldOption>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldOption" /> class.
        /// </summary>
        /// <param name="en">English option value.</param>
        /// <param name="pt">Portuguese option value.</param>
        /// <param name="br">Brazilian portuguese option value.</param>
        /// <param name="es">Spanish option value.</param>
        /// <param name="de">German option value.</param>
        /// <param name="hu">Hungarian option value.</param>
        /// <param name="fr">French option value.</param>
        public FieldOption(string en = default(string), string pt = default(string), string br = default(string), string es = default(string), string de = default(string), string hu = default(string), string fr = default(string))
        {
            this.En = en;
            this.Pt = pt;
            this.Br = br;
            this.Es = es;
            this.De = de;
            this.Hu = hu;
            this.Fr = fr;
        }

        /// <summary>
        /// Gets or Sets OptionId
        /// </summary>
        [DataMember(Name="option_id", EmitDefaultValue=false)]
        public int OptionId { get; private set; }

        /// <summary>
        /// English option value
        /// </summary>
        /// <value>English option value</value>
        [DataMember(Name="en", EmitDefaultValue=false)]
        public string En { get; set; }

        /// <summary>
        /// Portuguese option value
        /// </summary>
        /// <value>Portuguese option value</value>
        [DataMember(Name="pt", EmitDefaultValue=false)]
        public string Pt { get; set; }

        /// <summary>
        /// Brazilian portuguese option value
        /// </summary>
        /// <value>Brazilian portuguese option value</value>
        [DataMember(Name="br", EmitDefaultValue=false)]
        public string Br { get; set; }

        /// <summary>
        /// Spanish option value
        /// </summary>
        /// <value>Spanish option value</value>
        [DataMember(Name="es", EmitDefaultValue=false)]
        public string Es { get; set; }

        /// <summary>
        /// German option value
        /// </summary>
        /// <value>German option value</value>
        [DataMember(Name="de", EmitDefaultValue=false)]
        public string De { get; set; }

        /// <summary>
        /// Hungarian option value
        /// </summary>
        /// <value>Hungarian option value</value>
        [DataMember(Name="hu", EmitDefaultValue=false)]
        public string Hu { get; set; }

        /// <summary>
        /// French option value
        /// </summary>
        /// <value>French option value</value>
        [DataMember(Name="fr", EmitDefaultValue=false)]
        public string Fr { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldOption {\n");
            sb.Append("  OptionId: ").Append(OptionId).Append("\n");
            sb.Append("  En: ").Append(En).Append("\n");
            sb.Append("  Pt: ").Append(Pt).Append("\n");
            sb.Append("  Br: ").Append(Br).Append("\n");
            sb.Append("  Es: ").Append(Es).Append("\n");
            sb.Append("  De: ").Append(De).Append("\n");
            sb.Append("  Hu: ").Append(Hu).Append("\n");
            sb.Append("  Fr: ").Append(Fr).Append("\n");
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
            return this.Equals(input as FieldOption);
        }

        /// <summary>
        /// Returns true if FieldOption instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OptionId == input.OptionId ||
                    (this.OptionId != null &&
                    this.OptionId.Equals(input.OptionId))
                ) && 
                (
                    this.En == input.En ||
                    (this.En != null &&
                    this.En.Equals(input.En))
                ) && 
                (
                    this.Pt == input.Pt ||
                    (this.Pt != null &&
                    this.Pt.Equals(input.Pt))
                ) && 
                (
                    this.Br == input.Br ||
                    (this.Br != null &&
                    this.Br.Equals(input.Br))
                ) && 
                (
                    this.Es == input.Es ||
                    (this.Es != null &&
                    this.Es.Equals(input.Es))
                ) && 
                (
                    this.De == input.De ||
                    (this.De != null &&
                    this.De.Equals(input.De))
                ) && 
                (
                    this.Hu == input.Hu ||
                    (this.Hu != null &&
                    this.Hu.Equals(input.Hu))
                ) && 
                (
                    this.Fr == input.Fr ||
                    (this.Fr != null &&
                    this.Fr.Equals(input.Fr))
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
                if (this.OptionId != null)
                    hashCode = hashCode * 59 + this.OptionId.GetHashCode();
                if (this.En != null)
                    hashCode = hashCode * 59 + this.En.GetHashCode();
                if (this.Pt != null)
                    hashCode = hashCode * 59 + this.Pt.GetHashCode();
                if (this.Br != null)
                    hashCode = hashCode * 59 + this.Br.GetHashCode();
                if (this.Es != null)
                    hashCode = hashCode * 59 + this.Es.GetHashCode();
                if (this.De != null)
                    hashCode = hashCode * 59 + this.De.GetHashCode();
                if (this.Hu != null)
                    hashCode = hashCode * 59 + this.Hu.GetHashCode();
                if (this.Fr != null)
                    hashCode = hashCode * 59 + this.Fr.GetHashCode();
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


            // OptionId (int) minimum
            if(this.OptionId < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OptionId, must be a value greater than or equal to 1.", new [] { "OptionId" });
            }

            yield break;
        }
    }

}
