using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Linq;

public void CreateExcelFile(string filePath)
{
    using (SpreadsheetDocument document = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
    {
        WorkbookPart workbookPart = document.AddWorkbookPart();
        workbookPart.Workbook = new Workbook();
        WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
        worksheetPart.Worksheet = new Worksheet(new SheetData());

        Sheets sheets = document.WorkbookPart.Workbook.AppendChild(new Sheets());
        Sheet sheet = new Sheet() { Id = document.WorkbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Sheet1" };
        sheets.Append(sheet);

        SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

        // Define styles
        WorkbookStylesPart stylesPart = workbookPart.AddNewPart<WorkbookStylesPart>();
        stylesPart.Stylesheet = new Stylesheet();

        // Create a bold font
        Font boldFont = new Font();
        boldFont.Append(new Bold());
        stylesPart.Stylesheet.Fonts = new Fonts();
        stylesPart.Stylesheet.Fonts.Append(boldFont);
        stylesPart.Stylesheet.Fonts.Count = 1;

        // Create a fill with background color
        Fill fill = new Fill();
        PatternFill patternFill = new PatternFill() { PatternType = PatternValues.Solid };
        patternFill.ForegroundColor = new ForegroundColor() { Rgb = new HexBinaryValue() { Value = "FFFF00" } }; // Yellow background
        patternFill.BackgroundColor = new BackgroundColor() { Indexed = 64 };
        fill.Append(patternFill);
        stylesPart.Stylesheet.Fills = new Fills();
        stylesPart.Stylesheet.Fills.Append(fill);
        stylesPart.Stylesheet.Fills.Count = 2;

        // Create a cell format with bold font and background color
        CellFormat cellFormat = new CellFormat();
        cellFormat.FontId = 0;
        cellFormat.FillId = 1;
        cellFormat.ApplyFont = true;
        cellFormat.ApplyFill = true;
        stylesPart.Stylesheet.CellFormats = new CellFormats();
        stylesPart.Stylesheet.CellFormats.Append(cellFormat);
        stylesPart.Stylesheet.CellFormats.Count = 1;

        stylesPart.Stylesheet.Save();

        // Create header row
        Row headerRow = new Row();
        sheetData.Append(headerRow);

        // Add header cells
        string[] headers = { "Header1", "Header2", "Header3" };
        foreach (string header in headers)
        {
            Cell cell = new Cell() { CellValue = new CellValue(header), DataType = CellValues.String, StyleIndex = 0 };
            headerRow.Append(cell);
        }

        worksheetPart.Worksheet.Save();
    }
}
