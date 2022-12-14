// Add the following namespace to work with excel files
using Microsoft.Office.Interop.Excel;
namespace Ibuprofen
{
    public class Excel
    {
        // Create an excel application object, workbook oject and worksheet object
        _Application excel = new Application();
        Workbook workbook;
        Worksheet worksheet;

        // Method creates a new Excel file by creating a new Excel workbook with a single worksheet
        public void NewFile()
        {
            workbook = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            worksheet = workbook.Worksheets[1];
        }

        // Method adds a new worksheet to the existing workbook 
        public void NewSheet()
        {
            Worksheet newSheet = excel.Worksheets.Add(After: this.worksheet);
        }

        // Method saves workbook at a specified path
        public void SaveAs(string path)
        {
            workbook.SaveAs(path);
        }
        // Method closes Excel file
        public void Close()
        {
            workbook.Close();
        }
    }
}