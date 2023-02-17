using Assignment1New.EnumType;
using Assignment1New.Heros;
using Assignment1New.Heros.Items;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TestProject
{

    [TestFixture]
    public class MageTestClass
    {

        [Test]
        public void NameOfHero()
        {
            // Arrange 
            Mage mage = new Mage("TestMage");

            string expectedName = "TestMage";

            // Act 
            string name = mage.Name;

            // Assert
            Assert.That(name, Is.EqualTo(expectedName));
        }

        [Test]
        public void LevelOfHero()
        {
            // Arrange
            Mage mage = new Mage("TestMage");

            int expectedLevel = mage.Level;

            // Act
            int level = 1;

            // Assert

            Assert.That(level, Is.EqualTo(expectedLevel));
        }

        [Test]
        public void AttributesOfHeroStrength()
        {
            // Arrange
            Mage mage = new Mage("TestMage");

            int expectedStrength = 1;

            // Act
            int strength = mage.Attribute.Strength;

            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }

        [Test]
        public void AttributesOfHeroDexterity()
        {
            // Arrange
            Mage mage = new Mage("TestMage");

            int expectedDexterity = 1;
            // Act
            int dexterity = mage.Attribute.Dexterity;
            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));
        }

        [Test]
        public void AttributesOfHeroIntelligence()
        {
            // Arrange
            Mage mage = new Mage("TestMage");
            int expectedIntelligence = 8;

            // Act

            int intelligence = mage.Attribute.Intelligence;

            // Assert
            Assert.That(intelligence, Is.EqualTo(expectedIntelligence));
        }

        [Test]
        public void OnLevelUpCheckLevel()
        {

            // Arrange
            Mage mage = new Mage("TestMage");
            int expectedLevel = 2;

            // Act
            mage.LevelUp();
            int level = mage.Level;

            // Assert
            Assert.That(level, Is.EqualTo(expectedLevel));
        }

        [Test]
        public void OnLevelUpCheckStrength()
        {

            // Arrange
            Mage mage = new Mage("TestMage");
            int expectedStrength = 2;

            // Act
            mage.LevelUp();
            int strength = mage.Attribute.Strength;

            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }

        [Test]
        public void OnLevelUpCheckDexterity()
        {

            // Arrange
            Mage mage = new Mage("TestMage");
            int expectedDexterity = 2;

            // Act
            mage.LevelUp();
            int dexterity = mage.Attribute.Dexterity;

            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));
        }
        [Test]
        public void OnLevelUpCheckIntelligence()
        {
            // Arrange
            Mage mage = new Mage("TestMage");

            int expectedIntelligence = 13;
            // Act
            mage.LevelUp();
            int intelligence = mage.Attribute.Intelligence;

            // Assert
            Assert.That(intelligence, Is.EqualTo(expectedIntelligence));
        }


        [Test]
        public void CreateWeaponCheckName()
        {

            // Arrange
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Bows, 3);

            string expectedWeaponName = "Common Axe";
            // Act
            string name = newWeapon.Name;

            // Assert
            Assert.That(name, Is.EqualTo(expectedWeaponName));
        }



        [Test]
        public void CreateWeaponCheckRequiredLevel()
        {

            // Arrange
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Bows, 3);


            int expectedRequiredLevel = 1;

            // Act

            int requiredLevel = newWeapon.RequiredLevel;

            // Assert
            Assert.That(requiredLevel, Is.EqualTo(expectedRequiredLevel));
        }


        [Test]
        public void CreateWeaponCheckSlot()
        {

            // Arrange
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Bows, 3);
            string slotName = "Weapon";
            Slot expectedSlot = (Slot)Enum.Parse(typeof(Slot), slotName);

            // Act
            Slot slot = newWeapon.Slot;

            // Assert
            Assert.That(slot, Is.EqualTo(expectedSlot));
        }

        [Test]
        public void CreateWeaponCheckType()
        {

            // Arrange
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Bows, 3);
            string type = "Bows";
            WeaponType expectedWeapon = (WeaponType)Enum.Parse(typeof(WeaponType), type);

            // Act             
            WeaponType weaponType = newWeapon.Type;

            // Assert
            Assert.That(weaponType, Is.EqualTo(expectedWeapon));
        }


        [Test]
        public void CreateWeaponCheckDamage()
        {

            // Arrange
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Bows, 3);
            int expectedDamage = 3;

            // Act    
            int damage = newWeapon.Damage;

            // Assert
            Assert.That(damage, Is.EqualTo(expectedDamage));
        }


        [Test]
        public void CreateArmorCkeckName()
        {
            // Arrange
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));

            string expectedName = "Common Plate Chest";

            // Act
            string name = newArmor.Name;

            // Assert

        }

        [Test]
        public void CreateArmorCkeckRequiredLevel()
        {
            // Arrange
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));

            int expectedRequiredLevel = 1;


            // Act

            int requiredLevel = newArmor.RequiredLevel;


            // Assert

            Assert.That(requiredLevel, Is.EqualTo(expectedRequiredLevel));

        }

        [Test]
        public void CreateArmorCkeckSlot()
        {
            // Arrange
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));

            string slotName = "Body";
            Slot expectedSlotName = (Slot)Enum.Parse(typeof(Slot), slotName);


            // Act

            Slot slot = newArmor.Slot;

            // Assert
            Assert.That(slot, Is.EqualTo(expectedSlotName));
        }

        [Test]
        public void CreateArmorCkeckType()
        {
            // Arrange
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));
            string type = "Leather";
            ArmorType expectedArmorType = (ArmorType)Enum.Parse(typeof(ArmorType), type);


            // Act
            ArmorType armorType = newArmor.Type;


            // Assert
            Assert.That(armorType, Is.EqualTo(expectedArmorType));
        }

        [Test]
        public void CreateArmorCkeckArmoAttributeStrength()
        {
            // Arrange
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));
            int expectedStrength = 1;


            // Act
            int strength = newArmor.ArmoAttribute.Strength;

            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }

        [Test]
        public void CreateArmorCkeckArmoAttributeDexterity()
        {
            // Arrange
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));

            int expectedDexterity = 3;


            // Act
            int dexterity = newArmor.ArmoAttribute.Dexterity;

            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));


        }

        [Test]
        public void CreateArmorCkeckArmoAttributeIntelligence()
        {
            // Arrange
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));
            int expectedIntelligence = 1;

            // Act
            int intelligence = newArmor.ArmoAttribute.Intelligence;

            // Assert
            Assert.That(intelligence, Is.EqualTo(expectedIntelligence));

        }

        [Test]
        public void equipWeapon()
        {
            // Arrange
            Mage mage = new Mage("TestMage");

            mage.LevelUp();
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Staffs, 3);
            mage.EquipItem(newWeapon);
        }

        [Test]
        public void equipArmor()
        {
            // Arrange
            Mage mage = new Mage("TestMage");

            mage.LevelUp();
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Cloth, new HeroAttribute(1, 3, 1));

            mage.EquipItem(newArmor);
        }

        [Test]
        public void TotalAttributeStrengthBeforeAnyEquip()
        {
            // Arrange
            Mage mage = new Mage("TestMage");

            int expectedStrength = 1;

            // Act
            int strength = mage.totalAttribute.Strength;

            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }

        [Test]
        public void TotalAttributeDexterityBeforeAnyEquip()
        {
            // Arrange
            Mage mage = new Mage("TestMage");
            int expectedDexterity = 1;

            // Act
            int dexterity = mage.totalAttribute.Dexterity;

            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));
        }

        [Test]
        public void TotalAttributeIntelligenceBeforeAnyEquip()
        {
            // Arrange
            Mage mage = new Mage("TestMage");
            int expectedIntelligence = 8;

            // Act

            int intelligence = mage.totalAttribute.Intelligence;


            // Assert
            Assert.That(intelligence, Is.EqualTo(expectedIntelligence));
        }

        [Test]
        public void TotalAttributeStrengthAfterOneArmorEquip()
        {
            // Arrange
            Mage mage = new Mage("TestMage");

            int expectedStrength = 2;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Cloth, new HeroAttribute(1, 3, 1));

            mage.EquipItem(newArmor);

            int strength = mage.totalAttribute.Strength;

            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }

        [Test]
        public void TotalAttributeDexterityAfterOneArmorEquip()
        {
            // Arrange
            Mage mage = new Mage("TestMage");

            int expectedDexterity = 4;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Cloth, new HeroAttribute(1, 3, 1));

            mage.EquipItem(newArmor);

            int dexterity = mage.totalAttribute.Dexterity;

            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));

        }

        [Test]
        public void TotalAttributeIntelligenceAfterOneArmorEquip()
        {
            // Arrange
            Mage mage = new Mage("TestMage");
            int expectedIntelligence = 9;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Cloth, new HeroAttribute(1, 3, 1));

            mage.EquipItem(newArmor);
            int intelligence = mage.totalAttribute.Intelligence;

            // Assert
            Assert.That(intelligence, Is.EqualTo(expectedIntelligence));
        }

        [Test]
        public void TotalAttributeStrengthAfterTwoArmorEquip()
        {
            // Arrange
            Mage mage = new Mage("TestMage");

            int expectedStrength = 4;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Cloth, new HeroAttribute(1, 3, 1));
            var newArmor2 = new Armor("Common Plate", 1, Slot.Head, ArmorType.Cloth, new HeroAttribute(2, 1, 2));

            mage.EquipItem(newArmor);
            mage.EquipItem(newArmor2);
            int strength = mage.totalAttribute.Strength;

            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }

        [Test]
        public void TotalAttributeDexterityAfterTwoArmorEquip()
        {
            // Arrange
            Mage mage = new Mage("TestMage");
            int expectedDexterity = 5;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Cloth, new HeroAttribute(1, 3, 1));
            var newArmor2 = new Armor("Common Plate", 1, Slot.Head, ArmorType.Cloth, new HeroAttribute(2, 1, 2));

            mage.EquipItem(newArmor);
            mage.EquipItem(newArmor2);
            int dexterity = mage.totalAttribute.Dexterity;

            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));

        }

        [Test]
        public void TotalAttributeIntelligenceAfterTwoArmorEquip()
        {
            // Arrange
            Mage mage = new Mage("TestMage");
            int expectedIntelligence = 11;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Cloth, new HeroAttribute(1, 3, 1));
            var newArmor2 = new Armor("Common Plate", 1, Slot.Head, ArmorType.Cloth, new HeroAttribute(2, 1, 2));

            mage.EquipItem(newArmor);
            mage.EquipItem(newArmor2);

            int intelligence = mage.totalAttribute.Intelligence;

            // Assert
            Assert.That(intelligence, Is.EqualTo(expectedIntelligence));
        }

        [Test]
        public void TotalAttributeStrengthAfterReplacingArmor()
        {
            // Arrange
            Mage mage = new Mage("TestMage");

            int expectedStrength = 3;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Cloth, new HeroAttribute(1, 3, 1));
            var newArmor2 = new Armor("Common Plate", 1, Slot.Body, ArmorType.Cloth, new HeroAttribute(2, 1, 2));

            mage.EquipItem(newArmor);
            mage.EquipItem(newArmor2);
            int strength = mage.totalAttribute.Strength;


            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }
        [Test]
        public void TotalAttributeDexterityAfterReplacingArmor()
        {
            // Arrange
            Mage mage = new Mage("TestMage");
            int expectedDexterity = 2;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Cloth, new HeroAttribute(1, 3, 1));
            var newArmor2 = new Armor("Common Plate", 1, Slot.Body, ArmorType.Cloth, new HeroAttribute(2, 1, 2));
            mage.EquipItem(newArmor);
            mage.EquipItem(newArmor2);
            int dexterity = mage.totalAttribute.Dexterity;

            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));
        }

        [Test]
        public void TotalAttributeInteligenceAfterReplacingArmor()
        {
            // Arrange
            Mage mage = new Mage("TestMage");
            int expectedIntelligence = 10;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Cloth, new HeroAttribute(1, 3, 1));
            var newArmor2 = new Armor("Common Plate", 1, Slot.Body, ArmorType.Cloth, new HeroAttribute(2, 1, 2));

            mage.EquipItem(newArmor);
            mage.EquipItem(newArmor2);

            int intelligence = mage.totalAttribute.Intelligence;

            // Assert
            Assert.That(intelligence, Is.EqualTo(expectedIntelligence));
        }

        [Test]
        public void DamageCalculate()
        {
            // Arrange
            Mage mage = new Mage("TestMage");

            int expectedDamage = 1;
            // Act
            int damage = mage.CalculateDamage();

            // Assert

            Assert.That(damage, Is.EqualTo(expectedDamage));
        }

        [Test]
        public void DamageCalculateAfterEquipWeapon()
        {
            // Arrange
            Mage mage = new Mage("TestMage");

            int expectedDamage = 3;

            // Act
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Staffs, 3);
            mage.EquipItem(newWeapon);
            int damage = mage.CalculateDamage();

            // Assert
            Assert.That(damage, Is.EqualTo(expectedDamage));
        }

        [Test]
        public void DamageCalculateAfterReplacreEquipedWeapon()
        {
            // Arrange
            Mage mage = new Mage("TestMage");

            int expectedDamage = 2;

            // Act
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Staffs, 1);
            var newWeapon2 = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Staffs, 2);

            mage.EquipItem(newWeapon);
            mage.EquipItem(newWeapon2);

            int damage = mage.CalculateDamage();

            // Assert
            Assert.That(damage, Is.EqualTo(expectedDamage));
        }

        [Test]
        public void DamageCalculateAfterEquipArmorWeapon()
        {
            // Arrange
            Mage mage = new Mage("TestMage");

            int expectedDamage = 1;
            // Act
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Staffs, 1);
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Cloth, new HeroAttribute(1, 3, 1));

            mage.EquipItem(newWeapon);
            mage.EquipItem(newArmor);

            int damage = mage.CalculateDamage();

            // Assert
            Assert.That(damage, Is.EqualTo(expectedDamage));

        }

        [Test]
        public void HeroDisplay()
        {
            // Arrange
            Mage mage = new Mage("TestMage");

            string expectedName = "TestMage";
            int expectedLevel = 1;
            string expectedClass = "Mage";
            int expectedTotalStrength = 1;
            int expectedTotalDexterity = 1;
            int expectedTotalIntelligence = 8;
            int expectedDamage = 1;


            string expected = $"Hero's name: {expectedName}{Environment.NewLine}Hero's Class: {expectedClass}{Environment.NewLine}Hero's level: {expectedLevel}{Environment.NewLine}Hero's strength: {expectedTotalStrength}{Environment.NewLine}Hero's dexterity: {expectedTotalDexterity}{Environment.NewLine}Hero's intelligence: {expectedTotalIntelligence}{Environment.NewLine}Hero's damage: {expectedDamage}{Environment.NewLine}";

            // Act
            string expectedOutput = mage.display();

            // Assert
            Assert.That(expectedOutput, Is.EqualTo(expected));
        }
    }
}
