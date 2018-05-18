namespace WorkflowCaptureWinFormsDemo
{
    partial class RadForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadForm1));
            this.radDiagram1 = new Telerik.WinControls.UI.RadDiagram();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel4 = new Telerik.WinControls.UI.RadPanel();
            this.radDiagramRibbonBar1 = new Telerik.WinControls.UI.RadDiagramRibbonBar();
            this.radRibbonFormBehavior1 = new Telerik.WinControls.UI.RadRibbonFormBehavior();
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.textboxFile = new Telerik.WinControls.UI.RadTextBox();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.checkDiscard = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.textboxStore = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.textboxNew = new Telerik.WinControls.UI.RadTextBox();
            this.textboxId = new Telerik.WinControls.UI.RadTextBox();
            this.dropdownContainers = new Telerik.WinControls.UI.RadDropDownButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.textboxName = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDiagramRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textboxFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkDiscard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textboxStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textboxNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textboxId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropdownContainers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textboxName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radDiagram1
            // 
            this.radDiagram1.ConnectionBridge = Telerik.Windows.Diagrams.Core.BridgeType.Bow;
            this.radDiagram1.IsPanEnabled = false;
            this.radDiagram1.IsRotationEnabled = false;
            this.radDiagram1.IsZoomEnabled = false;
            this.radDiagram1.Location = new System.Drawing.Point(329, 170);
            this.radDiagram1.Name = "radDiagram1";
            this.radDiagram1.Size = new System.Drawing.Size(696, 704);
            this.radDiagram1.TabIndex = 1;
            this.radDiagram1.Text = "radDiagram1";
            this.radDiagram1.ItemsChanged += new System.EventHandler<Telerik.WinControls.UI.Diagrams.DiagramItemsChangedEventArgs>(this.radDiagram1_ItemsChanged);
            this.radDiagram1.ConnectionManipulationCompleted += new System.EventHandler<Telerik.Windows.Diagrams.Core.ManipulationEventArgs>(this.radDiagram1_ConnectionManipulationCompleted);
            this.radDiagram1.ConnectionManipulationStarted += new System.EventHandler<Telerik.Windows.Diagrams.Core.ManipulationEventArgs>(this.radDiagram1_ConnectionManipulationStarted);
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(187)))), ((int)(((byte)(239)))));
            this.radPanel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPanel1.Location = new System.Drawing.Point(2, 202);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(320, 40);
            this.radPanel1.TabIndex = 3;
            this.radPanel1.Text = "Pipette";
            this.radPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radPanel1.Click += new System.EventHandler(this.radPanel1_Click);
            // 
            // radPanel2
            // 
            this.radPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            this.radPanel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPanel2.Location = new System.Drawing.Point(2, 250);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(320, 40);
            this.radPanel2.TabIndex = 4;
            this.radPanel2.Text = "Incubation";
            this.radPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radPanel2.Click += new System.EventHandler(this.radPanel2_Click);
            // 
            // radPanel3
            // 
            this.radPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.radPanel3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPanel3.Location = new System.Drawing.Point(2, 298);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(320, 40);
            this.radPanel3.TabIndex = 4;
            this.radPanel3.Text = "Centrifugation";
            this.radPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radPanel3.Click += new System.EventHandler(this.radPanel3_Click);
            // 
            // radPanel4
            // 
            this.radPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(82)))), ((int)(((byte)(151)))));
            this.radPanel4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPanel4.Location = new System.Drawing.Point(2, 346);
            this.radPanel4.Name = "radPanel4";
            this.radPanel4.Size = new System.Drawing.Size(320, 40);
            this.radPanel4.TabIndex = 5;
            this.radPanel4.Text = "Magnetic Separation";
            this.radPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radPanel4.Click += new System.EventHandler(this.radPanel4_Click);
            // 
            // radDiagramRibbonBar1
            // 
            this.radDiagramRibbonBar1.AssociatedDiagram = this.radDiagram1;
            // 
            // 
            // 
            this.radDiagramRibbonBar1.ExitButton.Text = "Exit";
            this.radDiagramRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radDiagramRibbonBar1.Name = "radDiagramRibbonBar1";
            // 
            // 
            // 
            this.radDiagramRibbonBar1.OptionsButton.Text = "Options";
            this.radDiagramRibbonBar1.Size = new System.Drawing.Size(1031, 151);
            this.radDiagramRibbonBar1.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("radDiagramRibbonBar1.StartButtonImage")));
            this.radDiagramRibbonBar1.TabIndex = 0;
            this.radDiagramRibbonBar1.Text = "Workflow Capture of Awesomeness";
            this.radDiagramRibbonBar1.ThemeName = "Office2013Light";
            // 
            // radRibbonFormBehavior1
            // 
            this.radRibbonFormBehavior1.Form = this;
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(212, 170);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 24);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "Export Workflow";
            this.radButton1.ThemeName = "TelerikMetroBlue";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // textboxFile
            // 
            this.textboxFile.Location = new System.Drawing.Point(2, 172);
            this.textboxFile.Name = "textboxFile";
            this.textboxFile.ShowNullText = true;
            this.textboxFile.Size = new System.Drawing.Size(204, 20);
            this.textboxFile.TabIndex = 6;
            this.textboxFile.Text = "c:\\temp.txt";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.checkDiscard);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.textboxStore);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.textboxNew);
            this.radGroupBox1.Controls.Add(this.textboxId);
            this.radGroupBox1.Controls.Add(this.dropdownContainers);
            this.radGroupBox1.Controls.Add(this.radButton2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.textboxName);
            this.radGroupBox1.HeaderText = "Container Info";
            this.radGroupBox1.Location = new System.Drawing.Point(2, 402);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(320, 282);
            this.radGroupBox1.TabIndex = 7;
            this.radGroupBox1.Text = "Container Info";
            // 
            // checkDiscard
            // 
            this.checkDiscard.Location = new System.Drawing.Point(97, 162);
            this.checkDiscard.Name = "checkDiscard";
            this.checkDiscard.Size = new System.Drawing.Size(62, 18);
            this.checkDiscard.TabIndex = 0;
            this.checkDiscard.Text = "Discard?";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(10, 136);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(33, 18);
            this.radLabel4.TabIndex = 6;
            this.radLabel4.Text = "Store";
            // 
            // textboxStore
            // 
            this.textboxStore.Location = new System.Drawing.Point(97, 136);
            this.textboxStore.Name = "textboxStore";
            this.textboxStore.Size = new System.Drawing.Size(100, 20);
            this.textboxStore.TabIndex = 5;
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(10, 110);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(29, 18);
            this.radLabel3.TabIndex = 3;
            this.radLabel3.Text = "New";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(10, 84);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(21, 18);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Id: ";
            // 
            // textboxNew
            // 
            this.textboxNew.Location = new System.Drawing.Point(97, 110);
            this.textboxNew.Name = "textboxNew";
            this.textboxNew.Size = new System.Drawing.Size(100, 20);
            this.textboxNew.TabIndex = 2;
            // 
            // textboxId
            // 
            this.textboxId.Location = new System.Drawing.Point(97, 84);
            this.textboxId.Name = "textboxId";
            this.textboxId.Size = new System.Drawing.Size(100, 20);
            this.textboxId.TabIndex = 3;
            // 
            // dropdownContainers
            // 
            this.dropdownContainers.Location = new System.Drawing.Point(97, 21);
            this.dropdownContainers.Name = "dropdownContainers";
            this.dropdownContainers.Size = new System.Drawing.Size(140, 24);
            this.dropdownContainers.TabIndex = 2;
            this.dropdownContainers.Text = "Containers";
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(97, 195);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(100, 24);
            this.radButton2.TabIndex = 1;
            this.radButton2.Text = "Add/Update";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click_1);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(10, 60);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(39, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Name:";
            // 
            // textboxName
            // 
            this.textboxName.Location = new System.Drawing.Point(97, 60);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(100, 20);
            this.textboxName.TabIndex = 0;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 859);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.textboxFile);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radDiagramRibbonBar1);
            this.Controls.Add(this.radPanel4);
            this.Controls.Add(this.radPanel3);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radDiagram1);
            this.FormBehavior = this.radRibbonFormBehavior1;
            this.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None;
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Workflow Capture of Awesomeness";
            this.ThemeName = "Office2013Light";
            ((System.ComponentModel.ISupportInitialize)(this.radDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDiagramRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textboxFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkDiscard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textboxStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textboxNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textboxId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropdownContainers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textboxName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadDiagram radDiagram1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadPanel radPanel4;
        private Telerik.WinControls.UI.RadDiagramRibbonBar radDiagramRibbonBar1;
        private Telerik.WinControls.UI.RadRibbonFormBehavior radRibbonFormBehavior1;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadTextBox textboxFile;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadDropDownButton dropdownContainers;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox textboxName;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox textboxStore;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox textboxNew;
        private Telerik.WinControls.UI.RadTextBox textboxId;
        private Telerik.WinControls.UI.RadCheckBox checkDiscard;
    }
}