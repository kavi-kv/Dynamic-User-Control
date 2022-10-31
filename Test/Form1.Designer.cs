namespace Test
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.registerPnl = new SaaUI.SaaPanel();
            this.disLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.saaFormControlBox1 = new SaaUI.SaaFormControlBox();
            this.etNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.etPriceTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.disItembtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.registerPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_NEGATIVE;
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.saaFormControlBox1);
            this.guna2Panel1.Controls.Add(this.disItembtn);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(1008, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(220, 700);
            this.guna2Panel1.TabIndex = 0;
            // 
            // registerPnl
            // 
            this.registerPnl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.registerPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.registerPnl.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.registerPnl.BackColorAngle = 90F;
            this.registerPnl.Border = 10;
            this.registerPnl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.registerPnl.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.registerPnl.BorderColorAngle = 90;
            this.registerPnl.ColorType = SaaUI.PanelColorType.Default;
            this.registerPnl.Controls.Add(this.label1);
            this.registerPnl.Controls.Add(this.guna2Button1);
            this.registerPnl.Controls.Add(this.etPriceTxt);
            this.registerPnl.Controls.Add(this.etNameTxt);
            this.registerPnl.EnableDoubleBuffering = true;
            this.registerPnl.ForceDrawRegion = true;
            this.registerPnl.Location = new System.Drawing.Point(634, 118);
            this.registerPnl.Name = "registerPnl";
            this.registerPnl.Radius.BottomLeft = 10;
            this.registerPnl.Radius.BottomRight = 10;
            this.registerPnl.Radius.TopLeft = 10;
            this.registerPnl.Radius.TopRight = 10;
            this.registerPnl.Size = new System.Drawing.Size(412, 464);
            this.registerPnl.TabIndex = 1;
            this.registerPnl.Transparence = 100;
            this.registerPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.registerPnl_Paint);
            // 
            // disLayout
            // 
            this.disLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disLayout.AutoScroll = true;
            this.disLayout.Location = new System.Drawing.Point(0, 0);
            this.disLayout.Name = "disLayout";
            this.disLayout.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.disLayout.Size = new System.Drawing.Size(623, 700);
            this.disLayout.TabIndex = 2;
            // 
            // saaFormControlBox1
            // 
            this.saaFormControlBox1.CloseActive = ((System.Drawing.Image)(resources.GetObject("saaFormControlBox1.CloseActive")));
            this.saaFormControlBox1.CloseInActive = ((System.Drawing.Image)(resources.GetObject("saaFormControlBox1.CloseInActive")));
            this.saaFormControlBox1.CloseTip = "Close";
            this.saaFormControlBox1.DisableClose = false;
            this.saaFormControlBox1.DisableMaximize = false;
            this.saaFormControlBox1.DisableMinimize = false;
            this.saaFormControlBox1.Location = new System.Drawing.Point(119, 2);
            this.saaFormControlBox1.MaximizeActive = ((System.Drawing.Image)(resources.GetObject("saaFormControlBox1.MaximizeActive")));
            this.saaFormControlBox1.MaximizeInActive = ((System.Drawing.Image)(resources.GetObject("saaFormControlBox1.MaximizeInActive")));
            this.saaFormControlBox1.MaximizeTip = "Maximize";
            this.saaFormControlBox1.MinimizeActive = ((System.Drawing.Image)(resources.GetObject("saaFormControlBox1.MinimizeActive")));
            this.saaFormControlBox1.MinimizeInActive = ((System.Drawing.Image)(resources.GetObject("saaFormControlBox1.MinimizeInActive")));
            this.saaFormControlBox1.MinimizeTip = "Minimize";
            this.saaFormControlBox1.Name = "saaFormControlBox1";
            this.saaFormControlBox1.ShowClose = true;
            this.saaFormControlBox1.ShowMaximize = true;
            this.saaFormControlBox1.ShowMinimize = true;
            this.saaFormControlBox1.Size = new System.Drawing.Size(90, 30);
            this.saaFormControlBox1.TabIndex = 0;
            // 
            // etNameTxt
            // 
            this.etNameTxt.BorderRadius = 10;
            this.etNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.etNameTxt.DefaultText = "";
            this.etNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.etNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.etNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.etNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.etNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.etNameTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.etNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.etNameTxt.Location = new System.Drawing.Point(61, 161);
            this.etNameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.etNameTxt.Name = "etNameTxt";
            this.etNameTxt.PasswordChar = '\0';
            this.etNameTxt.PlaceholderText = "Name";
            this.etNameTxt.SelectedText = "";
            this.etNameTxt.Size = new System.Drawing.Size(291, 50);
            this.etNameTxt.TabIndex = 0;
            // 
            // etPriceTxt
            // 
            this.etPriceTxt.BorderRadius = 10;
            this.etPriceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.etPriceTxt.DefaultText = "";
            this.etPriceTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.etPriceTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.etPriceTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.etPriceTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.etPriceTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.etPriceTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.etPriceTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.etPriceTxt.Location = new System.Drawing.Point(61, 247);
            this.etPriceTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.etPriceTxt.Name = "etPriceTxt";
            this.etPriceTxt.PasswordChar = '\0';
            this.etPriceTxt.PlaceholderText = "Price";
            this.etPriceTxt.SelectedText = "";
            this.etPriceTxt.Size = new System.Drawing.Size(291, 50);
            this.etPriceTxt.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(249)))), ((int)(((byte)(253)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(126, 331);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 48);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Save";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(118, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reguster New Item";
            // 
            // disItembtn
            // 
            this.disItembtn.BorderRadius = 10;
            this.disItembtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.disItembtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.disItembtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.disItembtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.disItembtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.disItembtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disItembtn.ForeColor = System.Drawing.Color.White;
            this.disItembtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(117)))), ((int)(((byte)(168)))));
            this.disItembtn.Location = new System.Drawing.Point(20, 325);
            this.disItembtn.Name = "disItembtn";
            this.disItembtn.Size = new System.Drawing.Size(197, 51);
            this.disItembtn.TabIndex = 1;
            this.disItembtn.Text = "DIsplay ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 700);
            this.Controls.Add(this.disLayout);
            this.Controls.Add(this.registerPnl);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.registerPnl.ResumeLayout(false);
            this.registerPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private SaaUI.SaaPanel registerPnl;
        private System.Windows.Forms.FlowLayoutPanel disLayout;
        private SaaUI.SaaFormControlBox saaFormControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox etNameTxt;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox etPriceTxt;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button disItembtn;
    }
}

