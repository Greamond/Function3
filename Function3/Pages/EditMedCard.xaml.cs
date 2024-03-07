using Function3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Function3.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditMedCard.xaml
    /// </summary>
    public partial class EditMedCard : Page
    {
        MedicalCard medcard;
        public EditMedCard(MedicalCard medcard)
        {
            InitializeComponent();
            this.medcard = medcard;
            NumMedCard.Content = "№:" + medcard.Id;
            Fullname.Content = MainWindow.conn.Patients.First(x => x.Id == medcard.Id).FIO();
            Inf.Text = medcard.Inforamtion;
            Simptoms.Text = medcard.Symptoms;
            Diagnosis.Text = medcard.Diagnosis;
            TreatmentRecom.Text = medcard.TreatmentRecom;
            Recipes.Text =  medcard.Recipes;
            DirectionSpecialist.Text = medcard.DirectionSpecialist;
            Research.Text = medcard.Research;
            Procedures.Text = medcard.Procedures;
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            medcard.Inforamtion = Inf.Text;
            medcard.Symptoms = Simptoms.Text; 
            medcard.Diagnosis = Diagnosis.Text;
            medcard.TreatmentRecom = TreatmentRecom.Text;
            medcard.Recipes = Recipes.Text;
            medcard.DirectionSpecialist = DirectionSpecialist.Text;
            medcard.Research = Research.Text;
            medcard.Procedures = Procedures.Text;
        }
    }
}
