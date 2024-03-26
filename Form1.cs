using System.Data;
using System.Text;
using Microsoft.Office;
using Microsoft.Office.Interop.Excel;

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
                System.Windows.Forms.Label textLabel = new System.Windows.Forms.Label() { Left = 50, Top = 20, Text = text };
                System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox() { Left = 50, Top = 50, Width = 400 };
                System.Windows.Forms.Button confirmation = new System.Windows.Forms.Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
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
                dataGridView1[x + 3, i].Value = message + dataGridView1[x, y].Value;
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

        }


        private void iSave()

        { 
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            app.Visible = true;
            
            Microsoft.Office.Interop.Excel.Worksheet sh = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
            worksheet = Workbook.ActiveSheet;
            worksheet.Name = "Exported from gridview";



        }

    }

}