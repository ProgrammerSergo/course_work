namespace reshotka
{
    partial class AddWords
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wordTb = new System.Windows.Forms.TextBox();
            this.helpTb = new System.Windows.Forms.TextBox();
            this.addWordBtn = new System.Windows.Forms.Button();
            this.wordsPanel = new System.Windows.Forms.DataGridView();
            this.word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.help = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createCross = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wordsPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Слово";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Подсказка";
            // 
            // wordTb
            // 
            this.wordTb.Location = new System.Drawing.Point(16, 90);
            this.wordTb.Name = "wordTb";
            this.wordTb.Size = new System.Drawing.Size(200, 20);
            this.wordTb.TabIndex = 1;
            // 
            // helpTb
            // 
            this.helpTb.Location = new System.Drawing.Point(16, 140);
            this.helpTb.Multiline = true;
            this.helpTb.Name = "helpTb";
            this.helpTb.Size = new System.Drawing.Size(200, 77);
            this.helpTb.TabIndex = 1;
            // 
            // addWordBtn
            // 
            this.addWordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.addWordBtn.FlatAppearance.BorderSize = 0;
            this.addWordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWordBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addWordBtn.Location = new System.Drawing.Point(16, 237);
            this.addWordBtn.Name = "addWordBtn";
            this.addWordBtn.Size = new System.Drawing.Size(200, 29);
            this.addWordBtn.TabIndex = 2;
            this.addWordBtn.Text = "Добавить слово";
            this.addWordBtn.UseVisualStyleBackColor = false;
            this.addWordBtn.Click += new System.EventHandler(this.addWordBtn_Click);
            // 
            // wordsPanel
            // 
            this.wordsPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wordsPanel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.word,
            this.help});
            this.wordsPanel.Location = new System.Drawing.Point(256, 29);
            this.wordsPanel.Name = "wordsPanel";
            this.wordsPanel.Size = new System.Drawing.Size(444, 237);
            this.wordsPanel.TabIndex = 3;
            // 
            // word
            // 
            this.word.HeaderText = "Слово";
            this.word.Name = "word";
            this.word.ReadOnly = true;
            // 
            // help
            // 
            this.help.HeaderText = "Подсказка";
            this.help.Name = "help";
            this.help.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Название кроссворда";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(16, 29);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(200, 20);
            this.nameTb.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Слова";
            // 
            // createCross
            // 
            this.createCross.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(237)))), ((int)(((byte)(153)))));
            this.createCross.FlatAppearance.BorderSize = 0;
            this.createCross.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCross.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createCross.Location = new System.Drawing.Point(500, 283);
            this.createCross.Name = "createCross";
            this.createCross.Size = new System.Drawing.Size(200, 29);
            this.createCross.TabIndex = 2;
            this.createCross.Text = "Создать";
            this.createCross.UseVisualStyleBackColor = false;
            this.createCross.Click += new System.EventHandler(this.createCross_Click);
            // 
            // AddWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 335);
            this.Controls.Add(this.wordsPanel);
            this.Controls.Add(this.createCross);
            this.Controls.Add(this.addWordBtn);
            this.Controls.Add(this.helpTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.wordTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddWords";
            this.Text = "Добавление поля";
            this.Load += new System.EventHandler(this.AddWords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wordsPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wordTb;
        private System.Windows.Forms.TextBox helpTb;
        private System.Windows.Forms.Button addWordBtn;
        private System.Windows.Forms.DataGridView wordsPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createCross;
        private System.Windows.Forms.DataGridViewTextBoxColumn word;
        private System.Windows.Forms.DataGridViewTextBoxColumn help;
    }
}