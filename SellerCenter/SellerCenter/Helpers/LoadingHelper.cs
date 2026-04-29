namespace SellerCenter.Helpers
{
    public static class LoadingHelper
    {
        public static void ShowLoading(
            Button button,
            ProgressBar progressBar,
            string loadingText = "Đang xử lý..."
        )
        {
            button.Enabled = false;
            button.Text = loadingText;

            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 30;
            progressBar.Visible = true;
        }

        public static void HideLoading(
            Button button,
            ProgressBar progressBar,
            string normalText
        )
        {
            button.Enabled = true;
            button.Text = normalText;

            progressBar.Visible = false;
            progressBar.MarqueeAnimationSpeed = 0;
        }
    }

    #region demo khi call api --> show loading

    //private async void btnPost_Click(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        LoadingHelper.ShowLoading(btnPost, progressBar1, "Đang đăng...");

    //        await PostFacebookAsync(
    //            SessionManager.FacebookPageId,
    //            SessionManager.FacebookPageToken,
    //            txtContent.Text.Trim()
    //        );

    //        MessageBox.Show("Đăng bài thành công");
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show("Lỗi: " + ex.Message);
    //    }
    //    finally
    //    {
    //        LoadingHelper.HideLoading(btnPost, progressBar1, "Đăng bài");
    //    }
    //}

    #endregion demo khi call api --> show loading
}