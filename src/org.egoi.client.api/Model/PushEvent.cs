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
    /// Push event schema
    /// </summary>
    [DataContract]
    public partial class PushEvent :  IEquatable<PushEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PushEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PushEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PushEvent" /> class.
        /// </summary>
        /// <param name="os">The OS of the device. (required).</param>
        /// <param name="contact">The UID of the contact. (required).</param>
        /// <param name="messageHash">The hash of the campaign related to the notification. (required).</param>
        /// <param name="_event">The event to register (open, canceled). (required).</param>
        /// <param name="deviceId">The E-goi&#39;s ID of the device. (required).</param>
        public PushEvent(string os = default(string), string contact = default(string), string messageHash = default(string), string _event = default(string), int deviceId = default(int))
        {
            // to ensure "os" is required (not null)
            if (os == null)
            {
                throw new InvalidDataException("os is a required property for PushEvent and cannot be null");
            }
            else
            {
                this.Os = os;
            }

            // to ensure "contact" is required (not null)
            if (contact == null)
            {
                throw new InvalidDataException("contact is a required property for PushEvent and cannot be null");
            }
            else
            {
                this.Contact = contact;
            }

            // to ensure "messageHash" is required (not null)
            if (messageHash == null)
            {
                throw new InvalidDataException("messageHash is a required property for PushEvent and cannot be null");
            }
            else
            {
                this.MessageHash = messageHash;
            }

            // to ensure "_event" is required (not null)
            if (_event == null)
            {
                throw new InvalidDataException("_event is a required property for PushEvent and cannot be null");
            }
            else
            {
                this.Event = _event;
            }

            // to ensure "deviceId" is required (not null)
            if (deviceId == null)
            {
                throw new InvalidDataException("deviceId is a required property for PushEvent and cannot be null");
            }
            else
            {
                this.DeviceId = deviceId;
            }

        }

        /// <summary>
        /// The OS of the device.
        /// </summary>
        /// <value>The OS of the device.</value>
        [DataMember(Name="os", EmitDefaultValue=true)]
        public string Os { get; set; }

        /// <summary>
        /// The UID of the contact.
        /// </summary>
        /// <value>The UID of the contact.</value>
        [DataMember(Name="contact", EmitDefaultValue=true)]
        public string Contact { get; set; }

        /// <summary>
        /// The hash of the campaign related to the notification.
        /// </summary>
        /// <value>The hash of the campaign related to the notification.</value>
        [DataMember(Name="message_hash", EmitDefaultValue=true)]
        public string MessageHash { get; set; }

        /// <summary>
        /// The event to register (open, canceled).
        /// </summary>
        /// <value>The event to register (open, canceled).</value>
        [DataMember(Name="event", EmitDefaultValue=true)]
        public string Event { get; set; }

        /// <summary>
        /// The E-goi&#39;s ID of the device.
        /// </summary>
        /// <value>The E-goi&#39;s ID of the device.</value>
        [DataMember(Name="device_id", EmitDefaultValue=true)]
        public int DeviceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PushEvent {\n");
            sb.Append("  Os: ").Append(Os).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  MessageHash: ").Append(MessageHash).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
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
            return this.Equals(input as PushEvent);
        }

        /// <summary>
        /// Returns true if PushEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of PushEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PushEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Os == input.Os ||
                    (this.Os != null &&
                    this.Os.Equals(input.Os))
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.MessageHash == input.MessageHash ||
                    (this.MessageHash != null &&
                    this.MessageHash.Equals(input.MessageHash))
                ) && 
                (
                    this.Event == input.Event ||
                    (this.Event != null &&
                    this.Event.Equals(input.Event))
                ) && 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
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
                if (this.Os != null)
                    hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.MessageHash != null)
                    hashCode = hashCode * 59 + this.MessageHash.GetHashCode();
                if (this.Event != null)
                    hashCode = hashCode * 59 + this.Event.GetHashCode();
                if (this.DeviceId != null)
                    hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
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
