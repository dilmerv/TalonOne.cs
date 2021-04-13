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
    ///  Class for testing RuleFailureReason
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RuleFailureReasonTests
    {
        // TODO uncomment below to declare an instance variable for RuleFailureReason
        //private RuleFailureReason instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of RuleFailureReason
            //instance = new RuleFailureReason();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RuleFailureReason
        /// </summary>
        [Test]
        public void RuleFailureReasonInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" RuleFailureReason
            //Assert.IsInstanceOf(typeof(RuleFailureReason), instance);
        }


        /// <summary>
        /// Test the property 'CampaignID'
        /// </summary>
        [Test]
        public void CampaignIDTest()
        {
            // TODO unit test for the property 'CampaignID'
        }
        /// <summary>
        /// Test the property 'CampaignName'
        /// </summary>
        [Test]
        public void CampaignNameTest()
        {
            // TODO unit test for the property 'CampaignName'
        }
        /// <summary>
        /// Test the property 'RulesetID'
        /// </summary>
        [Test]
        public void RulesetIDTest()
        {
            // TODO unit test for the property 'RulesetID'
        }
        /// <summary>
        /// Test the property 'CouponID'
        /// </summary>
        [Test]
        public void CouponIDTest()
        {
            // TODO unit test for the property 'CouponID'
        }
        /// <summary>
        /// Test the property 'CouponValue'
        /// </summary>
        [Test]
        public void CouponValueTest()
        {
            // TODO unit test for the property 'CouponValue'
        }
        /// <summary>
        /// Test the property 'ReferralID'
        /// </summary>
        [Test]
        public void ReferralIDTest()
        {
            // TODO unit test for the property 'ReferralID'
        }
        /// <summary>
        /// Test the property 'ReferralValue'
        /// </summary>
        [Test]
        public void ReferralValueTest()
        {
            // TODO unit test for the property 'ReferralValue'
        }
        /// <summary>
        /// Test the property 'RuleIndex'
        /// </summary>
        [Test]
        public void RuleIndexTest()
        {
            // TODO unit test for the property 'RuleIndex'
        }
        /// <summary>
        /// Test the property 'RuleName'
        /// </summary>
        [Test]
        public void RuleNameTest()
        {
            // TODO unit test for the property 'RuleName'
        }
        /// <summary>
        /// Test the property 'ConditionIndex'
        /// </summary>
        [Test]
        public void ConditionIndexTest()
        {
            // TODO unit test for the property 'ConditionIndex'
        }
        /// <summary>
        /// Test the property 'EffectIndex'
        /// </summary>
        [Test]
        public void EffectIndexTest()
        {
            // TODO unit test for the property 'EffectIndex'
        }
        /// <summary>
        /// Test the property 'Details'
        /// </summary>
        [Test]
        public void DetailsTest()
        {
            // TODO unit test for the property 'Details'
        }

    }

}