using FluentAssertions;
using FluentExtensions.Object;
using Newtonsoft.Json;
using NUnit.Framework;

namespace FluentExtensions.Tests.Object
{
    [TestFixture]
    public class ObjectToJsonExtensionTests
    {
        [Test]
        public void TestObjectToJson()
        {
            var myObj = new
            {
                FirstName = "John",
                LastName = "Doe"
            };

            var json = myObj.ToJson();
            json.Should().Be(JsonConvert.SerializeObject(myObj));
        }

        [Test]
        public void TestObjectToPrettyJson()
        {
            var myObj = new
            {
                FirstName = "John",
                LastName = "Doe"
            };

            var json = myObj.ToPrettyJson();
            json.Should().Be(JsonConvert.SerializeObject(myObj, Formatting.Indented));
        }

        [Test]
        public void TestObjectToJsonPreservingReferences()
        {
            var myObj = new
            {
                FirstName = "John",
                LastName = "Doe"
            };

            var json = myObj.ToJsonPreservingReferences();
            json.Should().Be(JsonConvert.SerializeObject(myObj, Formatting.None, new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            }));
        }

        [Test]
        public void TestObjectToPrettyJsonPreservingReferences()
        {
            var myObj = new
            {
                FirstName = "John",
                LastName = "Doe"
            };

            var json = myObj.ToPrettyJsonPreservingReferences();
            json.Should().Be(JsonConvert.SerializeObject(myObj, Formatting.Indented, new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            }));
        }
    }
}