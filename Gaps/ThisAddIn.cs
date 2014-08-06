using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.IO;

namespace Gaps
{
    public class oApp
    {
        public static ThisAddIn thisAddin { get; set; }
    }

    public partial class ThisAddIn
    {
        public bool ImportGaps(DateTime date, bool TextSIMs, string branch)
        {
            string sGaps = "\\\\br3615gaps\\gaps\\" + branch + " Gaps Download\\";
            string sPath;
            string sFile;

            sPath = sGaps + date.ToString("yyyy") + "\\";
            sFile = branch + " " + date.ToString("yyyy-MM-dd") + ".csv";

            if (File.Exists(sPath + sFile))
            {
                Excel.Workbooks Workbooks = Application.Workbooks;
                Excel.Worksheet ActiveSheet = Application.ActiveSheet;
                int totalCols = 0;
                int totalRows = 0;
                int qtIndex = 0;
                int[] colFormats;

                // Remove any data before inserting gaps
                Application.DisplayAlerts = false;
                ActiveSheet.AutoFilterMode = false;
                ActiveSheet.Cells.Delete();
                Application.DisplayAlerts = true;


                using (StreamReader sr = new StreamReader(new FileStream(sPath + sFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite), Encoding.Default))
                {
                    string currentLine = sr.ReadLine();

                    if (!String.IsNullOrEmpty(currentLine))
                        totalCols = currentLine.Split(',').Count();
                }

                colFormats = new int[totalCols];

                for (int j = 0; j < totalCols; j++)
                    colFormats[j] = 2;

                ActiveSheet.QueryTables.Add("TEXT;" + sPath + sFile, ActiveSheet.Range["A1"]);
                qtIndex = ActiveSheet.QueryTables.Count;

                ActiveSheet.QueryTables[qtIndex].Name = branch + " " + date.ToString("yyyy-MM-dd");
                ActiveSheet.QueryTables[qtIndex].FieldNames = true;
                ActiveSheet.QueryTables[qtIndex].RowNumbers = false;
                ActiveSheet.QueryTables[qtIndex].FillAdjacentFormulas = false;
                ActiveSheet.QueryTables[qtIndex].PreserveFormatting = false;
                ActiveSheet.QueryTables[qtIndex].RefreshOnFileOpen = false;
                ActiveSheet.QueryTables[qtIndex].RefreshStyle = Excel.XlCellInsertionMode.xlInsertDeleteCells;
                ActiveSheet.QueryTables[qtIndex].SavePassword = false;
                ActiveSheet.QueryTables[qtIndex].SaveData = true;
                ActiveSheet.QueryTables[qtIndex].AdjustColumnWidth = true;
                ActiveSheet.QueryTables[qtIndex].RefreshPeriod = 0;
                ActiveSheet.QueryTables[qtIndex].TextFilePromptOnRefresh = false;
                ActiveSheet.QueryTables[qtIndex].TextFilePlatform = 437;
                ActiveSheet.QueryTables[qtIndex].TextFileStartRow = 1;
                ActiveSheet.QueryTables[qtIndex].TextFileParseType = Excel.XlTextParsingType.xlDelimited;
                ActiveSheet.QueryTables[qtIndex].TextFileTextQualifier = Excel.XlTextQualifier.xlTextQualifierDoubleQuote;
                ActiveSheet.QueryTables[qtIndex].TextFileConsecutiveDelimiter = false;
                ActiveSheet.QueryTables[qtIndex].TextFileTabDelimiter = false;
                ActiveSheet.QueryTables[qtIndex].TextFileSemicolonDelimiter = false;
                ActiveSheet.QueryTables[qtIndex].TextFileCommaDelimiter = true;
                ActiveSheet.QueryTables[qtIndex].TextFileSpaceDelimiter = false;
                ActiveSheet.QueryTables[qtIndex].TextFileColumnDataTypes = colFormats;
                ActiveSheet.QueryTables[qtIndex].TextFileTrailingMinusNumbers = true;
                ActiveSheet.QueryTables[qtIndex].Refresh(false);

                // Clean up connections and tables
                Application.ActiveWorkbook.Connections[branch + " " + date.ToString("yyyy-MM-dd")].Delete();
                ActiveSheet.QueryTables[qtIndex].Delete();

                // Insert SIM numbers
                totalRows = ActiveSheet.UsedRange.Rows.Count;
                ActiveSheet.Columns["A:A"].Insert();
                ActiveSheet.Range["A1"].Value = "SIM";
                ActiveSheet.Range["A1"].Font.Bold = true;

                if (TextSIMs)
                    ActiveSheet.Range["A2:A" + totalRows].Formula = "=\"=\"&\"\"\"\"&C2&D2&\"\"\"\"";
                else
                    ActiveSheet.Range["A2:A" + totalRows].Formula = "=C2&D2";

                ActiveSheet.Range["A2:A" + totalRows].Value = ActiveSheet.Range["A2:A" + totalRows].Value;

                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Gaps from " + date.ToString("MMM dd yyyy") + " could not be found.", "Gaps not found");
                return false;
            }
        }

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            oApp.thisAddin = this;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
