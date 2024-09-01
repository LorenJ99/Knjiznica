namespace Knjiznica
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.member_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member_surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.azuriranje = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.brisanje = new System.Windows.Forms.Button();
            this.dodavanje = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.member_name,
            this.member_surname,
            this.member_id});
            this.dataGridView1.Location = new System.Drawing.Point(378, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 297);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // member_name
            // 
            this.member_name.HeaderText = "Ime";
            this.member_name.MinimumWidth = 6;
            this.member_name.Name = "member_name";
            this.member_name.Width = 125;
            // 
            // member_surname
            // 
            this.member_surname.HeaderText = "Prezime";
            this.member_surname.MinimumWidth = 6;
            this.member_surname.Name = "member_surname";
            this.member_surname.Width = 125;
            // 
            // member_id
            // 
            this.member_id.HeaderText = "ID člana";
            this.member_id.MinimumWidth = 6;
            this.member_id.Name = "member_id";
            this.member_id.Width = 125;
            // 
            // azuriranje
            // 
            this.azuriranje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.azuriranje.Location = new System.Drawing.Point(163, 397);
            this.azuriranje.Name = "azuriranje";
            this.azuriranje.Size = new System.Drawing.Size(166, 39);
            this.azuriranje.TabIndex = 20;
            this.azuriranje.Text = "Ažuriraj člana";
            this.azuriranje.UseVisualStyleBackColor = true;
            this.azuriranje.Click += new System.EventHandler(this.azuriranje_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(154, 255);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(185, 22);
            this.textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(154, 198);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 22);
            this.textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 22);
            this.textBox1.TabIndex = 17;
            // 
            // brisanje
            // 
            this.brisanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brisanje.Location = new System.Drawing.Point(163, 352);
            this.brisanje.Name = "brisanje";
            this.brisanje.Size = new System.Drawing.Size(166, 39);
            this.brisanje.TabIndex = 16;
            this.brisanje.Text = "Obriši člana";
            this.brisanje.UseVisualStyleBackColor = true;
            this.brisanje.Click += new System.EventHandler(this.brisanje_Click);
            // 
            // dodavanje
            // 
            this.dodavanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodavanje.Location = new System.Drawing.Point(163, 307);
            this.dodavanje.Name = "dodavanje";
            this.dodavanje.Size = new System.Drawing.Size(166, 39);
            this.dodavanje.TabIndex = 15;
            this.dodavanje.Text = "Dodaj člana";
            this.dodavanje.UseVisualStyleBackColor = true;
            this.dodavanje.Click += new System.EventHandler(this.dodavanje_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(35, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "ID člana:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(35, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(35, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ime:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(225, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "Upravljanje članovima";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(853, 496);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.azuriranje);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.brisanje);
            this.Controls.Add(this.dodavanje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button azuriranje;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button brisanje;
        private System.Windows.Forms.Button dodavanje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_id;
    }
}