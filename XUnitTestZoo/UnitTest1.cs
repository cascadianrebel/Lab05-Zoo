using System;
using Xunit;
using Lab05_Zoo.Classes;
using Lab05_Zoo.Interfaces;
using Lab05_Zoo;

namespace XUnitTestZoo
{
    public class UnitTest1
    {
        [Fact]
        public void InterfacesCanImplement()
        {
            Bat testBat = new Bat();
            Crow testCrow = new Crow();
            Dolphin testDolphin = new Dolphin();
            Owl testOwl = new Owl();
            Penguin testPenguin = new Penguin();
            SeaOtter testOtter = new SeaOtter();
            Snake testSnake = new Snake();

            Assert.True(testBat.Fly());
            Assert.True(testCrow.Fly());
            Assert.True(testDolphin.Carnivore());
            Assert.True(testOwl.Fly());
            Assert.True(testPenguin.Carnivore());
            Assert.True(testOtter.Carnivore());
            Assert.True(testSnake.Carnivore());
            Assert.True(testOwl.Carnivore());
            
        }

        [Fact]
        public void CanInherit()
        {
            Bat testBat = new Bat();
            Crow testCrow = new Crow();
            Dolphin testDolphin = new Dolphin();
            Owl testOwl = new Owl();
            Penguin testPenguin = new Penguin();
            SeaOtter testOtter = new SeaOtter();
            Snake testSnake = new Snake();

            Assert.False(testBat.Extinct);
            Assert.False(testCrow.WarmBlooded);
            Assert.True(testDolphin.LiveBirth);
            Assert.True(testOwl.LaysEggs);
            Assert.False(testPenguin.Dangerous);
            Assert.True(testOtter.HasLegs);
            Assert.True(testSnake.ForkedTongue);           
        }

        [Fact]
        public void PolymorphismWorks()
        {
            Lizard testLizard = new Lizard();
            Owl testOwl = new Owl();
            Penguin testPenguin = new Penguin();
            Crow testCrow = new Crow();

            Assert.IsAssignableFrom<Animals>(testLizard);
            Assert.Equal("Parliament", testOwl.GroupName() );
            Assert.Equal("Murder", testCrow.GroupName());
            Assert.Equal("colony", testPenguin.GroupName());
        }
    }
}
