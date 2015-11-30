namespace calc_rent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.areanum = new System.Windows.Forms.NumericUpDown();
            this.hnum = new System.Windows.Forms.NumericUpDown();
            this.floornum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.roomn = new System.Windows.Forms.NumericUpDown();
            this.renc = new System.Windows.Forms.CheckBox();
            this.cleanupc = new System.Windows.Forms.CheckBox();
            this.elevc = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.miscc = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.elec = new System.Windows.Forms.CheckBox();
            this.hotwater = new System.Windows.Forms.CheckBox();
            this.coldwater = new System.Windows.Forms.CheckBox();
            this.gas = new System.Windows.Forms.CheckBox();
            this.heatc = new System.Windows.Forms.CheckBox();
            this.elecmeter = new System.Windows.Forms.CheckBox();
            this.hotwatermeter = new System.Windows.Forms.CheckBox();
            this.coldwatermeter = new System.Windows.Forms.CheckBox();
            this.gasmeter = new System.Windows.Forms.CheckBox();
            this.Accept = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.rennum = new System.Windows.Forms.TextBox();
            this.cleanupnum = new System.Windows.Forms.TextBox();
            this.elevnum = new System.Windows.Forms.TextBox();
            this.heatnum = new System.Windows.Forms.TextBox();
            this.miscnum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.areanum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floornum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Площадь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Жильцы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Этаж";
            // 
            // areanum
            // 
            this.areanum.Location = new System.Drawing.Point(74, 145);
            this.areanum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.areanum.Name = "areanum";
            this.areanum.Size = new System.Drawing.Size(61, 20);
            this.areanum.TabIndex = 1;
            // 
            // hnum
            // 
            this.hnum.Location = new System.Drawing.Point(74, 171);
            this.hnum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.hnum.Name = "hnum";
            this.hnum.Size = new System.Drawing.Size(61, 20);
            this.hnum.TabIndex = 1;
            // 
            // floornum
            // 
            this.floornum.Location = new System.Drawing.Point(74, 197);
            this.floornum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.floornum.Name = "floornum";
            this.floornum.Size = new System.Drawing.Size(61, 20);
            this.floornum.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Номер";
            // 
            // roomn
            // 
            this.roomn.Location = new System.Drawing.Point(74, 85);
            this.roomn.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.roomn.Name = "roomn";
            this.roomn.Size = new System.Drawing.Size(61, 20);
            this.roomn.TabIndex = 1;
            // 
            // renc
            // 
            this.renc.AutoSize = true;
            this.renc.Location = new System.Drawing.Point(227, 122);
            this.renc.Name = "renc";
            this.renc.Size = new System.Drawing.Size(134, 17);
            this.renc.TabIndex = 2;
            this.renc.Text = "Капитальный ремонт";
            this.renc.UseVisualStyleBackColor = true;
            this.renc.CheckedChanged += new System.EventHandler(this.renc_CheckedChanged);
            // 
            // cleanupc
            // 
            this.cleanupc.AutoSize = true;
            this.cleanupc.Location = new System.Drawing.Point(227, 145);
            this.cleanupc.Name = "cleanupc";
            this.cleanupc.Size = new System.Drawing.Size(115, 17);
            this.cleanupc.TabIndex = 2;
            this.cleanupc.Text = "Уборка подьезда";
            this.cleanupc.UseVisualStyleBackColor = true;
            this.cleanupc.CheckedChanged += new System.EventHandler(this.cleanupc_CheckedChanged);
            // 
            // elevc
            // 
            this.elevc.AutoSize = true;
            this.elevc.Location = new System.Drawing.Point(227, 171);
            this.elevc.Name = "elevc";
            this.elevc.Size = new System.Drawing.Size(53, 17);
            this.elevc.TabIndex = 2;
            this.elevc.Text = "Лифт";
            this.elevc.UseVisualStyleBackColor = true;
            this.elevc.CheckedChanged += new System.EventHandler(this.elevc_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Фиксированная ежемесячная оплата";
            // 
            // miscc
            // 
            this.miscc.AutoSize = true;
            this.miscc.Location = new System.Drawing.Point(227, 224);
            this.miscc.Name = "miscc";
            this.miscc.Size = new System.Drawing.Size(63, 17);
            this.miscc.TabIndex = 2;
            this.miscc.Text = "Прочее";
            this.miscc.UseVisualStyleBackColor = true;
            this.miscc.CheckedChanged += new System.EventHandler(this.miscc_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Услуги и наличие счётчика";
            // 
            // elec
            // 
            this.elec.AutoSize = true;
            this.elec.Location = new System.Drawing.Point(366, 122);
            this.elec.Name = "elec";
            this.elec.Size = new System.Drawing.Size(102, 17);
            this.elec.TabIndex = 2;
            this.elec.Text = "Электричество";
            this.elec.UseVisualStyleBackColor = true;
            // 
            // hotwater
            // 
            this.hotwater.AutoSize = true;
            this.hotwater.Location = new System.Drawing.Point(366, 145);
            this.hotwater.Name = "hotwater";
            this.hotwater.Size = new System.Drawing.Size(94, 17);
            this.hotwater.TabIndex = 2;
            this.hotwater.Text = "Горячая вода";
            this.hotwater.UseVisualStyleBackColor = true;
            // 
            // coldwater
            // 
            this.coldwater.AutoSize = true;
            this.coldwater.Location = new System.Drawing.Point(366, 171);
            this.coldwater.Name = "coldwater";
            this.coldwater.Size = new System.Drawing.Size(102, 17);
            this.coldwater.TabIndex = 2;
            this.coldwater.Text = "Холодная вода";
            this.coldwater.UseVisualStyleBackColor = true;
            // 
            // gas
            // 
            this.gas.AutoSize = true;
            this.gas.Location = new System.Drawing.Point(366, 197);
            this.gas.Name = "gas";
            this.gas.Size = new System.Drawing.Size(44, 17);
            this.gas.TabIndex = 2;
            this.gas.Text = "Газ";
            this.gas.UseVisualStyleBackColor = true;
            // 
            // heatc
            // 
            this.heatc.AutoSize = true;
            this.heatc.Location = new System.Drawing.Point(227, 200);
            this.heatc.Name = "heatc";
            this.heatc.Size = new System.Drawing.Size(81, 17);
            this.heatc.TabIndex = 2;
            this.heatc.Text = "Отопление";
            this.heatc.UseVisualStyleBackColor = true;
            this.heatc.CheckedChanged += new System.EventHandler(this.heatc_CheckedChanged);
            // 
            // elecmeter
            // 
            this.elecmeter.AutoSize = true;
            this.elecmeter.Location = new System.Drawing.Point(475, 122);
            this.elecmeter.Name = "elecmeter";
            this.elecmeter.Size = new System.Drawing.Size(15, 14);
            this.elecmeter.TabIndex = 3;
            this.elecmeter.UseVisualStyleBackColor = true;
            // 
            // hotwatermeter
            // 
            this.hotwatermeter.AutoSize = true;
            this.hotwatermeter.Location = new System.Drawing.Point(475, 148);
            this.hotwatermeter.Name = "hotwatermeter";
            this.hotwatermeter.Size = new System.Drawing.Size(15, 14);
            this.hotwatermeter.TabIndex = 3;
            this.hotwatermeter.UseVisualStyleBackColor = true;
            // 
            // coldwatermeter
            // 
            this.coldwatermeter.AutoSize = true;
            this.coldwatermeter.Location = new System.Drawing.Point(475, 173);
            this.coldwatermeter.Name = "coldwatermeter";
            this.coldwatermeter.Size = new System.Drawing.Size(15, 14);
            this.coldwatermeter.TabIndex = 3;
            this.coldwatermeter.UseVisualStyleBackColor = true;
            // 
            // gasmeter
            // 
            this.gasmeter.AutoSize = true;
            this.gasmeter.Location = new System.Drawing.Point(475, 200);
            this.gasmeter.Name = "gasmeter";
            this.gasmeter.Size = new System.Drawing.Size(15, 14);
            this.gasmeter.TabIndex = 3;
            this.gasmeter.UseVisualStyleBackColor = true;
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(12, 316);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 4;
            this.Accept.Text = "Принять";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(111, 316);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Отменить";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // rennum
            // 
            this.rennum.Enabled = false;
            this.rennum.Location = new System.Drawing.Point(160, 116);
            this.rennum.Name = "rennum";
            this.rennum.Size = new System.Drawing.Size(61, 20);
            this.rennum.TabIndex = 5;
            this.rennum.Text = "0";
            // 
            // cleanupnum
            // 
            this.cleanupnum.Enabled = false;
            this.cleanupnum.Location = new System.Drawing.Point(160, 142);
            this.cleanupnum.Name = "cleanupnum";
            this.cleanupnum.Size = new System.Drawing.Size(61, 20);
            this.cleanupnum.TabIndex = 5;
            this.cleanupnum.Text = "0";
            // 
            // elevnum
            // 
            this.elevnum.Enabled = false;
            this.elevnum.Location = new System.Drawing.Point(160, 167);
            this.elevnum.Name = "elevnum";
            this.elevnum.Size = new System.Drawing.Size(61, 20);
            this.elevnum.TabIndex = 5;
            this.elevnum.Text = "0";
            // 
            // heatnum
            // 
            this.heatnum.Enabled = false;
            this.heatnum.Location = new System.Drawing.Point(160, 193);
            this.heatnum.Name = "heatnum";
            this.heatnum.Size = new System.Drawing.Size(61, 20);
            this.heatnum.TabIndex = 5;
            this.heatnum.Text = "0";
            // 
            // miscnum
            // 
            this.miscnum.Enabled = false;
            this.miscnum.Location = new System.Drawing.Point(160, 219);
            this.miscnum.Name = "miscnum";
            this.miscnum.Size = new System.Drawing.Size(61, 20);
            this.miscnum.TabIndex = 5;
            this.miscnum.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 351);
            this.ControlBox = false;
            this.Controls.Add(this.cleanupnum);
            this.Controls.Add(this.elevnum);
            this.Controls.Add(this.heatnum);
            this.Controls.Add(this.miscnum);
            this.Controls.Add(this.rennum);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.gasmeter);
            this.Controls.Add(this.coldwatermeter);
            this.Controls.Add(this.hotwatermeter);
            this.Controls.Add(this.elecmeter);
            this.Controls.Add(this.gas);
            this.Controls.Add(this.miscc);
            this.Controls.Add(this.coldwater);
            this.Controls.Add(this.heatc);
            this.Controls.Add(this.elevc);
            this.Controls.Add(this.hotwater);
            this.Controls.Add(this.cleanupc);
            this.Controls.Add(this.elec);
            this.Controls.Add(this.renc);
            this.Controls.Add(this.floornum);
            this.Controls.Add(this.hnum);
            this.Controls.Add(this.roomn);
            this.Controls.Add(this.areanum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.Text = "Новая квартира";
            ((System.ComponentModel.ISupportInitialize)(this.areanum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floornum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown areanum;
        private System.Windows.Forms.NumericUpDown hnum;
        private System.Windows.Forms.NumericUpDown floornum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown roomn;
        private System.Windows.Forms.CheckBox renc;
        private System.Windows.Forms.CheckBox cleanupc;
        private System.Windows.Forms.CheckBox elevc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox miscc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox elec;
        private System.Windows.Forms.CheckBox hotwater;
        private System.Windows.Forms.CheckBox coldwater;
        private System.Windows.Forms.CheckBox gas;
        private System.Windows.Forms.CheckBox heatc;
        private System.Windows.Forms.CheckBox elecmeter;
        private System.Windows.Forms.CheckBox hotwatermeter;
        private System.Windows.Forms.CheckBox coldwatermeter;
        private System.Windows.Forms.CheckBox gasmeter;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox rennum;
        private System.Windows.Forms.TextBox cleanupnum;
        private System.Windows.Forms.TextBox elevnum;
        private System.Windows.Forms.TextBox heatnum;
        private System.Windows.Forms.TextBox miscnum;
    }
}