using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WFUPR2
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection();
       // string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True";
        // @"Data Source=((LocalDB)\MSSQLLocalDB;Initial Catalog=Northwind;
        // Integrated Security=true";

        public Form1()
        {
            InitializeComponent();
            this.connection.StateChange += new StateChangeEventHandler(this.connection_StateChange);

        }
        //string connectionString = GetConnectionStringByName("DBConnect.NorthwindConnectionString");

        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }
        string connectionString = GetConnectionStringByName("DBConnect.NorthwindConnectionString");

        private void connection_StateChange(object sender, StateChangeEventArgs e)
        {
            подклБДToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Closed);
            asyncBDToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Closed);
            отклБДToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Open);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void подклБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    MessageBox.Show("Соединение с базой данных " +
                   connection.Database + " выполнено успешно " + "\nСервер: " +
                   connection.DataSource);
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            catch (SqlException XcpSQL)
            {
                foreach (SqlError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message, "Источник ошибки: " + se.Source,
                    MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void отклБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else
                MessageBox.Show("Соединение с базой данных уже закрыто");

        }

        private async void asyncBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.ConnectionString = connectionString;
                        await connection.OpenAsync();
                        MessageBox.Show("Соединение с базой данных " +
                       connection.Database + " выполнено успешно " + "\nСервер: " +
                       connection.DataSource);
                    }
                    else
                        MessageBox.Show("Соединение с базой данных уже установлено");
                }
                catch
                {
                    MessageBox.Show("Ошибка соединения с базой данных");
                }
            }


        }

        private void списокПодклToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    string str = String.Format("Name = { 0}\nProviderName = { 1}\nConnectionString = { 2} ", cs.Name, cs.ProviderName, cs.ConnectionString);
                    MessageBox.Show(str, "Параметры подключений");
                }
            }

        }
    }
}

