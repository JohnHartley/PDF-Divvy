/*
 * Created by SharpDevelop.
 * User: john_
 * Date: 27/02/2020
 * Time: 7:11 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace PDFdivvyWF
{
    /// <summary>
    /// Description of DivvyUpPDF.
    /// </summary>
    public class DivvyUpPDF
    {
        public delegate void writeLogDelegate(string message);

        public writeLogDelegate writeLog;
        public int lineCount = 0;
        int currentLine = 0;
        string[] header;
        List<string[]> allLines;

        public DivvyUpPDF()
        {
            writeLog = (m) => { Console.WriteLine(m); };
        }

        /// <summary>
        /// Loads 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="skipLines">Number of lines before the header line</param>
        /// <returns></returns>
        public int loadCSV(string fileName, int skipLines = 0)
        {
            currentLine = 0;
            lineCount = 0;
            allLines = new List<string[]>();
            if (String.IsNullOrEmpty(fileName)) { writeLog("Empty file name for CSV file."); return 0; }
            if( ! File.Exists(fileName)) { writeLog("Cannot find CSV file: " + fileName); return 0; }
            string[] lines = File.ReadAllLines(fileName);
            if (skipLines > 0)
            {
                writeLog("Skipping " + skipLines + " lines");
                currentLine += skipLines;
            }

            // Read header
            string HeaderLine = lines[currentLine];
            if (HeaderLine.EndsWith(",")) // shoddy header
                HeaderLine = HeaderLine.Substring(0, HeaderLine.Length - 1);
            header = getFieldsParse(HeaderLine);
            var headerCount = header.Length;
            writeLog("Header: " + lines[currentLine]);
            writeLog("Counted " + header.Length + " fields");
            currentLine++;
            while (currentLine < lines.Length)
            {
                if (lines[currentLine].StartsWith("#") || lines[currentLine].Trim() == "")  // skip comment or emptyline 
                {
                    currentLine++;
                }
                else
                {
                    // var fields = getFields(lines[currentLine], header.Length, ',');
                    var fields = getFieldsParse(lines[currentLine]);
                    allLines.Add(fields);
                    lineCount++;
                    currentLine++;
                }
            }

            return lineCount;
        }

        string[] getFieldsParse(string line)
        {
            int p = 0;
            string f;
            List<string> fields = new List<string>(); ;
            while (p < line.Length)
            {
                if (line[p] == '"')
                {
                    p++;
                    f = "";
                    while (p < line.Length && line[p] != '"')
                        f += line[p++];
                    if (p < line.Length && line[p] == '"')
                        p++;
                    fields.Add(f);
                }
                else
                {
                    f = "";
                    while (p < line.Length && line[p] != ',')
                        f += line[p++];
                    fields.Add(f);
                }
                if (p < line.Length && line[p] == ',')
                    p++;
            }

            return fields.ToArray();
        }

        public void processPDF(string filename, string directoryToWrite, string fileFormat, bool write = false)
        {
            // Check file exists
            if (!File.Exists(filename))
            {
                writeLog("Cannot find PDF: " + filename);
                return;
            }
            PdfDocument inputDocument;

            // Open the file
            try
            {
                inputDocument = PdfReader.Open(filename, PdfDocumentOpenMode.Import);
            }
            catch (Exception ex)
            {
                writeLog("Error opening PDF: " + ex.Message);
                return;
            }

            writeLog("PDF Opened " + filename);
            writeLog("Version: " + inputDocument.Version);
            writeLog("Pages: " + inputDocument.PageCount);

            string originalname = Path.GetFileNameWithoutExtension(filename);

            if (String.IsNullOrEmpty(directoryToWrite))
                directoryToWrite = Path.GetDirectoryName(filename);
            // Check output directory
            if (!Directory.Exists(directoryToWrite))
            {
                writeLog("Output directory does not exist: " + directoryToWrite);
                return;
            }

            if (String.IsNullOrEmpty(fileFormat))
                fileFormat = "{name} ({index}).pdf";

            for (int idx = 0; idx < inputDocument.PageCount; idx++)
            {
                // Create new document
                PdfDocument outputDocument = new PdfDocument();
                outputDocument.Version = inputDocument.Version;
                outputDocument.Info.Title =
                    String.Format("Page {0} of {1}", idx + 1, inputDocument.Info.Title);
                outputDocument.Info.Creator = inputDocument.Info.Creator;

                string nextFileName = getFileName(fileFormat, originalname, allLines[idx], idx);
                writeLog("Filename :" + nextFileName);
                nextFileName = Path.Combine(directoryToWrite, nextFileName);
                // Add the page and save it
                outputDocument.AddPage(inputDocument.Pages[idx]);
                if (write)
                    outputDocument.Save(nextFileName);
            }
        }

        public string getFileName(string format, string name, string[] fields, int idx)
        {
            if (format == "")
                return name;
            format = format.Replace("{name}", name);
            format = format.Replace("{index}", (idx + 1).ToString());
            string fn = String.Format(format, fields);
            if (!fn.ToLower().EndsWith(".pdf"))
                fn += ".pdf";
            return fn;
        }
    }
}
