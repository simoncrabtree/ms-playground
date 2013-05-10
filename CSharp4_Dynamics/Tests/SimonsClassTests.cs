using CSharp4_Dynamics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class SimonsClassTests
    {
        [TestMethod]
        public void ConstructObject()
        {
            var myClass = new SimonsClass();

            Assert.AreEqual("", myClass.Name);
        }

        [TestMethod]
        public void CallNamedArgument()
        {
            var myClass = new SimonsClass();

            var result = myClass.DoSomething(name: "Simon", address: "1 Main Street");
            
            Assert.AreEqual("Hello Simon from 1 Main Street", result);
        }

        [TestMethod]
        public void NamedAndOptionalParameters()
        {
            var myClass = new SimonsClass();

            var helloSimon = myClass.SayHello(name: "Simon");
            var hiDave = myClass.SayHello(name: "Dave", greeting: "Hi");
            var helloEveryone = myClass.SayHello();

            Assert.AreEqual("Hello Simon", helloSimon);
            Assert.AreEqual("Hi Dave", hiDave);
            Assert.AreEqual("Hello Everyone", helloEveryone);
        }
    }
}
