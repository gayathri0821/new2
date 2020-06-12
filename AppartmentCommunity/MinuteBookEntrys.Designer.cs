namespace MyProject1
{
    partial class MinuteBookEntrys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinuteBookEntrys));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvdetails = new System.Windows.Forms.DataGridView();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(372, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minute Book  Entrys";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(121, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Details";
            // 
            // dgvdetails
            // 
            this.dgvdetails.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetails.Location = new System.Drawing.Point(286, 92);
            this.dgvdetails.Name = "dgvdetails";
            this.dgvdetails.RowTemplate.Height = 24;
            this.dgvdetails.Size = new System.Drawing.Size(699, 267);
            this.dgvdetails.TabIndex = 2;
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.Black;
            this.btnrefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnrefresh.BackgroundImage")));
            this.btnrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrefresh.Location = new System.Drawing.Point(380, 388);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(122, 46);
            this.btnrefresh.TabIndex = 3;
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnprint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnprint.BackgroundImage")));
            this.btnprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnprint.Location = new System.Drawing.Point(607, 388);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(114, 46);
            this.btnprint.TabIndex = 4;
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // MinuteBookEntrys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1113, 495);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.dgvdetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "MinuteBookEntrys";
            this.Text = "MinuteBookEntrys";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvdetails;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnprint;
    }
}