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
    /// Campaign voice send request schema
    /// </summary>
    [DataContract]
    public partial class CampaignVoiceSendRequest :  IEquatable<CampaignVoiceSendRequest>, IValidatableObject
    {
        /// <summary>
        /// Destination field of this campaign
        /// </summary>
        /// <value>Destination field of this campaign</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DestinationFieldEnum
        {
            /// <summary>
            /// Enum Phone for value: phone
            /// </summary>
            [EnumMember(Value = "phone")]
            Phone = 1,

            /// <summary>
            /// Enum Cellphone for value: cellphone
            /// </summary>
            [EnumMember(Value = "cellphone")]
            Cellphone = 2,

            /// <summary>
            /// Enum Phonefailsafecellphone for value: phone_failsafe_cellphone
            /// </summary>
            [EnumMember(Value = "phone_failsafe_cellphone")]
            Phonefailsafecellphone = 3,

            /// <summary>
            /// Enum Cellphonefailsafephone for value: cellphone_failsafe_phone
            /// </summary>
            [EnumMember(Value = "cellphone_failsafe_phone")]
            Cellphonefailsafephone = 4,

            /// <summary>
            /// Enum Cellphonephone for value: cellphone_phone
            /// </summary>
            [EnumMember(Value = "cellphone_phone")]
            Cellphonephone = 5

        }

        /// <summary>
        /// Destination field of this campaign
        /// </summary>
        /// <value>Destination field of this campaign</value>
        [DataMember(Name="destination_field", EmitDefaultValue=true)]
        public DestinationFieldEnum DestinationField { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignVoiceSendRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CampaignVoiceSendRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignVoiceSendRequest" /> class.
        /// </summary>
        /// <param name="listId">listId (required).</param>
        /// <param name="segments">segments (required).</param>
        /// <param name="notify">Array of IDs of the users to notify.</param>
        /// <param name="destinationField">Destination field of this campaign (required).</param>
        /// <param name="uniqueContactsOnly">True to send the campaign only to unique contacts (default to false).</param>
        /// <param name="limitContacts">limitContacts.</param>
        /// <param name="limitHour">limitHour.</param>
        /// <param name="limitSpeed">Speed limit to send the campaign.</param>
        /// <param name="scheduleDate">The date and time.</param>
        public CampaignVoiceSendRequest(int listId = default(int), OSegmentsActionSend segments = default(OSegmentsActionSend), List<int> notify = default(List<int>), DestinationFieldEnum destinationField = default(DestinationFieldEnum), bool uniqueContactsOnly = false, OLimitContactsActionSend limitContacts = default(OLimitContactsActionSend), LimitHourActionSendLimitHour limitHour = default(LimitHourActionSendLimitHour), int limitSpeed = default(int), DateTime scheduleDate = default(DateTime))
        {
            // to ensure "listId" is required (not null)
            if (listId == null)
            {
                throw new InvalidDataException("listId is a required property for CampaignVoiceSendRequest and cannot be null");
            }
            else
            {
                this.ListId = listId;
            }

            // to ensure "segments" is required (not null)
            if (segments == null)
            {
                throw new InvalidDataException("segments is a required property for CampaignVoiceSendRequest and cannot be null");
            }
            else
            {
                this.Segments = segments;
            }

            // to ensure "destinationField" is required (not null)
            if (destinationField == null)
            {
                throw new InvalidDataException("destinationField is a required property for CampaignVoiceSendRequest and cannot be null");
            }
            else
            {
                this.DestinationField = destinationField;
            }

            this.Notify = notify;
            // use default value if no "uniqueContactsOnly" provided
            if (uniqueContactsOnly == null)
            {
                this.UniqueContactsOnly = false;
            }
            else
            {
                this.UniqueContactsOnly = uniqueContactsOnly;
            }
            this.LimitContacts = limitContacts;
            this.LimitHour = limitHour;
            this.LimitSpeed = limitSpeed;
            this.ScheduleDate = scheduleDate;
        }

        /// <summary>
        /// Gets or Sets ListId
        /// </summary>
        [DataMember(Name="list_id", EmitDefaultValue=true)]
        public int ListId { get; set; }

        /// <summary>
        /// Gets or Sets Segments
        /// </summary>
        [DataMember(Name="segments", EmitDefaultValue=true)]
        public OSegmentsActionSend Segments { get; set; }

        /// <summary>
        /// Array of IDs of the users to notify
        /// </summary>
        /// <value>Array of IDs of the users to notify</value>
        [DataMember(Name="notify", EmitDefaultValue=false)]
        public List<int> Notify { get; set; }


        /// <summary>
        /// True to send the campaign only to unique contacts
        /// </summary>
        /// <value>True to send the campaign only to unique contacts</value>
        [DataMember(Name="unique_contacts_only", EmitDefaultValue=false)]
        public bool UniqueContactsOnly { get; set; }

        /// <summary>
        /// Gets or Sets LimitContacts
        /// </summary>
        [DataMember(Name="limit_contacts", EmitDefaultValue=false)]
        public OLimitContactsActionSend LimitContacts { get; set; }

        /// <summary>
        /// Gets or Sets LimitHour
        /// </summary>
        [DataMember(Name="limit_hour", EmitDefaultValue=false)]
        public LimitHourActionSendLimitHour LimitHour { get; set; }

        /// <summary>
        /// Speed limit to send the campaign
        /// </summary>
        /// <value>Speed limit to send the campaign</value>
        [DataMember(Name="limit_speed", EmitDefaultValue=false)]
        public int LimitSpeed { get; set; }

        /// <summary>
        /// The date and time
        /// </summary>
        /// <value>The date and time</value>
        [DataMember(Name="schedule_date", EmitDefaultValue=false)]
        public DateTime ScheduleDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignVoiceSendRequest {\n");
            sb.Append("  ListId: ").Append(ListId).Append("\n");
            sb.Append("  Segments: ").Append(Segments).Append("\n");
            sb.Append("  Notify: ").Append(Notify).Append("\n");
            sb.Append("  DestinationField: ").Append(DestinationField).Append("\n");
            sb.Append("  UniqueContactsOnly: ").Append(UniqueContactsOnly).Append("\n");
            sb.Append("  LimitContacts: ").Append(LimitContacts).Append("\n");
            sb.Append("  LimitHour: ").Append(LimitHour).Append("\n");
            sb.Append("  LimitSpeed: ").Append(LimitSpeed).Append("\n");
            sb.Append("  ScheduleDate: ").Append(ScheduleDate).Append("\n");
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
            return this.Equals(input as CampaignVoiceSendRequest);
        }

        /// <summary>
        /// Returns true if CampaignVoiceSendRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CampaignVoiceSendRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignVoiceSendRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ListId == input.ListId ||
                    (this.ListId != null &&
                    this.ListId.Equals(input.ListId))
                ) && 
                (
                    this.Segments == input.Segments ||
                    (this.Segments != null &&
                    this.Segments.Equals(input.Segments))
                ) && 
                (
                    this.Notify == input.Notify ||
                    this.Notify != null &&
                    input.Notify != null &&
                    this.Notify.SequenceEqual(input.Notify)
                ) && 
                (
                    this.DestinationField == input.DestinationField ||
                    (this.DestinationField != null &&
                    this.DestinationField.Equals(input.DestinationField))
                ) && 
                (
                    this.UniqueContactsOnly == input.UniqueContactsOnly ||
                    (this.UniqueContactsOnly != null &&
                    this.UniqueContactsOnly.Equals(input.UniqueContactsOnly))
                ) && 
                (
                    this.LimitContacts == input.LimitContacts ||
                    (this.LimitContacts != null &&
                    this.LimitContacts.Equals(input.LimitContacts))
                ) && 
                (
                    this.LimitHour == input.LimitHour ||
                    (this.LimitHour != null &&
                    this.LimitHour.Equals(input.LimitHour))
                ) && 
                (
                    this.LimitSpeed == input.LimitSpeed ||
                    (this.LimitSpeed != null &&
                    this.LimitSpeed.Equals(input.LimitSpeed))
                ) && 
                (
                    this.ScheduleDate == input.ScheduleDate ||
                    (this.ScheduleDate != null &&
                    this.ScheduleDate.Equals(input.ScheduleDate))
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
                if (this.ListId != null)
                    hashCode = hashCode * 59 + this.ListId.GetHashCode();
                if (this.Segments != null)
                    hashCode = hashCode * 59 + this.Segments.GetHashCode();
                if (this.Notify != null)
                    hashCode = hashCode * 59 + this.Notify.GetHashCode();
                if (this.DestinationField != null)
                    hashCode = hashCode * 59 + this.DestinationField.GetHashCode();
                if (this.UniqueContactsOnly != null)
                    hashCode = hashCode * 59 + this.UniqueContactsOnly.GetHashCode();
                if (this.LimitContacts != null)
                    hashCode = hashCode * 59 + this.LimitContacts.GetHashCode();
                if (this.LimitHour != null)
                    hashCode = hashCode * 59 + this.LimitHour.GetHashCode();
                if (this.LimitSpeed != null)
                    hashCode = hashCode * 59 + this.LimitSpeed.GetHashCode();
                if (this.ScheduleDate != null)
                    hashCode = hashCode * 59 + this.ScheduleDate.GetHashCode();
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


            // ListId (int) minimum
            if(this.ListId < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ListId, must be a value greater than or equal to 1.", new [] { "ListId" });
            }



            // LimitSpeed (int) maximum
            if(this.LimitSpeed > (int)10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LimitSpeed, must be a value less than or equal to 10.", new [] { "LimitSpeed" });
            }

            // LimitSpeed (int) minimum
            if(this.LimitSpeed < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LimitSpeed, must be a value greater than or equal to 1.", new [] { "LimitSpeed" });
            }

            yield break;
        }
    }

}
