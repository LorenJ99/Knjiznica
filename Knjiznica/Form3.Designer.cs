namespace Knjiznica
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dodaj = new System.Windows.Forms.Button();
            this.obrisi_knjigu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.azuriraj_knjigu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(231, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upravljanje knjigama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(41, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(41, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(41, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID knjige:";
            // 
            // dodaj
            // 
            this.dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodaj.Location = new System.Drawing.Point(169, 316);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(166, 39);
            this.dodaj.TabIndex = 4;
            this.dodaj.Text = "Dodaj knjigu";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // obrisi_knjigu
            // 
            this.obrisi_knjigu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.obrisi_knjigu.Location = new System.Drawing.Point(169, 361);
            this.obrisi_knjigu.Name = "obrisi_knjigu";
            this.obrisi_knjigu.Size = new System.Drawing.Size(166, 39);
            this.obrisi_knjigu.TabIndex = 5;
            this.obrisi_knjigu.Text = "Obriši knjigu";
            this.obrisi_knjigu.UseVisualStyleBackColor = true;
            this.obrisi_knjigu.Click += new System.EventHandler(this.obrisi_knjigu_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 250);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(185, 22);
            this.textBox3.TabIndex = 8;
            // 
            // azuriraj_knjigu
            // 
            this.azuriraj_knjigu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.azuriraj_knjigu.Location = new System.Drawing.Point(169, 406);
            this.azuriraj_knjigu.Name = "azuriraj_knjigu";
            this.azuriraj_knjigu.Size = new System.Drawing.Size(166, 39);
            this.azuriraj_knjigu.TabIndex = 9;
            this.azuriraj_knjigu.Text = "Ažuriraj knjigu";
            this.azuriraj_knjigu.UseVisualStyleBackColor = true;
            this.azuriraj_knjigu.Click += new System.EventHandler(this.azuriraj_knjigu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_name,
            this.book_author,
            this.book_id});
            this.dataGridView1.Location = new System.Drawing.Point(434, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 297);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // book_name
            // 
            this.book_name.HeaderText = "Naziv";
            this.book_name.MinimumWidth = 6;
            this.book_name.Name = "book_name";
            this.book_name.Width = 125;
            // 
            // book_author
            // 
            this.book_author.HeaderText = "Autor";
            this.book_author.MinimumWidth = 6;
            this.book_author.Name = "book_author";
            this.book_author.Width = 125;
            // 
            // book_id
            // 
            this.book_id.HeaderText = "ID knjige";
            this.book_id.MinimumWidth = 6;
            this.book_id.Name = "book_id";
            this.book_id.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(973, 495);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.azuriraj_knjigu);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.obrisi_knjigu);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button obrisi_knjigu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button azuriraj_knjigu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_author;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
    }
}