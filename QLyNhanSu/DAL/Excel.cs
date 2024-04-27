using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using excel = Microsoft.Office.Interop.Excel;

using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Drawing.Imaging;

namespace QLyNhanSu.DAL
{
    internal class Excel
    {
        public string Exports(System.Data.DataTable dt, string _pathname)
        {
            var _return = "......";
            try
            {
                if (dt != null && dt.Rows.Count > 0)
                {
                    _return = "No data";
                    var excelApp = new excel.Application();
                    excelApp.Workbooks.Add();
                    excel.Worksheet workSheet = (excel.Worksheet)excelApp.ActiveSheet;

                    for (var i = 0; i < dt.Columns.Count; i++)
                    {
                        workSheet.Cells[2, i + 1] = dt.Columns[i].ColumnName;
                    }

                    for (var i = 0; i < dt.Rows.Count; i++)
                    {
                        for (var j = 0; j < dt.Columns.Count; j++)
                        {
                            if (dt.Columns[j].DataType == typeof(byte[]) && dt.Rows[i][j] != DBNull.Value)
                            {
                                byte[] imageData = (byte[])dt.Rows[i][j];
                                if (imageData != null && imageData.Length > 0)
                                {
                                    using (MemoryStream ms = new MemoryStream(imageData))
                                    {
                                        try
                                        {
                                            Image img = Image.FromStream(ms);

                                            // Resize the image to 24x24 pixels
                                            Image resizedImg = img.GetThumbnailImage(64, 64, null, IntPtr.Zero);

                                            // Save the resized image to a temporary file
                                            string tempImagePath = Path.GetTempFileName();
                                            resizedImg.Save(tempImagePath, ImageFormat.Png);

                                            // Add the resized image to the Excel worksheet
                                            ((excel.Range)workSheet.Rows[i + 3]).RowHeight = 64;
                                            ((excel.Range)workSheet.Rows[i + 1]).ColumnWidth = 12;
                                            excel.Range cell = (excel.Range)workSheet.Cells[i + 3, j + 1];
                                            float left = Convert.ToSingle(cell.Left);
                                            float top = Convert.ToSingle(cell.Top);
                                            const float imageOffsetX = 2.0f;
                                            const float imageOffsetY = 2.0f;
                                            workSheet.Shapes.AddPicture(tempImagePath, (Microsoft.Office.Core.MsoTriState)excel.XlPictureAppearance.xlScreen, (Microsoft.Office.Core.MsoTriState)XlCopyPictureFormat.xlBitmap,
                                                left + imageOffsetX, top + imageOffsetY, 64, 64);

                                            // Delete the temporary image file
                                            File.Delete(tempImagePath);
                                        }
                                        catch (ArgumentException ex)
                                        {
                                            Console.WriteLine("Invalid image data at row {0}, column {1}: {2}", i, j, ex.Message);
                                        }
                                    }
                                }
                                else
                                {
                                    workSheet.Cells[i + 3, j + 1] = "";
                                }
                            }
                            else
                            {
                                workSheet.Cells[i + 3, j + 1] = dt.Rows[i][j];
                            }
                        }
                    }


                    int socot = dt.Columns.Count;
                    int sohang = dt.Rows.Count;

                    workSheet.get_Range("A1", Convert.ToChar(socot + 65) + "1").Merge(false);
                    excel.Range caption = workSheet.get_Range("A1", Convert.ToChar(socot + 65) + "1");
                    caption.Select();
                    caption.FormulaR1C1 = "DỮ LIỆU";
                    caption.Font.FontStyle = "Bold";

                    caption.HorizontalAlignment = excel.Constants.xlCenter;
                    caption.Font.Bold = true;
                    caption.VerticalAlignment = excel.Constants.xlCenter;
                    caption.Font.Size = 15;

                    caption.Interior.ColorIndex = 33;
                    caption.RowHeight = 30;

                    excel.Range header = workSheet.get_Range("A2", Convert.ToChar(socot + 65) + "2");
                    header.Select();

                    header.HorizontalAlignment = excel.Constants.xlCenter;
                    header.Font.Bold = true;
                    header.Font.Size = 13;
                    header.HorizontalAlignment = excel.Constants.xlCenter;

                    for(int i = 0; i < sohang; i++)
                    {
                        ((excel.Range)workSheet.Cells[1, i + 1]).EntireColumn.AutoFit();
                    }
                    //save file
                    workSheet.SaveAs(_pathname);
                    excelApp.Quit();
                    excelApp.Visible = false;
                    return _return = "Export Successfully!";
                }
            } catch (Exception ex)
            {
                _return = "Error:" + ex.Message;
            }
            return _return;
        }
        public string Exports(System.Data.DataTable dt, string _pathname, string _tenform)
        {
            var _return = "......";
            try
            {
                if (dt != null || dt.Columns.Count > 0)
                {
                    _return = "No data";
                    var excelApp = new excel.Application();
                    excelApp.Workbooks.Add();
                    excel.Worksheet workSheet = (excel.Worksheet)excelApp.ActiveSheet;

                    for (var i = 0; i < dt.Columns.Count; i++)
                    {
                        workSheet.Cells[2, i + 1] = dt.Columns[i].ColumnName;
                    }
                    for (var i = 0; i < dt.Rows.Count; i++)
                    {
                        for (var j = 0; j < dt.Columns.Count; j++)
                        {
                            workSheet.Cells[i + 3, j + 1] = dt.Rows[i][j];
                        }
                    }
                    int socot = dt.Columns.Count;
                    int sohang = dt.Rows.Count;

                    workSheet.get_Range("A1", Convert.ToChar(socot + 65) + "1").Merge(false);
                    excel.Range caption = workSheet.get_Range("A1", Convert.ToChar(socot + 65) + "1");
                    caption.Select();
                    caption.FormulaR1C1 = "DỮ LIỆU";
                    caption.Font.FontStyle = "Bold";

                    caption.HorizontalAlignment = excel.Constants.xlCenter;
                    caption.Font.Bold = true;
                    caption.VerticalAlignment = excel.Constants.xlCenter;
                    caption.Font.Size = 15;

                    caption.Interior.ColorIndex = 33;
                    caption.RowHeight = 30;

                    excel.Range header = workSheet.get_Range("A2", Convert.ToChar(socot + 65) + "2");
                    header.Select();

                    header.HorizontalAlignment = excel.Constants.xlCenter;
                    header.Font.Bold = true;
                    header.Font.Size = 13;
                    header.HorizontalAlignment = excel.Constants.xlCenter;

                    for (int i = 0; i < sohang; i++)
                    {
                        ((excel.Range)workSheet.Cells[1, i + 1]).EntireColumn.AutoFit();
                    }
                    //save file
                    workSheet.SaveAs(_pathname);
                    excelApp.Quit();
                    excelApp.Visible = true;
                    return _return = "Export Successfully!";
                }
            }
            catch (Exception ex)
            {
                _return = "Error:" + ex.Message;
            }
            return _return;
        }
        public System.Data.DataTable Import(string _pathname)
        {
            string connstr = "Provider-Microsoft.Jet.Oledb.4.0;Data Source='" + _pathname + "';Extended Properties=Excel 8.0";
            OleDbConnection conn = new OleDbConnection(connstr);
            string strSQL = "SELECT * FROM [Sheet1$]";
            OleDbCommand cmd = new OleDbCommand(strSQL, conn);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
    
}
