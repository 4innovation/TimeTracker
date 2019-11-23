using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TimeTracker
{
    public class GlobalFun
    {

        public GlobalFun()
        {
        }



        public void SetArray2DataGridView(DataGridView DGV, List<List<string>> LArray, bool VisibleHeadeer = false)
        {
            DGV.Rows.Clear();
            DGV.RowHeadersVisible = VisibleHeadeer;
            DGV.ColumnCount = LArray[0].Count();

            for (int i = 0; i < LArray.Count(); i++)
            {
                string[] row = new string[LArray[i].Count()];
                for(int j = 0; j < LArray[i].Count; j++)
                {
                    row[j] = LArray[i][j];
                }
                DGV.Rows.Add(row);
            }

        }

    }

}
