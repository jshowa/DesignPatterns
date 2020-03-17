using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace DesignPatternsTests
{
    public class UnitTestsConsole : TextWriter
    {
        public override Encoding Encoding => Encoding.Unicode;

        private readonly ITestOutputHelper _output;

        public UnitTestsConsole(ITestOutputHelper output)
        {
            _output = output;
        }

        public override void WriteLine(string message)
        {
            _output.WriteLine(message);
        }

        public override void WriteLine(string format, params object[] args)
        {
            _output.WriteLine(format, args);
        }


    }
}
