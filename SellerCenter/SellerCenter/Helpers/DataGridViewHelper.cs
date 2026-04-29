namespace SellerCenter.Helpers
{
    public static class DataGridViewHelper
    {
        public static void HandleRowClick<T>(
            DataGridView dgv,
            DataGridViewCellEventArgs e,
            Action<T> onRowSelected
        )
        {
            if (e.RowIndex < 0) return;

            var row = dgv.Rows[e.RowIndex];

            if (row.DataBoundItem is T item)
            {
                if (item == null) return;
                onRowSelected?.Invoke(item);
            }
        }
    }
}