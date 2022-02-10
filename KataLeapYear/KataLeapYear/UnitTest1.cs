using NUnit.Framework;

namespace KataLeapYear {
    public class LeapYear_Should {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void return_true_when_year_is_divisible_by_400() {
            var result = LeapYear.IsLeap(800);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void return_false_when_year_is_divisible_by_100_and_not_by_400() {
            var result = LeapYear.IsLeap(200);

            Assert.AreEqual(false, result);
        }
    }

    public static class LeapYear {
        public static bool IsLeap(int year) {
           if ( year % 400 == 0) return true;
           return false;
        }
    }
}