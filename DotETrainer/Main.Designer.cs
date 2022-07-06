namespace DotETrainer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ProcOpenLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infhealth = new System.Windows.Forms.CheckBox();
            this.infstamina = new System.Windows.Forms.CheckBox();
            this.infhunger = new System.Windows.Forms.CheckBox();
            this.infthirst = new System.Windows.Forms.CheckBox();
            this.inffuel = new System.Windows.Forms.CheckBox();
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.experimentalHealth = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Running: ";
            // 
            // ProcOpenLabel
            // 
            this.ProcOpenLabel.AutoSize = true;
            this.ProcOpenLabel.Location = new System.Drawing.Point(130, 9);
            this.ProcOpenLabel.Name = "ProcOpenLabel";
            this.ProcOpenLabel.Size = new System.Drawing.Size(38, 21);
            this.ProcOpenLabel.TabIndex = 1;
            this.ProcOpenLabel.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Made By\r\nSaniee#0007";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DotETrainer.Properties.Resources.tenebris_vector_art;
            this.pictureBox1.Location = new System.Drawing.Point(12, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // infhealth
            // 
            this.infhealth.AutoSize = true;
            this.infhealth.Location = new System.Drawing.Point(12, 33);
            this.infhealth.Name = "infhealth";
            this.infhealth.Size = new System.Drawing.Size(123, 25);
            this.infhealth.TabIndex = 4;
            this.infhealth.Text = "Freeze Health";
            this.infhealth.UseVisualStyleBackColor = true;
            this.infhealth.CheckedChanged += new System.EventHandler(this.infhealth_CheckedChanged);
            // 
            // infstamina
            // 
            this.infstamina.AutoSize = true;
            this.infstamina.Location = new System.Drawing.Point(12, 64);
            this.infstamina.Name = "infstamina";
            this.infstamina.Size = new System.Drawing.Size(134, 25);
            this.infstamina.TabIndex = 5;
            this.infstamina.Text = "Freeze Stamina";
            this.infstamina.UseVisualStyleBackColor = true;
            this.infstamina.CheckedChanged += new System.EventHandler(this.infstamina_CheckedChanged);
            // 
            // infhunger
            // 
            this.infhunger.AutoSize = true;
            this.infhunger.Location = new System.Drawing.Point(10, 95);
            this.infhunger.Name = "infhunger";
            this.infhunger.Size = new System.Drawing.Size(130, 25);
            this.infhunger.TabIndex = 6;
            this.infhunger.Text = "Freeze Hunger";
            this.infhunger.UseVisualStyleBackColor = true;
            this.infhunger.CheckedChanged += new System.EventHandler(this.infhunger_CheckedChanged);
            // 
            // infthirst
            // 
            this.infthirst.AutoSize = true;
            this.infthirst.Location = new System.Drawing.Point(10, 126);
            this.infthirst.Name = "infthirst";
            this.infthirst.Size = new System.Drawing.Size(117, 25);
            this.infthirst.TabIndex = 7;
            this.infthirst.Text = "Freeze Thirst";
            this.infthirst.UseVisualStyleBackColor = true;
            this.infthirst.CheckedChanged += new System.EventHandler(this.infthirst_CheckedChanged);
            // 
            // inffuel
            // 
            this.inffuel.AutoSize = true;
            this.inffuel.Location = new System.Drawing.Point(12, 157);
            this.inffuel.Name = "inffuel";
            this.inffuel.Size = new System.Drawing.Size(156, 25);
            this.inffuel.TabIndex = 8;
            this.inffuel.Text = "Infinite Fire Breath";
            this.inffuel.UseVisualStyleBackColor = true;
            this.inffuel.CheckedChanged += new System.EventHandler(this.inffuel_CheckedChanged);
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // experimentalHealth
            // 
            this.experimentalHealth.AutoSize = true;
            this.experimentalHealth.Location = new System.Drawing.Point(174, 22);
            this.experimentalHealth.Name = "experimentalHealth";
            this.experimentalHealth.Size = new System.Drawing.Size(145, 46);
            this.experimentalHealth.TabIndex = 9;
            this.experimentalHealth.Text = "Infinite Health + \r\nMore speed";
            this.experimentalHealth.UseVisualStyleBackColor = true;
            this.experimentalHealth.CheckedChanged += new System.EventHandler(this.experimentalHealth_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 301);
            this.Controls.Add(this.experimentalHealth);
            this.Controls.Add(this.inffuel);
            this.Controls.Add(this.infthirst);
            this.Controls.Add(this.infhunger);
            this.Controls.Add(this.infstamina);
            this.Controls.Add(this.infhealth);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProcOpenLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "DotE Trainer";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProcOpenLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox infhealth;
        private System.Windows.Forms.CheckBox infstamina;
        private System.Windows.Forms.CheckBox infhunger;
        private System.Windows.Forms.CheckBox infthirst;
        private System.Windows.Forms.CheckBox inffuel;
        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.CheckBox experimentalHealth;
    }
}
