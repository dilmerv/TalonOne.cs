/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
    ///  Class for testing CustomerProfile
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CustomerProfileTests
    {
        // TODO uncomment below to declare an instance variable for CustomerProfile
        //private CustomerProfile instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CustomerProfile
            //instance = new CustomerProfile();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CustomerProfile
        /// </summary>
        [Test]
        public void CustomerProfileInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CustomerProfile
            //Assert.IsInstanceOfType<CustomerProfile> (instance, "variable 'instance' is a CustomerProfile");
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
        /// Test the property 'Attributes'
        /// </summary>
        [Test]
        public void AttributesTest()
        {
            // TODO unit test for the property 'Attributes'
        }
        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Test]
        public void AccountIdTest()
        {
            // TODO unit test for the property 'AccountId'
        }
        /// <summary>
        /// Test the property 'ClosedSessions'
        /// </summary>
        [Test]
        public void ClosedSessionsTest()
        {
            // TODO unit test for the property 'ClosedSessions'
        }
        /// <summary>
        /// Test the property 'TotalSales'
        /// </summary>
        [Test]
        public void TotalSalesTest()
        {
            // TODO unit test for the property 'TotalSales'
        }
        /// <summary>
        /// Test the property 'LoyaltyMemberships'
        /// </summary>
        [Test]
        public void LoyaltyMembershipsTest()
        {
            // TODO unit test for the property 'LoyaltyMemberships'
        }
        /// <summary>
        /// Test the property 'LastActivity'
        /// </summary>
        [Test]
        public void LastActivityTest()
        {
            // TODO unit test for the property 'LastActivity'
        }

    }

}