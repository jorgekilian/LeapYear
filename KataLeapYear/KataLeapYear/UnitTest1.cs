using NUnit.Framework;

namespace KataLeapYear {
    public class LeapYear_Should {

        // Los años divisibles por 400 son bisiestos
        // Los años divisibles por 100 pero no por 400 NO son bisiestos
        // Los años divisibles por 4 pero no por 100 son bisiestos
        // Los años no divisibles por 4 NO son bisiestos

        [TestCase(400)]
        [TestCase(800)]
        [TestCase(1200)]
        [TestCase(1600)]
        [TestCase(2000)]
        [TestCase(2400)]
        [TestCase(2800)]
        [TestCase(3200)]
        public void return_true_when_year_is_divisible_by_400(int year) {
            var result = LeapYear.IsLeap(year);

            Assert.AreEqual(true, result);
        }

        [TestCase(100)]
        [TestCase(200)]
        [TestCase(300)]
        [TestCase(500)]
        [TestCase(600)]
        [TestCase(700)]
        [TestCase(900)]
        [TestCase(1000)]
        public void return_false_when_year_is_divisible_by_100_and_not_by_400(int year) {
            var result = LeapYear.IsLeap(year);

            Assert.AreEqual(false, result);
        }

        [TestCase(4)]
        [TestCase(8)]
        [TestCase(12)]
        [TestCase(16)]
        [TestCase(20)]
        [TestCase(24)]
        [TestCase(28)]
        [TestCase(32)]
        [TestCase(36)]
        [TestCase(40)]
        [TestCase(44)]
        [TestCase(48)]
        [TestCase(52)]
        [TestCase(56)]
        [TestCase(60)]
        [TestCase(64)]
        [TestCase(68)]
        [TestCase(72)]
        [TestCase(76)]
        [TestCase(80)]
        [TestCase(84)]
        [TestCase(88)]
        [TestCase(92)]
        [TestCase(96)]
        [TestCase(104)]
        [TestCase(108)]
        public void return_true_when_year_is_divisible_by_4_and_not_by_100(int year) {
            var result = LeapYear.IsLeap(year);

            Assert.AreEqual(true, result);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(9)]
        [TestCase(10)]
        [TestCase(11)]
        [TestCase(13)]
        [TestCase(14)]
        [TestCase(15)]
        [TestCase(17)]
        [TestCase(18)]
        [TestCase(21)]
        [TestCase(22)]
        [TestCase(23)]
        [TestCase(25)]
        [TestCase(26)]
        [TestCase(27)]
        [TestCase(29)]
        [TestCase(30)]
        [TestCase(31)]
        [TestCase(33)]
        [TestCase(34)]
        [TestCase(35)]
        [TestCase(2022)]
        public void return_false_when_year_is_not_divisible_by_4(int year) {
            var result = LeapYear.IsLeap(year);

            Assert.AreEqual(false, result);
        }
    }

    public static class LeapYear {
        public static bool IsLeap(int year) {
            if (year % 4 == 0 && (year % 100) != 0) return true;
            return year % 400 == 0;
        }
    }
}