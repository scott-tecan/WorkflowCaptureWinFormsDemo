namespace WorkflowCaptureWinFormsDemo
{
    partial class ScrollBarTest
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
            this.radScrollablePanel1 = new Telerik.WinControls.UI.RadScrollablePanel();
            this.radDiagram1 = new Telerik.WinControls.UI.RadDiagram();
            this.radDiagramToolbox1 = new Telerik.WinControls.UI.RadDiagramToolbox();
            //this.radDiagramToolbox1 = new WorkflowCaptureToolbox();
            ((System.ComponentModel.ISupportInitialize)(this.radScrollablePanel1)).BeginInit();
            this.radScrollablePanel1.PanelContainer.SuspendLayout();
            this.radScrollablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDiagramToolbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radScrollablePanel1
            // 
            this.radScrollablePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.radScrollablePanel1.Location = new System.Drawing.Point(12, 24);
            this.radScrollablePanel1.Name = "radScrollablePanel1";
            // 
            // radScrollablePanel1.PanelContainer
            // 
            this.radScrollablePanel1.PanelContainer.Controls.Add(this.radDiagramToolbox1);
            this.radScrollablePanel1.PanelContainer.Controls.Add(this.radDiagram1);
            this.radScrollablePanel1.PanelContainer.Size = new System.Drawing.Size(851, 657);
            this.radScrollablePanel1.Size = new System.Drawing.Size(853, 659);
            this.radScrollablePanel1.TabIndex = 0;
            // 
            // radDiagram1
            // 
            this.radDiagram1.HorizontalScrollbarVisibility = Telerik.WinControls.UI.Diagrams.ScrollBarVisibility.Visible;
            this.radDiagram1.Location = new System.Drawing.Point(305, 24);
            this.radDiagram1.Name = "radDiagram1";
            this.radDiagram1.Size = new System.Drawing.Size(400, 400);
            this.radDiagram1.TabIndex = 0;
            this.radDiagram1.Text = "radDiagram1";
            this.radDiagram1.VerticalScrollbarVisibility = Telerik.WinControls.UI.Diagrams.ScrollBarVisibility.Visible;
            // 
            // radDiagramToolbox1
            // 
            this.radDiagramToolbox1.AllowDragDrop = true;
            this.radDiagramToolbox1.AllowDrop = true;
            this.radDiagramToolbox1.AllowEdit = false;
            this.radDiagramToolbox1.EnableCustomGrouping = true;
            this.radDiagramToolbox1.FullRowSelect = false;
            this.radDiagramToolbox1.GroupIndent = 10;
            this.radDiagramToolbox1.ItemSize = new System.Drawing.Size(80, 80);
            this.radDiagramToolbox1.ItemSpacing = 15;
            this.radDiagramToolbox1.Location = new System.Drawing.Point(9, 24);
            this.radDiagramToolbox1.Name = "radDiagramToolbox1";
            this.radDiagramToolbox1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.radDiagramToolbox1.ShowGroups = true;
            this.radDiagramToolbox1.Size = new System.Drawing.Size(290, 450);
            this.radDiagramToolbox1.TabIndex = 1;
            this.radDiagramToolbox1.ViewType = Telerik.WinControls.UI.ListViewType.IconsView;
            // 
            // ScrollBarTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(972, 737);
            this.Controls.Add(this.radScrollablePanel1);
            this.Name = "ScrollBarTest";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ScrollBarTest";
            this.radScrollablePanel1.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radScrollablePanel1)).EndInit();
            this.radScrollablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDiagramToolbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadScrollablePanel radScrollablePanel1;
        private Telerik.WinControls.UI.RadDiagramToolbox radDiagramToolbox1;
        private Telerik.WinControls.UI.RadDiagram radDiagram1;
    }
}
