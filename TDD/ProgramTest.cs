using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    [TestFixture]
    class MyStackShould
    {
        MyStack stack;
        [Test]
        public void throw_exception_for_empty_pop()
        {
            stack = new MyStack();
            
            var ex = Assert.Throws<Exception>(() => stack.pop());
            Assert.That(ex.Message, Is.EqualTo("my exception"));
        }

        [Test]
        public void pop_last_item()
        {
            stack = new MyStack();

            stack.push("1");
            stack.push("2");
            stack.push("3");

            Assert.AreEqual(stack.pop(), "3");
        }

    }
}
