using NUnit.Framework;

namespace HowToNotFixProblems.UnitTests
{
    [TestFixture]
    public class AddressValidatorTests
    {
        private AddressValidator _Validator;

        [SetUp]
        public void SetUp()
        {
            _Validator = new AddressValidator();
        }

        [Test]
        public void Validate_HouseNumberBeyond100_False()
        {
            Assert.That(_Validator.Validate(new Address { HouseNumber = 200 }), Is.False);
        }

        [Test]
        public void Validate_HouseNumberLowerThan100_True()
        {
            Assert.That(_Validator.Validate(new Address { HouseNumber = 50 }), Is.True);
        }
    }
}