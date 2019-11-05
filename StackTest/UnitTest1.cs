using NUnit.Framework;
using System;
using System.Collections.Generic;
using Moq;
using Stack;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            var mock = new Mock<IStorage>();
            //private Order _order;
            var service = new OrderService(mock.Object);
        }

        [Test]
        public void Test()
        {
            var mock = new Mock<IStorage>();
            Order _order = new Order();
            var service = new OrderService(mock.Object);
            //mock.Setup(s => s.Store(_order)).Returns(3);
            mock.Setup(s => s.Store(null)).Throws(new ArgumentException());
            var result = service.PlaceOrder(null);
            //mock.Verify(s => s.Store(_order), Times.Once);
            Assert.That(result, Is.EqualTo(-1));
            //Assert.That(result,Is.EqualTo(3));
        }








    //    [TestCase("Kod")]
    //    [TestCase("Malpa")]
    //    public void StackPush(string a)
    //    {
    //        List<string> _list = new List<string>();
    //        if (a == null)
    //            throw new ArgumentNullException();
    //        _list.Add(a);
    //        Assert.AreEqual(a, _list[_list.Count - 1]);
    //       // Assert.That(()=>);
    //    }
    //    [TestCase("Kod")]
    //    [TestCase("Malpa")]
    //    public void StackPop(string a)
    //    {
    //        List<string> _list = new List<string>();
    //        _list.Add(a);
    //        _list.Add(a);
    //        _list.RemoveAt(_list.Count - 1);
    //        Assert.AreEqual(1, _list.Count);
    //    }
    //    [TestCase("Kod")]
    //    [TestCase("Malpa")]
    //    public void StackPeak(string a)
    //    {
    //        List<string> _list = new List<string>();
    //        string c = a + "alfa";
    //        _list.Add(c);
    //        _list.Add(a+"cos");
    //        string final = _list[_list.Count - 1];
    //        Assert.AreEqual(a+"cos", final);
    //    }
    //    [TestCase("Kod")]
    //    [TestCase("Malpa")]
    //    public void ListCount(String a)
    //    {
    //        List<string> _list = new List<string>();
            
    //}

    }
}