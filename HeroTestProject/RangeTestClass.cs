using Assignment1New.EnumType;
using Assignment1New.Heros.Items;
using Assignment1New.Heros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestProject
{
    [TestFixture]
    public class RangeTestClass
    {
        [Test]
        public void NameOfHero()
        {
            // Arrange 
            Ranger range = new Ranger("TestMage");

            string expectedName = "TestMage";

            // Act 
            string name = range.Name;

            // Assert
            Assert.That(name, Is.EqualTo(expectedName));
        }

        [Test]
        public void LevelOfHero()
        {
            // Arrange
            Ranger range = new Ranger("TestMage");

            int expectedLevel = range.Level;

            // Act
            int level = 1;

            // Assert

            Assert.That(level, Is.EqualTo(expectedLevel));
        }

        [Test]
        public void AttributesOfHeroStrength()
        {
            // Arrange
            Ranger range = new Ranger("TestMage");

            int expectedStrength = 1;

            // Act
            int strength = range.Attribute.Strength;

            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }

        [Test]
        public void AttributesOfHeroDexterity()
        {
            // Arrange
            Ranger range = new Ranger("TestMage");

            int expectedDexterity = 7;
            // Act
            int dexterity = range.Attribute.Dexterity;
            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));
        }

        [Test]
        public void AttributesOfHeroIntelligence()
        {
            // Arrange
            Ranger range = new Ranger("TestMage");
            int expectedIntelligence = 1;

            // Act

            int intelligence = range.Attribute.Intelligence;

            // Assert
            Assert.That(intelligence, Is.EqualTo(expectedIntelligence));
        }

        [Test]
        public void OnLevelUpCheckLevel()
        {

            // Arrange
            Ranger range = new Ranger("TestRage");
            int expectedLevel = 2;

            // Act
            range.LevelUp();
            int level = range.Level;

            // Assert
            Assert.That(level, Is.EqualTo(expectedLevel));
        }

        [Test]
        public void OnLevelUpCheckStrength()
        {

            // Arrange
            Ranger ranger = new Ranger("TestMage");
            int expectedStrength = 2;

            // Act
            ranger.LevelUp();
            int strength = ranger.Attribute.Strength;

            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }

        [Test]
        public void OnLevelUpCheckDexterity()
        {

            // Arrange
            Ranger ranger = new Ranger("TestMage");
            int expectedDexterity = 12;

            // Act
            ranger.LevelUp();
            int dexterity = ranger.Attribute.Dexterity;

            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));
        }
        [Test]
        public void OnLevelUpCheckIntelligence()
        {
            // Arrange
            Ranger ranger = new Ranger("TestMage");

            int expectedIntelligence = 2;
            // Act
            ranger.LevelUp();
            int intelligence = ranger.Attribute.Intelligence;

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
            Ranger ranger = new Ranger("TestMage");

            ranger.LevelUp();
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Bows, 3);
            ranger.EquipItem(newWeapon);
        }

        [Test]
        public void equipArmor()
        {
            // Arrange
            Ranger ranger = new Ranger("TestMage");

            ranger.LevelUp();
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));

            ranger.EquipItem(newArmor);
        }

        [Test]
        public void TotalAttributeStrengthBeforeAnyEquip()
        {
            // Arrange
            Ranger ranger = new Ranger("TestMage");

            int expectedStrength = 1;

            // Act
            int strength = ranger.totalAttribute.Strength;

            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }

        [Test]
        public void TotalAttributeDexterityBeforeAnyEquip()
        {
            // Arrange
            Ranger ranger = new Ranger("TestMage");
            int expectedDexterity = 7;

            // Act
            int dexterity = ranger.totalAttribute.Dexterity;

            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));
        }

        [Test]
        public void TotalAttributeIntelligenceBeforeAnyEquip()
        {
            // Arrange
            Ranger ranger = new Ranger("TestMage");
            int expectedIntelligence = 1;

            // Act

            int intelligence = ranger.totalAttribute.Intelligence;

            // Assert
            Assert.That(intelligence, Is.EqualTo(expectedIntelligence));
        }

        [Test]
        public void TotalAttributeStrengthAfterOneArmorEquip()
        {
            // Arrange
            Ranger ranger = new Ranger("TestMage");

            int expectedStrength = 2;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));

            ranger.EquipItem(newArmor);

            int strength = ranger.totalAttribute.Strength;

            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }

        [Test]
        public void TotalAttributeDexterityAfterOneArmorEquip()
        {
            // Arrange
            Ranger ranger = new Ranger("TestMage");

            int expectedDexterity = 10;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));

            ranger.EquipItem(newArmor);

            int dexterity = ranger.totalAttribute.Dexterity;

            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));

        }

        [Test]
        public void TotalAttributeIntelligenceAfterOneArmorEquip()
        {
            // Arrange
            Ranger ranger = new Ranger("TestMage");
            int expectedIntelligence = 2;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));

            ranger.EquipItem(newArmor);
            int intelligence = ranger.totalAttribute.Intelligence;

            // Assert
            Assert.That(intelligence, Is.EqualTo(expectedIntelligence));
        }

        [Test]
        public void TotalAttributeStrengthAfterTwoArmorEquip()
        {
            // Arrange
            Ranger ranger = new Ranger("TestMage");

            int expectedStrength = 4;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));
            var newArmor2 = new Armor("Common Plate", 1, Slot.Head, ArmorType.Mail, new HeroAttribute(2, 1, 2));

            ranger.EquipItem(newArmor);
            ranger.EquipItem(newArmor2);
            int strength = ranger.totalAttribute.Strength;

            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }

        [Test]
        public void TotalAttributeDexterityAfterTwoArmorEquip()
        {
            // Arrange
            Ranger ranger = new Ranger("TestMage");
            int expectedDexterity = 11;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));
            var newArmor2 = new Armor("Common Plate", 1, Slot.Head, ArmorType.Leather, new HeroAttribute(2, 1, 2));

            ranger.EquipItem(newArmor);
            ranger.EquipItem(newArmor2);
            int dexterity = ranger.totalAttribute.Dexterity;

            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));

        }

        [Test]
        public void TotalAttributeIntelligenceAfterTwoArmorEquip()
        {
            // Arrange
            Ranger ranger = new Ranger("TestMage");
            int expectedIntelligence = 4;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));
            var newArmor2 = new Armor("Common Plate", 1, Slot.Head, ArmorType.Mail, new HeroAttribute(2, 1, 2));

            ranger.EquipItem(newArmor);
            ranger.EquipItem(newArmor2);

            int intelligence = ranger.totalAttribute.Intelligence;

            // Assert
            Assert.That(intelligence, Is.EqualTo(expectedIntelligence));
        }

        [Test]
        public void TotalAttributeStrengthAfterReplacingArmor()
        {
            // Arrange
            Ranger ranger = new Ranger("TestMage");

            int expectedStrength = 3;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));
            var newArmor2 = new Armor("Common Plate", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(2, 1, 2));

            ranger.EquipItem(newArmor);
            ranger.EquipItem(newArmor2);
            int strength = ranger.totalAttribute.Strength;


            // Assert
            Assert.That(strength, Is.EqualTo(expectedStrength));
        }
        [Test]
        public void TotalAttributeDexterityAfterReplacingArmor()
        {
            // Arrange
            Ranger ranger = new Ranger("TestMage");
            int expectedDexterity = 8;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));
            var newArmor2 = new Armor("Common Plate", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(2, 1, 2));
            ranger.EquipItem(newArmor);
            ranger.EquipItem(newArmor2);
            int dexterity = ranger.totalAttribute.Dexterity;

            // Assert
            Assert.That(dexterity, Is.EqualTo(expectedDexterity));
        }

        [Test]
        public void TotalAttributeInteligenceAfterReplacingArmor()
        {
            // Arrange
            Ranger ranger = new Ranger("TestMage");
            int expectedIntelligence = 3;

            // Act
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));
            var newArmor2 = new Armor("Common Plate", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(2, 1, 2));

            ranger.EquipItem(newArmor);
            ranger.EquipItem(newArmor2);

            int intelligence = ranger.totalAttribute.Intelligence;

            // Assert
            Assert.That(intelligence, Is.EqualTo(expectedIntelligence));
        }

        [Test]
        public void DamageCalculate()
        {
            // Arrange
            Ranger ranger = new Ranger("TestMage");

            int expectedDamage = 1;
            // Act
            int damage = ranger.CalculateDamage();

            // Assert

            Assert.That(damage, Is.EqualTo(expectedDamage));
        }

        [Test]
        public void DamageCalculateAfterEquipWeapon()
        {
            // Arrange
            Ranger ranger = new Ranger("TestMage");

            int expectedDamage = 3;

            // Act
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Bows, 3);
            ranger.EquipItem(newWeapon);
            int damage = ranger.CalculateDamage();

            // Assert
            Assert.That(damage, Is.EqualTo(expectedDamage));
        }

        [Test]
        public void DamageCalculateAfterReplacreEquipedWeapon()
        {
            // Arrange
            Ranger ranger = new Ranger("TestMage");

            int expectedDamage = 2;

            // Act
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Bows, 1);
            var newWeapon2 = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Bows, 2);

            ranger.EquipItem(newWeapon);
            ranger.EquipItem(newWeapon2);

            int damage = ranger.CalculateDamage();

            // Assert
            Assert.That(damage, Is.EqualTo(expectedDamage));
        }

        [Test]
        public void DamageCalculateAfterEquipArmorWeapon()
        {
            // Arrange
            Ranger ranger = new Ranger("TestMage");

            int expectedDamage = 1;
            // Act
            var newWeapon = new Weapon("Common Axe", 1, Slot.Weapon, WeaponType.Bows, 1);
            var newArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(1, 3, 1));

            ranger.EquipItem(newWeapon);
            ranger.EquipItem(newArmor);

            int damage = ranger.CalculateDamage();

            // Assert
            Assert.That(damage, Is.EqualTo(expectedDamage));

        }

        [Test]
        public void HeroDisplay()
        {
            // Arrange
            Ranger ranger = new Ranger("TestMage");

            string expectedName = "TestMage";
            int expectedLevel = 1;
            string expectedClass = "Ranger";
            int expectedTotalStrength = 1;
            int expectedTotalDexterity = 7;
            int expectedTotalIntelligence = 1;
            int expectedDamage = 1;


            string expected = $"Hero's name: {expectedName}{Environment.NewLine}Hero's Class: {expectedClass}{Environment.NewLine}Hero's level: {expectedLevel}{Environment.NewLine}Hero's strength: {expectedTotalStrength}{Environment.NewLine}Hero's dexterity: {expectedTotalDexterity}{Environment.NewLine}Hero's intelligence: {expectedTotalIntelligence}{Environment.NewLine}Hero's damage: {expectedDamage}{Environment.NewLine}";

            // Act
            string expectedOutput = ranger.display();

            // Assert
            Assert.That(expectedOutput, Is.EqualTo(expected));
        }
    }
}
