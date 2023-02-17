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
    public class RogueTestClass
    {
        [Test]
        public void NameOfHero()
        {
            // Arrange 
            Rogue rogue = new Rogue("TestMage");

            string expectedName = "TestMage";

            // Act 
            string name = rogue.Name;

            // Assert
            Assert.That(name, Is.EqualTo(expectedName));
        }

        [Test]
        public void LevelOfHero()
        {
            // Arrange
            Rogue rogue = new Rogue("TestMage");

            int expectedLevel = rogue.Level;

            // Act
            int level = 1;

            // Assert

            Assert.That(level, Is.EqualTo(expectedLevel));
        }

        [Test]
        public void AttributesOfHeroStrength()
        {
            // Arrange
            Rogue rogue = new Rogue("TestMage");

            int expectedStrength = 2;

            // Act
            int strength = rogue.Attribute.Strength;

            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }

        [Test]
        public void AttributesOfHeroDexterity()
        {
            // Arrange
            Rogue rogue = new Rogue("TestMage");

            int expectedDexterity = 6;
            // Act
            int dexterity = rogue.Attribute.Dexterity;
            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));
        }

        [Test]
        public void AttributesOfHeroIntelligence()
        {
            // Arrange
            Rogue rogue = new Rogue("TestMage");
            int expectedIntelligence = 1;

            // Act

            int intelligence = rogue.Attribute.Intelligence;

            // Assert
            Assert.That(intelligence, Is.EqualTo(expectedIntelligence));
        }

        [Test]
        public void OnLevelUpCheckLevel()
        {

            // Arrange
            Rogue rogue = new Rogue("TestMage");
            int expectedLevel = 2;

            // Act
            rogue.LevelUp();
            int level = rogue.Level;

            // Assert
            Assert.That(level, Is.EqualTo(expectedLevel));
        }

        [Test]
        public void OnLevelUpCheckStrength()
        {

            // Arrange
            Rogue rogue = new Rogue("TestMage");
            int expectedStrength = 3;

            // Act
            rogue.LevelUp();
            int strength = rogue.Attribute.Strength;

            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }

        [Test]
        public void OnLevelUpCheckDexterity()
        {

            // Arrange
            Rogue rogue = new Rogue("TestMage");
            int expectedDexterity = 10;

            // Act
            rogue.LevelUp();
            int dexterity = rogue.Attribute.Dexterity;

            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));
        }
        [Test]
        public void OnLevelUpCheckIntelligence()
        {
            // Arrange
            Rogue rogue = new Rogue("TestMage");

            int expectedIntelligence = 2;
            // Act
            rogue.LevelUp();
            int intelligence = rogue.Attribute.Intelligence;

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
            Rogue rogue = new Rogue("TestMage");

            rogue.LevelUp();
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Swords, 3);
            rogue.EquipItem(newWeapon);
        }

        [Test]
        public void equipArmor()
        {
            // Arrange
            Rogue rogue = new Rogue("TestMage");

            rogue.LevelUp();
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));

            rogue.EquipItem(newArmor);
        }

        [Test]
        public void TotalAttributeStrengthBeforeAnyEquip()
        {
            // Arrange
            Rogue rogue = new Rogue("TestMage");

            int expectedStrength = 2;

            // Act
            int strength = rogue.totalAttribute.Strength;

            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }

        [Test]
        public void TotalAttributeDexterityBeforeAnyEquip()
        {
            // Arrange
            Rogue rogue = new Rogue("TestMage");
            int expectedDexterity = 6;

            // Act
            int dexterity = rogue.totalAttribute.Dexterity;

            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));
        }

        [Test]
        public void TotalAttributeIntelligenceBeforeAnyEquip()
        {
            // Arrange
            Rogue rogue = new Rogue("TestMage");
            int expectedIntelligence = 1;

            // Act

            int intelligence = rogue.totalAttribute.Intelligence;


            // Assert
            Assert.That(intelligence, Is.EqualTo(expectedIntelligence));
        }

        [Test]
        public void TotalAttributeStrengthAfterOneArmorEquip()
        {
            // Arrange
            Rogue rogue = new Rogue("TestMage");

            int expectedStrength = 3;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));

            rogue.EquipItem(newArmor);

            int strength = rogue.totalAttribute.Strength;

            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }

        [Test]
        public void TotalAttributeDexterityAfterOneArmorEquip()
        {
            // Arrange
            Rogue rogue = new Rogue("TestMage");

            int expectedDexterity = 9;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));

            rogue.EquipItem(newArmor);

            int dexterity = rogue.totalAttribute.Dexterity;

            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));

        }

        [Test]
        public void TotalAttributeIntelligenceAfterOneArmorEquip()
        {
            // Arrange
            Rogue rogue = new Rogue("TestMage");
            int expectedIntelligence = 2;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));

            rogue.EquipItem(newArmor);
            int intelligence = rogue.totalAttribute.Intelligence;

            // Assert
            Assert.That(intelligence, Is.EqualTo(expectedIntelligence));
        }

        [Test]
        public void TotalAttributeStrengthAfterTwoArmorEquip()
        {
            // Arrange
            Rogue rogue = new Rogue("TestMage");

            int expectedStrength = 5;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));
            var newArmor2 = new Armor("Common Plate", 1, Slot.Head, ArmorType.Leather, new HeroAttribute(2, 1, 2));

            rogue.EquipItem(newArmor);
            rogue.EquipItem(newArmor2);
            int strength = rogue.totalAttribute.Strength;

            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }

        [Test]
        public void TotalAttributeDexterityAfterTwoArmorEquip()
        {
            // Arrange
            Rogue rogue = new Rogue("TestMage");
            int expectedDexterity = 10;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));
            var newArmor2 = new Armor("Common Plate", 1, Slot.Head, ArmorType.Leather, new HeroAttribute(2, 1, 2));

            rogue.EquipItem(newArmor);
            rogue.EquipItem(newArmor2);
            int dexterity = rogue.totalAttribute.Dexterity;

            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));

        }

        [Test]
        public void TotalAttributeIntelligenceAfterTwoArmorEquip()
        {
            // Arrange
            Rogue rogue = new Rogue("TestMage");
            int expectedIntelligence = 4;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));
            var newArmor2 = new Armor("Common Plate", 1, Slot.Head, ArmorType.Leather, new HeroAttribute(2, 1, 2));

            rogue.EquipItem(newArmor);
            rogue.EquipItem(newArmor2);

            int intelligence = rogue.totalAttribute.Intelligence;

            // Assert
            Assert.That(intelligence, Is.EqualTo(expectedIntelligence));
        }

        [Test]
        public void TotalAttributeStrengthAfterReplacingArmor()
        {
            // Arrange
            Rogue rogue = new Rogue("TestMage");

            int expectedStrength = 4;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));
            var newArmor2 = new Armor("Common Plate", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(2, 1, 2));

            rogue.EquipItem(newArmor);
            rogue.EquipItem(newArmor2);
            int strength = rogue.totalAttribute.Strength;


            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }
        [Test]
        public void TotalAttributeDexterityAfterReplacingArmor()
        {
            // Arrange
            Rogue rogue = new Rogue("TestMage");
            int expectedDexterity = 7;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));
            var newArmor2 = new Armor("Common Plate", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(2, 1, 2));
            rogue.EquipItem(newArmor);
            rogue.EquipItem(newArmor2);
            int dexterity = rogue.totalAttribute.Dexterity;

            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));
        }

        [Test]
        public void TotalAttributeInteligenceAfterReplacingArmor()
        {
            // Arrange
            Rogue rogue = new Rogue("TestMage");
            int expectedIntelligence = 3;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));
            var newArmor2 = new Armor("Common Plate", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(2, 1, 2));

            rogue.EquipItem(newArmor);
            rogue.EquipItem(newArmor2);

            int intelligence = rogue.totalAttribute.Intelligence;

            // Assert
            Assert.That(intelligence, Is.EqualTo(expectedIntelligence));
        }

        [Test]
        public void DamageCalculate()
        {
            // Arrange
            Rogue rogue = new Rogue("TestMage");

            int expectedDamage = 1;
            // Act
            int damage = rogue.CalculateDamage();

            // Assert

            Assert.That(damage, Is.EqualTo(expectedDamage));
        }

        [Test]
        public void DamageCalculateAfterEquipWeapon()
        {
            // Arrange
            Rogue rogue = new Rogue("TestMage");

            int expectedDamage = 3;

            // Act
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Swords, 3);
            rogue.EquipItem(newWeapon);
            int damage = rogue.CalculateDamage();

            // Assert
            Assert.That(damage, Is.EqualTo(expectedDamage));
        }

        [Test]
        public void DamageCalculateAfterReplacreEquipedWeapon()
        {
            // Arrange
            Rogue rogue = new Rogue("TestMage");

            int expectedDamage = 2;

            // Act
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Swords, 1);
            var newWeapon2 = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Swords, 2);

            rogue.EquipItem(newWeapon);
            rogue.EquipItem(newWeapon2);

            int damage = rogue.CalculateDamage();

            // Assert
            Assert.That(damage, Is.EqualTo(expectedDamage));
        }

        [Test]
        public void DamageCalculateAfterEquipArmorWeapon()
        {
            // Arrange
            Rogue rogue = new Rogue("TestMage");

            int expectedDamage = 1;
            // Act
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Swords, 1);
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));

            rogue.EquipItem(newWeapon);
            rogue.EquipItem(newArmor);

            int damage = rogue.CalculateDamage();

            // Assert
            Assert.That(damage, Is.EqualTo(expectedDamage));

        }

        [Test]
        public void HeroDisplay()
        {
            // Arrange
            Rogue rogue = new Rogue("TestMage");

            string expectedName = "TestMage";
            int expectedLevel = 1;
            string expectedClass = "Rogue";
            int expectedTotalStrength = 2;
            int expectedTotalDexterity = 6;
            int expectedTotalIntelligence = 1;
            int expectedDamage = 1;


            string expected = $"Hero's name: {expectedName}{Environment.NewLine}Hero's Class: {expectedClass}{Environment.NewLine}Hero's level: {expectedLevel}{Environment.NewLine}Hero's strength: {expectedTotalStrength}{Environment.NewLine}Hero's dexterity: {expectedTotalDexterity}{Environment.NewLine}Hero's intelligence: {expectedTotalIntelligence}{Environment.NewLine}Hero's damage: {expectedDamage}{Environment.NewLine}";

            // Act
            string expectedOutput = rogue.display();

            // Assert
            Assert.That(expectedOutput, Is.EqualTo(expected));
        }
    }
}
