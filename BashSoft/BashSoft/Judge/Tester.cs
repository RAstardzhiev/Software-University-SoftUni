namespace BashSoft
{
    using System;
    using System.IO;
    using Contracts;
    using Exceptions;

    public class Tester : IContentComparer
    {
        public void CompareContent(string userOutputPath, string expectedOutputPath)
        {
            try
            {
                OutputWriter.WriteMessageOnNewLine("Reading files...");

                string mismatchesPath = this.GetMismatchPath(expectedOutputPath);

                string[] actualOutputLines = File.ReadAllLines(userOutputPath);
                string[] expectedOutputLines = File.ReadAllLines(expectedOutputPath);

                bool hasMismatch;
                string[] mismatches = this.GetLinesWithPossibleMismatches(
                    actualOutputLines, 
                    expectedOutputLines, 
                    out hasMismatch);

                this.PrintOutput(mismatches, hasMismatch, mismatchesPath);
                OutputWriter.WriteMessageOnNewLine("Files read!");
            }
            catch (IOException)
            {
                throw new InvalidPathException();
            }
        }

        private string GetMismatchPath(string expectedOutputPath)
        {
            int indexOf = expectedOutputPath.LastIndexOf('\\');
            string directoryPath = expectedOutputPath.Substring(0, indexOf);
            string finalPath = directoryPath + @"\Mismatches.txt";
            return finalPath;
        }

        private string[] GetLinesWithPossibleMismatches(string[] actualOutputLines, string[] expectedOutputLines, out bool hasMismatch)
        {
            hasMismatch = false;
            string output = string.Empty;

            int minOuputLines = actualOutputLines.Length;
            if (minOuputLines != expectedOutputLines.Length)
            {
                hasMismatch = true;
                minOuputLines = Math.Min(actualOutputLines.Length, expectedOutputLines.Length);
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.ComparisonOfFilesWithDifferentSizes);
            }

            string[] mismatches = new string[minOuputLines];
            OutputWriter.WriteMessageOnNewLine("Comparing files...");

            for (int index = 0; index < minOuputLines; index++)
            {
                string actualLine = actualOutputLines[index];
                string expectedLine = expectedOutputLines[index];

                if (!actualOutputLines.Equals(expectedLine))
                {
                    output = string.Format($"Mismatch at line {index} -- expected: \"{expectedLine}\", actual: \"{actualLine}\"");
                    output += Environment.NewLine;
                    hasMismatch = true;
                }
                else
                {
                    output = actualLine;
                    output += Environment.NewLine;
                }

                mismatches[index] = output;
            }

            return mismatches;
        }

        private void PrintOutput(string[] mismatches, bool hasMismatch, string mismatchesPath)
        {
            if (hasMismatch)
            {
                foreach (var line in mismatches)
                {
                    OutputWriter.WriteMessageOnNewLine(line);
                }
                
                File.WriteAllLines(mismatchesPath, mismatches);
                return;
            }

            OutputWriter.WriteMessageOnNewLine("Files are identical. There are no mismatches.");
        }
    }
}