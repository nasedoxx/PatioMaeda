namespace ControlPatio.Catalogos
{
    partial class FBsqEntradas
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
            this.gcEntradas = new DevExpress.XtraGrid.GridControl();
            this.gvEntradas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.entradaSalidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaSalidaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gcEntradas
            // 
            this.gcEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcEntradas.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcEntradas.Location = new System.Drawing.Point(12, 12);
            this.gcEntradas.MainView = this.gvEntradas;
            this.gcEntradas.Name = "gcEntradas";
            this.gcEntradas.Size = new System.Drawing.Size(438, 479);
            this.gcEntradas.TabIndex = 6;
            this.gcEntradas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEntradas});
            this.gcEntradas.DoubleClick += new System.EventHandler(this.gcEntradas_DoubleClick);
            // 
            // gvEntradas
            // 
            this.gvEntradas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gvEntradas.GridControl = this.gcEntradas;
            this.gvEntradas.Name = "gvEntradas";
            this.gvEntradas.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvEntradas.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvEntradas.OptionsBehavior.Editable = false;
            this.gvEntradas.OptionsBehavior.ReadOnly = true;
            this.gvEntradas.OptionsDetail.EnableMasterViewMode = false;
            this.gvEntradas.OptionsFind.AlwaysVisible = true;
            this.gvEntradas.OptionsFind.FindNullPrompt = "Texto a buscar...";
            this.gvEntradas.OptionsFind.ShowClearButton = false;
            this.gvEntradas.OptionsView.ColumnAutoWidth = false;
            this.gvEntradas.OptionsView.ShowGroupPanel = false;
            this.gvEntradas.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridColumn1.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "Contenedor";
            this.gridColumn1.FieldName = "Contenedor";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "F. Entrada";
            this.gridColumn2.FieldName = "Fecha";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 80;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.Caption = "Tamaño";
            this.gridColumn3.FieldName = "Tam";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 80;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.Caption = "EIR Entrada";
            this.gridColumn4.FieldName = "EirEntrada";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.Caption = "EIR Salida";
            this.gridColumn5.FieldName = "EirSalida";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // entradaSalidaBindingSource
            // 
            this.entradaSalidaBindingSource.DataSource = typeof(ControlPatio.EntradaSalida);
            // 
            // FBsqEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 503);
            this.Controls.Add(this.gcEntradas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FBsqEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contenedores sin Eir Entrada/Salida";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FBsqEntradas_FormClosed);
            this.Load += new System.EventHandler(this.FBsqEntradas_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FBsqEntradas_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.gcEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaSalidaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcEntradas;
        private System.Windows.Forms.BindingSource entradaSalidaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEntradas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}