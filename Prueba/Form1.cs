using Novacode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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

        public string  td,tg ,thi, gastosData, fileComidas, daysHere, addMonday;
        public int dayID, ID1;
        public float comida, transport, accommodation, entre, supplies; 

        private void Form1_Load(object sender, EventArgs e)
        {

            button1.Text = Properties.Settings.Default.dbGastosId.ToString();
            
            var dataSource = new List<Le>();
            dataSource.Add(new Le() { Name = "<Select Value>", Value = "1" });
            dataSource.Add(new Le() { Name = "comida", Value = "2" });
            dataSource.Add(new Le() { Name = "transport", Value = "3" });
            dataSource.Add(new Le() { Name = "supplies", Value = "4" });
            dataSource.Add(new Le() { Name = "accommodation", Value = "5" });
            dataSource.Add(new Le() { Name = "salud", Value = "6" });
            dataSource.Add(new Le() { Name = "entre", Value = "7" });
            dataSource.Add(new Le() { Name = "cell", Value = "8" });
            dataSource.Add(new Le() { Name = "others", Value = "9" });
  
            //Setup data binding
            this.typeSpenditure.DataSource = dataSource;
            this.typeSpenditure.DisplayMember = "Name";
            this.typeSpenditure.ValueMember = "Value";

            this.timeStamp1.Text = "Today is: "+ DateTime.Now.ToString("dd/MM/yy");
            DateTime arrival = new DateTime(2011, 8, 31);
            DateTime ahora = DateTime.Today;
            daysHere = ((ahora - arrival).TotalDays).ToString();
            dayID = Convert.ToInt32((ahora - arrival).TotalDays);
            dayID = 1290;
            DateTime today = DateTime.Today;
            if (today.DayOfWeek == DayOfWeek.Monday) {
                addMonday = "Monday";
            }
            else
            {
                addMonday = "";
            }

            this.timeSpent1.Text = daysHere + " days" + addMonday  ;

            foreach (var c in this.tabControl1.TabPages[1].Controls.OfType<TextBox>())
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

            dataB ini = new dataB();
            SqlDataReader reader = ini.readLastDay(dayID);
            
            string tx = "";
            List<string> list = new List<string>();
            while (reader.Read()){
                tx=tx+reader["day"].ToString();
                td =  reader["cash"].ToString() +" cash "+ reader["caus"].ToString() + " caus "+ reader["dos"].ToString() + " dos " +reader["bwest"].ToString() +" bwest "+ reader["credit"].ToString() + " credit";
                tg =  reader["total"].ToString() + " total";
                comida = float.Parse(reader["comida"].ToString(), CultureInfo.InvariantCulture.NumberFormat);
                list.Add(reader["day"].ToString());  
            }

            dataGastos.Text = td + Environment.NewLine + tg;
            ini.closeD();

            preValue.Text = comida.ToString();
            for (int i = 0; i < list.Count; i++)
            {
                richTextBox1.Text += list[i];
            }

        }

        private void typeSpenditure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeSpenditure.SelectedIndex > 0)
            {
                thi = typeSpenditure.GetItemText(this.typeSpenditure.SelectedItem);
            }
        }

        private void sendMeals_Click(object sender, EventArgs e)
        {
            string salvar = timeToilet.Text + Environment.NewLine + breakfastMeal.Text + Environment.NewLine + lunchMeal.Text + Environment.NewLine + dinnerMeal.Text + Environment.NewLine;
            string fileName = fileComidas;
            Uno h = new Uno();

            h.Saving(fileName, salvar, daysHere, addMonday);

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
                string docGastos = openFileGastos.FileName;
                nameDocGastos.Text = docGastos;
                writeDocGastos.Enabled = true; 
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

            button1.Text = Properties.Settings.Default.dbGastosId.ToString();
            
            if (ID1<dayID){
                string sql = "INSERT INTO Gastos (Id,Value) VALUES (@Id,@Value)";
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Francisco\documents\visual studio 2013\Projects\Prueba\Prueba\Database1.mdf;Integrated Security=True");
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Id", dayID);
                command.Parameters.AddWithValue("@Value", textTransport.Text);
                command.ExecuteNonQuery();
                connection.Close();            
            }
            if (ID1 == dayID) {
                string sql = "UPDATE Gastos SET Value=@Value WHERE Id=@Id";
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Francisco\documents\visual studio 2013\Projects\Prueba\Prueba\Database1.mdf;Integrated Security=True");
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Id", dayID);
                command.Parameters.AddWithValue("@Value", textTransport.Text);
                command.ExecuteNonQuery();
                connection.Close(); 
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataB n = new dataB();
            ID1 = n.maxID();
            Properties.Settings.Default.dbGastosId = ID1;
            button1.Text = ID1.ToString();
        }

        private void nextGasto_Click(object sender, EventArgs e)
        {
            gastosData += value.Text + " " + thi + " " + descriptionGasto.Text;
            dataGastos.Text = td + Environment.NewLine + tg + Environment.NewLine + gastosData;
            gastosData = gastosData + Environment.NewLine;


            if (Convert.ToInt32(this.typeSpenditure.SelectedValue) == 2)
            {
                float cd = float.Parse(value.Text, CultureInfo.InvariantCulture.NumberFormat);
                comida += cd;
                preValue.Text = comida.ToString();
                dataB jj = new dataB();

                jj.updateData(dayID, comida);

            }


        }

        private void writeDocGastos_Click(object sender, EventArgs e)
        {
            string salvar = td + Environment.NewLine + tg + Environment.NewLine + gastosData;
            string fileName = nameDocGastos.Text;
            Uno he = new Uno();

            he.Saving(fileName, salvar, daysHere, addMonday);
        }


    }
}