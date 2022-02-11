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

        [TestCase(2004)]
        [TestCase(2008)]
        [TestCase(2012)]
        [TestCase(2016)]
        [TestCase(2020)]
        [TestCase(2024)]
        [TestCase(2028)]
        [TestCase(2032)]
        [TestCase(2036)]
        [TestCase(2040)]
        [TestCase(2044)]
        [TestCase(2048)]
        [TestCase(2052)]
        [TestCase(2056)]
        [TestCase(2060)]
        [TestCase(2064)]
        [TestCase(2068)]
        [TestCase(2072)]
        [TestCase(2076)]
        [TestCase(2080)]
        [TestCase(2084)]
        [TestCase(2088)]
        [TestCase(2092)]
        [TestCase(2096)]
        [TestCase(2104)]
        [TestCase(2108)]
        public void return_true_when_year_is_divisible_by_4_and_not_by_100(int year) {
            var result = LeapYear.IsLeap(year);

            Assert.AreEqual(true, result);
        }

        [TestCase(2001)]
        [TestCase(2002)]
        [TestCase(2003)]
        [TestCase(2005)]
        [TestCase(2006)]
        [TestCase(2007)]
        [TestCase(2009)]
        [TestCase(2010)]
        [TestCase(2011)]
        [TestCase(2013)]
        [TestCase(2014)]
        [TestCase(2015)]
        [TestCase(2017)]
        [TestCase(2018)]
        [TestCase(2021)]
        [TestCase(2022)]
        [TestCase(2023)]
        [TestCase(2025)]
        [TestCase(2026)]
        [TestCase(2027)]
        [TestCase(2029)]
        [TestCase(2030)]
        [TestCase(2031)]
        [TestCase(2033)]
        [TestCase(2034)]
        [TestCase(2035)]
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