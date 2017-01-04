using NUnit.Framework;

namespace HowToNotFixProblems.UnitTests
{
    [TestFixture]
    public class PersonValidatorTests
    {
        private PersonValidator _Validator;

        [SetUp]
        public void SetUp()
        {
            _Validator = new PersonValidator();
        }

        [Test]
        public void Validate_AgeBelowZero_False()
        {
            var person = new Person
            {
                Age = -10,
                FirstName = "Jeff-fe-ffe",
                LastName = "Duham dot com",
                Address = new Address { HouseNumber = 10, Street = "bakerstreet" }
            };

            Assert.That(_Validator.Validate(person), Is.False);
        }
    }
}