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

namespace Function3.Elements
{
    /// <summary>
    /// Логика взаимодействия для MedCard_itm.xaml
    /// </summary>
    public partial class MedCard_itm : UserControl
    {

        public MedCard_itm(MedicalCard medcard)
        {
            InitializeComponent();
 
            NumMedCard.Content = "№:" + medcard.Id;
            Fullname.Content = MainWindow.conn.Patients.Where(x => x.Id == medcard.Id).First().FIO();
            Inf.Text = "Ифнормация: " + medcard.Inforamtion;
            Simptoms.Text = "Симптомы: " + medcard.Symptoms;
            Diagnosis.Text = "Диагноз: " + medcard.Diagnosis;
            TreatmentRecom.Text = "Лечебные рекомендации" + medcard.TreatmentRecom;
            Recipes.Text = "Рецепты: " + medcard.Recipes;
            DirectionSpecialist.Text = "Направления: " + medcard.DirectionSpecialist;
            Research.Text = "Исслдования: " + medcard.Research;
            Procedures.Text = "Процедуры: " + medcard.Procedures;
        }
    }
}
