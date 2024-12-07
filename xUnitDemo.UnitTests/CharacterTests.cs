using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xUnitDemo.Classes;

namespace xUnitDemo.UnitTests.VS
{
    public class CharacterTests
    {
        [Fact]
        public void TakeDamage_DamageMinor0_returnException()
        {
            //arranje
            var character = new Character("Link", 100);

            //assert
            Assert.Throws<ArgumentException>(() => character.TakeDamage(-10));
        }

    }
}
