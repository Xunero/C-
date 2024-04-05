using System;
using System.Windows.Forms;

namespace CarDealershipApp
{
    public partial class FamilyCarForm : Form
    {
        public FamilyCarForm()
        {
            InitializeComponent();
        }

        // Metoda do pobierania danych o samochodzie rodzinym z formularza
        public FamilyCar GetFamilyCar()
        {
            FamilyCar car = new FamilyCar();
            car.Brand = txtBrand.Text;
            car.Model = txtModel.Text;
            car.Year = Convert.ToInt32(txtYear.Text);
            car.NumberOfSeats = Convert.ToInt32(txtNumberOfSeats.Text);
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