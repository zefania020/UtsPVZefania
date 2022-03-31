using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kalkulator_Sederhana
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void ButtonTambahClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxAngka1.Text)||string.IsNullOrEmpty(textBoxAngka2.Text))
			{
				MessageBox.Show("Angka 1 dan Angka 2 tidak boleh kosong");
			} else {
				int a, b, c;
				a = int.Parse(this.textBoxAngka1.Text);
				b = int.Parse(this.textBoxAngka2.Text);
				c = a + b;
				this.labelHasil.Text = c.ToString();
			}
		}
		
		void ButtonKurangClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxAngka1.Text)||string.IsNullOrEmpty(textBoxAngka2.Text))
			{
				MessageBox.Show("Angka 1 dan Angka 2 tidak boleh kosong");
			} else {
				int a, b, c;
				a = int.Parse(this.textBoxAngka1.Text);
				b = int.Parse(this.textBoxAngka2.Text);
				c = a - b;
				this.labelHasil.Text = c.ToString();
			}
		}
		
		void ButtonKaliClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxAngka1.Text)||string.IsNullOrEmpty(textBoxAngka2.Text))
			{
				MessageBox.Show("Angka 1 dan Angka 2 tidak boleh kosong");
			} else {
				int a, b, c;
				a = int.Parse(this.textBoxAngka1.Text);
				b = int.Parse(this.textBoxAngka2.Text);
				c = a * b;
				this.labelHasil.Text = c.ToString();
			}
		}
		
		void ButtonBagiClick(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxAngka1.Text)||string.IsNullOrEmpty(textBoxAngka2.Text))
			{
				MessageBox.Show("Angka 1 dan Angka 2 tidak boleh kosong");
			} else {
				int a, b, c;
				a = int.Parse(this.textBoxAngka1.Text);
				b = int.Parse(this.textBoxAngka2.Text);
				c = a / b;
				this.labelHasil.Text = c.ToString();
			}
		}
		
		void ButtonClearClick(object sender, EventArgs e)
		{
			textBoxAngka1.Clear();
			textBoxAngka2.Clear();
			labelHasil.Text = "";
		}
	}
	
	
}
