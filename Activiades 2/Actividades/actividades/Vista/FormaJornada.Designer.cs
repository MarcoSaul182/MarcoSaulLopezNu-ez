namespace actividades.Vista
{
    partial class FormaJornada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaJornada));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEquipo = new System.Windows.Forms.Button();
            this.buttonJornadas = new System.Windows.Forms.Button();
            this.buttonCampeonato = new System.Windows.Forms.Button();
            this.pictureExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(30, 30);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(700, 296);
            this.splitContainer1.SplitterDistance = 73;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(103, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liga de Futbol Miguel Hidalgo";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.5545F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.4455F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Controls.Add(this.buttonEquipo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonJornadas, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCampeonato, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureExit, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 219);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonEquipo
            // 
            this.buttonEquipo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEquipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEquipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEquipo.Location = new System.Drawing.Point(3, 112);
            this.buttonEquipo.Name = "buttonEquipo";
            this.buttonEquipo.Size = new System.Drawing.Size(353, 104);
            this.buttonEquipo.TabIndex = 2;
            this.buttonEquipo.Text = "Equipo";
            this.buttonEquipo.UseVisualStyleBackColor = false;
            // 
            // buttonJornadas
            // 
            this.buttonJornadas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonJornadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonJornadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJornadas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonJornadas.Location = new System.Drawing.Point(362, 3);
            this.buttonJornadas.Name = "buttonJornadas";
            this.buttonJornadas.Size = new System.Drawing.Size(306, 103);
            this.buttonJornadas.TabIndex = 1;
            this.buttonJornadas.Text = "Jornadas";
            this.buttonJornadas.UseVisualStyleBackColor = false;
            // 
            // buttonCampeonato
            // 
            this.buttonCampeonato.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCampeonato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCampeonato.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCampeonato.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCampeonato.Location = new System.Drawing.Point(3, 3);
            this.buttonCampeonato.Name = "buttonCampeonato";
            this.buttonCampeonato.Size = new System.Drawing.Size(353, 103);
            this.buttonCampeonato.TabIndex = 0;
            this.buttonCampeonato.Text = "Campeonato";
            this.buttonCampeonato.UseVisualStyleBackColor = false;
            this.buttonCampeonato.Click += new System.EventHandler(this.buttonCampeonato_Click);
            this.buttonCampeonato.MouseEnter += new System.EventHandler(this.buttonCampeonato_MouseEnter);
            // 
            // pictureExit
            // 
            this.pictureExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureExit.Image")));
            this.pictureExit.Location = new System.Drawing.Point(362, 112);
            this.pictureExit.Name = "pictureExit";
            this.pictureExit.Size = new System.Drawing.Size(306, 86);
            this.pictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureExit.TabIndex = 3;
            this.pictureExit.TabStop = false;
            this.pictureExit.Click += new System.EventHandler(this.pictureExit_Click);
            // 
            // FormaJornada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 356);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormaJornada";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Text = "FormaJornada";
            this.Load += new System.EventHandler(this.FormaJornada_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonCampeonato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEquipo;
        private System.Windows.Forms.Button buttonJornadas;
        private System.Windows.Forms.PictureBox pictureExit;
    }
}