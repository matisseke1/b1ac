﻿namespace b1ac
{
    partial class mainform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.chkDeletar = new Bunifu.Framework.UI.BunifuCheckbox();
            this.btnSelf = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMain = new Bunifu.Framework.UI.BunifuFlatButton();
            this.rodarAC = new System.Windows.Forms.Timer(this.components);
            this.btnAC = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1 = new TablessControl();
            this.AC = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trackjitter = new Bunifu.Framework.UI.BunifuTrackbar();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuCheckbox2 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.rangelol = new Bunifu.Framework.UI.BunifuRange();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.AC.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.chkDeletar);
            this.panel1.Controls.Add(this.btnSelf);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMain);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // chkDeletar
            // 
            this.chkDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.chkDeletar.ChechedOffColor = System.Drawing.Color.DimGray;
            this.chkDeletar.Checked = true;
            this.chkDeletar.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.chkDeletar.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.chkDeletar, "chkDeletar");
            this.chkDeletar.Name = "chkDeletar";
            // 
            // btnSelf
            // 
            this.btnSelf.Active = false;
            this.btnSelf.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.btnSelf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            resources.ApplyResources(this.btnSelf, "btnSelf");
            this.btnSelf.BorderRadius = 5;
            this.btnSelf.ButtonText = "SelfDestruct";
            this.btnSelf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelf.DisabledColor = System.Drawing.Color.Gray;
            this.btnSelf.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSelf.Iconimage = global::b1ac.Properties.Resources.round_sentiment_very_dissatisfied_white_18dp;
            this.btnSelf.Iconimage_right = null;
            this.btnSelf.Iconimage_right_Selected = null;
            this.btnSelf.Iconimage_Selected = null;
            this.btnSelf.IconMarginLeft = 0;
            this.btnSelf.IconMarginRight = 0;
            this.btnSelf.IconRightVisible = true;
            this.btnSelf.IconRightZoom = 0D;
            this.btnSelf.IconVisible = true;
            this.btnSelf.IconZoom = 50D;
            this.btnSelf.IsTab = false;
            this.btnSelf.Name = "btnSelf";
            this.btnSelf.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.btnSelf.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(82)))), ((int)(((byte)(181)))));
            this.btnSelf.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSelf.selected = false;
            this.btnSelf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelf.Textcolor = System.Drawing.Color.White;
            this.btnSelf.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelf.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // btnMain
            // 
            this.btnMain.Active = false;
            this.btnMain.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.btnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            resources.ApplyResources(this.btnMain, "btnMain");
            this.btnMain.BorderRadius = 5;
            this.btnMain.ButtonText = "Main";
            this.btnMain.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnMain.DisabledColor = System.Drawing.Color.Gray;
            this.btnMain.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMain.Iconimage = global::b1ac.Properties.Resources.round_home_white_18dp;
            this.btnMain.Iconimage_right = null;
            this.btnMain.Iconimage_right_Selected = null;
            this.btnMain.Iconimage_Selected = null;
            this.btnMain.IconMarginLeft = 0;
            this.btnMain.IconMarginRight = 0;
            this.btnMain.IconRightVisible = true;
            this.btnMain.IconRightZoom = 0D;
            this.btnMain.IconVisible = true;
            this.btnMain.IconZoom = 50D;
            this.btnMain.IsTab = false;
            this.btnMain.Name = "btnMain";
            this.btnMain.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.btnMain.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.btnMain.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMain.selected = false;
            this.btnMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMain.Textcolor = System.Drawing.Color.White;
            this.btnMain.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // rodarAC
            // 
            this.rodarAC.Interval = 50;
            this.rodarAC.Tick += new System.EventHandler(this.rodar_Tick);
            // 
            // btnAC
            // 
            this.btnAC.Active = false;
            this.btnAC.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.btnAC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            resources.ApplyResources(this.btnAC, "btnAC");
            this.btnAC.BorderRadius = 5;
            this.btnAC.ButtonText = "Autoclicker";
            this.btnAC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAC.DisabledColor = System.Drawing.Color.Gray;
            this.btnAC.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAC.Iconimage = global::b1ac.Properties.Resources.round_mouse_white_18dp;
            this.btnAC.Iconimage_right = null;
            this.btnAC.Iconimage_right_Selected = null;
            this.btnAC.Iconimage_Selected = null;
            this.btnAC.IconMarginLeft = 0;
            this.btnAC.IconMarginRight = 0;
            this.btnAC.IconRightVisible = true;
            this.btnAC.IconRightZoom = 0D;
            this.btnAC.IconVisible = true;
            this.btnAC.IconZoom = 50D;
            this.btnAC.IsTab = false;
            this.btnAC.Name = "btnAC";
            this.btnAC.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.btnAC.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(82)))), ((int)(((byte)(181)))));
            this.btnAC.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAC.selected = false;
            this.btnAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAC.Textcolor = System.Drawing.Color.White;
            this.btnAC.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Name = "label9";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AC);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // AC
            // 
            this.AC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(52)))));
            this.AC.Controls.Add(this.label8);
            this.AC.Controls.Add(this.label7);
            this.AC.Controls.Add(this.trackjitter);
            this.AC.Controls.Add(this.label6);
            this.AC.Controls.Add(this.bunifuCheckbox2);
            this.AC.Controls.Add(this.label3);
            this.AC.Controls.Add(this.label5);
            this.AC.Controls.Add(this.lblMax);
            this.AC.Controls.Add(this.lblMin);
            this.AC.Controls.Add(this.rangelol);
            this.AC.Controls.Add(this.bunifuCheckbox1);
            this.AC.Controls.Add(this.label2);
            resources.ApplyResources(this.AC, "AC");
            this.AC.Name = "AC";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Name = "label7";
            // 
            // trackjitter
            // 
            this.trackjitter.BackColor = System.Drawing.Color.Transparent;
            this.trackjitter.BackgroudColor = System.Drawing.Color.DimGray;
            this.trackjitter.BorderRadius = 5;
            this.trackjitter.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            resources.ApplyResources(this.trackjitter, "trackjitter");
            this.trackjitter.MaximumValue = 10;
            this.trackjitter.MinimumValue = 0;
            this.trackjitter.Name = "trackjitter";
            this.trackjitter.SliderRadius = 5;
            this.trackjitter.Value = 0;
            this.trackjitter.ValueChanged += new System.EventHandler(this.trackjitter_ValueChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // bunifuCheckbox2
            // 
            this.bunifuCheckbox2.BackColor = System.Drawing.Color.DimGray;
            this.bunifuCheckbox2.ChechedOffColor = System.Drawing.Color.DimGray;
            this.bunifuCheckbox2.Checked = false;
            this.bunifuCheckbox2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.bunifuCheckbox2.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.bunifuCheckbox2, "bunifuCheckbox2");
            this.bunifuCheckbox2.Name = "bunifuCheckbox2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // lblMax
            // 
            resources.ApplyResources(this.lblMax, "lblMax");
            this.lblMax.ForeColor = System.Drawing.Color.White;
            this.lblMax.Name = "lblMax";
            // 
            // lblMin
            // 
            resources.ApplyResources(this.lblMin, "lblMin");
            this.lblMin.ForeColor = System.Drawing.Color.White;
            this.lblMin.Name = "lblMin";
            // 
            // rangelol
            // 
            this.rangelol.BackColor = System.Drawing.Color.Transparent;
            this.rangelol.BackgroudColor = System.Drawing.Color.DimGray;
            this.rangelol.BorderRadius = 5;
            this.rangelol.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            resources.ApplyResources(this.rangelol, "rangelol");
            this.rangelol.MaximumRange = 21;
            this.rangelol.Name = "rangelol";
            this.rangelol.RangeMax = 10;
            this.rangelol.RangeMin = 0;
            this.rangelol.RangeChanged += new System.EventHandler(this.rangelol_RangeChanged);
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.DimGray;
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(91)))), ((int)(((byte)(199)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.bunifuCheckbox1, "bunifuCheckbox1");
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // mainform
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "mainform";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.mainform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.AC.ResumeLayout(false);
            this.AC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnMain;
        private Bunifu.Framework.UI.BunifuFlatButton btnAC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer rodarAC;
        private Bunifu.Framework.UI.BunifuFlatButton btnSelf;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCheckbox chkDeletar;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuRange rangelol;
        private System.Windows.Forms.Label label5;
        private TablessControl tabControl1;
        private System.Windows.Forms.TabPage AC;
        private Bunifu.Framework.UI.BunifuTrackbar trackjitter;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

