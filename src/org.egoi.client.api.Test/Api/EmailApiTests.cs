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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using org.egoi.client.api.Client;
using org.egoi.client.api.Api;
using org.egoi.client.api.Model;

namespace org.egoi.client.api.Test
{
    /// <summary>
    ///  Class for testing EmailApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class EmailApiTests
    {
        private EmailApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EmailApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EmailApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EmailApi
            //Assert.IsInstanceOfType(typeof(EmailApi), instance, "instance is a EmailApi");
        }

        
        /// <summary>
        /// Test ActionEnableEmailRss
        /// </summary>
        [Test]
        public void ActionEnableEmailRssTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string campaignHash = null;
            //var response = instance.ActionEnableEmailRss(campaignHash);
            //Assert.IsInstanceOf<AcceptedResponse> (response, "response is AcceptedResponse");
        }
        
        /// <summary>
        /// Test ActionSendEmail
        /// </summary>
        [Test]
        public void ActionSendEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string campaignHash = null;
            //CampaignEmailSendRequest campaignEmailSendRequest = null;
            //var response = instance.ActionSendEmail(campaignHash, campaignEmailSendRequest);
            //Assert.IsInstanceOf<AcceptedResponse> (response, "response is AcceptedResponse");
        }
        
        /// <summary>
        /// Test CreateEmailCampaign
        /// </summary>
        [Test]
        public void CreateEmailCampaignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EmailCampaignCreate emailCampaignCreate = null;
            //var response = instance.CreateEmailCampaign(emailCampaignCreate);
            //Assert.IsInstanceOf<HashcodeCampaign> (response, "response is HashcodeCampaign");
        }
        
        /// <summary>
        /// Test CreateEmailRssCampaign
        /// </summary>
        [Test]
        public void CreateEmailRssCampaignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EmailRssCampaignCreate emailRssCampaignCreate = null;
            //var response = instance.CreateEmailRssCampaign(emailRssCampaignCreate);
            //Assert.IsInstanceOf<HashcodeCampaign> (response, "response is HashcodeCampaign");
        }
        
        /// <summary>
        /// Test PatchEmailCampaign
        /// </summary>
        [Test]
        public void PatchEmailCampaignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string campaignHash = null;
            //EmailCampaignPatch emailCampaignPatch = null;
            //var response = instance.PatchEmailCampaign(campaignHash, emailCampaignPatch);
            //Assert.IsInstanceOf<HashcodeCampaign> (response, "response is HashcodeCampaign");
        }
        
    }

}
