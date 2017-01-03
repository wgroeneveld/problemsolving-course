using System;
using System.IO;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace going_beyond_1.UnitTests
{
    [TestFixture]
    public class AllSqlFilesShouldBeEmbeddedTest
    {
        [Test]
        public void AllSqlFilesInDbProjectShouldBeEmbedded()
        {
            var csproj = ReadProjectFile();

            var regex = new Regex("<Content Include=\"(.*).sql\"");
            var matches = regex.Matches(csproj);

            var matchesAsString = string.Empty;
            foreach (var match in matches)
            {
                matchesAsString += match + Environment.NewLine;
            }

            Assert.AreEqual(0, matches.Count, "ALL SQL FILES SHOULD BE EMBEDDED RESOURCES! These aren't --> "
                + Environment.NewLine
                + matchesAsString);
        }

        private static string ReadProjectFile()
        {
            var dbAssembly = typeof(MyDatabaseUpdater).Assembly;
            var projectDir = dbAssembly.CodeBase.Substring(0, dbAssembly.CodeBase.IndexOf(".UnitTest", StringComparison.InvariantCulture));
            var csprojFile = Directory.GetFiles(projectDir.Replace("file:///", ""), "*.csproj")[0];

            var csproj = File.ReadAllText(csprojFile);
            return csproj;
        }
    }
}