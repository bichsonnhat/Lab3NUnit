namespace Lab3NUnit.UnitTests
{
    [TestFixture]
    public class Lab3NUnit
    {
        [Test]
        public void Test_CheckDate()
        {
            Function function = new Function();
            // February cases
            Assert.IsTrue(function.CheckDate(29, 2, 2020)); // Leap year, valid
            Assert.IsFalse(function.CheckDate(30, 2, 2020)); // Invalid date for February
            Assert.IsFalse(function.CheckDate(31, 2, 2020)); // Invalid date for February

            Assert.IsFalse(function.CheckDate(29, 2, 2022)); // Non-leap year, invalid
            Assert.IsFalse(function.CheckDate(30, 2, 2022)); // Invalid date for February
            Assert.IsFalse(function.CheckDate(31, 2, 2022)); // Invalid date for February

            Assert.IsTrue(function.CheckDate(29, 2, 2024)); // Leap year, valid
            Assert.IsFalse(function.CheckDate(30, 2, 2024)); // Invalid date for February
            Assert.IsFalse(function.CheckDate(31, 2, 2024)); // Invalid date for February

            // April cases
            Assert.IsTrue(function.CheckDate(29, 4, 2020)); // Valid
            Assert.IsTrue(function.CheckDate(30, 4, 2020)); // Valid
            Assert.IsFalse(function.CheckDate(31, 4, 2020)); // Invalid date for April

            Assert.IsTrue(function.CheckDate(29, 4, 2022)); // Valid
            Assert.IsTrue(function.CheckDate(30, 4, 2022)); // Valid
            Assert.IsFalse(function.CheckDate(31, 4, 2022)); // Invalid date for April

            Assert.IsTrue(function.CheckDate(29, 4, 2024)); // Valid
            Assert.IsTrue(function.CheckDate(30, 4, 2024)); // Valid
            Assert.IsFalse(function.CheckDate(31, 4, 2024)); // Invalid date for April

            // August cases
            Assert.IsTrue(function.CheckDate(29, 8, 2020)); // Valid
            Assert.IsTrue(function.CheckDate(30, 8, 2020)); // Valid
            Assert.IsTrue(function.CheckDate(31, 8, 2020)); // Valid

            Assert.IsTrue(function.CheckDate(29, 8, 2022)); // Valid
            Assert.IsTrue(function.CheckDate(30, 8, 2022)); // Valid
            Assert.IsTrue(function.CheckDate(31, 8, 2022)); // Valid

            Assert.IsTrue(function.CheckDate(29, 8, 2024)); // Valid
            Assert.IsTrue(function.CheckDate(30, 8, 2024)); // Valid
            Assert.IsTrue(function.CheckDate(31, 8, 2024)); // Valid
        }

        [Test]
        public void Test_DayInMonth()
        {
            Function function = new Function();
            // Valid cases for February
            Assert.That(function.DayInMonth(2, 2020), Is.EqualTo(29)); // Leap year
            Assert.That(function.DayInMonth(2, 2021), Is.EqualTo(28)); // Non-leap year
            Assert.That(function.DayInMonth(2, 2024), Is.EqualTo(29)); // Leap year
            Assert.That(function.DayInMonth(2, 3000), Is.EqualTo(28)); // Non-leap year
            Assert.That(function.DayInMonth(2, 3001), Is.EqualTo(28)); // Non-leap year
            Assert.That(function.DayInMonth(2, 1000), Is.EqualTo(28)); // Leap year
            Assert.That(function.DayInMonth(2, 999), Is.EqualTo(28));  // Non-leap year

            // Valid cases for April
            Assert.That(function.DayInMonth(4, 2020), Is.EqualTo(30));
            Assert.That(function.DayInMonth(4, 2021), Is.EqualTo(30));
            Assert.That(function.DayInMonth(4, 2024), Is.EqualTo(30));
            Assert.That(function.DayInMonth(4, 3000), Is.EqualTo(30));
            Assert.That(function.DayInMonth(4, 3001), Is.EqualTo(30));
            Assert.That(function.DayInMonth(4, 1000), Is.EqualTo(30));
            Assert.That(function.DayInMonth(4, 999), Is.EqualTo(30));

            // Valid cases for August
            Assert.That(function.DayInMonth(8, 2020), Is.EqualTo(31));
            Assert.That(function.DayInMonth(8, 2021), Is.EqualTo(31));
            Assert.That(function.DayInMonth(8, 2024), Is.EqualTo(31));
            Assert.That(function.DayInMonth(8, 3000), Is.EqualTo(31));
            Assert.That(function.DayInMonth(8, 3001), Is.EqualTo(31));
            Assert.That(function.DayInMonth(8, 1000), Is.EqualTo(31));
            Assert.That(function.DayInMonth(8, 999), Is.EqualTo(31));
        }
    }
}
