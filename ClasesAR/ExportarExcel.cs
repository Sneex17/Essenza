using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essenza.ClasesAR
{
    public class ExportarExcel
    {
        public DataGridView row {  get; set; }
        public DataGridView column { get; set; }
        public int RowCells { get; set; }
        public string ruta { get; set; }


        public static void exportarExcel(ExportarExcel excel)
        {
            string Ruta = @"S:\xrami\OneDrive - Universidad Central del Este\Trabajos de Programación Media ISW-123-1/doc.xlsx";
            SLDocument Documento = new SLDocument();
            SLStyle Estilos = new SLStyle();
            Estilos.Font.FontSize = 13;
            Estilos.Font.Bold = true;
            
            int Cells = 1;
            foreach( DataGridViewColumn columnas in excel.column.Columns)
            {
                Documento.SetCellValue(1, Cells, columnas.HeaderText.ToString());
                Documento.SetCellStyle(1, Cells, Estilos);
                Cells++;
            }

            int Rows = 2;
            //int dgvRC = 1;
            foreach(DataGridViewRow rows in excel.row.Rows)
            {
                //for(int i = 0; i < excel.RowCells; i++)
                //{
                //    for (int j = 1; j < excel.RowCells + 1; j++)
                //    {
                //        Documento.SetCellValue(Rows, j, rows.Cells[i].Value.ToString());

                //    }

                //}
                int i = 0;
                int j = 1;
                while (i < excel.RowCells && j < excel.RowCells + 1)
                {
                    Documento.SetCellValue(Rows, j, rows.Cells[i].Value.ToString());
                    i++;
                    j++;
                }
                Rows++;
                //Documento.SetCellValue(Rows, 1, rows.Cells[0].Value.ToString());
                //Documento.SetCellValue(Rows, 2, rows.Cells[1].Value.ToString());
                //Rows++;

                

            }

            Documento.SaveAs(excel.ruta);
            
        }

    }
}
