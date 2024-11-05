using System;
using Microsoft.Maui.Controls;

namespace App.Clinic
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void PatientsClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Patients");
        }

        private async void PhysiciansClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Physicians");
        }

        private async void AppointmentsClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Appointments");
        }
    }
}
