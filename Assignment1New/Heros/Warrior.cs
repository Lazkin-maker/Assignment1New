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
    public class Warrior : Hero
    {
        public List<WeaponType> WarriorValidWeapons
        {
            get { return base.ValidWeaponTypes; }
            set { base.ValidWeaponTypes = value; }
        }

        public List<ArmorType> WarriorValidArmor
        {
            get { return base.ValidArmorTypes; }
            set { base.ValidArmorTypes = new List<ArmorType> { ArmorType.Plate, ArmorType.Mail }; }
        }

        public Dictionary<Slot, Item> Equipment
        {
            get { return base.equipment; }
            set { base.equipment = value; }
        }

        public Warrior(string name) : base(name)
        {
            Attribute = new HeroAttribute(5, 2, 1);
            WarriorValidWeapons = new List<WeaponType>() { WeaponType.Axes, WeaponType.Hammers, WeaponType.Swords };
            WarriorValidArmor = new List<ArmorType>() { ArmorType.Plate, ArmorType.Mail };
        }


        public override void EquipItem(Item item)
        {
            base.EquipItem(item);
            if (item is Weapon)
            {
                Weapon weapon = (Weapon)item;
                if (!WarriorValidWeapons.Contains(weapon.Type))
                {
                    throw new InvalidItemException($"{Name} cannot equip {item.Name} because it is not an availeble weapon!");
                }
            }
            else if (item is Armor)
            {
                Armor armor = (Armor)item;
                base.EquipArmor(armor);
                if (!WarriorValidArmor.Contains(armor.Type))
                {
                    throw new InvalidArmorException($"{Name} cannot equip {armor.Name} because it is not Leather type nor Mail!");
                }

            }
        }
        public override int LevelUp()
        {
            level = level + 1;
            Attribute.Strength = Attribute.Strength + 3;
            Attribute.Dexterity = Attribute.Dexterity + 2;
            Attribute.Intelligence = Attribute.Intelligence + 1;
            return level;
        }

        /* public override void display()
         {
             base.display();
         }*/
    }
}
