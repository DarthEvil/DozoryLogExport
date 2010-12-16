using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DozorySharp;
using OfficeOpenXml;

namespace DLogExport
{
    class ReportGenerator
    {
        private Dictionary<string,string> _operations = new Dictionary<string, string>();

        public ReportGenerator()
        {
            _operations.Add("from_office_to_privateshopstorage", "В магазин");
            _operations.Add("from_privateshopstorage_to_office", "Из магазина");
            _operations.Add("from_office_auxiliaryinv_to_privateshopstorage", "В магазин");
            _operations.Add("from_privateshopstorage_to_office_auxiliaryinv", "Из магазина");
            _operations.Add("from_office_to_actor", "Взял");
            _operations.Add("from_actor_to_office", "Положил");
            _operations.Add("from_artefactcreator_to_office", "Из арт.станка");
            _operations.Add("from_office_to_artefactrecycle", "В арт.станок");
            _operations.Add("from_officemachine_to_office", "Из проф.станка");
            _operations.Add("from_office_to_officemachine", "В проф.станок");
            _operations.Add("from_officemachine_to_actor", "Из проф.станка");
            _operations.Add("from_actor_to_office_mods", "Положил");
            _operations.Add("from_rucksack_to_office", "Из рюкзака");
            _operations.Add("from_office_auxiliaryinv_to_actor", "Взял");
            _operations.Add("from_office_mods_to_actor", "Взял");
            _operations.Add("from_actor_to_office_library", "Положил");
            _operations.Add("from_office_library_to_actor", "Взял");
            _operations.Add("from_actor_to_office_auxiliaryinv", "Положил");
            _operations.Add("from_actor_to_office_prof_inventory", "Положил");
            _operations.Add("from_office_prof_inventory_to_actor", "Взял");

            _operations.Add("to_treasury", "Положил");
            _operations.Add("to_person", "Взял");
            _operations.Add("to_order_table", "Купил МАЭ");
            _operations.Add("taler_exchange", "Обменял на рубли");
            _operations.Add("talerland", "Талерленд");
        }

