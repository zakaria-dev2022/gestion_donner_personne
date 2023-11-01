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
using System.Data.Common;

namespace Gestion_donner_personne
{
    public partial class Form1 : Form
    {
        string connection = "Data Source=DESKTOP-G1088CP;Integrated Security=True";
        private SqlDataAdapter dataAdapter;
        SqlConnection Connection;
        SqlCommand cmd;
        private DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(connection);
            Connection.Open();

            //initializez l'adapteur de donnée et le datatable
            dataAdapter = new SqlDataAdapter("select * from client ", connection);
            dt = new DataTable();
            //remplissez le datatable avec less donnes
            dataAdapter.Fill(dt);
            //liez le datatable au tableau
            tableaux.DataSource = dt;
        }
    }
}
