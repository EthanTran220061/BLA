namespace BLA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            SignOut = new Button();
            SignIn = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Save_Data = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SignOut
            // 
            SignOut.Location = new Point(224, 373);
            SignOut.Name = "SignOut";
            SignOut.Size = new Size(93, 42);
            SignOut.TabIndex = 0;
            SignOut.Text = "Sign Out";
            SignOut.UseVisualStyleBackColor = true;
            SignOut.Click += Sign_Out;
            // 
            // SignIn
            // 
            SignIn.Location = new Point(472, 373);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(93, 42);
            SignIn.TabIndex = 1;
            SignIn.Text = "Sign In";
            SignIn.UseVisualStyleBackColor = true;
            SignIn.Click += SignIn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(12, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 335);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Time Out";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Time In";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Name";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Period";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Destination";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Message";
            Column6.Name = "Column6";
            // 
            // Save_Data
            // 
            Save_Data.Location = new Point(689, 382);
            Save_Data.Name = "Save_Data";
            Save_Data.Size = new Size(99, 33);
            Save_Data.TabIndex = 3;
            Save_Data.Text = "Save Data";
            Save_Data.UseVisualStyleBackColor = true;
            Save_Data.Click += Save_Data_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 382);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 514);
            Controls.Add(pictureBox1);
            Controls.Add(Save_Data);
            Controls.Add(dataGridView1);
            Controls.Add(SignIn);
            Controls.Add(SignOut);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button SignOut;
        private Button SignIn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button Save_Data;
        private PictureBox pictureBox1;
    }
}