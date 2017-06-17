namespace _14.Export_to_Excel
{
    using OfficeOpenXml;
    using System;
    using System.IO;

    public class ExportToExcel
    {
        public static void Main()
        {
            var file = GetFile();
            ExportFileToExcel(ref file);
            SuccessMessage("Ready! Your Excel file is on your Desktop. Named - New Excel.xlsx");
        }

        private static void ExportFileToExcel(ref string file)
        {
            try
            {
                using (var reader = new StreamReader(file))
                {
                    using (var excelPackage = new ExcelPackage())
                    {
                        var workSheet = excelPackage.Workbook.Worksheets.Add("Sheet");

                        var row = 1;
                        var line = reader.ReadLine();

                        while (line != null)
                        {
                            var cellData = line.Split('\t');

                            for (int i = 0; i < cellData.Length; i++)
                            {
                                workSheet.Cells[row, i + 1, row, i + 1].Value = cellData[i];
                            }

                            line = reader.ReadLine();
                            row++;
                        }

                        var outputFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "New Excel.xlsx");
                        excelPackage.SaveAs(new FileInfo(outputFile));
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                ErrorMessage(ex.Message);
            }
        }

        private static string GetFile()
        {
            Console.WriteLine("Enter the full path to your file:");
            var file = Console.ReadLine();

            while (!File.Exists(file))
            {
                ErrorMessage($@"This file doesn't exists. Please try again e.g: {Environment.NewLine}D:\Software-University-SoftUni\C# Advanced\File Name.txt");
                file = Console.ReadLine();
            }

            SuccessMessage("Reading file...");
            return file;
        }

        private static void SuccessMessage(string message)
        {
            WriteWithDifferentColor(message, ConsoleColor.Green);
        }

        private static void ErrorMessage(string message)
        {
            WriteWithDifferentColor(message, ConsoleColor.Red);
        }

        private static void WriteWithDifferentColor(string message, ConsoleColor color)
        {
            var currentConsoleColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = currentConsoleColor;
        }
    }
}
