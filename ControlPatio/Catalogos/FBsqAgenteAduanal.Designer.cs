namespace ControlPatio.Catalogos
{
    partial class FBsqAgenteAduanal
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
            this.gcAA = new DevExpress.XtraGrid.GridControl();
            this.agenteAduanalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvAA = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colClienteId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClienteNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClienteRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenteAduanalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAA)).BeginInit();
            this.SuspendLayout();
            // 
            // gcAA
            // 
            this.gcAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcAA.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcAA.DataSource = this.agenteAduanalBindingSource;
            this.gcAA.Location = new System.Drawing.Point(12, 12);
            this.gcAA.MainView = this.gvAA;
            this.gcAA.Name = "gcAA";
            this.gcAA.Size = new System.Drawing.Size(374, 471);
            this.gcAA.TabIndex = 6;
            this.gcAA.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAA});
            this.gcAA.DoubleClick += new System.EventHandler(this.gcAA_DoubleClick);
            // 
            // agenteAduanalBindingSource
            // 
            this.agenteAduanalBindingSource.DataSource = typeof(ControlPatio.AgenteAduanal);
            // 
            // gvAA
            // 
            this.gvAA.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colClienteId,
            this.colClienteNombre,
            this.colClienteRFC});
            this.gvAA.GridControl = this.gcAA;
            this.gvAA.Name = "gvAA";
            this.gvAA.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvAA.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvAA.OptionsBehavior.Editable = false;
            this.gvAA.OptionsBehavior.ReadOnly = true;
            this.gvAA.OptionsDetail.EnableMasterViewMode = false;
            this.gvAA.OptionsFind.AlwaysVisible = true;
            this.gvAA.OptionsFind.FindNullPrompt = "Texto a buscar...";
            this.gvAA.OptionsFind.ShowClearButton = false;
            this.gvAA.OptionsView.ColumnAutoWidth = false;
            this.gvAA.OptionsView.ShowGroupPanel = false;
            // 
            // colClienteId
            // 
            this.colClienteId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colClienteId.AppearanceHeader.Options.UseFont = true;
            this.colClienteId.Caption = "Clave";
            this.colClienteId.FieldName = "AgenteId";
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
            this.colClienteNombre.FieldName = "AgenteNombre";
            this.colClienteNombre.Name = "colClienteNombre";
            this.colClienteNombre.Visible = true;
            this.colClienteNombre.VisibleIndex = 1;
            this.colClienteNombre.Width = 180;
            // 
            // colClienteRFC
            // 
            this.colClienteRFC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colClienteRFC.AppearanceHeader.Options.UseFont = true;
            this.colClienteRFC.Caption = "Patente";
            this.colClienteRFC.FieldName = "AgentePatente";
            this.colClienteRFC.Name = "colClienteRFC";
            this.colClienteRFC.Visible = true;
            this.colClienteRFC.VisibleIndex = 2;
            this.colClienteRFC.Width = 90;
            // 
            // FBsqAgenteAduanal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 495);
            this.Controls.Add(this.gcAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FBsqAgenteAduanal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agente Aduanal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FBsqAgenteAduanal_FormClosed);
            this.Load += new System.EventHandler(this.FBsqAgenteAduanal_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FBsqAgenteAduanal_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.gcAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenteAduanalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcAA;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAA;
        private DevExpress.XtraGrid.Columns.GridColumn colClienteId;
        private DevExpress.XtraGrid.Columns.GridColumn colClienteNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colClienteRFC;
        private System.Windows.Forms.BindingSource agenteAduanalBindingSource;
    }
}