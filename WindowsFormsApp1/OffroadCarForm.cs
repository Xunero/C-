using System;
using System.Windows.Forms;

namespace CarDealershipApp
{
    public partial class OffroadCarForm : Form
    {
        public OffroadCarForm()
        {
            InitializeComponent();
        }

        // Metoda do pobierania danych o samochodzie terenowym z formularza
        public OffroadCar GetOffroadCar()
        {
            OffroadCar car = new OffroadCar();
            car.Brand = txtBrand.Text;
            car.Model = txtModel.Text;
            car.Year = Convert.ToInt32(txtYear.Text);
            car.FourWheelDrive = chkFourWheelDrive.Checked;
            return car;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Tutaj można dodać logikę zatwierdzającą dane, jeśli jest to konieczne
            // W przypadku tego przykładu, możemy po prostu zamknąć formularz, jeśli użytkownik kliknie przycisk OK
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Anulowanie wprowadzania danych
            DialogResult = DialogResult.Cancel;
        }
    }
}