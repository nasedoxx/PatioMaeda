namespace ControlPatio.Catalogos
{
    partial class FBsqNaviera
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
            this.gcBuque = new DevExpress.XtraGrid.GridControl();
            this.navieraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvBuque = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBuqueId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuqueNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcBuque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navieraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBuque)).BeginInit();
            this.SuspendLayout();
            // 
            // gcBuque
            // 
            this.gcBuque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcBuque.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcBuque.DataSource = this.navieraBindingSource;
            this.gcBuque.Location = new System.Drawing.Point(10, 12);
            this.gcBuque.MainView = this.gvBuque;
            this.gcBuque.Name = "gcBuque";
            this.gcBuque.Size = new System.Drawing.Size(372, 464);
            this.gcBuque.TabIndex = 5;
            this.gcBuque.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBuque});
            this.gcBuque.DoubleClick += new System.EventHandler(this.gcBuque_DoubleClick);
            // 
            // navieraBindingSource
            // 
            this.navieraBindingSource.DataSource = typeof(ControlPatio.Naviera);
            // 
            // gvBuque
            // 
            this.gvBuque.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBuqueId,
            this.colBuqueNombre});
            this.gvBuque.GridControl = this.gcBuque;
            this.gvBuque.Name = "gvBuque";
            this.gvBuque.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvBuque.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvBuque.OptionsBehavior.Editable = false;
            this.gvBuque.OptionsBehavior.ReadOnly = true;
            this.gvBuque.OptionsDetail.EnableMasterViewMode = false;
            this.gvBuque.OptionsFind.AlwaysVisible = true;
            this.gvBuque.OptionsFind.FindNullPrompt = "Texto a buscar...";
            this.gvBuque.OptionsFind.ShowClearButton = false;
            this.gvBuque.OptionsView.ColumnAutoWidth = false;
            this.gvBuque.OptionsView.ShowGroupPanel = false;
            // 
            // colBuqueId
            // 
            this.colBuqueId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBuqueId.AppearanceHeader.Options.UseFont = true;
            this.colBuqueId.Caption = "Clave";
            this.colBuqueId.FieldName = "NavieraId";
            this.colBuqueId.Name = "colBuqueId";
            this.colBuqueId.Visible = true;
            this.colBuqueId.VisibleIndex = 0;
            this.colBuqueId.Width = 70;
            // 
            // colBuqueNombre
            // 
            this.colBuqueNombre.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBuqueNombre.AppearanceCell.Options.UseFont = true;
            this.colBuqueNombre.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBuqueNombre.AppearanceHeader.Options.UseFont = true;
            this.colBuqueNombre.Caption = "Nombre";
            this.colBuqueNombre.FieldName = "NavieraNombre";
            this.colBuqueNombre.Name = "colBuqueNombre";
            this.colBuqueNombre.Visible = true;
            this.colBuqueNombre.VisibleIndex = 1;
            this.colBuqueNombre.Width = 200;
            // 
            // FBsqNaviera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 488);
            this.Controls.Add(this.gcBuque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FBsqNaviera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Naviera";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FBsqNaviera_FormClosed);
            this.Load += new System.EventHandler(this.FBsqNaviera_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FBsqNaviera_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.gcBuque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navieraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBuque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcBuque;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBuque;
        private DevExpress.XtraGrid.Columns.GridColumn colBuqueId;
        private DevExpress.XtraGrid.Columns.GridColumn colBuqueNombre;
        private System.Windows.Forms.BindingSource navieraBindingSource;
    }
}