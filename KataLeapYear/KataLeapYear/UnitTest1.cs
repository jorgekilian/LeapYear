using NUnit.Framework;

namespace KataLeapYear {
    public class LeapYear_Should {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void return_true_when_year_is_divisible_by_400() {
            bool result = false;

            result = LeapYear.IsLeap(800);

            Assert.AreEqual(true, result);
        }
    }

    public static class LeapYear {
        public static bool IsLeap(int year) {
            throw new System.NotImplementedException();
        }
    }
}