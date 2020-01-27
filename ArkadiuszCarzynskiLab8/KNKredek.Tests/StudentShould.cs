using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace KNKredek.Tests
{
    public class StudentShould
    {
        private readonly ITestOutputHelper _stdOut;

        public StudentShould(ITestOutputHelper stdOut)
        {
            _stdOut = stdOut;
        }
        //[Fact(Skip = "no nie wiem")]
        [Fact]

        public void BeActiveWhenNew()
        {
            _stdOut.WriteLine("Checking student");
            Student sut = new Student(); // system under test

            Assert.True(sut.IsActive);
        }

        [Theory]
        [InlineData("Mirek", "Handlarz")]
        [InlineData("Misd", "")]
        [InlineData("Mdfsek", "s")]

        public void CalculateFulllName(string firstName, string lastName)
        {
            Student sut = new Student();
            sut.FirstName = firstName;
            sut.LastName = lastName;

            Assert.Equal(firstName + " " + lastName, sut.FullName, ignoreCase: true);
        }

        [Fact]
        public void CalculateFullNameStartsWithFirstName()
        {
            Student sut = new Student();

            sut.FirstName = "Kot";
            sut.LastName = "Student";

            Assert.EndsWith("Student", sut.FullName); 
        }

        [Fact]
        public void CalculateFullName_Containse()
        {
            Student sut = new Student();

            sut.FirstName = "Mirek";
            sut.LastName = "Handlarz";

            Assert.Contains(" ", sut.FullName);
        }

        [Fact]
        public void CalculateMotivation_Equals()
        {
            Student sut = new Student();

            int motivationXD = sut.Motivation;

            Assert.Equal(100, motivationXD);
        }

        [Fact]
        public void CalculateMotivation_Range()
        {
            Student sut = new Student();
            int motivationXD = sut.Motivation;

            Assert.InRange(motivationXD, 50,300);
        }

        [Fact]
        public void CalculateMotivationAfterRest()
        {
            Student sut = new Student();
            int motivationXD = sut.CalculateMotivationAfterRest();

            Assert.InRange(motivationXD, 1, 51);
        }

        [Fact]
        public void CalculateMotivationCheckAfterRest()
        {
            Student sut = new Student();
            int motivationXD = sut.CalculateMotivationAfterRest();

            Assert.True(motivationXD >= 1 && motivationXD < 51);
        }

        [Fact]
        public void CalculateIndex()
        {
            Student sut = new Student();
            sut.SetRandomIndexNumber();
            int? index = sut.IndexNumber;

            Assert.NotNull(index);
        }

        [Fact]
        public void RaiseRestEvent()
        {
            Student sut = new Student();
            Assert.Raises<EventArgs>(
                handler => sut.StudentRest += handler,
                handler => sut.StudentRest -= handler,
                () => sut.Rest());
        }

        [Fact]
        public void RaisePropertyChangeEvent()
        {
            Student sut = new Student();
            Assert.PropertyChanged(sut, "Motivation", () => sut.TakeAllTheCodeIn2Hours());
        }
    }
}
