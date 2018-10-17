/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/

/* 
 * Loan
 *
 * Returns the entire loan or specific entities of a loan.
 *
 * OpenAPI spec version: 1.3.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Elli.Api.Loans.Client;
using Elli.Api.Loans.Api;
using Elli.Api.Loans.Model;

namespace Elli.Api.Loans.Test
{
    /// <summary>
    ///  Class for testing DisclosureTracking2015Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DisclosureTracking2015ApiTests
    {
        private DisclosureTracking2015Api instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DisclosureTracking2015Api();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DisclosureTracking2015Api
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DisclosureTracking2015Api
            //Assert.IsInstanceOfType(typeof(DisclosureTracking2015Api), instance, "instance is a DisclosureTracking2015Api");
        }

        
        /// <summary>
        /// Test GetAllLoanDisclosureTracking2015Logs
        /// </summary>
        [Test]
        public void GetAllLoanDisclosureTracking2015LogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loanId = null;
            //var response = instance.GetAllLoanDisclosureTracking2015Logs(loanId);
            //Assert.IsInstanceOf<List<DisclosureTracking2015Contract>> (response, "response is List<DisclosureTracking2015Contract>");
        }
        
        /// <summary>
        /// Test GetLoanDisclosureTracking2015Log
        /// </summary>
        [Test]
        public void GetLoanDisclosureTracking2015LogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loanId = null;
            //string logId = null;
            //var response = instance.GetLoanDisclosureTracking2015Log(loanId, logId);
            //Assert.IsInstanceOf<DisclosureTracking2015Contract> (response, "response is DisclosureTracking2015Contract");
        }
        
        /// <summary>
        /// Test GetLoanDisclosureTracking2015Snapshot
        /// </summary>
        [Test]
        public void GetLoanDisclosureTracking2015SnapshotTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loanId = null;
            //string logId = null;
            //string type = null;
            //var response = instance.GetLoanDisclosureTracking2015Snapshot(loanId, logId, type);
            //Assert.IsInstanceOf<Dictionary<string, string>> (response, "response is Dictionary<string, string>");
        }
        
    }

}
