namespace ControlPatio.Catalogos
{
    partial class FBsqCliente
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
            this.gcCliente = new DevExpress.XtraGrid.GridControl();
            this.gvCliente = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colClienteId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClienteNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClienteRFC = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCliente
            // 
            this.gcCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcCliente.DataSource = this.clienteBindingSource;
            this.gcCliente.Location = new System.Drawing.Point(12, 12);
            this.gcCliente.MainView = this.gvCliente;
            this.gcCliente.Name = "gcCliente";
            this.gcCliente.Size = new System.Drawing.Size(372, 470);
            this.gcCliente.TabIndex = 5;
            this.gcCliente.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCliente});
            this.gcCliente.DoubleClick += new System.EventHandler(this.gcCliente_DoubleClick);
            // 
            // gvCliente
            // 
            this.gvCliente.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colClienteId,
            this.colClienteNombre,
            this.colClienteRFC});
            this.gvCliente.GridControl = this.gcCliente;
            this.gvCliente.Name = "gvCliente";
            this.gvCliente.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCliente.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCliente.OptionsBehavior.Editable = false;
            this.gvCliente.OptionsBehavior.ReadOnly = true;
            this.gvCliente.OptionsDetail.EnableMasterViewMode = false;
            this.gvCliente.OptionsFind.AlwaysVisible = true;
            this.gvCliente.OptionsFind.FindNullPrompt = "Texto a buscar...";
            this.gvCliente.OptionsFind.ShowClearButton = false;
            this.gvCliente.OptionsView.ColumnAutoWidth = false;
            this.gvCliente.OptionsView.ShowGroupPanel = false;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(ControlPatio.Cliente);
            // 
            // colClienteId
            // 
            this.colClienteId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colClienteId.AppearanceHeader.Options.UseFont = true;
            this.colClienteId.Caption = "Clave";
            this.colClienteId.FieldName = "ClienteId";
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
            this.colClienteNombre.FieldName = "ClienteNombre";
            this.colClienteNombre.Name = "colClienteNombre";
            this.colClienteNombre.Visible = true;
            this.colClienteNombre.VisibleIndex = 1;
            this.colClienteNombre.Width = 180;
            // 
            // colClienteRFC
            // 
            this.colClienteRFC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colClienteRFC.AppearanceHeader.Options.UseFont = true;
            this.colClienteRFC.Caption = "RFC";
            this.colClienteRFC.FieldName = "ClienteRFC";
            this.colClienteRFC.Name = "colClienteRFC";
            this.colClienteRFC.Visible = true;
            this.colClienteRFC.VisibleIndex = 2;
            this.colClienteRFC.Width = 90;
            // 
            // FBsqCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 494);
            this.Controls.Add(this.gcCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FBsqCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FBsqCliente_FormClosed);
            this.Load += new System.EventHandler(this.FBsqCliente_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FBsqCliente_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.gcCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCliente;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colClienteId;
        private DevExpress.XtraGrid.Columns.GridColumn colClienteNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colClienteRFC;
    }
}