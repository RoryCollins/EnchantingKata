using NUnit.Framework;

namespace EnchantingKata.Tests
{
    public class EnchantingAWeaponShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_A_Prefix_To_The_Weapon_Name()
        {
            var durance = new Durance();
            var dagger = new Weapon("dagger of the nooblet");
            durance.EnchantWeapon(dagger);

            Assert.AreEqual("Inferno dagger of the nooblet", dagger.Name);
        }

        [Test]
        public void Replace_An_Existing_Enchantment()
        {
            var durance = new Durance();
            var dagger = new Weapon("dagger of the nooblet");
            durance.EnchantWeapon(dagger);
            durance.EnchantWeapon(dagger);
            
            Assert.AreEqual("Inferno dagger of the nooblet", dagger.Name);
        }


        [Test]
        public void Describe_An_Unenchanted_Weapon()
        {
            var dagger = new Weapon("dagger of the nooblet");

            Assert.AreEqual("dagger of the nooblet", dagger.Name);   
        }
    }
}