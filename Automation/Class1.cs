using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation
{
    public class Class1
    {
        [Test]

        public static void number4IsEven()
        {
            int expectedRemainder = 0;
            int actualRemainder = 4 % 2;

            Assert.AreEqual(expectedRemainder, actualRemainder);
            //Assert.IsTrue(expectedRemainder == actualRemainder);
        }

        [Test]

        public static void currenHourIsEqualTo19()
        {
            int expectedHout = 19;
            int actualHour = DateTime.Now.Hour;

            Assert.AreEqual(expectedHout, actualHour);
        }
        [Test]

        public static void number995DividesBy3WithoutRemainder()
        {
            int expectedRemainder = 0;
            int actualRemainder = 995 % 3;

            Assert.AreEqual(expectedRemainder, actualRemainder);
        }

        [Test]

        public static void treciadienis()
        {
            //   int expectedDay = 3;
            //   int actualDay = (int)DateTime.Now.DayOfWeek;

            //  Assert.AreEqual(expectedDay, actualDay);


            DayOfWeek expectedDay = DayOfWeek.Wednesday;
            DayOfWeek actualDay = DateTime.Now.DayOfWeek;

            Assert.AreEqual(expectedDay, actualDay);
        }

        [Test]

        public static void waitFor5Seconds()
        {
            System.Threading.Thread.Sleep(5000);          
        }

        [Test]

        public static void thereAre4EventNumbersBetween1And10()
        {
            int expectedCount = 4;
            int actualCount = 0;

            for (int number = 1; number < 10; number++)
            {
                if (number % 2 == 0)
                {
                    actualCount++;
                } 
            }

            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
