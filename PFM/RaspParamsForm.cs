using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFM
{
    public partial class RaspParamsForm : Form
    {
        public RaspParamsForm()
        {
            InitializeComponent();
        }

        private void RaspParamsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pfmDataSet.sort". При необходимости она может быть перемещена или удалена.
            this.sortTableAdapter.Fill(this.pfmDataSet.sort);
            // TODO: This line of code loads data into the 'pfmDataSet.sizes' table. You can move, or remove it, as needed.
            this.sizesTableAdapter.Fill(this.pfmDataSet.sizes);
            // TODO: This line of code loads data into the 'pfmDataSet.output_lenght' table. You can move, or remove it, as needed.
            this.output_lenghtTableAdapter.Fill(this.pfmDataSet.output_lenght);
            // TODO: This line of code loads data into the 'pfmDataSet.output_lenght' table. You can move, or remove it, as needed.
            this.output_lenghtTableAdapter.Fill(this.pfmDataSet.output_lenght);
            // TODO: This line of code loads data into the 'pfmDataSet.input_length' table. You can move, or remove it, as needed.
            this.input_lengthTableAdapter.Fill(this.pfmDataSet.input_length);
            // TODO: This line of code loads data into the 'pfmDataSet.output_lenght' table. You can move, or remove it, as needed.
            this.output_lenghtTableAdapter.Fill(this.pfmDataSet.output_lenght);
            // TODO: This line of code loads data into the 'pfmDataSet.input_length' table. You can move, or remove it, as needed.
            this.input_lengthTableAdapter.Fill(this.pfmDataSet.input_length);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                this.output_lenghtTableAdapter.Update(this.pfmDataSet);
                this.sizesTableAdapter.Update(this.pfmDataSet);
                this.sortTableAdapter.Update(this.pfmDataSet);

                this.Hide();
                MainForm MainForm = new MainForm();
                MainForm.Show();
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sizesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
