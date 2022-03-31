using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//3
using System.Data.SqlClient;

namespace KasirBaru_Pertemuan7
{
	public partial class MainForm : Form
	{
		//4
        private SqlCommand cmd; 
        private DataSet ds; 
        private SqlDataAdapter da;
        
        Koneksi Konn = new Koneksi();
        
		public MainForm()
		{
			InitializeComponent();
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			SqlConnection conn = Konn.GetConn();
			try
			{
				conn.Open();
				cmd = new SqlCommand("Select * from TBL_BARANG", conn);
			
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "TBL_BARANG");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "TBL_BARANG";
				dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			catch (Exception G)
			{
				MessageBox.Show(G.ToString());
			}
			finally
			{
				conn.Close();
			}
		}
	}
}
