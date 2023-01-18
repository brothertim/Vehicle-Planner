using System.IO;

namespace Vehicle_Planner
{
    public partial class Form1 : Form
    {
        String path = @"D:\listbox.txt";
        String saveDetails = "{0, -20}|{1, -25}|{2, -25}|{3, -50}|{4, -20}|{5, -20}|{6, -100}"; //initialize and create columns in a string
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)  //exit button actions
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm to exit", "Inventory System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(iExit == DialogResult.Yes) { Application.Exit(); }
        }

        private void button2_Click(object sender, EventArgs e) //clear button actions
        {
            //comboBox1.Clear();
            siteNameEntryBox.Clear();
            selectName.Text = "Select Name";
            selectCounty.Text = "Select County";
            selectVehicle.Text = "Select Vehicle";
            selectSetupType.Text = "Select Setup Type";
        }

        private void button1_Click(object sender, EventArgs e) //save button actions
        {
            String Name, County, Date, Site, Vehicle, SetupType, Notes;  //declare vars as strings

            //assign variables
            Name = selectName.Text;
            County = selectCounty.Text;
            Date = dateTimePicker1.Text;
            Site = siteNameEntryBox.Text;
            Vehicle = selectVehicle.Text;
            SetupType = selectSetupType.Text;
            Notes = noteBox.Text;

            //what is passed when save button pressed
            listBox1.Items.Add(String.Format(saveDetails, Name, County, Site, Date, Vehicle, SetupType, Notes));
            
            //save listbox file
            System.IO.File.WriteAllLines(path, listBox1.Items.Cast<string>().ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)  //initialized values
        {
            listBox1.Items.Add(String.Format(saveDetails, "Name", "County","Site Name", "Date", "Vehicle", "Setup Type", "Notes"));
            
            //add file read here
            //StreamReader sr = new StreamReader(path);
            //listBox1.Items.Add(sr.ReadLine());
            //sr.Close();
                


            //add new users here
            selectName.Items.Add("Ernie Marquez");
            selectName.Items.Add("Eli Lovato");
            selectName.Items.Add("Greg Prudencio");
            selectName.Items.Add("Tyler Sullivan");
            selectName.Items.Add("Timothy Smith");
            selectName.Items.Add("Esau Monterroza");
            selectName.Items.Add("Brian Sanchez");
            selectName.Items.Add("Hector Quiroz");
            selectName.Items.Add("Picasso Montez");
            selectName.Items.Add("Eric Kolste");
            selectName.Items.Add("Sheamus O'Hara");

            //change available county names here
            /*selectCounty.Items.Add("Bernalillo");
            selectCounty.Items.Add("Doña Ana");
            selectCounty.Items.Add("Grant");
            selectCounty.Items.Add("Harding");
            selectCounty.Items.Add("Los Alamos");
            selectCounty.Items.Add("Rio Arriba");
            selectCounty.Items.Add("Sandoval");
            selectCounty.Items.Add("San Juan");
            selectCounty.Items.Add("Santa Fe");
            selectCounty.Items.Add("Taos");*/
            selectCounty.Items.Add("Catron");
            selectCounty.Items.Add("Chaves");
            selectCounty.Items.Add("Cibola");
            selectCounty.Items.Add("Colfax");
            selectCounty.Items.Add("Curry");
            selectCounty.Items.Add("De Baca");
            selectCounty.Items.Add("Eddy");
            selectCounty.Items.Add("Guadalupe");
            selectCounty.Items.Add("Hidalgo");
            selectCounty.Items.Add("Lea");
            selectCounty.Items.Add("Lincoln");
            selectCounty.Items.Add("Luna");
            selectCounty.Items.Add("McKinley");
            selectCounty.Items.Add("Mora");
            selectCounty.Items.Add("Otero");
            selectCounty.Items.Add("Quay");
            selectCounty.Items.Add("Roosevelt");
            selectCounty.Items.Add("San Miguel");
            selectCounty.Items.Add("Sierra");
            selectCounty.Items.Add("Socorro");
            selectCounty.Items.Add("Torrance");
            selectCounty.Items.Add("Union");
            selectCounty.Items.Add("Valencia");

            //default text
            selectName.Text = "Select Name";
            selectCounty.Text = "Select County";
            selectVehicle.Text = "Select Vehicle";
            selectSetupType.Text = "Select Setup Type";

            //add vehicles here
            selectVehicle.Items.Add("Big Transit");
            selectVehicle.Items.Add("Small Transit");
            selectVehicle.Items.Add("White Chevy Cargo");
            selectVehicle.Items.Add("Other");
            selectVehicle.Items.Add("Rental");
            selectVehicle.Items.Add("None");

            //add trip types here
            selectSetupType.Items.Add("Absentee");
            selectSetupType.Items.Add("Early Voting");
            selectSetupType.Items.Add("Alternate EV");
            selectSetupType.Items.Add("Election Day");
            selectSetupType.Items.Add("Training");
            selectSetupType.Items.Add("Site Check");
            selectSetupType.Items.Add("Other");

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.DataSource = File.ReadAllLines(path);
        }
    }
}