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

        }

        [Fact]
        public void PolymorphismWorks()
        {

        }
    }
}
