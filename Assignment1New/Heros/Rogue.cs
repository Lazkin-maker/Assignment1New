using Assignment1New.EnumType;
using Assignment1New.Exceptions;
using Assignment1New.Heros.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment1New.Heros
{
    public class Rogue : Hero
    {
        public List<WeaponType> RogueValidWeapons
        {
            get { return base.ValidWeaponTypes; }
            set { base.ValidWeaponTypes = value; }
        }

        public List<ArmorType> RogueValidArmor
        {
            get { return base.ValidArmorTypes; }
            set { base.ValidArmorTypes = new List<ArmorType> { ArmorType.Leather, ArmorType.Mail }; }
        }

        public Dictionary<Slot, Item> Equipment
        {
            get { return base.equipment; }
            set { base.equipment = value; }
        }

        public Rogue(string name) : base(name)
        {
            Attribute = new HeroAttribute(2, 6, 1);
            RogueValidWeapons = new List<WeaponType>() { WeaponType.Daggers, WeaponType.Swords };
            RogueValidArmor = new List<ArmorType>() { ArmorType.Leather, ArmorType.Mail };
        }


        public override void EquipItem(Item item)
        {
            base.EquipItem(item);
            if (item is Weapon)
            {
                Weapon weapon = (Weapon)item;
                if (!RogueValidWeapons.Contains(weapon.Type))
                {
                    throw new InvalidItemException($"{Name} cannot equip {item.Name} because it is not an availeble weapon!");
                }
            }
            else if (item is Armor)
            {
                Armor armor = (Armor)item;
                base.EquipArmor(armor);
                if (!RogueValidArmor.Contains(armor.Type))
                {
                    throw new InvalidArmorException($"{Name} cannot equip {armor.Name} because it is not Leather type nor Mail!");
                }

            }
        }
        public override int LevelUp()
        {
            level = level + 1;
            Attribute.Strength = Attribute.Strength + 1;
            Attribute.Dexterity = Attribute.Dexterity + 4;
            Attribute.Intelligence = Attribute.Intelligence + 1;
            return level;
        }

        /* public override void display()
         {
             base.display();
         }*/

    }
}
