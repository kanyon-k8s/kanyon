using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kanyon;
using System;
using System.Collections.Generic;
using System.Text;
using Kanyon.Core;
using Moq;
using Kanyon.Engine.Loaders;
using System.Threading.Tasks;

namespace Kanyon.Tests
{
    [TestClass()]
    public class PolicySetEvaluatorTests
    {
        [TestMethod()]
        public async Task EvaluateTest()
        {
            var mockPolicy = new Mock<IPolicy>();
            var testSet = new PolicySet
            {
                mockPolicy.Object,
                mockPolicy.Object
            };

            var loader = new Mock<IPolicySetLoader>();
            loader.Setup(l => l.Load()).Returns(() => Task.FromResult((IEnumerable<IPolicy>)testSet));

            var expected = new Manifest
            {
                new Kanyon.Kubernetes.Core.V1.Namespace(),
                new Kubernetes.Apps.V1.Deployment()
            };

            var sut = new PolicySetEvaluator(loader.Object);
            await sut.Evaluate(expected, new Dictionary<string, string>());

            mockPolicy.Verify(p => p.Evaluate(It.IsAny<IManifestObject>(), It.IsAny<Dictionary<string, string>>()), Times.Exactly(4));
        }

        [TestMethod]
        public async Task Evaluate_WhenLoaderIsNull_NoOps()
        {
            var expected = new Manifest
            {
                new Kanyon.Kubernetes.Core.V1.Namespace(),
                new Kubernetes.Apps.V1.Deployment()
            };

            var sut = new PolicySetEvaluator(null);
            await sut.Evaluate(expected, new Dictionary<string, string>());
        }
    }
}