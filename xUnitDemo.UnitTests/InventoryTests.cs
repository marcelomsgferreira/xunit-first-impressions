using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xUnitDemo.Classes;

namespace xUnitDemo.UnitTests.VS
{
    public class InventoryTests
    {
        [Fact]
        public void AddItem_WhenItemIsNull_ShouldThrowArgumentException()
        {
            // Arrange
            var inventory = new Inventory(3);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => inventory.AddItem(null));
        }

        [Fact]
        public void AddItem_WhenItemIsEmpty_ShouldThrowArgumentException()
        {
            // Arrange
            var inventory = new Inventory(3);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => inventory.AddItem(string.Empty));
        }

        [Fact]
        public void AddItem_WhenCapacityIsExceeded_ShouldReturnFalse()
        {
            // Arrange
            var inventory = new Inventory(2);
            inventory.AddItem("Item1");
            inventory.AddItem("Item2");

            // Act
            var result = inventory.AddItem("Item3");

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void AddItem_WhenItemIsAddedSuccessfully_ShouldReturnTrue()
        {
            // Arrange
            var inventory = new Inventory(3);

            // Act
            var result = inventory.AddItem("NewItem");

            // Assert
            Assert.True(result);
        }
      
    }
}
