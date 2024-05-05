using System;
using System.IO;
using NUnit.Framework;
using calculate_final_gpa;

namespace calculate_final_gpa_tests
{
    public class Tests
    {
        private Program _program;
        private StringWriter _consoleOutput;

        [SetUp]
        public void Setup()
        {
            _program = new Program();
            _consoleOutput = new StringWriter();
            Console.SetOut(_consoleOutput);
        }

        [TearDown]
        public void TearDown()
        {
            _consoleOutput.Dispose();
        }

        [Test]
        public void TestGpaOutput()
        {
            _program.Main(new string[0]);

            string output = _consoleOutput.ToString();
            string expectedGpa = "Final GPA:\t\t\t 3.40";

            Assert.IsTrue(output.Contains(expectedGpa));
        }
    }
}