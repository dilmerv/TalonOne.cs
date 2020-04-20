/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using TalonOne.Api;
using TalonOne.Model;
using TalonOne.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace TalonOne.Test
{
    /// <summary>
    ///  Class for testing CustomerSessionV2
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CustomerSessionV2Tests
    {
        // TODO uncomment below to declare an instance variable for CustomerSessionV2
        //private CustomerSessionV2 instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CustomerSessionV2
            //instance = new CustomerSessionV2();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CustomerSessionV2
        /// </summary>
        [Test]
        public void CustomerSessionV2InstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" CustomerSessionV2
            //Assert.IsInstanceOf(typeof(CustomerSessionV2), instance);
        }


        /// <summary>
        /// Test the property 'IntegrationId'
        /// </summary>
        [Test]
        public void IntegrationIdTest()
        {
            // TODO unit test for the property 'IntegrationId'
        }
        /// <summary>
        /// Test the property 'Created'
        /// </summary>
        [Test]
        public void CreatedTest()
        {
            // TODO unit test for the property 'Created'
        }
        /// <summary>
        /// Test the property 'ApplicationId'
        /// </summary>
        [Test]
        public void ApplicationIdTest()
        {
            // TODO unit test for the property 'ApplicationId'
        }
        /// <summary>
        /// Test the property 'ProfileId'
        /// </summary>
        [Test]
        public void ProfileIdTest()
        {
            // TODO unit test for the property 'ProfileId'
        }
        /// <summary>
        /// Test the property 'CouponCodes'
        /// </summary>
        [Test]
        public void CouponCodesTest()
        {
            // TODO unit test for the property 'CouponCodes'
        }
        /// <summary>
        /// Test the property 'ReferralCode'
        /// </summary>
        [Test]
        public void ReferralCodeTest()
        {
            // TODO unit test for the property 'ReferralCode'
        }
        /// <summary>
        /// Test the property 'State'
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO unit test for the property 'State'
        }
        /// <summary>
        /// Test the property 'CartItems'
        /// </summary>
        [Test]
        public void CartItemsTest()
        {
            // TODO unit test for the property 'CartItems'
        }
        /// <summary>
        /// Test the property 'AdditionalCosts'
        /// </summary>
        [Test]
        public void AdditionalCostsTest()
        {
            // TODO unit test for the property 'AdditionalCosts'
        }
        /// <summary>
        /// Test the property 'Identifiers'
        /// </summary>
        [Test]
        public void IdentifiersTest()
        {
            // TODO unit test for the property 'Identifiers'
        }
        /// <summary>
        /// Test the property 'Attributes'
        /// </summary>
        [Test]
        public void AttributesTest()
        {
            // TODO unit test for the property 'Attributes'
        }
        /// <summary>
        /// Test the property 'FirstSession'
        /// </summary>
        [Test]
        public void FirstSessionTest()
        {
            // TODO unit test for the property 'FirstSession'
        }
        /// <summary>
        /// Test the property 'Total'
        /// </summary>
        [Test]
        public void TotalTest()
        {
            // TODO unit test for the property 'Total'
        }
        /// <summary>
        /// Test the property 'CartItemTotal'
        /// </summary>
        [Test]
        public void CartItemTotalTest()
        {
            // TODO unit test for the property 'CartItemTotal'
        }
        /// <summary>
        /// Test the property 'AdditionalCostTotal'
        /// </summary>
        [Test]
        public void AdditionalCostTotalTest()
        {
            // TODO unit test for the property 'AdditionalCostTotal'
        }

    }

}
