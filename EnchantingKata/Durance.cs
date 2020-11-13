namespace EnchantingKata
{
    public class Durance
    {
        public void EnchantWeapon(Weapon weapon)
        {
            var fireEnchantment = new Enchantment("Inferno", "+5 fire damage");
            weapon.Enchant(fireEnchantment);
        }
    }
}