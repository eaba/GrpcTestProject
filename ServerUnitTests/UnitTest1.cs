using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.Services;
using Shouldly;

namespace ServerUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethodException1()
        {
            var service = new FileSync();

            service.ShouldNotBeNull();

            await Task.Delay(TimeSpan.FromSeconds(1));
        }
        [TestMethod]
        public async Task TestMethodException2()
        {
            var service = new FileSync();

            service.ShouldNotBeNull();

            await Task.Delay(TimeSpan.FromSeconds(1));
        }
        [TestMethod]
        public async Task TestMethodException3()
        {
            var service = new FileSync();

            service.ShouldNotBeNull();

            await Task.Delay(TimeSpan.FromSeconds(1));
        }
        [TestMethod]
        public async Task TestMethodException4()
        {
            var service = new FileSync();

            service.ShouldNotBeNull();

            await Task.Delay(TimeSpan.FromSeconds(1));
        }
        [TestMethod]
        public async Task TestMethodException5()
        {
            var service = new FileSync();

            service.ShouldNotBeNull();

            await Task.Delay(TimeSpan.FromSeconds(1));
        }
        [TestMethod]
        public async Task TestMethodException6()
        {
            var service = new FileSync();

            service.ShouldNotBeNull();

            await Task.Delay(TimeSpan.FromSeconds(1));
        }
        [TestMethod]
        public async Task TestMethodException7()
        {
            var service = new FileSync();

            service.ShouldNotBeNull();

            await Task.Delay(TimeSpan.FromSeconds(1));
        }
        [TestMethod]
        public async Task TestMethodException8()
        {
            var service = new FileSync();

            service.ShouldNotBeNull();

            await Task.Delay(TimeSpan.FromSeconds(1));
        }
        [TestMethod]
        public async Task TestMethodException9()
        {
            var service = new FileSync();

            service.ShouldNotBeNull();

            await Task.Delay(TimeSpan.FromSeconds(1));
        }
    }
}
