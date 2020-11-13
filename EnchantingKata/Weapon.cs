namespace EnchantingKata
{
    public class Weapon
    {
        private readonly string name;
        public Weapon(string name)
        {
            this.name = name;
        }

        public string Name =>
            enchantment == null
                ? name
                : $"{enchantment.prefix} {name}";

        private Enchantment enchantment;

        public void Enchant(Enchantment enchantment)
        {
            this.enchantment = enchantment;
        }
    }
}