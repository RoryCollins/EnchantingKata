using System;
using NUnit.Framework;

namespace EnchantingKata.Tests
{
    [TestFixture]
    public class EnchantmentShould
    {
        [Test]
        public void Throw_Exception_For_Null_Prefix()
        {
            Assert.Throws<ArgumentNullException>(() => new Enchantment(null, "+5 fire damage"));
        }

        [Test]
        public void Throw_Exception_For_Null_Attribute()
        {
            Assert.Throws<ArgumentNullException>(() => new Enchantment("Inferno", null));
        }
    }
}