        /// <summary>
        /// Создание отчета
        /// </summary>
        /// <param name="filename">Имя файла</param>
        /// <param name="responce">Загруженные данные</param>
        public void Generate(string filename, Responce responce)
        {
            FileInfo newFile = new FileInfo(filename);
            if (newFile.Exists)
            {
                newFile.Delete();  // ensures we create a new workbook
                newFile = new FileInfo(filename);
            }
            using (ExcelPackage xlPackage = new ExcelPackage(newFile))
            {
                // this will cause the assembly to output the raw XML files in the outputDir
                // for debug purposes.  You will see to sub-folders called 'xl' and 'docProps'.
                xlPackage.DebugMode = false;

                //пишем склады
                foreach (StorageType item in responce.GetStoragesList)
                {
                    string title = "Неизвестен";

                    switch (item)
                    {
                        case StorageType.Main:
                            title = "Основной";
                            break;
                        case StorageType.Second:
                            title = "Дополнительный";
                            break;
                        case StorageType.Mods:
                            title = "Модификаторы";
                            break;
                        case StorageType.Prof:
                            title = "Профессиональный";
                            break;
                        case StorageType.Lib:
                            title = "Библиотека";
                            break;    
                    }

                    
                    ExcelWorksheet worksheet = xlPackage.Workbook.Worksheets.Add(title);
                    worksheet.Cell(1, 1).Value = "Дата";
                    worksheet.Cell(1, 2).Value = "Персонаж";
                    worksheet.Cell(1, 3).Value = "Операция";
                    worksheet.Cell(1, 4).Value = "Предмет";
                    worksheet.Cell(1, 5).Value = "ID предмета";


                    List<StorageOperation> operations = responce.GetStorage(item);

                    int i = 2;
                    foreach (StorageOperation operation in operations)
                    {
                        string oName = operation.TypeAction;

                        if (_operations.ContainsKey(oName)){
                            oName = _operations[oName];
                        }

                        worksheet.Cell(i, 1).Value = operation.Date.ToString("dd.MM.yyyy HH:mm:ss");
                        worksheet.Cell(i, 2).Value = operation.PersonNick;
                        worksheet.Cell(i, 3).Value = oName;
                        worksheet.Cell(i, 4).Value = operation.ItemName;
                        worksheet.Cell(i, 5).Value = operation.ItemID.ToString();
                        i++;
                    }
                }


                //Пишем деньги
                foreach (TreasureType item in responce.GetTreasutesList)
                {
                    string title = "Неизвестен";

                    switch (item)
                    {
                        case TreasureType.Money:
                            title = "Рубли";
                            break;
                        case TreasureType.Taler:
                            title = "Талеры";
                            break;
                    }


                    ExcelWorksheet worksheet = xlPackage.Workbook.Worksheets.Add(title);
                    worksheet.Cell(1, 1).Value = "Дата";
                    worksheet.Cell(1, 2).Value = "Персонаж";
                    worksheet.Cell(1, 3).Value = "Операция";
                    worksheet.Cell(1, 4).Value = "Сумма";


                    List<TreasureOperation> operations = responce.GetTreasute(item);

                    int i = 2;
                    foreach (TreasureOperation operation in operations)
                    {
                        string oName = operation.TypeAction;
                           if (_operations.ContainsKey(oName)){
                            oName = _operations[oName];
                        }

                        worksheet.Cell(i, 1).Value = operation.Date.ToString("dd.MM.yyyy HH:mm:ss");
                        worksheet.Cell(i, 2).Value = operation.PersonNick;
                        worksheet.Cell(i, 3).Value = oName;
                        worksheet.Cell(i, 4).Value = operation.Value.ToString();
                        i++;
                    }
                }

                //for (int i=0;i<3;i++)
                //{
                //    // add a new worksheet to the empty workbook
                //    ExcelWorksheet worksheet = xlPackage.Workbook.Worksheets.Add("Tinned Goods - "+i);
                //    // write some strings into column 1
                //    worksheet.Cell(1, 1).Value = "Product";
                //    worksheet.Cell(2, 1).Value = "Broad Beans";
                //    worksheet.Cell(3, 1).Value = "Carrots";
                //    worksheet.Cell(4, 1).Value = "Peas";
                //    worksheet.Cell(5, 1).Value = "Total";

                //    // increase the width of column one as these strings will be too wide to display
                //    worksheet.Column(1).Width = 15;

                //    // write some values into column 2
                //    worksheet.Cell(1, 2).Value = "Tins Sold";

                //    ExcelCell cell = worksheet.Cell(2, 2);
                //    cell.Value = "15"; // tins of Beans sold
                //    string calcStartAddress = cell.CellAddress;  // we want this for the formula

                //    worksheet.Cell(3, 2).Value = "32";  // tins Carrots sold

                //    cell = worksheet.Cell(4, 2);
                //    cell.Value = "65";  // tins of Peas sold
                //    string calcEndAddress = cell.CellAddress;  // we want this for the formula

                //    // now add a formula to show the total number of tins sold
                //    // This actually adds "SUM(B2:B4)" as the formula
                //    worksheet.Cell(5, 2).Formula = string.Format("SUM({0}:{1})", calcStartAddress, calcEndAddress);

                //    // Ah, but we forgot to add a line for String Beans!
                //    // Note that InsertRow automatically updates all the formulas in the sheet
                //    // to reference the correct cell range.
                //    worksheet.InsertRow(3);

                //    // now add the String Beans line
                //    worksheet.Cell(3, 1).Value = "String Beans";
                //    worksheet.Cell(3, 2).Value = "3";

                //    // set the row height of the total row to be a bit bigger
                //    worksheet.Row(6).Height = 20;

                //    // lets set the header text 
                //    worksheet.HeaderFooter.oddHeader.CenteredText = "Tinned Goods Sales";
                //    // add the page number to the footer plus the total number of pages
                //    worksheet.HeaderFooter.oddFooter.RightAlignedText =
                //        string.Format("Page {0} of {1}", ExcelHeaderFooter.PageNumber, ExcelHeaderFooter.NumberOfPages);
                //    // add the sheet name to the footer
                //    worksheet.HeaderFooter.oddFooter.CenteredText = ExcelHeaderFooter.SheetName;
                //    // add the file path to the footer
                //    worksheet.HeaderFooter.oddFooter.LeftAlignedText = ExcelHeaderFooter.FilePath + ExcelHeaderFooter.FileName;

                //    // change the sheet view to show it in page layout mode
                //    worksheet.View.PageLayoutView = true;
                //}

                // we had better add some document properties to the spreadsheet 

                //// set some core property values
                //xlPackage.Workbook.Properties.Title = "Sample 1";
                //xlPackage.Workbook.Properties.Author = "John Tunnicliffe";
                //xlPackage.Workbook.Properties.Subject = "ExcelPackage Samples";
                //xlPackage.Workbook.Properties.Keywords = "Office Open XML";
                //xlPackage.Workbook.Properties.Category = "ExcelPackage Samples";
                //xlPackage.Workbook.Properties.Comments = "This sample demonstrates how to create an Excel 2007 file from scratch using the Packaging API and Office Open XML";

                //// set some extended property values
                //xlPackage.Workbook.Properties.Company = "AdventureWorks Inc.";
                //xlPackage.Workbook.Properties.HyperlinkBase = new Uri("http://www.linkedin.com/pub/0/277/8a5");

                //// set some custom property values
                //xlPackage.Workbook.Properties.SetCustomPropertyValue("Checked by", "John Tunnicliffe");
                //xlPackage.Workbook.Properties.SetCustomPropertyValue("EmployeeID", "1147");
                //xlPackage.Workbook.Properties.SetCustomPropertyValue("AssemblyName", "ExcelPackage");

                // save our new workbook and we are done!
                xlPackage.Save();
            }

            // if you want to take a look at the XML created in the package, simply uncomment the following lines
            // These copy the output file and give it a zip extension so you can open it and take a look!
            //FileInfo zipFile = new FileInfo(outputDir.FullName + @"\sample1.zip");
            //if (zipFile.Exists) zipFile.Delete();
            //newFile.CopyTo(zipFile.FullName);
            //return newFile.FullName;
        }
    }
}
