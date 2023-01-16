namespace PasswordGenerator
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
            this.PanelTopColor = new System.Windows.Forms.Panel();
            this.PanelNavbar = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.NavbarSideline1 = new System.Windows.Forms.Panel();
            this.NavbarSideline2 = new System.Windows.Forms.Panel();
            this.BtnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnMinimize = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.BtnIssues = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuHSlider1 = new Bunifu.UI.WinForms.BunifuHSlider();
            this.bunifuCheckBox1 = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuCheckBox2 = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuCheckBox3 = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuCheckBox4 = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.PanelNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTopColor
            // 
            this.PanelTopColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.PanelTopColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopColor.Location = new System.Drawing.Point(0, 0);
            this.PanelTopColor.Name = "PanelTopColor";
            this.PanelTopColor.Size = new System.Drawing.Size(360, 3);
            this.PanelTopColor.TabIndex = 4;
            // 
            // PanelNavbar
            // 
            this.PanelNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PanelNavbar.Controls.Add(this.label7);
            this.PanelNavbar.Controls.Add(this.NavbarSideline1);
            this.PanelNavbar.Controls.Add(this.NavbarSideline2);
            this.PanelNavbar.Controls.Add(this.BtnMenu);
            this.PanelNavbar.Controls.Add(this.BtnMinimize);
            this.PanelNavbar.Controls.Add(this.BtnClose);
            this.PanelNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelNavbar.Location = new System.Drawing.Point(0, 3);
            this.PanelNavbar.Name = "PanelNavbar";
            this.PanelNavbar.Size = new System.Drawing.Size(360, 35);
            this.PanelNavbar.TabIndex = 8;
            this.PanelNavbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelNavbar_MouseDown);
            this.PanelNavbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelNavbar_MouseMove);
            this.PanelNavbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelNavbar_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(116, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 19);
            this.label7.TabIndex = 158;
            this.label7.Text = "Random Password";
            // 
            // NavbarSideline1
            // 
            this.NavbarSideline1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.NavbarSideline1.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavbarSideline1.Location = new System.Drawing.Point(0, 0);
            this.NavbarSideline1.Name = "NavbarSideline1";
            this.NavbarSideline1.Size = new System.Drawing.Size(1, 35);
            this.NavbarSideline1.TabIndex = 10;
            // 
            // NavbarSideline2
            // 
            this.NavbarSideline2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.NavbarSideline2.Dock = System.Windows.Forms.DockStyle.Right;
            this.NavbarSideline2.Location = new System.Drawing.Point(358, 0);
            this.NavbarSideline2.Name = "NavbarSideline2";
            this.NavbarSideline2.Size = new System.Drawing.Size(2, 35);
            this.NavbarSideline2.TabIndex = 9;
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.ImageActive = null;
            this.BtnMenu.Location = new System.Drawing.Point(4, 3);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(44, 29);
            this.BtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMenu.TabIndex = 8;
            this.BtnMenu.TabStop = false;
            this.BtnMenu.Zoom = 0;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.ActiveBorderThickness = 1;
            this.BtnMinimize.ActiveCornerRadius = 11;
            this.BtnMinimize.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(57)))));
            this.BtnMinimize.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(57)))));
            this.BtnMinimize.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(100)))), ((int)(((byte)(38)))));
            this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMinimize.BackgroundImage")));
            this.BtnMinimize.ButtonText = "";
            this.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimize.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnMinimize.IdleBorderThickness = 1;
            this.BtnMinimize.IdleCornerRadius = 11;
            this.BtnMinimize.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.BtnMinimize.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BtnMinimize.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnMinimize.Location = new System.Drawing.Point(317, 6);
            this.BtnMinimize.Margin = new System.Windows.Forms.Padding(5);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(13, 23);
            this.BtnMinimize.TabIndex = 6;
            this.BtnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.ActiveBorderThickness = 1;
            this.BtnClose.ActiveCornerRadius = 11;
            this.BtnClose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(47)))), ((int)(((byte)(74)))));
            this.BtnClose.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(47)))), ((int)(((byte)(74)))));
            this.BtnClose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(31)))), ((int)(((byte)(49)))));
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.ButtonText = "";
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnClose.IdleBorderThickness = 1;
            this.BtnClose.IdleCornerRadius = 11;
            this.BtnClose.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.BtnClose.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BtnClose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnClose.Location = new System.Drawing.Point(336, 6);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(5);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(13, 23);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PanelNavbar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // BtnIssues
            // 
            this.BtnIssues.ActiveBorderThickness = 2;
            this.BtnIssues.ActiveCornerRadius = 10;
            this.BtnIssues.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnIssues.ActiveForecolor = System.Drawing.Color.White;
            this.BtnIssues.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.BtnIssues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.BtnIssues.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnIssues.BackgroundImage")));
            this.BtnIssues.ButtonText = "Generate Password";
            this.BtnIssues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIssues.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIssues.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnIssues.IdleBorderThickness = 2;
            this.BtnIssues.IdleCornerRadius = 10;
            this.BtnIssues.IdleFillColor = System.Drawing.Color.Transparent;
            this.BtnIssues.IdleForecolor = System.Drawing.Color.White;
            this.BtnIssues.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.BtnIssues.Location = new System.Drawing.Point(16, 161);
            this.BtnIssues.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnIssues.Name = "BtnIssues";
            this.BtnIssues.Size = new System.Drawing.Size(317, 44);
            this.BtnIssues.TabIndex = 146;
            this.BtnIssues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnIssues.Click += new System.EventHandler(this.BtnIssues_Click);
            // 
            // bunifuSnackbar1
            // 
            this.bunifuSnackbar1.AllowDragging = false;
            this.bunifuSnackbar1.AllowMultipleViews = true;
            this.bunifuSnackbar1.ClickToClose = true;
            this.bunifuSnackbar1.DoubleClickToClose = true;
            this.bunifuSnackbar1.DurationAfterIdle = 3000;
            this.bunifuSnackbar1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bunifuSnackbar1.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.bunifuSnackbar1.ErrorOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.FadeCloseIcon = false;
            this.bunifuSnackbar1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bunifuSnackbar1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.bunifuSnackbar1.InformationOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.Margin = 10;
            this.bunifuSnackbar1.MaximumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.MaximumViews = 7;
            this.bunifuSnackbar1.MessageRightMargin = 15;
            this.bunifuSnackbar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.ShowBorders = true;
            this.bunifuSnackbar1.ShowCloseIcon = true;
            this.bunifuSnackbar1.ShowIcon = true;
            this.bunifuSnackbar1.ShowShadows = false;
            this.bunifuSnackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.LimeGreen;
            this.bunifuSnackbar1.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.bunifuSnackbar1.SuccessOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ViewsMargin = 7;
            this.bunifuSnackbar1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bunifuSnackbar1.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.bunifuSnackbar1.WarningOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ZoomCloseIcon = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 147;
            this.label1.Text = "Password Length:";
            // 
            // bunifuHSlider1
            // 
            this.bunifuHSlider1.AllowCursorChanges = true;
            this.bunifuHSlider1.AllowHomeEndKeysDetection = false;
            this.bunifuHSlider1.AllowIncrementalClickMoves = true;
            this.bunifuHSlider1.AllowMouseDownEffects = false;
            this.bunifuHSlider1.AllowMouseHoverEffects = false;
            this.bunifuHSlider1.AllowScrollingAnimations = true;
            this.bunifuHSlider1.AllowScrollKeysDetection = true;
            this.bunifuHSlider1.AllowScrollOptionsMenu = true;
            this.bunifuHSlider1.AllowShrinkingOnFocusLost = false;
            this.bunifuHSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuHSlider1.BackgroundImage")));
            this.bunifuHSlider1.BindingContainer = null;
            this.bunifuHSlider1.BorderRadius = 2;
            this.bunifuHSlider1.BorderThickness = 1;
            this.bunifuHSlider1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuHSlider1.DrawThickBorder = false;
            this.bunifuHSlider1.DurationBeforeShrink = 2000;
            this.bunifuHSlider1.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.bunifuHSlider1.LargeChange = 10;
            this.bunifuHSlider1.Location = new System.Drawing.Point(136, 58);
            this.bunifuHSlider1.Maximum = 128;
            this.bunifuHSlider1.Minimum = 8;
            this.bunifuHSlider1.MinimumSize = new System.Drawing.Size(0, 31);
            this.bunifuHSlider1.MinimumThumbLength = 18;
            this.bunifuHSlider1.Name = "bunifuHSlider1";
            this.bunifuHSlider1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuHSlider1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuHSlider1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuHSlider1.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider1.ShrinkSizeLimit = 3;
            this.bunifuHSlider1.Size = new System.Drawing.Size(170, 31);
            this.bunifuHSlider1.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuHSlider1.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.bunifuHSlider1.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.bunifuHSlider1.SmallChange = 1;
            this.bunifuHSlider1.TabIndex = 148;
            this.bunifuHSlider1.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.bunifuHSlider1.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.bunifuHSlider1.ThumbLength = 18;
            this.bunifuHSlider1.ThumbMargin = 1;
            this.bunifuHSlider1.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.bunifuHSlider1.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuHSlider1.Value = 8;
            // 
            // bunifuCheckBox1
            // 
            this.bunifuCheckBox1.AllowBindingControlAnimation = true;
            this.bunifuCheckBox1.AllowBindingControlColorChanges = false;
            this.bunifuCheckBox1.AllowBindingControlLocation = true;
            this.bunifuCheckBox1.AllowCheckBoxAnimation = false;
            this.bunifuCheckBox1.AllowCheckmarkAnimation = true;
            this.bunifuCheckBox1.AllowOnHoverStates = true;
            this.bunifuCheckBox1.AutoCheck = true;
            this.bunifuCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCheckBox1.BackgroundImage")));
            this.bunifuCheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuCheckBox1.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.bunifuCheckBox1.BorderRadius = 12;
            this.bunifuCheckBox1.Checked = true;
            this.bunifuCheckBox1.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.bunifuCheckBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCheckBox1.CustomCheckmarkImage = null;
            this.bunifuCheckBox1.Location = new System.Drawing.Point(67, 102);
            this.bunifuCheckBox1.MinimumSize = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox1.Name = "bunifuCheckBox1";
            this.bunifuCheckBox1.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox1.OnCheck.BorderRadius = 12;
            this.bunifuCheckBox1.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox1.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox1.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.BorderRadius = 12;
            this.bunifuCheckBox1.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox1.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox1.OnHoverChecked.BorderRadius = 12;
            this.bunifuCheckBox1.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox1.OnHoverUnchecked.BorderRadius = 12;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderThickness = 1;
            this.bunifuCheckBox1.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.bunifuCheckBox1.OnUncheck.BorderRadius = 12;
            this.bunifuCheckBox1.OnUncheck.BorderThickness = 1;
            this.bunifuCheckBox1.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.Size = new System.Drawing.Size(21, 21);
            this.bunifuCheckBox1.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.bunifuCheckBox1.TabIndex = 150;
            this.bunifuCheckBox1.ThreeState = false;
            this.bunifuCheckBox1.ToolTipText = "Allow Lowercase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(94, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 151;
            this.label3.Text = "Lowercase";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(94, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 153;
            this.label4.Text = "Uppercase";
            // 
            // bunifuCheckBox2
            // 
            this.bunifuCheckBox2.AllowBindingControlAnimation = true;
            this.bunifuCheckBox2.AllowBindingControlColorChanges = false;
            this.bunifuCheckBox2.AllowBindingControlLocation = true;
            this.bunifuCheckBox2.AllowCheckBoxAnimation = false;
            this.bunifuCheckBox2.AllowCheckmarkAnimation = true;
            this.bunifuCheckBox2.AllowOnHoverStates = true;
            this.bunifuCheckBox2.AutoCheck = true;
            this.bunifuCheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCheckBox2.BackgroundImage")));
            this.bunifuCheckBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuCheckBox2.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.bunifuCheckBox2.BorderRadius = 12;
            this.bunifuCheckBox2.Checked = true;
            this.bunifuCheckBox2.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.bunifuCheckBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCheckBox2.CustomCheckmarkImage = null;
            this.bunifuCheckBox2.Location = new System.Drawing.Point(67, 129);
            this.bunifuCheckBox2.MinimumSize = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox2.Name = "bunifuCheckBox2";
            this.bunifuCheckBox2.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox2.OnCheck.BorderRadius = 12;
            this.bunifuCheckBox2.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox2.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox2.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox2.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox2.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox2.OnDisable.BorderRadius = 12;
            this.bunifuCheckBox2.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox2.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox2.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox2.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox2.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox2.OnHoverChecked.BorderRadius = 12;
            this.bunifuCheckBox2.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox2.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox2.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox2.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox2.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox2.OnHoverUnchecked.BorderRadius = 12;
            this.bunifuCheckBox2.OnHoverUnchecked.BorderThickness = 1;
            this.bunifuCheckBox2.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox2.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.bunifuCheckBox2.OnUncheck.BorderRadius = 12;
            this.bunifuCheckBox2.OnUncheck.BorderThickness = 1;
            this.bunifuCheckBox2.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox2.Size = new System.Drawing.Size(21, 21);
            this.bunifuCheckBox2.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.bunifuCheckBox2.TabIndex = 152;
            this.bunifuCheckBox2.ThreeState = false;
            this.bunifuCheckBox2.ToolTipText = "Allow Uppercase";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(234, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 155;
            this.label5.Text = "Numeric";
            // 
            // bunifuCheckBox3
            // 
            this.bunifuCheckBox3.AllowBindingControlAnimation = true;
            this.bunifuCheckBox3.AllowBindingControlColorChanges = false;
            this.bunifuCheckBox3.AllowBindingControlLocation = true;
            this.bunifuCheckBox3.AllowCheckBoxAnimation = false;
            this.bunifuCheckBox3.AllowCheckmarkAnimation = true;
            this.bunifuCheckBox3.AllowOnHoverStates = true;
            this.bunifuCheckBox3.AutoCheck = true;
            this.bunifuCheckBox3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCheckBox3.BackgroundImage")));
            this.bunifuCheckBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuCheckBox3.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.bunifuCheckBox3.BorderRadius = 12;
            this.bunifuCheckBox3.Checked = true;
            this.bunifuCheckBox3.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.bunifuCheckBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCheckBox3.CustomCheckmarkImage = null;
            this.bunifuCheckBox3.Location = new System.Drawing.Point(207, 102);
            this.bunifuCheckBox3.MinimumSize = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox3.Name = "bunifuCheckBox3";
            this.bunifuCheckBox3.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox3.OnCheck.BorderRadius = 12;
            this.bunifuCheckBox3.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox3.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox3.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox3.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox3.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox3.OnDisable.BorderRadius = 12;
            this.bunifuCheckBox3.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox3.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox3.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox3.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox3.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox3.OnHoverChecked.BorderRadius = 12;
            this.bunifuCheckBox3.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox3.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox3.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox3.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox3.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox3.OnHoverUnchecked.BorderRadius = 12;
            this.bunifuCheckBox3.OnHoverUnchecked.BorderThickness = 1;
            this.bunifuCheckBox3.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox3.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.bunifuCheckBox3.OnUncheck.BorderRadius = 12;
            this.bunifuCheckBox3.OnUncheck.BorderThickness = 1;
            this.bunifuCheckBox3.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox3.Size = new System.Drawing.Size(21, 21);
            this.bunifuCheckBox3.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.bunifuCheckBox3.TabIndex = 154;
            this.bunifuCheckBox3.ThreeState = false;
            this.bunifuCheckBox3.ToolTipText = "Allow Numeric";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(234, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 157;
            this.label6.Text = "Special";
            // 
            // bunifuCheckBox4
            // 
            this.bunifuCheckBox4.AllowBindingControlAnimation = true;
            this.bunifuCheckBox4.AllowBindingControlColorChanges = false;
            this.bunifuCheckBox4.AllowBindingControlLocation = true;
            this.bunifuCheckBox4.AllowCheckBoxAnimation = false;
            this.bunifuCheckBox4.AllowCheckmarkAnimation = true;
            this.bunifuCheckBox4.AllowOnHoverStates = true;
            this.bunifuCheckBox4.AutoCheck = true;
            this.bunifuCheckBox4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCheckBox4.BackgroundImage")));
            this.bunifuCheckBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuCheckBox4.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.bunifuCheckBox4.BorderRadius = 12;
            this.bunifuCheckBox4.Checked = true;
            this.bunifuCheckBox4.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.bunifuCheckBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCheckBox4.CustomCheckmarkImage = null;
            this.bunifuCheckBox4.Location = new System.Drawing.Point(207, 129);
            this.bunifuCheckBox4.MinimumSize = new System.Drawing.Size(17, 17);
            this.bunifuCheckBox4.Name = "bunifuCheckBox4";
            this.bunifuCheckBox4.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox4.OnCheck.BorderRadius = 12;
            this.bunifuCheckBox4.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox4.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox4.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox4.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox4.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox4.OnDisable.BorderRadius = 12;
            this.bunifuCheckBox4.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox4.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox4.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox4.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox4.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox4.OnHoverChecked.BorderRadius = 12;
            this.bunifuCheckBox4.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox4.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox4.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox4.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox4.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox4.OnHoverUnchecked.BorderRadius = 12;
            this.bunifuCheckBox4.OnHoverUnchecked.BorderThickness = 1;
            this.bunifuCheckBox4.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox4.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.bunifuCheckBox4.OnUncheck.BorderRadius = 12;
            this.bunifuCheckBox4.OnUncheck.BorderThickness = 1;
            this.bunifuCheckBox4.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox4.Size = new System.Drawing.Size(21, 21);
            this.bunifuCheckBox4.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.bunifuCheckBox4.TabIndex = 156;
            this.bunifuCheckBox4.ThreeState = false;
            this.bunifuCheckBox4.ToolTipText = "Allow Special Characters";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(312, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 158;
            this.label2.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(360, 215);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bunifuCheckBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuCheckBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunifuCheckBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuCheckBox1);
            this.Controls.Add(this.bunifuHSlider1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnIssues);
            this.Controls.Add(this.PanelNavbar);
            this.Controls.Add(this.PanelTopColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Random Password Generator";
            this.PanelNavbar.ResumeLayout(false);
            this.PanelNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopColor;
        private System.Windows.Forms.Panel PanelNavbar;
        private System.Windows.Forms.Panel NavbarSideline1;
        private System.Windows.Forms.Panel NavbarSideline2;
        private Bunifu.Framework.UI.BunifuImageButton BtnMenu;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnMinimize;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnIssues;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuHSlider bunifuHSlider1;
        private Bunifu.UI.WinForms.BunifuCheckBox bunifuCheckBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuCheckBox bunifuCheckBox2;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuCheckBox bunifuCheckBox3;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuCheckBox bunifuCheckBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

