using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xUnitDemo.Classes;
namespace xUnitDemo.UnitTests.VS
{
    public class UserValidatorTests
    {
        [Fact]
        public void IsValidEmail_IsNullOrEmpty_ReturnsTrue()
        {
            //arranje
            var UserValidator = new UserValidator();
            string email = "marcelo@gmail.com";

            //act
            var result = UserValidator.IsValidEmail(email);

            //assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidEmail_IsNullOrEmpty_ReturnsFalse()
        {
            //arranje
            var UserValidator = new UserValidator();
            string email = "   ";

            //act
            var result = UserValidator.IsValidEmail(email);

            //assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidEmail_contaisA_ReturnsTrue()
        {
            //arranje
            var UserValidator = new UserValidator();
            string email = "asdasd asd@asdasd.com";

            //act
            var result = UserValidator.IsValidEmail(email);

            //assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidEmail_contaisA_ReturnsFalse()
        {
            //arranje
            var UserValidator = new UserValidator();
            string email = "asdasdasd sda ";

            //act
            var result = UserValidator.IsValidEmail(email);

            //assert
            Assert.False(result);
        }

        [Fact]
        public void IsValidEmail_contaisDot_ReturnsTrue()
        {
            //arranje
            var UserValidator = new UserValidator();
            string email = "asdasd asd@asdasd.com";

            //act
            var result = UserValidator.IsValidEmail(email);

            //assert
            Assert.True(result);
        }

        [Fact]
        public void IsValidEmail_contaisDot_ReturnsFalse()
        {
            //arranje
            var UserValidator = new UserValidator();
            string email = "asdasdasd sda ";

            //act
            var result = UserValidator.IsValidEmail(email);

            //assert
            Assert.False(result);
        }

        //////////////////////////////////////////
        
        [Fact]
        public void IsAdult_AgeMinorThan18_ReturnFalse()
        {
            //arranje
            var userValidator = new UserValidator();

            //act
            var result = userValidator.IsAdult(new DateTime(2010, 6, 12, 3, 39, 25, 929));

            //assert
            Assert.False(result);
        }

        [Fact]
        public void IsAdult_AgeMajorThan18_ReturnTrue()
        {
            //arranje
            var userValidator = new UserValidator();

            //act
            var result = userValidator.IsAdult(new DateTime(2000, 6, 12, 3, 39, 25, 929));

            //assert
            Assert.True(result);
        }
    }
}
