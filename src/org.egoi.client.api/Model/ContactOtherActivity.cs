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
    /// Other contact activity schema
    /// </summary>
    [DataContract]
    public partial class ContactOtherActivity :  IEquatable<ContactOtherActivity>, IValidatableObject
    {
        /// <summary>
        /// Action name
        /// </summary>
        /// <value>Action name</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionNameEnum
        {
            /// <summary>
            /// Enum Emailopen for value: email_open
            /// </summary>
            [EnumMember(Value = "email_open")]
            Emailopen = 1,

            /// <summary>
            /// Enum Forward for value: forward
            /// </summary>
            [EnumMember(Value = "forward")]
            Forward = 2,

            /// <summary>
            /// Enum Conversion for value: conversion
            /// </summary>
            [EnumMember(Value = "conversion")]
            Conversion = 3,

            /// <summary>
            /// Enum Emailsend for value: email_send
            /// </summary>
            [EnumMember(Value = "email_send")]
            Emailsend = 4,

            /// <summary>
            /// Enum Smssend for value: sms_send
            /// </summary>
            [EnumMember(Value = "sms_send")]
            Smssend = 5,

            /// <summary>
            /// Enum Voicesend for value: voice_send
            /// </summary>
            [EnumMember(Value = "voice_send")]
            Voicesend = 6,

            /// <summary>
            /// Enum Mmssend for value: mms_send
            /// </summary>
            [EnumMember(Value = "mms_send")]
            Mmssend = 7,

            /// <summary>
            /// Enum Smsreport for value: sms_report
            /// </summary>
            [EnumMember(Value = "sms_report")]
            Smsreport = 8,

            /// <summary>
            /// Enum Voicereport for value: voice_report
            /// </summary>
            [EnumMember(Value = "voice_report")]
            Voicereport = 9,

            /// <summary>
            /// Enum Invitationsend for value: invitation_send
            /// </summary>
            [EnumMember(Value = "invitation_send")]
            Invitationsend = 10,

            /// <summary>
            /// Enum Invitationopen for value: invitation_open
            /// </summary>
            [EnumMember(Value = "invitation_open")]
            Invitationopen = 11,

            /// <summary>
            /// Enum Mmsopen for value: mms_open
            /// </summary>
            [EnumMember(Value = "mms_open")]
            Mmsopen = 12,

            /// <summary>
            /// Enum Unsubscribe for value: unsubscribe
            /// </summary>
            [EnumMember(Value = "unsubscribe")]
            Unsubscribe = 13,

            /// <summary>
            /// Enum Emailsoftbounce for value: email_soft_bounce
            /// </summary>
            [EnumMember(Value = "email_soft_bounce")]
            Emailsoftbounce = 14,

            /// <summary>
            /// Enum Emailhardbounce for value: email_hard_bounce
            /// </summary>
            [EnumMember(Value = "email_hard_bounce")]
            Emailhardbounce = 15,

            /// <summary>
            /// Enum Subscription for value: subscription
            /// </summary>
            [EnumMember(Value = "subscription")]
            Subscription = 16,

            /// <summary>
            /// Enum Resubscription for value: resubscription
            /// </summary>
            [EnumMember(Value = "resubscription")]
            Resubscription = 17,

            /// <summary>
            /// Enum Unsubscribereason for value: unsubscribe_reason
            /// </summary>
            [EnumMember(Value = "unsubscribe_reason")]
            Unsubscribereason = 18,

            /// <summary>
            /// Enum Facebooklike for value: facebook_like
            /// </summary>
            [EnumMember(Value = "facebook_like")]
            Facebooklike = 19,

            /// <summary>
            /// Enum Socialshare for value: social_share
            /// </summary>
            [EnumMember(Value = "social_share")]
            Socialshare = 20,

            /// <summary>
            /// Enum Unsubscribemanual for value: unsubscribe_manual
            /// </summary>
            [EnumMember(Value = "unsubscribe_manual")]
            Unsubscribemanual = 21,

            /// <summary>
            /// Enum Doubleoptin for value: double_optin
            /// </summary>
            [EnumMember(Value = "double_optin")]
            Doubleoptin = 22,

            /// <summary>
            /// Enum Doubleoptinresend for value: double_optin_resend
            /// </summary>
            [EnumMember(Value = "double_optin_resend")]
            Doubleoptinresend = 23,

            /// <summary>
            /// Enum Emailspamcomplaint for value: email_spam_complaint
            /// </summary>
            [EnumMember(Value = "email_spam_complaint")]
            Emailspamcomplaint = 24,

            /// <summary>
            /// Enum Emailfielddisable for value: email_field_disable
            /// </summary>
            [EnumMember(Value = "email_field_disable")]
            Emailfielddisable = 25,

            /// <summary>
            /// Enum Cellphonefielddisable for value: cellphone_field_disable
            /// </summary>
            [EnumMember(Value = "cellphone_field_disable")]
            Cellphonefielddisable = 26,

            /// <summary>
            /// Enum Phonefielddisable for value: phone_field_disable
            /// </summary>
            [EnumMember(Value = "phone_field_disable")]
            Phonefielddisable = 27,

            /// <summary>
            /// Enum Unsubscribeapi for value: unsubscribe_api
            /// </summary>
            [EnumMember(Value = "unsubscribe_api")]
            Unsubscribeapi = 28,

            /// <summary>
            /// Enum Emailfieldenable for value: email_field_enable
            /// </summary>
            [EnumMember(Value = "email_field_enable")]
            Emailfieldenable = 29,

            /// <summary>
            /// Enum Cellphonefieldenable for value: cellphone_field_enable
            /// </summary>
            [EnumMember(Value = "cellphone_field_enable")]
            Cellphonefieldenable = 30,

            /// <summary>
            /// Enum Phonefieldenable for value: phone_field_enable
            /// </summary>
            [EnumMember(Value = "phone_field_enable")]
            Phonefieldenable = 31,

            /// <summary>
            /// Enum Editsubscription for value: edit_subscription
            /// </summary>
            [EnumMember(Value = "edit_subscription")]
            Editsubscription = 32,

            /// <summary>
            /// Enum Doubleoptedit for value: double_optedit
            /// </summary>
            [EnumMember(Value = "double_optedit")]
            Doubleoptedit = 33,

            /// <summary>
            /// Enum Automationevent for value: automation_event
            /// </summary>
            [EnumMember(Value = "automation_event")]
            Automationevent = 34,

            /// <summary>
            /// Enum Pushsend for value: push_send
            /// </summary>
            [EnumMember(Value = "push_send")]
            Pushsend = 35,

            /// <summary>
            /// Enum Pushopen for value: push_open
            /// </summary>
            [EnumMember(Value = "push_open")]
            Pushopen = 36,

            /// <summary>
            /// Enum Pushreceived for value: push_received
            /// </summary>
            [EnumMember(Value = "push_received")]
            Pushreceived = 37,

            /// <summary>
            /// Enum Pusherror for value: push_error
            /// </summary>
            [EnumMember(Value = "push_error")]
            Pusherror = 38,

            /// <summary>
            /// Enum Pushcanceled for value: push_canceled
            /// </summary>
            [EnumMember(Value = "push_canceled")]
            Pushcanceled = 39,

            /// <summary>
            /// Enum Replytoemail for value: reply_to_email
            /// </summary>
            [EnumMember(Value = "reply_to_email")]
            Replytoemail = 40,

            /// <summary>
            /// Enum Webpushsend for value: web_push_send
            /// </summary>
            [EnumMember(Value = "web_push_send")]
            Webpushsend = 41,

            /// <summary>
            /// Enum Webpushdelivered for value: web_push_delivered
            /// </summary>
            [EnumMember(Value = "web_push_delivered")]
            Webpushdelivered = 42,

            /// <summary>
            /// Enum Webpushopen for value: web_push_open
            /// </summary>
            [EnumMember(Value = "web_push_open")]
            Webpushopen = 43,

            /// <summary>
            /// Enum Webpushbounce for value: web_push_bounce
            /// </summary>
            [EnumMember(Value = "web_push_bounce")]
            Webpushbounce = 44,

            /// <summary>
            /// Enum Webpushsubscription for value: web_push_subscription
            /// </summary>
            [EnumMember(Value = "web_push_subscription")]
            Webpushsubscription = 45,

            /// <summary>
            /// Enum Webpushunsubscription for value: web_push_unsubscription
            /// </summary>
            [EnumMember(Value = "web_push_unsubscription")]
            Webpushunsubscription = 46,

            /// <summary>
            /// Enum Addpushcontact for value: add_push_contact
            /// </summary>
            [EnumMember(Value = "add_push_contact")]
            Addpushcontact = 47,

            /// <summary>
            /// Enum Removepushcontact for value: remove_push_contact
            /// </summary>
            [EnumMember(Value = "remove_push_contact")]
            Removepushcontact = 48,

            /// <summary>
            /// Enum Forgetsubscription for value: forget_subscription
            /// </summary>
            [EnumMember(Value = "forget_subscription")]
            Forgetsubscription = 49,

            /// <summary>
            /// Enum Changeconsent for value: change_consent
            /// </summary>
            [EnumMember(Value = "change_consent")]
            Changeconsent = 50,

            /// <summary>
            /// Enum Pushunsubscription for value: push_unsubscription
            /// </summary>
            [EnumMember(Value = "push_unsubscription")]
            Pushunsubscription = 51

        }

        /// <summary>
        /// Action name
        /// </summary>
        /// <value>Action name</value>
        [DataMember(Name="action_name", EmitDefaultValue=false)]
        public ActionNameEnum? ActionName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactOtherActivity" /> class.
        /// </summary>
        /// <param name="date">The date and time.</param>
        /// <param name="actionName">Action name.</param>
        public ContactOtherActivity(DateTime? date = default(DateTime?), ActionNameEnum? actionName = default(ActionNameEnum?))
        {
            this.Date = date;
            this.ActionName = actionName;
        }
        
        /// <summary>
        /// The date and time
        /// </summary>
        /// <value>The date and time</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactOtherActivity {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  ActionName: ").Append(ActionName).Append("\n");
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
            return this.Equals(input as ContactOtherActivity);
        }

        /// <summary>
        /// Returns true if ContactOtherActivity instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactOtherActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactOtherActivity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.ActionName == input.ActionName ||
                    (this.ActionName != null &&
                    this.ActionName.Equals(input.ActionName))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.ActionName != null)
                    hashCode = hashCode * 59 + this.ActionName.GetHashCode();
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
