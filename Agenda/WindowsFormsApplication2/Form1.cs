using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Agenda' table. You can move, or remove it, as needed.
            this.agendaTableAdapter.Fill(this.database1DataSet.Agenda);
            // TODO: This line of code loads data into the 'database1DataSet.Agenda' table. You can move, or remove it, as needed.
            this.agendaTableAdapter.Fill(this.database1DataSet.Agenda);
            // TODO: This line of code loads data into the 'database1DataSet.Agenda' table. You can move, or remove it, as needed.
            this.agendaTableAdapter.Fill(this.database1DataSet.Agenda);

        }

        private void agendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void agendaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.agendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void agendaBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.agendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void enderecoLabel_Click(object sender, EventArgs e)
        {

        }

        private void enderecoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cidadeLabel_Click(object sender, EventArgs e)
        {

        }

        private void cidadeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void estadoLabel_Click(object sender, EventArgs e)
        {

        }

        private void estadoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void paisLabel_Click(object sender, EventArgs e)
        {

        }

        private void paisTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void telefoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void agendaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
