using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarDealershipApp
{
    public partial class MainForm : Form
    {
        private List<Car> cars = new List<Car>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddSportCar_Click(object sender, EventArgs e)
        {
            SportCarForm sportCarForm = new SportCarForm();
            if (sportCarForm.ShowDialog() == DialogResult.OK)
            {
                SportCar car = sportCarForm.GetSportCar();
                AddCar(car);
            }
        }

        private void btnAddFamilyCar_Click(object sender, EventArgs e)
        {
            FamilyCarForm familyCarForm = new FamilyCarForm();
            if (familyCarForm.ShowDialog() == DialogResult.OK)
            {
                FamilyCar car = familyCarForm.GetFamilyCar();
                AddCar(car);
            }
        }

        private void btnAddOffroadCar_Click(object sender, EventArgs e)
        {
            OffroadCarForm offroadCarForm = new OffroadCarForm();
            if (offroadCarForm.ShowDialog() == DialogResult.OK)
            {
                OffroadCar car = offroadCarForm.GetOffroadCar();
                AddCar(car);
            }
        }

        private void btnRemoveCar_Click(object sender, EventArgs e)
        {
            if (listViewCars.SelectedIndices.Count > 0)
            {
                int index = listViewCars.SelectedIndices[0];
                RemoveCar(index);
            }
            else
            {
                MessageBox.Show("Select a car to remove.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddCar(Car car)
        {
            cars.Add(car);
            UpdateListView();
        }

        private void RemoveCar(int index)
        {
            if (index >= 0 && index < cars.Count)
            {
                cars.RemoveAt(index);
                UpdateListView();
            }
        }

        private void UpdateListView()
        {
            listViewCars.Items.Clear();
            foreach (Car car in cars)
            {
                ListViewItem item = new ListViewItem(car.DisplayInfo());
                listViewCars.Items.Add(item);
            }
        }
    }
}
