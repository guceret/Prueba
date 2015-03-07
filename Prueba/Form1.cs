using Novacode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string fileComidas, daysHere, addMonday; 

        private void Form1_Load(object sender, EventArgs e)
        {

            button1.Text = Properties.Settings.Default.dbGastosId.ToString();
            
            var dataSource = new List<Le>();
            dataSource.Add(new Le() { Name = "<Select Value>", Value = "1" });
            dataSource.Add(new Le() { Name = "Comida", Value = "2" });
            dataSource.Add(new Le() { Name = "Transport", Value = "8" });
            //Setup data binding
            this.typeSpenditure.DataSource = dataSource;
            this.typeSpenditure.DisplayMember = "Name";
            this.typeSpenditure.ValueMember = "Value";

            this.timeStamp1.Text = "Today is: "+ DateTime.Now.ToString("dd/MM/yy");
            DateTime arrival = new DateTime(2011, 8, 31);
            DateTime ahora = DateTime.Today;
            daysHere = ((ahora - arrival).TotalDays).ToString();
            
            DateTime today = DateTime.Today;
            if (today.DayOfWeek == DayOfWeek.Monday) {
                addMonday = "Monday";
            }
            else
            {
                addMonday = "";
            }

            this.timeSpent1.Text = ((ahora - arrival).TotalDays).ToString() + " days" + addMonday  ;

            foreach (var c in this.tabControl1.TabPages[0].Controls.OfType<TextBox>())
            {
                if (c.Name.Contains("Meal")){
                    c.Multiline = true;
                    c.Height = 40;
                }
                if (c.Name.Contains("time"))
                {
                    c.Height = 80;
                    c.Text = "";
                }
            }

            tabPage1.Text = "Comida";
            tabPage2.Text = "Gastos";
            tabPage3.Text = "Transport";
            nameDocGastos.Enabled = false;
            nameDocComida.Enabled = false;
            sendMeals.Enabled = false;

        }

        private void typeSpenditure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeSpenditure.SelectedIndex > 0)
            {
                this.textBox3.Text = this.typeSpenditure.SelectedValue.ToString();
            }
        }

        private void sendMeals_Click(object sender, EventArgs e)
        {
            string salvar = timeToilet.Text + Environment.NewLine + breakfastMeal.Text + Environment.NewLine + lunchMeal.Text + Environment.NewLine + dinnerMeal.Text + Environment.NewLine;

            string fileName = fileComidas;
            if (!File.Exists(fileName))
            {
                var doc1 = DocX.Create(fileName);
                doc1.Save();
            }

            // Create a document in memory:
            var doc = DocX.Load(fileName);
            string headlineText = daysHere +addMonday;

            // A formatting object for our headline:
            var headLineFormat = new Formatting();
            headLineFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
            headLineFormat.Size = 18D;
            //headLineFormat.Position = 12;

            // A formatting object for our normal paragraph text:
            var paraFormat = new Formatting();
            paraFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
            paraFormat.Size = 11D;

            // Insert the now text obejcts;
            doc.InsertParagraph(headlineText, false, headLineFormat);
            doc.InsertParagraph(salvar, false, paraFormat);

            // Save to the output directory:
            doc.Save();
        }

        private void breakfast_TextChanged(object sender, EventArgs e)
        {
            string salvar = timeToilet.Text + Environment.NewLine + breakfastMeal.Text + Environment.NewLine + lunchMeal.Text + Environment.NewLine + dinnerMeal.Text + Environment.NewLine;
            dataComidas.Text = salvar;
        }

        private void lunch_TextChanged(object sender, EventArgs e)
        {
            string salvar = timeToilet.Text + Environment.NewLine + breakfastMeal.Text + Environment.NewLine + lunchMeal.Text + Environment.NewLine + dinnerMeal.Text + Environment.NewLine;
            dataComidas.Text = salvar;
        }

        private void timeToilet_TextChanged(object sender, EventArgs e)
        {
            string salvar = timeToilet.Text + Environment.NewLine + breakfastMeal.Text + Environment.NewLine + lunchMeal.Text + Environment.NewLine + dinnerMeal.Text + Environment.NewLine;
            dataComidas.Text = salvar;
        }

        private void dinner_TextChanged(object sender, EventArgs e)
        {
            string salvar = timeToilet.Text + Environment.NewLine + breakfastMeal.Text + Environment.NewLine + lunchMeal.Text + Environment.NewLine + dinnerMeal.Text + Environment.NewLine;
            dataComidas.Text = salvar;
        }

        private void openDocGastos_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileGastos = new OpenFileDialog();
            // Set filter options and filter index.
            openFileGastos.Filter = "Doc Files (.docx)|*.docx|All Files (*.*)|*.*";
            if (openFileGastos.ShowDialog() == DialogResult.OK)
            {
                //label1.Text = openFileDia.SafeFileName;
                string docGastos = openFileGastos.FileName;
                nameDocGastos.Text = docGastos;
            }
        }

        private void openDocComida_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDia = new OpenFileDialog();
            // Set filter options and filter index.
            openFileDia.Filter = "Doc Files (.docx)|*.docx|All Files (*.*)|*.*";
            if (openFileDia.ShowDialog() == DialogResult.OK)
            {
                //label1.Text = openFileDia.SafeFileName;
                string docComidas = openFileDia.FileName;
                fileComidas = docComidas; 
                nameDocComida.Text = docComidas;
            }
            if (File.Exists(fileComidas)) {

                sendMeals.Enabled = true;
            }
        }

        private void ToDo_Click(object sender, EventArgs e) 
        {
            string fileNm = @"C:\Users\Francisco\Documents\Visual Studio 2013\Projects\Prueba\ToDO.docx";
            System.Diagnostics.Process.Start(fileNm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlConnection sc = new SqlConnection();
            //SqlCommand com = new SqlCommand();
            //sc.ConnectionString = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Francisco\documents\visual studio 2013\Projects\Prueba\Prueba\Database1.mdf;Integrated Security=True");
            //sc.Open();
            //com.Connection = sc;
            //com.CommandText = ("INSERT INTO Gastos (Value) VALUES ('" +textBox6.Text + "');");
            //com.ExecuteNonQuery();
            //sc.Close();
            
            Properties.Settings.Default.dbGastosId++;
            button1.Text = Properties.Settings.Default.dbGastosId.ToString();


            string sql = "INSERT INTO Gastos (Id,Value) VALUES (@Id,@Value)";
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Francisco\documents\visual studio 2013\Projects\Prueba\Prueba\Database1.mdf;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@Id", Properties.Settings.Default.dbGastosId);
            command.Parameters.AddWithValue("@Value", textBox6.Text);

            command.ExecuteNonQuery();
            //comma;
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT MAX(ID) FROM Gastos";
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Francisco\documents\visual studio 2013\Projects\Prueba\Prueba\Database1.mdf;Integrated Security=True");
            connection.Open(); 
            SqlCommand comSelect = new SqlCommand(query, connection);
            int ID = Convert.ToInt32(comSelect.ExecuteScalar());
            //textBox6.Text = ID.ToString();
            connection.Close();
            Properties.Settings.Default.dbGastosId = ID;
            button1.Text = ID.ToString();
        }





    }
}

