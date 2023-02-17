using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1New.EnumType;
using Assignment1New.Heros.Items;
using Assignment1New.Heros;

namespace TestProject
{
    [TestFixture]
    public class WarriorTestClass
    {
        [Test]
        public void NameOfHero()
        {
            // Arrange 
            Warrior warrior = new Warrior("TestMage");

            string expectedName = "TestMage";

            // Act 
            string name = warrior.Name;

            // Assert
            Assert.That(name, Is.EqualTo(expectedName));
        }

        [Test]
        public void LevelOfHero()
        {
            // Arrange
            Warrior warrior = new Warrior("TestMage");

            int expectedLevel = warrior.Level;

            // Act
            int level = 1;

            // Assert

            Assert.That(level, Is.EqualTo(expectedLevel));
        }

        [Test]
        public void AttributesOfHeroStrength()
        {
            // Arrange
            Warrior warrior = new Warrior("TestMage");

            int expectedStrength = 5;

            // Act
            int strength = warrior.Attribute.Strength;

            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }

        [Test]
        public void AttributesOfHeroDexterity()
        {
            // Arrange
            Warrior warrior = new Warrior("TestMage");

            int expectedDexterity = 2;
            // Act
            int dexterity = warrior.Attribute.Dexterity;
            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));
        }

        [Test]
        public void AttributesOfHeroIntelligence()
        {
            // Arrange
            Warrior warrior = new Warrior("TestMage");
            int expectedIntelligence = 1;

            // Act

            int intelligence = warrior.Attribute.Intelligence;

            // Assert
            Assert.That(intelligence, Is.EqualTo(expectedIntelligence));
        }

        [Test]
        public void OnLevelUpCheckLevel()
        {

            // Arrange
            Warrior warrior = new Warrior("TestMage");
            int expectedLevel = 2;

            // Act
            warrior.LevelUp();
            int level = warrior.Level;

            // Assert
            Assert.That(level, Is.EqualTo(expectedLevel));
        }

        [Test]
        public void OnLevelUpCheckStrength()
        {

            // Arrange
            Warrior warrior = new Warrior("TestMage");
            int expectedStrength = 8;

            // Act
            warrior.LevelUp();
            int strength = warrior.Attribute.Strength;

            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }

        [Test]
        public void OnLevelUpCheckDexterity()
        {

            // Arrange
            Warrior warrior = new Warrior("TestMage");
            int expectedDexterity = 4;

            // Act
            warrior.LevelUp();
            int dexterity = warrior.Attribute.Dexterity;

            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));
        }
        [Test]
        public void OnLevelUpCheckIntelligence()
        {
            // Arrange
            Warrior warrior = new Warrior("TestMage");

            int expectedIntelligence = 2;
            // Act
            warrior.LevelUp();
            int intelligence = warrior.Attribute.Intelligence;

            // Assert
            Assert.That(intelligence, Is.EqualTo(expectedIntelligence));
        }


        [Test]
        public void CreateWeaponCheckName()
        {

            // Arrange
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Swords, 3);

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
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Swords, 3);


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
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Swords, 3);
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
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Swords, 3);
            string type = "Swords";
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
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Swords, 3);
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
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Mail, new HeroAttribute(1, 3, 1));

            string expectedName = "Common Plate Chest";

            // Act
            string name = newArmor.Name;

            // Assert

        }

        [Test]
        public void CreateArmorCkeckRequiredLevel()
        {
            // Arrange
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Mail, new HeroAttribute(1, 3, 1));

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
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Mail, new HeroAttribute(1, 3, 1));

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
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Mail, new HeroAttribute(1, 3, 1));
            string type = "Mail";
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
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Mail, new HeroAttribute(1, 3, 1));
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
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Mail, new HeroAttribute(1, 3, 1));

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
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Mail, new HeroAttribute(1, 3, 1));
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
            Rogue rogue = new Rogue("TestMage");

            rogue.LevelUp();
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Swords, 3);
            rogue.EquipItem(newWeapon);
        }

        [Test]
        public void equipArmor()
        {
            // Arrange
            Warrior warrior = new Warrior("TestMage");

            warrior.LevelUp();
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Mail, new HeroAttribute(1, 3, 1));

            warrior.EquipItem(newArmor);
        }

        [Test]
        public void TotalAttributeStrengthBeforeAnyEquip()
        {
            // Arrange
            Warrior warrior = new Warrior("TestMage");

            int expectedStrength = 5;

            // Act
            int strength = warrior.totalAttribute.Strength;

            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }

        [Test]
        public void TotalAttributeDexterityBeforeAnyEquip()
        {
            // Arrange
            Warrior warrior = new Warrior("TestMage");
            int expectedDexterity = 2;

            // Act
            int dexterity = warrior.totalAttribute.Dexterity;

            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));
        }

        [Test]
        public void TotalAttributeIntelligenceBeforeAnyEquip()
        {
            // Arrange
            Warrior warrior = new Warrior("TestMage");
            int expectedIntelligence = 1;

            // Act

            int intelligence = warrior.totalAttribute.Intelligence;


            // Assert
            Assert.That(intelligence, Is.EqualTo(expectedIntelligence));
        }

        [Test]
        public void TotalAttributeStrengthAfterOneArmorEquip()
        {
            // Arrange
            Warrior warrior = new Warrior("TestMage");

            int expectedStrength = 6;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Mail, new HeroAttribute(1, 3, 1));

            warrior.EquipItem(newArmor);

            int strength = warrior.totalAttribute.Strength;

            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }

        [Test]
        public void TotalAttributeDexterityAfterOneArmorEquip()
        {
            // Arrange
            Warrior warrior = new Warrior("TestMage");

            int expectedDexterity = 5;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Mail, new HeroAttribute(1, 3, 1));

            warrior.EquipItem(newArmor);

            int dexterity = warrior.totalAttribute.Dexterity;

            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));

        }

        [Test]
        public void TotalAttributeIntelligenceAfterOneArmorEquip()
        {
            // Arrange
            Warrior warrior = new Warrior("TestMage");
            int expectedIntelligence = 2;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Mail, new HeroAttribute(1, 3, 1));

            warrior.EquipItem(newArmor);
            int intelligence = warrior.totalAttribute.Intelligence;

            // Assert
            Assert.That(intelligence, Is.EqualTo(expectedIntelligence));
        }

        [Test]
        public void TotalAttributeStrengthAfterTwoArmorEquip()
        {
            // Arrange
            Warrior warrior = new Warrior("TestMage");

            int expectedStrength = 8;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Mail, new HeroAttribute(1, 3, 1));
            var newArmor2 = new Armor("Common Plate", 1, Slot.Head, ArmorType.Mail, new HeroAttribute(2, 1, 2));

            warrior.EquipItem(newArmor);
            warrior.EquipItem(newArmor2);
            int strength = warrior.totalAttribute.Strength;

            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }

        [Test]
        public void TotalAttributeDexterityAfterTwoArmorEquip()
        {
            // Arrange
            Warrior warrior = new Warrior("TestMage");
            int expectedDexterity = 6;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Mail, new HeroAttribute(1, 3, 1));
            var newArmor2 = new Armor("Common Plate", 1, Slot.Head, ArmorType.Mail, new HeroAttribute(2, 1, 2));

            warrior.EquipItem(newArmor);
            warrior.EquipItem(newArmor2);
            int dexterity = warrior.totalAttribute.Dexterity;

            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));

        }

        [Test]
        public void TotalAttributeIntelligenceAfterTwoArmorEquip()
        {
            // Arrange
            Warrior warrior = new Warrior("TestMage");
            int expectedIntelligence = 4;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Mail, new HeroAttribute(1, 3, 1));
            var newArmor2 = new Armor("Common Plate", 1, Slot.Head, ArmorType.Mail, new HeroAttribute(2, 1, 2));

            warrior.EquipItem(newArmor);
            warrior.EquipItem(newArmor2);

            int intelligence = warrior.totalAttribute.Intelligence;

            // Assert
            Assert.That(intelligence, Is.EqualTo(expectedIntelligence));
        }

        [Test]
        public void TotalAttributeStrengthAfterReplacingArmor()
        {
            // Arrange
            Warrior warrior = new Warrior("TestMage");

            int expectedStrength = 7;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Mail, new HeroAttribute(1, 3, 1));
            var newArmor2 = new Armor("Common Plate", 1, Slot.Body, ArmorType.Mail, new HeroAttribute(2, 1, 2));

            warrior.EquipItem(newArmor);
            warrior.EquipItem(newArmor2);
            int strength = warrior.totalAttribute.Strength;


            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }
        [Test]
        public void TotalAttributeDexterityAfterReplacingArmor()
        {
            // Arrange
            Warrior warrior = new Warrior("TestMage");
            int expectedDexterity = 3;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Mail, new HeroAttribute(1, 3, 1));
            var newArmor2 = new Armor("Common Plate", 1, Slot.Body, ArmorType.Mail, new HeroAttribute(2, 1, 2));
            warrior.EquipItem(newArmor);
            warrior.EquipItem(newArmor2);
            int dexterity = warrior.totalAttribute.Dexterity;

            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));
        }

        [Test]
        public void TotalAttributeInteligenceAfterReplacingArmor()
        {
            // Arrange
            Warrior warrior = new Warrior("TestMage");
            int expectedIntelligence = 3;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Mail, new HeroAttribute(1, 3, 1));
            var newArmor2 = new Armor("Common Plate", 1, Slot.Body, ArmorType.Mail, new HeroAttribute(2, 1, 2));

            warrior.EquipItem(newArmor);
            warrior.EquipItem(newArmor2);

            int intelligence = warrior.totalAttribute.Intelligence;

            // Assert
            Assert.That(intelligence, Is.EqualTo(expectedIntelligence));
        }

        [Test]
        public void DamageCalculate()
        {
            // Arrange
            Warrior warrior = new Warrior("TestMage");

            int expectedDamage = 1;
            // Act
            int damage = warrior.CalculateDamage();

            // Assert

            Assert.That(damage, Is.EqualTo(expectedDamage));
        }

        [Test]
        public void DamageCalculateAfterEquipWeapon()
        {
            // Arrange
            Warrior warrior = new Warrior("TestMage");

            int expectedDamage = 3;

            // Act
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Swords, 3);
            warrior.EquipItem(newWeapon);
            int damage = warrior.CalculateDamage();

            // Assert
            Assert.That(damage, Is.EqualTo(expectedDamage));
        }

        [Test]
        public void DamageCalculateAfterReplacreEquipedWeapon()
        {
            // Arrange
            Warrior warrior = new Warrior("TestMage");

            int expectedDamage = 2;

            // Act
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Swords, 1);
            var newWeapon2 = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Swords, 2);

            warrior.EquipItem(newWeapon);
            warrior.EquipItem(newWeapon2);

            int damage = warrior.CalculateDamage();

            // Assert
            Assert.That(damage, Is.EqualTo(expectedDamage));
        }

        [Test]
        public void DamageCalculateAfterEquipArmorWeapon()
        {
            // Arrange
            Warrior warrior = new Warrior("TestMage");

            int expectedDamage = 1;
            // Act
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Swords, 1);
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Mail, new HeroAttribute(1, 3, 1));

            warrior.EquipItem(newWeapon);
            warrior.EquipItem(newArmor);

            int damage = warrior.CalculateDamage();

            // Assert
            Assert.That(damage, Is.EqualTo(expectedDamage));

        }

        [Test]
        public void HeroDisplay()
        {
            // Arrange
            Warrior warrior = new Warrior("TestMage");

            string expectedName = "TestMage";
            int expectedLevel = 1;
            string expectedClass = "Warrior";
            int expectedTotalStrength = 5;
            int expectedTotalDexterity = 2;
            int expectedTotalIntelligence = 1;
            int expectedDamage = 1;


            string expected = $"Hero's name: {expectedName}{Environment.NewLine}Hero's Class: {expectedClass}{Environment.NewLine}Hero's level: {expectedLevel}{Environment.NewLine}Hero's strength: {expectedTotalStrength}{Environment.NewLine}Hero's dexterity: {expectedTotalDexterity}{Environment.NewLine}Hero's intelligence: {expectedTotalIntelligence}{Environment.NewLine}Hero's damage: {expectedDamage}{Environment.NewLine}";

            // Act
            string expectedOutput = warrior.display();

            // Assert
            Assert.That(expectedOutput, Is.EqualTo(expected));
        }
    }
}
