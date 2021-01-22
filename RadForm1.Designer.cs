namespace YazılımSinama2
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadForm1));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dragAndDropRadGrid3 = new YazılımSinama2.DragAndDropRadGrid();
            this.dragAndDropRadGrid2 = new YazılımSinama2.DragAndDropRadGrid();
            this.dragAndDropRadGrid1 = new YazılımSinama2.DragAndDropRadGrid();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dragAndDropRadGrid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragAndDropRadGrid3.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragAndDropRadGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragAndDropRadGrid2.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragAndDropRadGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragAndDropRadGrid1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.dragAndDropRadGrid1);
            this.groupControl1.Location = new System.Drawing.Point(4, 45);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(189, 331);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "To Do";
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl2.Controls.Add(this.dragAndDropRadGrid2);
            this.groupControl2.Location = new System.Drawing.Point(209, 45);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(189, 331);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "İn Progress";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dragAndDropRadGrid3);
            this.groupControl3.Location = new System.Drawing.Point(415, 45);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(189, 331);
            this.groupControl3.TabIndex = 8;
            this.groupControl3.Text = "Other";
            // 
            // dragAndDropRadGrid3
            // 
            this.dragAndDropRadGrid3.Location = new System.Drawing.Point(5, 26);
            // 
            // 
            // 
            this.dragAndDropRadGrid3.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn2.HeaderText = "TASKNAME";
            gridViewTextBoxColumn2.Name = "TASKNAME";
            gridViewTextBoxColumn2.Width = 159;
            this.dragAndDropRadGrid3.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn2});
            this.dragAndDropRadGrid3.MasterTemplate.MultiSelect = true;
            this.dragAndDropRadGrid3.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.dragAndDropRadGrid3.Name = "dragAndDropRadGrid3";
            this.dragAndDropRadGrid3.ReadOnly = true;
            this.dragAndDropRadGrid3.Size = new System.Drawing.Size(179, 301);
            this.dragAndDropRadGrid3.TabIndex = 4;
            // 
            // dragAndDropRadGrid2
            // 
            this.dragAndDropRadGrid2.Location = new System.Drawing.Point(5, 25);
            // 
            // 
            // 
            this.dragAndDropRadGrid2.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.HeaderText = "TASKNAME";
            gridViewTextBoxColumn1.Name = "TASKNAME";
            gridViewTextBoxColumn1.Width = 159;
            this.dragAndDropRadGrid2.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1});
            this.dragAndDropRadGrid2.MasterTemplate.MultiSelect = true;
            this.dragAndDropRadGrid2.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.dragAndDropRadGrid2.Name = "dragAndDropRadGrid2";
            this.dragAndDropRadGrid2.ReadOnly = true;
            this.dragAndDropRadGrid2.Size = new System.Drawing.Size(179, 301);
            this.dragAndDropRadGrid2.TabIndex = 3;
            // 
            // dragAndDropRadGrid1
            // 
            this.dragAndDropRadGrid1.ColumnChooserSortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            this.dragAndDropRadGrid1.Location = new System.Drawing.Point(5, 26);
            // 
            // 
            // 
            this.dragAndDropRadGrid1.MasterTemplate.MultiSelect = true;
            this.dragAndDropRadGrid1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dragAndDropRadGrid1.Name = "dragAndDropRadGrid1";
            this.dragAndDropRadGrid1.ReadOnly = true;
            this.dragAndDropRadGrid1.Size = new System.Drawing.Size(179, 301);
            this.dragAndDropRadGrid1.TabIndex = 2;
            this.dragAndDropRadGrid1.DoubleClick += new System.EventHandler(this.dragAndDropRadGrid1_DoubleClick);
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(616, 601);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RadForm1";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dragAndDropRadGrid3.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragAndDropRadGrid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragAndDropRadGrid2.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragAndDropRadGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragAndDropRadGrid1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragAndDropRadGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DragAndDropRadGrid dragAndDropRadGrid1;
        private DragAndDropRadGrid dragAndDropRadGrid2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DragAndDropRadGrid dragAndDropRadGrid3;
    }
}
