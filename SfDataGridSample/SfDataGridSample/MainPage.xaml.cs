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
            double xCoordinate = point.X;
            double yCoordinate = point.Y;
            DisplayAlert("Co Ordinates", $"XCoOrdinate : {xCoordinate} YCoOrdinate : {yCoordinate}","Ok");
        }
    }
}
