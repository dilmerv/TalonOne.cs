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
    ///  Class for testing InventoryCoupon
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class InventoryCouponTests
    {
        // TODO uncomment below to declare an instance variable for InventoryCoupon
        //private InventoryCoupon instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of InventoryCoupon
            //instance = new InventoryCoupon();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InventoryCoupon
        /// </summary>
        [Test]
        public void InventoryCouponInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" InventoryCoupon
            //Assert.IsInstanceOf(typeof(InventoryCoupon), instance);
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
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
        /// Test the property 'CampaignId'
        /// </summary>
        [Test]
        public void CampaignIdTest()
        {
            // TODO unit test for the property 'CampaignId'
        }
        /// <summary>
        /// Test the property 'Value'
        /// </summary>
        [Test]
        public void ValueTest()
        {
            // TODO unit test for the property 'Value'
        }
        /// <summary>
        /// Test the property 'UsageLimit'
        /// </summary>
        [Test]
        public void UsageLimitTest()
        {
            // TODO unit test for the property 'UsageLimit'
        }
        /// <summary>
        /// Test the property 'DiscountLimit'
        /// </summary>
        [Test]
        public void DiscountLimitTest()
        {
            // TODO unit test for the property 'DiscountLimit'
        }
        /// <summary>
        /// Test the property 'StartDate'
        /// </summary>
        [Test]
        public void StartDateTest()
        {
            // TODO unit test for the property 'StartDate'
        }
        /// <summary>
        /// Test the property 'ExpiryDate'
        /// </summary>
        [Test]
        public void ExpiryDateTest()
        {
            // TODO unit test for the property 'ExpiryDate'
        }
        /// <summary>
        /// Test the property 'UsageCounter'
        /// </summary>
        [Test]
        public void UsageCounterTest()
        {
            // TODO unit test for the property 'UsageCounter'
        }
        /// <summary>
        /// Test the property 'DiscountCounter'
        /// </summary>
        [Test]
        public void DiscountCounterTest()
        {
            // TODO unit test for the property 'DiscountCounter'
        }
        /// <summary>
        /// Test the property 'DiscountRemainder'
        /// </summary>
        [Test]
        public void DiscountRemainderTest()
        {
            // TODO unit test for the property 'DiscountRemainder'
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
        /// Test the property 'ReferralId'
        /// </summary>
        [Test]
        public void ReferralIdTest()
        {
            // TODO unit test for the property 'ReferralId'
        }
        /// <summary>
        /// Test the property 'RecipientIntegrationId'
        /// </summary>
        [Test]
        public void RecipientIntegrationIdTest()
        {
            // TODO unit test for the property 'RecipientIntegrationId'
        }
        /// <summary>
        /// Test the property 'ImportId'
        /// </summary>
        [Test]
        public void ImportIdTest()
        {
            // TODO unit test for the property 'ImportId'
        }
        /// <summary>
        /// Test the property 'Reservation'
        /// </summary>
        [Test]
        public void ReservationTest()
        {
            // TODO unit test for the property 'Reservation'
        }
        /// <summary>
        /// Test the property 'BatchId'
        /// </summary>
        [Test]
        public void BatchIdTest()
        {
            // TODO unit test for the property 'BatchId'
        }
        /// <summary>
        /// Test the property 'ProfileRedemptionCount'
        /// </summary>
        [Test]
        public void ProfileRedemptionCountTest()
        {
            // TODO unit test for the property 'ProfileRedemptionCount'
        }
        /// <summary>
        /// Test the property 'State'
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO unit test for the property 'State'
        }

    }

}