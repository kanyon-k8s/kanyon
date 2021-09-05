using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kanyon.Engine.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanyon.Engine.Configuration.Tests
{
    [TestClass()]
    public class ArgumentManifestConfigurationProviderTests
    {
        [TestMethod()]
        public void Build_CreatesConfigurationEntries()
        {
            string test = "name=happypath";
            var sut = new ArgumentManifestConfigurationProvider(new[] { test });

            Dictionary<string, string> actual = new Dictionary<string, string>();
            actual = sut.Build(actual);

            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual("happypath", actual["name"]);
        }

        [TestMethod]
        public void Build_WhenMultipleArgumentsProvided_MultipleResultsAdded()
        {
            var sut = new ArgumentManifestConfigurationProvider(new[] { 
                "name=happypath",
                "path=c:\\temppath",
                "description=The happy path"
            });

            Dictionary<string, string> actual = new Dictionary<string, string>();
            actual = sut.Build(actual);

            Assert.AreEqual(3, actual.Count);
            Assert.AreEqual("happypath", actual["name"]);
            Assert.AreEqual("c:\\temppath", actual["path"]);
            Assert.AreEqual("The happy path", actual["description"]);
        }

        [TestMethod]
        public void Build_WhenMultipleEqualsSignsInArgument_AllSignsAfterFirstIgnored()
        {
            string test = "connstring=server=localhost;user=sa;";
            var sut = new ArgumentManifestConfigurationProvider(new[] { test });

            Dictionary<string, string> actual = new Dictionary<string, string>();
            actual = sut.Build(actual);

            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual("server=localhost;user=sa;", actual["connstring"]);
        }

        [TestMethod]
        public void Build_WhenResultsStartsWithValues_ValuesArePersisted()
        {
            string test = "name=happypath";
            var sut = new ArgumentManifestConfigurationProvider(new[] { test });

            Dictionary<string, string> actual = new Dictionary<string, string>() { { "preexisting_key", "preexisting_value" } };
            actual = sut.Build(actual);

            Assert.AreEqual(2, actual.Count);
            Assert.AreEqual("happypath", actual["name"]);
            Assert.AreEqual("preexisting_value", actual["preexisting_key"]);
        }
    }
}