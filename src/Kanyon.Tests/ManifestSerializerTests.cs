using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kanyon;
using System;
using System.Collections.Generic;
using System.Text;
using Kanyon.Filters;
using Moq;
using Kanyon.Core;

namespace Kanyon.Tests
{
    [TestClass()]
    public class ManifestSerializerTests
    {
        // Test that objects are filtered correctly
        [TestMethod]
        public void ProcessManifest_RespectsFilters()
        {
            Mock<IManifestFilter> filterMock = new Mock<IManifestFilter>();
            filterMock.Setup(filter => filter.Filter(It.Is<IManifestObject>(imo => imo.Kind == "Namespace"))).Returns(false);

            var expected = new Manifest
            {
                new Kanyon.Kubernetes.Core.V1.Namespace(),
                new Kubernetes.Apps.V1.Deployment()
            };

            var sut = new ManifestSerializer(filterMock.Object);
            var actual = sut.ProcessManifest(expected);

            Assert.IsFalse(actual.Contains("kind: Namespace"));
        }

        // Test that multiple objects get rendered to the document
        
        [TestMethod()]
        public void ProcessManifestTest()
        {
            var expected = new Manifest
            {
                new Kanyon.Kubernetes.Core.V1.Namespace(),
                new Kubernetes.Apps.V1.Deployment()
            };

            var sut = new ManifestSerializer(new NoOpManifestFilter());
            var actual = sut.ProcessManifest(expected);

            Assert.IsTrue(actual.Contains("\n---\n"));
        }
    }
}