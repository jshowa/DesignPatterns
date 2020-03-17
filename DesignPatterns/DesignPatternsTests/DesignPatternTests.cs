using System;
using Xunit;
using DesignPatterns;
using Xunit.Abstractions;

namespace DesignPatternsTests
{
    public class DesignPatternTests
    {

        public DesignPatternTests(ITestOutputHelper output)
        {
            var unitTestConsole = new UnitTestsConsole(output);
            Console.SetOut(unitTestConsole);
        }

        [Fact]
        public void TestConsoleOutput()
        {
            var x = new Program("abc 123");

            x.PrintToConsole();

            Assert.True(1 == 1);
        }
    }
}
