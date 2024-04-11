using DocumentFormat.OpenXml.Drawing.ChartDrawing;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDB
{
    public class ExportExcel
    {
        public void exportar()
        {
            SLDocument sl = new SLDocument();
            //poner estilo y nombrar columnas
            SLStyle stilo = new SLStyle();
            stilo.Font.FontSize = 20;
            stilo.Font.Bold = true;
            //poner un if con codincion de que si es la primera vez hacer lo siguiente:
            //sl.SetCellValue(1, 1, 0);
            sl.SetCellStyle(1,0, stilo);
            //sl.SetCellValue(fila,columna,dato a cargar) recuerda que en excel empieza en 1 no 0
            sl.SetCellValue(0, 0, 0);
            sl.SaveAs(@"ruta de Guardado de Excel");
        }
    }
}
