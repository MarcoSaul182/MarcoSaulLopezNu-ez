namespace actividades
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureStudents = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureStudents
            // 
            this.pictureStudents.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureStudents.BackgroundImage")));
            this.pictureStudents.Image = ((System.Drawing.Image)(resources.GetObject("pictureStudents.Image")));
            this.pictureStudents.Location = new System.Drawing.Point(13, 13);
            this.pictureStudents.Name = "pictureStudents";
            this.pictureStudents.Size = new System.Drawing.Size(896, 410);
            this.pictureStudents.TabIndex = 0;
            this.pictureStudents.TabStop = false;
            this.pictureStudents.Click += new System.EventHandler(this.pictureStudents_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 435);
            this.Controls.Add(this.pictureStudents);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureStudents;
    }
}