namespace PresentationLayer
{
    partial class MainMenu
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BranchComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.MovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewLoan = new System.Windows.Forms.DataGridView();
            this.IdLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMovie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pending = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.MoviesLabel = new System.Windows.Forms.Label();
            this.LoanLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(0)))), ((int)(((byte)(91)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BranchComboBox);
            this.panel2.Location = new System.Drawing.Point(1, 91);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 413);
            this.panel2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(38, 352);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "Mostrar Peliculas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(38, 302);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mostrar Sucursales";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(105, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sucursales";
            // 
            // BranchComboBox
            // 
            this.BranchComboBox.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchComboBox.FormattingEnabled = true;
            this.BranchComboBox.Location = new System.Drawing.Point(67, 142);
            this.BranchComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BranchComboBox.Name = "BranchComboBox";
            this.BranchComboBox.Size = new System.Drawing.Size(169, 28);
            this.BranchComboBox.TabIndex = 4;
            this.BranchComboBox.SelectedIndexChanged += new System.EventHandler(this.BranchComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 92);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "VIDEOTECA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.KingBoo;
            this.pictureBox1.Location = new System.Drawing.Point(1127, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieId,
            this.MovieName,
            this.CategoryId,
            this.MovieCategory,
            this.Description,
            this.ReleaseYear,
            this.MovieLanguage});
            this.dataGridView.Location = new System.Drawing.Point(295, 153);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 72;
            this.dataGridView.RowTemplate.Height = 31;
            this.dataGridView.Size = new System.Drawing.Size(924, 270);
            this.dataGridView.TabIndex = 4;
            // 
            // MovieId
            // 
            this.MovieId.HeaderText = "ID Pelicula";
            this.MovieId.MinimumWidth = 9;
            this.MovieId.Name = "MovieId";
            this.MovieId.ReadOnly = true;
            this.MovieId.Width = 175;
            // 
            // MovieName
            // 
            this.MovieName.HeaderText = "Titulo";
            this.MovieName.MinimumWidth = 9;
            this.MovieName.Name = "MovieName";
            this.MovieName.ReadOnly = true;
            this.MovieName.Width = 175;
            // 
            // CategoryId
            // 
            this.CategoryId.HeaderText = "ID Categoria";
            this.CategoryId.MinimumWidth = 9;
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.ReadOnly = true;
            this.CategoryId.Width = 175;
            // 
            // MovieCategory
            // 
            this.MovieCategory.HeaderText = "Categoria";
            this.MovieCategory.MinimumWidth = 9;
            this.MovieCategory.Name = "MovieCategory";
            this.MovieCategory.ReadOnly = true;
            this.MovieCategory.Width = 175;
            // 
            // Description
            // 
            this.Description.HeaderText = "Descripcion";
            this.Description.MinimumWidth = 9;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 175;
            // 
            // ReleaseYear
            // 
            this.ReleaseYear.HeaderText = "Año de Lanzamiento";
            this.ReleaseYear.MinimumWidth = 9;
            this.ReleaseYear.Name = "ReleaseYear";
            this.ReleaseYear.ReadOnly = true;
            this.ReleaseYear.Width = 175;
            // 
            // MovieLanguage
            // 
            this.MovieLanguage.HeaderText = "Idioma";
            this.MovieLanguage.MinimumWidth = 9;
            this.MovieLanguage.Name = "MovieLanguage";
            this.MovieLanguage.ReadOnly = true;
            this.MovieLanguage.Width = 175;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(721, 453);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 30);
            this.button3.TabIndex = 8;
            this.button3.Text = "Solicitar Prestamo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridViewLoan
            // 
            this.dataGridViewLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLoan,
            this.IdCustomer,
            this.IdBranch,
            this.IdMovie,
            this.LoanDate,
            this.Pending});
            this.dataGridViewLoan.Location = new System.Drawing.Point(295, 153);
            this.dataGridViewLoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewLoan.Name = "dataGridViewLoan";
            this.dataGridViewLoan.RowHeadersWidth = 72;
            this.dataGridViewLoan.RowTemplate.Height = 31;
            this.dataGridViewLoan.Size = new System.Drawing.Size(924, 270);
            this.dataGridViewLoan.TabIndex = 9;
            this.dataGridViewLoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoan_CellContentClick);
            // 
            // IdLoan
            // 
            this.IdLoan.HeaderText = "ID Prestamo";
            this.IdLoan.MinimumWidth = 9;
            this.IdLoan.Name = "IdLoan";
            this.IdLoan.ReadOnly = true;
            this.IdLoan.Width = 175;
            // 
            // IdCustomer
            // 
            this.IdCustomer.HeaderText = "ID Cliente";
            this.IdCustomer.MinimumWidth = 9;
            this.IdCustomer.Name = "IdCustomer";
            this.IdCustomer.ReadOnly = true;
            this.IdCustomer.Width = 175;
            // 
            // IdBranch
            // 
            this.IdBranch.HeaderText = "ID Sucursal";
            this.IdBranch.MinimumWidth = 9;
            this.IdBranch.Name = "IdBranch";
            this.IdBranch.ReadOnly = true;
            this.IdBranch.Width = 175;
            // 
            // IdMovie
            // 
            this.IdMovie.HeaderText = "ID Pelicula";
            this.IdMovie.MinimumWidth = 9;
            this.IdMovie.Name = "IdMovie";
            this.IdMovie.ReadOnly = true;
            this.IdMovie.Width = 175;
            // 
            // LoanDate
            // 
            this.LoanDate.HeaderText = "Fecha Prestamo";
            this.LoanDate.MinimumWidth = 9;
            this.LoanDate.Name = "LoanDate";
            this.LoanDate.ReadOnly = true;
            this.LoanDate.Width = 175;
            // 
            // Pending
            // 
            this.Pending.HeaderText = "Pendiente";
            this.Pending.MinimumWidth = 9;
            this.Pending.Name = "Pending";
            this.Pending.ReadOnly = true;
            this.Pending.Width = 175;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(311, 453);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 30);
            this.button4.TabIndex = 10;
            this.button4.Text = "Mostrar Mis Prestamos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1014, 453);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(191, 30);
            this.button5.TabIndex = 11;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MoviesLabel
            // 
            this.MoviesLabel.AutoSize = true;
            this.MoviesLabel.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MoviesLabel.Location = new System.Drawing.Point(324, 114);
            this.MoviesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MoviesLabel.Name = "MoviesLabel";
            this.MoviesLabel.Size = new System.Drawing.Size(95, 21);
            this.MoviesLabel.TabIndex = 12;
            this.MoviesLabel.Text = "Peliculas";
            // 
            // LoanLabel
            // 
            this.LoanLabel.AutoSize = true;
            this.LoanLabel.Font = new System.Drawing.Font("Showcard Gothic", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoanLabel.Location = new System.Drawing.Point(324, 114);
            this.LoanLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoanLabel.Name = "LoanLabel";
            this.LoanLabel.Size = new System.Drawing.Size(107, 21);
            this.LoanLabel.TabIndex = 13;
            this.LoanLabel.Text = "Prestamos";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1229, 504);
            this.Controls.Add(this.LoanLabel);
            this.Controls.Add(this.MoviesLabel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridViewLoan);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BranchComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieLanguage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridViewLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pending;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label MoviesLabel;
        private System.Windows.Forms.Label LoanLabel;
    }
}

