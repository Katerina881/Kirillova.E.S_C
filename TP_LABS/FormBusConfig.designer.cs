namespace TP_LABS
{
    partial class FormBusConfig
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
            this.groupBoxBuses = new System.Windows.Forms.GroupBox();
            this.labelBus = new System.Windows.Forms.Label();
            this.labelCommonBus = new System.Windows.Forms.Label();
            this.panelBus = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelOsnColor = new System.Windows.Forms.Label();
            this.pictureBoxBus = new System.Windows.Forms.PictureBox();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelColorVosim = new System.Windows.Forms.Panel();
            this.panelColorSedimoy = new System.Windows.Forms.Panel();
            this.panelColorShestoi = new System.Windows.Forms.Panel();
            this.panelColorPyatii = new System.Windows.Forms.Panel();
            this.panelColorChetvertii = new System.Windows.Forms.Panel();
            this.panelColorTretii = new System.Windows.Forms.Panel();
            this.panelColorVtoroi = new System.Windows.Forms.Panel();
            this.panelColorPervii = new System.Windows.Forms.Panel();
            this.buttonDob = new System.Windows.Forms.Button();
            this.buttonOtm = new System.Windows.Forms.Button();
            this.groupBoxBuses.SuspendLayout();
            this.panelBus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBus)).BeginInit();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBuses
            // 
            this.groupBoxBuses.Controls.Add(this.labelBus);
            this.groupBoxBuses.Controls.Add(this.labelCommonBus);
            this.groupBoxBuses.Location = new System.Drawing.Point(12, 45);
            this.groupBoxBuses.Name = "groupBoxBuses";
            this.groupBoxBuses.Size = new System.Drawing.Size(201, 143);
            this.groupBoxBuses.TabIndex = 1;
            this.groupBoxBuses.TabStop = false;
            this.groupBoxBuses.Text = "Тип автобуса";
            // 
            // labelBus
            // 
            this.labelBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBus.Location = new System.Drawing.Point(6, 87);
            this.labelBus.Name = "labelBus";
            this.labelBus.Size = new System.Drawing.Size(173, 40);
            this.labelBus.TabIndex = 2;
            this.labelBus.Text = "Двухэтажный автобус";
            this.labelBus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBus_MouseDown);
            // 
            // labelCommonBus
            // 
            this.labelCommonBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCommonBus.Location = new System.Drawing.Point(6, 31);
            this.labelCommonBus.Name = "labelCommonBus";
            this.labelCommonBus.Size = new System.Drawing.Size(173, 40);
            this.labelCommonBus.TabIndex = 0;
            this.labelCommonBus.Text = "Обычный автобус";
            this.labelCommonBus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCommonBus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCommonBus_MouseDown);
            // 
            // panelBus
            // 
            this.panelBus.AllowDrop = true;
            this.panelBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBus.Controls.Add(this.labelDopColor);
            this.panelBus.Controls.Add(this.labelOsnColor);
            this.panelBus.Controls.Add(this.pictureBoxBus);
            this.panelBus.Location = new System.Drawing.Point(245, 45);
            this.panelBus.Name = "panelBus";
            this.panelBus.Size = new System.Drawing.Size(241, 353);
            this.panelBus.TabIndex = 2;
            this.panelBus.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelBus_DragDrop);
            this.panelBus.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelBus_DragEnter);
            this.panelBus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBus_MouseDown);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(33, 269);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(173, 40);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Дополнительный цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelOsnColor_DragEnter);
            // 
            // labelOsnColor
            // 
            this.labelOsnColor.AllowDrop = true;
            this.labelOsnColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOsnColor.Location = new System.Drawing.Point(33, 197);
            this.labelOsnColor.Name = "labelOsnColor";
            this.labelOsnColor.Size = new System.Drawing.Size(173, 40);
            this.labelOsnColor.TabIndex = 1;
            this.labelOsnColor.Text = "Основной цвет";
            this.labelOsnColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOsnColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelOsnColor_DragDrop);
            this.labelOsnColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelOsnColor_DragEnter);
            // 
            // pictureBoxBus
            // 
            this.pictureBoxBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBus.Location = new System.Drawing.Point(19, 8);
            this.pictureBoxBus.Name = "pictureBoxBus";
            this.pictureBoxBus.Size = new System.Drawing.Size(201, 135);
            this.pictureBoxBus.TabIndex = 0;
            this.pictureBoxBus.TabStop = false;
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelColorVosim);
            this.groupBoxColors.Controls.Add(this.panelColorSedimoy);
            this.groupBoxColors.Controls.Add(this.panelColorShestoi);
            this.groupBoxColors.Controls.Add(this.panelColorPyatii);
            this.groupBoxColors.Controls.Add(this.panelColorChetvertii);
            this.groupBoxColors.Controls.Add(this.panelColorTretii);
            this.groupBoxColors.Controls.Add(this.panelColorVtoroi);
            this.groupBoxColors.Controls.Add(this.panelColorPervii);
            this.groupBoxColors.Location = new System.Drawing.Point(545, 45);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(177, 353);
            this.groupBoxColors.TabIndex = 3;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelColorVosim
            // 
            this.panelColorVosim.BackColor = System.Drawing.Color.White;
            this.panelColorVosim.Location = new System.Drawing.Point(103, 269);
            this.panelColorVosim.Name = "panelColorVosim";
            this.panelColorVosim.Size = new System.Drawing.Size(53, 52);
            this.panelColorVosim.TabIndex = 5;
            // 
            // panelColorSedimoy
            // 
            this.panelColorSedimoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelColorSedimoy.Location = new System.Drawing.Point(103, 185);
            this.panelColorSedimoy.Name = "panelColorSedimoy";
            this.panelColorSedimoy.Size = new System.Drawing.Size(53, 52);
            this.panelColorSedimoy.TabIndex = 4;
            // 
            // panelColorShestoi
            // 
            this.panelColorShestoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelColorShestoi.Location = new System.Drawing.Point(103, 111);
            this.panelColorShestoi.Name = "panelColorShestoi";
            this.panelColorShestoi.Size = new System.Drawing.Size(53, 52);
            this.panelColorShestoi.TabIndex = 1;
            // 
            // panelColorPyatii
            // 
            this.panelColorPyatii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelColorPyatii.Location = new System.Drawing.Point(103, 31);
            this.panelColorPyatii.Name = "panelColorPyatii";
            this.panelColorPyatii.Size = new System.Drawing.Size(53, 52);
            this.panelColorPyatii.TabIndex = 3;
            // 
            // panelColorChetvertii
            // 
            this.panelColorChetvertii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelColorChetvertii.Location = new System.Drawing.Point(17, 269);
            this.panelColorChetvertii.Name = "panelColorChetvertii";
            this.panelColorChetvertii.Size = new System.Drawing.Size(53, 52);
            this.panelColorChetvertii.TabIndex = 1;
            // 
            // panelColorTretii
            // 
            this.panelColorTretii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelColorTretii.Location = new System.Drawing.Point(17, 185);
            this.panelColorTretii.Name = "panelColorTretii";
            this.panelColorTretii.Size = new System.Drawing.Size(53, 52);
            this.panelColorTretii.TabIndex = 2;
            // 
            // panelColorVtoroi
            // 
            this.panelColorVtoroi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelColorVtoroi.Location = new System.Drawing.Point(17, 111);
            this.panelColorVtoroi.Name = "panelColorVtoroi";
            this.panelColorVtoroi.Size = new System.Drawing.Size(53, 52);
            this.panelColorVtoroi.TabIndex = 1;
            // 
            // panelColorPervii
            // 
            this.panelColorPervii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelColorPervii.Location = new System.Drawing.Point(17, 31);
            this.panelColorPervii.Name = "panelColorPervii";
            this.panelColorPervii.Size = new System.Drawing.Size(53, 52);
            this.panelColorPervii.TabIndex = 0;
            // 
            // buttonDob
            // 
            this.buttonDob.Location = new System.Drawing.Point(49, 243);
            this.buttonDob.Name = "buttonDob";
            this.buttonDob.Size = new System.Drawing.Size(123, 32);
            this.buttonDob.TabIndex = 4;
            this.buttonDob.Text = "Добавить";
            this.buttonDob.UseVisualStyleBackColor = true;
            this.buttonDob.Click += new System.EventHandler(this.buttonDob_Click);
            // 
            // buttonOtm
            // 
            this.buttonOtm.Location = new System.Drawing.Point(49, 314);
            this.buttonOtm.Name = "buttonOtm";
            this.buttonOtm.Size = new System.Drawing.Size(123, 32);
            this.buttonOtm.TabIndex = 5;
            this.buttonOtm.Text = "Отменить";
            this.buttonOtm.UseVisualStyleBackColor = true;
            // 
            // FormBusConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOtm);
            this.Controls.Add(this.buttonDob);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelBus);
            this.Controls.Add(this.groupBoxBuses);
            this.Name = "FormBusConfig";
            this.Text = "FormBusConfig";
            this.groupBoxBuses.ResumeLayout(false);
            this.panelBus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBus)).EndInit();
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxBuses;
        private System.Windows.Forms.Label labelBus;
        private System.Windows.Forms.Label labelCommonBus;
        private System.Windows.Forms.Panel panelBus;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelOsnColor;
        private System.Windows.Forms.PictureBox pictureBoxBus;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Panel panelColorVosim;
        private System.Windows.Forms.Panel panelColorSedimoy;
        private System.Windows.Forms.Panel panelColorShestoi;
        private System.Windows.Forms.Panel panelColorPyatii;
        private System.Windows.Forms.Panel panelColorChetvertii;
        private System.Windows.Forms.Panel panelColorTretii;
        private System.Windows.Forms.Panel panelColorVtoroi;
        private System.Windows.Forms.Panel panelColorPervii;
        private System.Windows.Forms.Button buttonDob;
        private System.Windows.Forms.Button buttonOtm;
    }
}