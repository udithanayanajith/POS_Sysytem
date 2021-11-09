using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPPM
{
	public partial class voucher: Form
	{
		SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-FLRVOGO\SQLEXPRESS; Initial Catalog=pos; Integrated Security=SSPI;");

		public voucher()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender,EventArgs e)
		{
			if (txt_v_name.Text == "" || txt_v_amt.Text == "")
			{
				MessageBox.Show("Please fill all details");
			}
			else
			{
				try
				{
					string query = "INSERT INTO voucher(v_amt,v_name) VALUES('" + txt_v_amt.Text + "','" + txt_v_name.Text + "')";
					SqlCommand cmd = new SqlCommand(query,connect);
					connect.Open();
					cmd.ExecuteNonQuery();
					MessageBox.Show("Done","Added to the voucher DB",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
					MessageBox.Show("Amount :" + txt_v_amt.Text,"Name :" + txt_v_name.Text);
					connect.Close();
					this.Close();
				}
				catch(Exception)
				{
					MessageBox.Show("Error with insertinf values to voucher table");
				}
			}
		}
	}
}
