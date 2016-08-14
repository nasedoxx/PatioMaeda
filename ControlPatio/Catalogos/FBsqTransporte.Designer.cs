namespace ControlPatio.Catalogos
{
    partial class FBsqTransporte
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
            this.gcTransporte = new DevExpress.XtraGrid.GridControl();
            this.transporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvTransporte = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colClienteId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClienteNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcTransporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransporte)).BeginInit();
            this.SuspendLayout();
            // 
            // gcTransporte
            // 
            this.gcTransporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcTransporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcTransporte.DataSource = this.transporteBindingSource;
            this.gcTransporte.Location = new System.Drawing.Point(10, 14);
            this.gcTransporte.MainView = this.gvTransporte;
            this.gcTransporte.Name = "gcTransporte";
            this.gcTransporte.Size = new System.Drawing.Size(374, 471);
            this.gcTransporte.TabIndex = 7;
            this.gcTransporte.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTransporte});
            this.gcTransporte.DoubleClick += new System.EventHandler(this.gcTransporte_DoubleClick);
            // 
            // transporteBindingSource
            // 
            this.transporteBindingSource.DataSource = typeof(ControlPatio.Transporte);
            // 
            // gvTransporte
            // 
            this.gvTransporte.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colClienteId,
            this.colClienteNombre});
            this.gvTransporte.GridControl = this.gcTransporte;
            this.gvTransporte.Name = "gvTransporte";
            this.gvTransporte.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvTransporte.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvTransporte.OptionsBehavior.Editable = false;
            this.gvTransporte.OptionsBehavior.ReadOnly = true;
            this.gvTransporte.OptionsDetail.EnableMasterViewMode = false;
            this.gvTransporte.OptionsFind.AlwaysVisible = true;
            this.gvTransporte.OptionsFind.FindNullPrompt = "Texto a buscar...";
            this.gvTransporte.OptionsFind.ShowClearButton = false;
            this.gvTransporte.OptionsView.ColumnAutoWidth = false;
            this.gvTransporte.OptionsView.ShowGroupPanel = false;
            // 
            // colClienteId
            // 
            this.colClienteId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colClienteId.AppearanceHeader.Options.UseFont = true;
            this.colClienteId.Caption = "Clave";
            this.colClienteId.FieldName = "TransporteId";
            this.colClienteId.Name = "colClienteId";
            this.colClienteId.Visible = true;
            this.colClienteId.VisibleIndex = 0;
            this.colClienteId.Width = 70;
            // 
            // colClienteNombre
            // 
            this.colClienteNombre.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colClienteNombre.AppearanceHeader.Options.UseFont = true;
            this.colClienteNombre.Caption = "Nombre";
            this.colClienteNombre.FieldName = "TransporteNombre";
            this.colClienteNombre.Name = "colClienteNombre";
            this.colClienteNombre.Visible = true;
            this.colClienteNombre.VisibleIndex = 1;
            this.colClienteNombre.Width = 250;
            // 
            // FBsqTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 497);
            this.Controls.Add(this.gcTransporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FBsqTransporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transporte";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FBsqTransporte_FormClosed);
            this.Load += new System.EventHandler(this.FBsqTransporte_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FBsqTransporte_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.gcTransporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTransporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcTransporte;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTransporte;
        private DevExpress.XtraGrid.Columns.GridColumn colClienteId;
        private DevExpress.XtraGrid.Columns.GridColumn colClienteNombre;
        private System.Windows.Forms.BindingSource transporteBindingSource;
    }
}