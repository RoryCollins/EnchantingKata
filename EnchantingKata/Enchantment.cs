using System;

namespace EnchantingKata
{
    public class Enchantment
    {
        public string prefix;
        private string attribute;

        public Enchantment(string prefix, string attribute)
        {
            this.prefix = prefix ?? throw new ArgumentNullException(nameof(prefix));
            this.attribute = attribute ?? throw new ArgumentNullException(nameof(attribute));
        }
    }
}