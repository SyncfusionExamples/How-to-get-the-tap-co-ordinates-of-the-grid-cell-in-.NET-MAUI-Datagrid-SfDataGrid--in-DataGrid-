namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void dataGrid_CellTapped(object sender, Syncfusion.Maui.DataGrid.DataGridCellTappedEventArgs e)
        {
            Point point = dataGrid.RowColumnIndexToPoint(e.RowColumnIndex);
            double xPosition = point.X;
            double yPosition = point.Y;
            DisplayAlert("Tap Position", $"XPosition: {xPosition} YPosition: {yPosition}", "Ok");
        }
    }
}
