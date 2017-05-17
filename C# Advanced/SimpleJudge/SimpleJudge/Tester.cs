namespace SimpleJudge
{
    using System;
    using System.IO;

    public static class Tester
    {
        public static void CompareContent(string userOutputPath, string expectedOutputPath)
        {
            OutputWriter.WriteMessageOnNewLine("Reading files...");

            string mismatchesPath = GetMismatchPath(expectedOutputPath);

            string[] userOutput = File.ReadAllLines(userOutputPath);
            string[] expectedOutput = File.ReadAllLines(expectedOutputPath);

            bool hasMismatch;
            string[] mismatches = GetLinesWithPossibleMismatches(userOutput, expectedOutput, out hasMismatch);

            PrintOutput(hasMismatch, mismatches, mismatchesPath);
            OutputWriter.WriteMessageOnNewLine("Files read!");
        }

        private static void PrintOutput(bool hasMismatch, string[] mismatches, string mismatchesPath)
        {
            if (hasMismatch)
            {
                foreach (var line in mismatches)
                {
                    OutputWriter.WriteMessageOnNewLine(line);
                }
            }
        }

        private static string[] GetLinesWithPossibleMismatches(string[] userOutput, string[] expectedOutput, out bool hasMismatch)
        {
            hasMismatch = false;
            string output = string.Empty;

            string[] mismatches = new string[userOutput.Length];
            OutputWriter.WriteMessageOnNewLine("Comparing files...");

            for (int i = 0; i < userOutput.Length && i < expectedOutput.Length; i++)
            {
                string userLine = userOutput[i];
                string expectedLine = expectedOutput[i];

                if (!userLine.Equals(expectedLine))
                {
                    output = $"Mismatch at line {i} -- expected: \"{expectedLine}\", actual: \"{userLine}\"{Environment.NewLine}";
                    hasMismatch = true;
                }
                else
                {
                    output = $"{userLine}{Environment.NewLine}";
                }

                mismatches[i] = output;
            }

            return mismatches;
        }

        public static string GetMismatchPath(string expectedOutput)
        {
            int dirFileSeparator = expectedOutput.LastIndexOf('\\');
            string directoryPath = expectedOutput.Substring(0, dirFileSeparator);
            string mismatchPath = directoryPath + @"\Mismatches.txt";
            return mismatchPath;
        }
    }
}
