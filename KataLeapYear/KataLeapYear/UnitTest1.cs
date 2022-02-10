using NUnit.Framework;

namespace KataLeapYear {
    public class LeapYear_Should {

        // Los años divisibles por 400 son bisiestos
        // Los años divisibles por 100 pero no por 400 NO son bisiestos
        // Los años divisibles por 4 pero no por 100 son bisiestos
        // Los años no divisibles por 4 NO son bisiestos

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
            return year % 400 == 0;
        }
    }
}