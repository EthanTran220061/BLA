using System;
using System.Data;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace BLA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 500,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
                Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }
        }
        int x = 2;
        int y = 0;
        private void Sign_Out(object sender, EventArgs e)
        {


            string promptName = Prompt.ShowDialog("Name", "Sign Out");
            string promptPeriod = Prompt.ShowDialog("Period", "Sign Out");
            string promptDest = Prompt.ShowDialog("Destination", "Sign Out");
            //dataGridView1[x, y].Value = promptName;
            //dataGridView1[x + 1, y].Value = promptPeriod;
            //dataGridView1[x + 2, y].Value = promptDest;
            DateTime currentTime = DateTime.Now;
            //dataGridView1[x - 2, y].Value = currentTime;
            dataGridView1.Rows.Add(currentTime, "", promptName, promptPeriod, promptDest, "");
            //x++;
            //y++;


        }
        bool first = true;
        int i = 1;
        private void SignIn_Click(object sender, EventArgs e)
        {

            string message = "Thank you for signing back in: ";




            if (first == true)
            {
                dataGridView1[x + 3, y].Value = message + dataGridView1[x, y].Value;
                DateTime currentTime = DateTime.Now;
                dataGridView1[x - 1, y].Value = currentTime;
                first = false;
            }
            else
            {
                dataGridView1[x + 3, i].Value = message + dataGridView1[x, i].Value;
                DateTime currentTime = DateTime.Now;
                dataGridView1[x - 1, i].Value = currentTime;
                i++;
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        

        private void Save_Data_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "CSV File (*.csv)|*.csv";
            saveDialog.FileName = "DataGridViewExport.csv";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToCSV(dataGridView1, saveDialog.FileName);
            }

        }
        

        private void ExportToCSV(DataGridView dataGridView, string fileName)
        {
            try
            {
                StreamWriter sw = new StreamWriter(fileName);

                // Writing headers
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    sw.Write(dataGridView.Columns[i].HeaderText);
                    if (i < dataGridView.ColumnCount - 1)
                        sw.Write(", ");
                }
                sw.WriteLine();

                // Writing data
                for (int j = 0; j < dataGridView.Rows.Count; j++)
                {
                    for (int k = 0; k < dataGridView.Columns.Count; k++)
                    {
                        if (dataGridView.Rows[j].Cells[k].Value != null)
                            sw.Write(dataGridView.Rows[j].Cells[k].Value.ToString() + " ");
                        //if (k < dataGridView.Columns.Count - 1)
                            //sw.Write(".");
                    }
                    sw.WriteLine();
                }
                sw.Flush();
                sw.Close();
                MessageBox.Show("Data exported successfully.", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }

}