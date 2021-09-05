using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kanyon;
using System;
using System.Collections.Generic;
using System.Text;
using Kanyon.Core;
using Moq;

namespace Kanyon.Tests
{
    [TestClass()]
    public class ManifestConfigurationProcessorTests
    {
        [TestMethod()]
        public void BuildConfiguration_CreatesCaseInsensitiveResults()
        {
            var seed = new Kanyon.Engine.Configuration.ArgumentManifestConfigurationProvider(new[]
            {
                "name=happypath"
            });

            var sut = new ManifestConfigurationProcessor(new[] { seed });

            var actual = sut.BuildConfiguration();

            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual("happypath", actual["NAME"]);
        }

        [TestMethod()]
        public void BuildConfiguration_CombinesMultipleProviders()
        {
            var seed = new Kanyon.Engine.Configuration.ArgumentManifestConfigurationProvider(new[]
            {
                "name=happypath"
            });
            var seed2 = new Kanyon.Engine.Configuration.ArgumentManifestConfigurationProvider(new[]
            {
                "age=42"
            });

            var sut = new ManifestConfigurationProcessor(new[] { seed, seed2 });

            var actual = sut.BuildConfiguration();

            Assert.AreEqual(2, actual.Count);
        }

        [TestMethod()]
        public void ProcessTest()
        {
            Mock<Manifest> mock = new Mock<Manifest>();

            var sut = new ManifestConfigurationProcessor(new[] { new Engine.Configuration.ArgumentManifestConfigurationProvider(new[] { "name=happypath" }) });
            sut.Process(mock.Object, new Dictionary<string, string> { { "name", "happypath" } });

            mock.Verify(m => m.ConfigureItems(It.IsAny<Dictionary<string, string>>()));
        }
    }
}