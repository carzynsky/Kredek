using KNKredek.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace KNKredek.Tests
{
    public class StudentFactoryShould
    {
        [Fact]
        public void CreateStudent_NotInKredek()
        {
            StudentFactory sut = new StudentFactory();

            TalentedPerson student1 = sut.Create("StudentWithoutSpecialPower");
            TalentedPerson student2 = sut.Create("StudentWithoutSpecialPower");

            Assert.NotSame(student1, student2);
        }

        [Fact]
        public void NotAllowNullNames()
        {
            StudentFactory sut = new StudentFactory();

            Assert.Throws<ArgumentNullException>(() => sut.Create(null));
        }
    }
}
