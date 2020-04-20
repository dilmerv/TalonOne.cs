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
    ///  Class for testing NewCustomerSession
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class NewCustomerSessionTests
    {
        // TODO uncomment below to declare an instance variable for NewCustomerSession
        //private NewCustomerSession instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of NewCustomerSession
            //instance = new NewCustomerSession();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NewCustomerSession
        /// </summary>
        [Test]
        public void NewCustomerSessionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" NewCustomerSession
            //Assert.IsInstanceOf(typeof(NewCustomerSession), instance);
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
        /// Test the property 'Coupon'
        /// </summary>
        [Test]
        public void CouponTest()
        {
            // TODO unit test for the property 'Coupon'
        }
        /// <summary>
        /// Test the property 'Referral'
        /// </summary>
        [Test]
        public void ReferralTest()
        {
            // TODO unit test for the property 'Referral'
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
        /// Test the property 'Identifiers'
        /// </summary>
        [Test]
        public void IdentifiersTest()
        {
            // TODO unit test for the property 'Identifiers'
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
        /// Test the property 'Attributes'
        /// </summary>
        [Test]
        public void AttributesTest()
        {
            // TODO unit test for the property 'Attributes'
        }

    }

}
