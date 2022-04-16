
namespace MatrixWinForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.rank = new System.Windows.Forms.RadioButton();
            this.stepen = new System.Windows.Forms.RadioButton();
            this.transpon = new System.Windows.Forms.RadioButton();
            this.opredel = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sum_rbtn = new System.Windows.Forms.RadioButton();
            this.sub_rbtn = new System.Windows.Forms.RadioButton();
            this.mult_rbtn = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.OpredelitelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(520, 242);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 303);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Размерность";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(608, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(520, 242);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(228, 484);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(600, 242);
            this.dataGridView3.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 19);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Матрица 1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(608, 25);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(84, 19);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Матрица 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // rank
            // 
            this.rank.AutoSize = true;
            this.rank.Location = new System.Drawing.Point(6, 22);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(50, 19);
            this.rank.TabIndex = 10;
            this.rank.TabStop = true;
            this.rank.Text = "Ранг";
            this.rank.UseVisualStyleBackColor = true;
            this.rank.Checked = true;
            this.rank.CheckedChanged += new System.EventHandler(this.rank_CheckedChanged);
            // 
            // stepen
            // 
            this.stepen.AutoSize = true;
            this.stepen.Location = new System.Drawing.Point(62, 22);
            this.stepen.Name = "stepen";
            this.stepen.Size = new System.Drawing.Size(143, 19);
            this.stepen.TabIndex = 11;
            this.stepen.TabStop = true;
            this.stepen.Text = "Возведение в степень";
            this.stepen.UseVisualStyleBackColor = true;
            this.stepen.CheckedChanged += new System.EventHandler(this.stepen_CheckedChanged);
            // 
            // transpon
            // 
            this.transpon.AutoSize = true;
            this.transpon.Location = new System.Drawing.Point(206, 22);
            this.transpon.Name = "transpon";
            this.transpon.Size = new System.Drawing.Size(131, 19);
            this.transpon.TabIndex = 12;
            this.transpon.TabStop = true;
            this.transpon.Text = "Транспонирование";
            this.transpon.UseVisualStyleBackColor = true;
            // 
            // opredel
            // 
            this.opredel.AutoSize = true;
            this.opredel.Location = new System.Drawing.Point(336, 22);
            this.opredel.Name = "opredel";
            this.opredel.Size = new System.Drawing.Size(104, 19);
            this.opredel.TabIndex = 13;
            this.opredel.TabStop = true;
            this.opredel.Text = "Определитель";
            this.opredel.UseVisualStyleBackColor = true;
            this.opredel.CheckedChanged += new System.EventHandler(this.opredel_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rank);
            this.groupBox1.Controls.Add(this.opredel);
            this.groupBox1.Controls.Add(this.stepen);
            this.groupBox1.Controls.Add(this.transpon);
            this.groupBox1.Location = new System.Drawing.Point(337, 406);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 53);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия с одной матрицей";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sum_rbtn);
            this.groupBox2.Controls.Add(this.sub_rbtn);
            this.groupBox2.Controls.Add(this.mult_rbtn);
            this.groupBox2.Location = new System.Drawing.Point(337, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 53);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Действия с двумя матрицами";
            // 
            // sum_rbtn
            // 
            this.sum_rbtn.AutoSize = true;
            this.sum_rbtn.Checked = true;
            this.sum_rbtn.Location = new System.Drawing.Point(6, 22);
            this.sum_rbtn.Name = "sum_rbtn";
            this.sum_rbtn.Size = new System.Drawing.Size(82, 19);
            this.sum_rbtn.TabIndex = 10;
            this.sum_rbtn.TabStop = true;
            this.sum_rbtn.Text = "Сложение";
            this.sum_rbtn.UseVisualStyleBackColor = true;
            this.sum_rbtn.CheckedChanged += new System.EventHandler(this.sum_rbtn_CheckedChanged);
            // 
            // sub_rbtn
            // 
            this.sub_rbtn.AutoSize = true;
            this.sub_rbtn.Location = new System.Drawing.Point(106, 22);
            this.sub_rbtn.Name = "sub_rbtn";
            this.sub_rbtn.Size = new System.Drawing.Size(86, 19);
            this.sub_rbtn.TabIndex = 11;
            this.sub_rbtn.TabStop = true;
            this.sub_rbtn.Text = "Вычитание";
            this.sub_rbtn.UseVisualStyleBackColor = true;
            this.sub_rbtn.CheckedChanged += new System.EventHandler(this.sub_rbtn_CheckedChanged);
            // 
            // mult_rbtn
            // 
            this.mult_rbtn.AutoSize = true;
            this.mult_rbtn.Location = new System.Drawing.Point(206, 22);
            this.mult_rbtn.Name = "mult_rbtn";
            this.mult_rbtn.Size = new System.Drawing.Size(90, 19);
            this.mult_rbtn.TabIndex = 12;
            this.mult_rbtn.TabStop = true;
            this.mult_rbtn.Text = "Умножение";
            this.mult_rbtn.UseVisualStyleBackColor = true;
            this.mult_rbtn.CheckedChanged += new System.EventHandler(this.mult_rbtn_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(834, 484);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(302, 242);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(834, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "В какую степень возвести?";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(834, 455);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 23);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "1";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // OpredelitelLabel
            // 
            this.OpredelitelLabel.AutoSize = true;
            this.OpredelitelLabel.Location = new System.Drawing.Point(834, 458);
            this.OpredelitelLabel.Name = "OpredelitelLabel";
            this.OpredelitelLabel.Size = new System.Drawing.Size(38, 15);
            this.OpredelitelLabel.TabIndex = 18;
            this.OpredelitelLabel.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 747);
            this.Controls.Add(this.OpredelitelLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RadioButton rank;
        private System.Windows.Forms.RadioButton stepen;
        private System.Windows.Forms.RadioButton transpon;
        private System.Windows.Forms.RadioButton opredel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton sum_rbtn;
        private System.Windows.Forms.RadioButton sub_rbtn;
        private System.Windows.Forms.RadioButton mult_rbtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label OpredelitelLabel;
    }
}

