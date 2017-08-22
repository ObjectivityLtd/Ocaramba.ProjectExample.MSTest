// <copyright file="HerokuappTestsMsTest.cs" company="Objectivity Bespoke Software Specialists">
// Copyright (c) Objectivity Bespoke Software Specialists. All rights reserved.
// </copyright>
// <license>
//     The MIT License (MIT)
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the "Software"), to deal
//     in the Software without restriction, including without limitation the rights
//     to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//     copies of the Software, and to permit persons to whom the Software is
//     furnished to do so, subject to the following conditions:
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
//     THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//     IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//     AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//     LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//     OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//     SOFTWARE.
// </license>

using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Objectivity.Test.Automation.Common;
using Objectivity.Test.Automation.Tests.MsTest;
using Objectivity.Test.Automation.Tests.PageObjects.PageObjects.TheInternet;
using Test.Automation.ProjectExample.MsTest.PageObjects.TheInternet;

namespace Test.Automation.ProjectExample.MsTest.Tests
{
    /// <summary>
    /// Tests to verify checkboxes tick and Untick.
    /// </summary>
    [TestClass]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
    public class HerokuappTestsMsTest2 : ProjectTestBase
    {
        [TestMethod]
        public void PageSourceContainsCaseTest()
        {
            const string ExpectedText = "HTTP status codes are a standard set of numbers used to communicate from a web server";
            var statusCodes = new InternetPage(this.DriverContext)
                .OpenHomePage()
                .GoToStatusCodesPage();

            Assert.IsTrue(statusCodes.IsTextExistedInPageSource(ExpectedText), "Text is not present!");
        }

        [TestMethod]
        public void JavaScriptClickTest()
        {
            HttpCode200Page httpCode200 = new InternetPage(this.DriverContext)
               .OpenHomePage()
               .GoToStatusCodesPage()
               .Click200();

            Assert.IsTrue(httpCode200.IsHTTPCode200PageIsDisplayed(), "Code 200 was not clicked or page is not displayed.");
        }
    }
}
