using Person;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUiCore
{
    public partial class Form1 : Form
    {
       List<PersonClass> People = ListMenager.LoadSempleData();
        public Form1()
        {
            InitializeComponent();
            //InitializeBandings();
            initialBind();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void initialBind()
        {
            initializeBindings.DataSource = People;
            initializeBindings.DisplayMember = "FullName";
            filteredList.DataSource = People.Where(p => p.YearsExperience >= 5).OrderBy(p => p.FirstName).ThenBy(p => p.LastName).ToList();
            filteredList.DisplayMember = "FullName";
            listBox1.DataSource = People.Select(p => p.BirthDay).ToList();
            
            
        }
        private void updateBindings()
        {
            filteredList.DataSource = People.Where(p => p.YearsExperience >= 5).OrderBy(p => p.FirstName).ThenBy(p => p.LastName).ToList();
            
        }
        private void initializeBindings_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonClass selectedPerson = (PersonClass)initializeBindings.SelectedItem;
            //YearsExperiencePcicker.value = 
            yearExperiencePicker.Value = selectedPerson.YearsExperience;
            
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            DomainUpDown.DomainUpDownItemCollection collection = this.domainUpDown1.Items;
            collection.Add("January");
            collection.Add("February");
            collection.Add("March");
            collection.Add("April");
            collection.Add("Maj");
            collection.Add("Juni");
            collection.Add("July");
            collection.Add("August");
            collection.Add("September");
            collection.Add("October");
            collection.Add("November");
            collection.Add("Dececember");
            
            //this.domainUpDown1.Text = "January";
        }

        private void updatePersonButton_Click_Click(object sender, EventArgs e)
        {
            PersonClass selectedPerson = (PersonClass)initializeBindings.SelectedItem;
            selectedPerson.YearsExperience = Convert.ToInt32(yearExperiencePicker.Value);
            
            updateBindings();
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(domainUpDown1.Text);
        }

        private void NAmesOFBirth_Click(object sender, EventArgs e)
        {

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
       
    }
}
