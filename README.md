# PDF-Divvy
[PDF Divvy]
Software to divide up a PDF as per a CSV file

There should be a line in the CSV for each page in the PDF

![Start screen](/doc/start-screen.png)

*CSV File* A comma delimited file with a header. The header is required.

*PDF File* The multi-page portable document format file. One page for each line in the CSV file.

*Output Directory* the destination of the split PDF files. If left blank, the generated files will be written to the directory where the source PDF is located

*File Format*  Allows control of the file names for the PDF files created. If left blank, the file name will be the same as the source PDF with '(1)' appended 
with the number incremented for each file. The file name can be based on the associated CSV file by using curly braces and a number indicating the column in the 
CSV. The column number starts with 0. For example '{1}.pdf' will give the value in the second column followed by the file extension e.g. '1234.pdf'

The File Format obeys the String.Format rules

https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=netframework-4.8#Starting
