namespace ControlPatio.Catalogos
{
    partial class FRepEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRepEntradas));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtFec1 = new DevExpress.XtraEditors.DateEdit();
            this.dtFec2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.gcCodigos = new DevExpress.XtraGrid.GridControl();
            this.gvCodigos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCveCalidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveContenedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataSet1 = new System.Data.DataSet();
            this.tbInvEntrada = new System.Data.DataTable();
            this.tbResumen = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.tbCalidad = new System.Data.DataTable();
            this.dataColumn3 = new System.Data.DataColumn();
            this.tbContenedor = new System.Data.DataTable();
            this.dataColumn4 = new System.Data.DataColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNaviera = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtNavieraId = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFec1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFec1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFec2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFec2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCodigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCodigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContenedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNaviera.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNavieraId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(12, 79);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(189, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Inventario de Entrada";
            // 
            // dtFec1
            // 
            this.dtFec1.EditValue = null;
            this.dtFec1.Location = new System.Drawing.Point(117, 12);
            this.dtFec1.Name = "dtFec1";
            this.dtFec1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFec1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFec1.Size = new System.Drawing.Size(138, 20);
            this.dtFec1.TabIndex = 3;
            // 
            // dtFec2
            // 
            this.dtFec2.EditValue = null;
            this.dtFec2.Location = new System.Drawing.Point(339, 12);
            this.dtFec2.Name = "dtFec2";
            this.dtFec2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFec2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFec2.Size = new System.Drawing.Size(138, 20);
            this.dtFec2.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(50, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Fecha inicial:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(277, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Fecha final:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBuscar.Location = new System.Drawing.Point(486, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 47);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gcCodigos
            // 
            this.gcCodigos.Location = new System.Drawing.Point(12, 104);
            this.gcCodigos.MainView = this.gvCodigos;
            this.gcCodigos.Name = "gcCodigos";
            this.gcCodigos.Size = new System.Drawing.Size(577, 192);
            this.gcCodigos.TabIndex = 27;
            this.gcCodigos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCodigos});
            // 
            // gvCodigos
            // 
            this.gvCodigos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gvCodigos.GridControl = this.gcCodigos;
            this.gvCodigos.Name = "gvCodigos";
            this.gvCodigos.OptionsCustomization.AllowColumnMoving = false;
            this.gvCodigos.OptionsCustomization.AllowColumnResizing = false;
            this.gvCodigos.OptionsCustomization.AllowGroup = false;
            this.gvCodigos.OptionsView.ColumnAutoWidth = false;
            this.gvCodigos.OptionsView.ShowGroupPanel = false;
            this.gvCodigos.OptionsView.ShowIndicator = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 334);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(577, 192);
            this.gridControl1.TabIndex = 29;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCveCalidad,
            this.colClaveContenedor,
            this.colDim,
            this.colTam});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowColumnResizing = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // colCveCalidad
            // 
            this.colCveCalidad.FieldName = "CveCalidad";
            this.colCveCalidad.Name = "colCveCalidad";
            this.colCveCalidad.Visible = true;
            this.colCveCalidad.VisibleIndex = 0;
            // 
            // colClaveContenedor
            // 
            this.colClaveContenedor.FieldName = "CveContenedor";
            this.colClaveContenedor.Name = "colClaveContenedor";
            this.colClaveContenedor.Visible = true;
            this.colClaveContenedor.VisibleIndex = 1;
            // 
            // colDim
            // 
            this.colDim.FieldName = "Dim";
            this.colDim.Name = "colDim";
            this.colDim.Visible = true;
            this.colDim.VisibleIndex = 2;
            // 
            // colTam
            // 
            this.colTam.FieldName = "Tam";
            this.colTam.Name = "colTam";
            this.colTam.Visible = true;
            this.colTam.VisibleIndex = 3;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.tbInvEntrada,
            this.tbResumen,
            this.tbCalidad,
            this.tbContenedor});
            // 
            // tbInvEntrada
            // 
            this.tbInvEntrada.TableName = "tbInvEntrada";
            // 
            // tbResumen
            // 
            this.tbResumen.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7});
            this.tbResumen.TableName = "tbResumen";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "CveCalidad";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "CveContenedor";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Dim";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Tam";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "Total";
            this.dataColumn7.DataType = typeof(int);
            this.dataColumn7.DefaultValue = 0;
            // 
            // tbCalidad
            // 
            this.tbCalidad.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn3});
            this.tbCalidad.TableName = "tbCalidad";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "ClaveCalidad";
            // 
            // tbContenedor
            // 
            this.tbContenedor.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn4});
            this.tbContenedor.TableName = "tbContenedor";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Tam";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(12, 309);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(135, 19);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "Resumen Calidad";
            // 
            // txtNaviera
            // 
            this.txtNaviera.Location = new System.Drawing.Point(117, 38);
            this.txtNaviera.Name = "txtNaviera";
            this.txtNaviera.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.txtNaviera.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNaviera.Size = new System.Drawing.Size(360, 20);
            this.txtNaviera.TabIndex = 30;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(70, 41);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 13);
            this.labelControl5.TabIndex = 31;
            this.labelControl5.Text = "Naviera:";
            // 
            // txtNavieraId
            // 
            this.txtNavieraId.Location = new System.Drawing.Point(117, 38);
            this.txtNavieraId.Name = "txtNavieraId";
            this.txtNavieraId.Size = new System.Drawing.Size(13, 20);
            this.txtNavieraId.TabIndex = 180;
            // 
            // FRepEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 550);
            this.Controls.Add(this.txtNavieraId);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtNaviera);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.gcCodigos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.dtFec2);
            this.Controls.Add(this.dtFec1);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRepEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entradas / Salidas";
            this.Load += new System.EventHandler(this.FRepEntradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtFec1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFec1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFec2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFec2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCodigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCodigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContenedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNaviera.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNavieraId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtFec1;
        private DevExpress.XtraEditors.DateEdit dtFec2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraGrid.GridControl gcCodigos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCodigos;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable tbInvEntrada;
        private System.Data.DataTable tbResumen;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private DevExpress.XtraEditors.ButtonEdit txtNaviera;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtNavieraId;
        private System.Data.DataTable tbCalidad;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataTable tbContenedor;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn colCveCalidad;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveContenedor;
        private DevExpress.XtraGrid.Columns.GridColumn colDim;
        private DevExpress.XtraGrid.Columns.GridColumn colTam;
        private System.Data.DataColumn dataColumn7;
    }
}