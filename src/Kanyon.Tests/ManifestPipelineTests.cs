using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kanyon;
using System;
using System.Collections.Generic;
using System.Text;
using Kanyon.Engine.Loaders;
using Moq;
using Kanyon.Core;
using System.Threading.Tasks;

namespace Kanyon.Tests
{
    [TestClass()]
    public class ManifestPipelineTests
    {
        /* To test, just 
         * verify LoadManifest gets called and return a manifest object for the rest of the tests, 
         * verify BuildConfiguration is called and return a Dictionary,
         * verify ManifestConfigurationProcessor.Process(...) is called,
         * verify PolicySetEvaluator.Evaluate(...) is called,
         * verify that serializer.ProcessManifest(Manifest) is called,
         * and assert that the serializer output is in the response 
         */
        [TestMethod()]
        public async Task ExecutePipelineTestAsync()
        {
            Mock<IManifestLoader> loaderMock = new Mock<IManifestLoader>();
            loaderMock.Setup(l => l.LoadManifest()).Returns(Task.FromResult(new Manifest()));

            Mock<IManifestConfigurationProcessor> processorMock = new Mock<IManifestConfigurationProcessor>();
            processorMock.Setup(p => p.BuildConfiguration()).Returns(new Dictionary<string, string>());

            Mock<IPolicySetEvaluator> policySetMock = new Mock<IPolicySetEvaluator>();

            string expected = "output: serializer";
            Mock<IManifestSerializer> serializerMock = new Mock<IManifestSerializer>();
            serializerMock.Setup(s => s.ProcessManifest(It.IsAny<Manifest>())).Returns(expected);

            var sut = new ManifestPipeline(processorMock.Object, loaderMock.Object, serializerMock.Object, policySetMock.Object);
            var actual = await sut.ExecutePipeline();

            Assert.AreEqual(expected, actual);
        }
    }
}