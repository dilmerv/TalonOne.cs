/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

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
    ///  Class for testing TemplateLimitConfig
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TemplateLimitConfigTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TemplateLimitConfig
        //private TemplateLimitConfig instance;

        public TemplateLimitConfigTests()
        {
            // TODO uncomment below to create an instance of TemplateLimitConfig
            //instance = new TemplateLimitConfig();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TemplateLimitConfig
        /// </summary>
        [Fact]
        public void TemplateLimitConfigInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TemplateLimitConfig
            //Assert.IsInstanceOfType<TemplateLimitConfig> (instance, "variable 'instance' is a TemplateLimitConfig");
        }


        /// <summary>
        /// Test the property 'Action'
        /// </summary>
        [Fact]
        public void ActionTest()
        {
            // TODO unit test for the property 'Action'
        }
        /// <summary>
        /// Test the property 'Limit'
        /// </summary>
        [Fact]
        public void LimitTest()
        {
            // TODO unit test for the property 'Limit'
        }
        /// <summary>
        /// Test the property 'Period'
        /// </summary>
        [Fact]
        public void PeriodTest()
        {
            // TODO unit test for the property 'Period'
        }
        /// <summary>
        /// Test the property 'Entities'
        /// </summary>
        [Fact]
        public void EntitiesTest()
        {
            // TODO unit test for the property 'Entities'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }

    }

}