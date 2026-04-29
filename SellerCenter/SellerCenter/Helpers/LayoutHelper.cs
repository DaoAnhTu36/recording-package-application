using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellerCenter.Helpers
{
    public static class LayoutHelper
    {
        public static void EqualRows(TableLayoutPanel table, int rowCount)
        {
            table.RowCount = rowCount;
            table.RowStyles.Clear();

            float percent = 100f / rowCount;

            for (int i = 0; i < rowCount; i++)
            {
                table.RowStyles.Add(new RowStyle(SizeType.Percent, percent));
            }
        }

        public static void EqualColumns(TableLayoutPanel table, int columnCount)
        {
            table.ColumnCount = columnCount;
            table.ColumnStyles.Clear();

            float percent = 100f / columnCount;

            for (int i = 0; i < columnCount; i++)
            {
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, percent));
            }
        }

        public static void FillAllControls(TableLayoutPanel table)
        {
            foreach (Control ctrl in table.Controls)
            {
                ctrl.Dock = DockStyle.Fill;
                ctrl.Margin = new Padding(4);
            }
        }

        public static void SetupEqualTable(
            TableLayoutPanel table,
            int rowCount,
            int columnCount
        )
        {
            table.Dock = DockStyle.Fill;
            table.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            EqualRows(table, rowCount);
            EqualColumns(table, columnCount);
            FillAllControls(table);
        }
    }
}