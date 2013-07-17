using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace HowsDayToday
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            try
            {


                if (name.Text.Length > 0 && name.Text.Length <= 50)
                {
                    DateTime res;
                    if (DateTime.TryParse(birthdayTB.Text, out res))
                    {
                        Core.Count obj = new Core.Count(name.Text.Trim(), DateTime.Parse(birthdayTB.Text.Trim()));
                        SocialPB.Value = obj.CalculateSocial();
                        RelationshipPB.Value = obj.CalculateRelationships();
                        WorkPB.Value = obj.CalculateWork();
                        PersonalPB.Value = obj.CalculatePersonal();
                        financePB.Value = obj.CalculateFinance();
                        EntertainmentPB.Value = obj.CalculateEntertainment();

                        Appear.Begin();
                    }
                    else
                    {
                        MessageBox.Show("Enter your correct birthday in the form MM/DD/YYYY.");
                    }
                }
                else
                {
                    MessageBox.Show("Name should be between 1 and 50 characters");
                }
            }
            catch
            {
                MessageBox.Show("Oops something went wrong, Please try again");
            }
            

        }

       

        
    }
}