namespace ControlPatio.Catalogos
{
    partial class FCatBuques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCatBuques));
            this.MsgError = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeshacer = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.btnBuscar = new DevExpress.XtraBars.BarButtonItem();
            this.btnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bnRegistros = new DevExpress.XtraEditors.DataNavigator();
            this.txtClave = new DevExpress.XtraEditors.TextEdit();
            this.buqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNaviera = new DevExpress.XtraEditors.ButtonEdit();
            this.txtNavieraId = new DevExpress.XtraEditors.TextEdit();
            this.navieraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MsgError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNaviera.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNavieraId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navieraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MsgError
            // 
            this.MsgError.ContainerControl = this;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnEditar,
            this.btnDeshacer,
            this.btnEliminar,
            this.btnBuscar,
            this.btnImprimir});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 26;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNuevo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGuardar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDeshacer),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEliminar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBuscar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnImprimir)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nuevo Registro";
            this.btnNuevo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Glyph")));
            this.btnNuevo.Id = 0;
            this.btnNuevo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNuevo.LargeGlyph")));
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevo_ItemClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Caption = "Guardar registro";
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Glyph")));
            this.btnGuardar.Id = 1;
            this.btnGuardar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGuardar.LargeGlyph")));
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuardar_ItemClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Caption = "Editar registro";
            this.btnEditar.Enabled = false;
            this.btnEditar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEditar.Glyph")));
            this.btnEditar.Id = 2;
            this.btnEditar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEditar.LargeGlyph")));
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditar_ItemClick);
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.Caption = "Deshacer cambios";
            this.btnDeshacer.Enabled = false;
            this.btnDeshacer.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDeshacer.Glyph")));
            this.btnDeshacer.Id = 3;
            this.btnDeshacer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDeshacer.LargeGlyph")));
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeshacer_ItemClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar registro";
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Glyph")));
            this.btnEliminar.Id = 4;
            this.btnEliminar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEliminar.LargeGlyph")));
            this.btnEliminar.Name = "btnEliminar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Caption = "(F4)  Buscar";
            this.btnBuscar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Glyph")));
            this.btnBuscar.Id = 10;
            this.btnBuscar.Name = "btnBuscar";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Caption = "Imprimir factura";
            this.btnImprimir.Glyph = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Glyph")));
            this.btnImprimir.Id = 16;
            this.btnImprimir.Name = "btnImprimir";
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            this.bar3.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(651, 42);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 337);
            this.barDockControlBottom.Size = new System.Drawing.Size(651, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 42);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 295);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(651, 42);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 295);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(54, 136);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 253;
            this.labelControl1.Text = "Naviera:";
            // 
            // bnRegistros
            // 
            this.bnRegistros.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.bnRegistros.Appearance.Options.UseBackColor = true;
            this.bnRegistros.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.bnRegistros.Buttons.Append.Visible = false;
            this.bnRegistros.Buttons.CancelEdit.Visible = false;
            this.bnRegistros.Buttons.EndEdit.Visible = false;
            this.bnRegistros.Buttons.NextPage.Enabled = false;
            this.bnRegistros.Buttons.NextPage.Visible = false;
            this.bnRegistros.Buttons.PrevPage.Enabled = false;
            this.bnRegistros.Buttons.PrevPage.Visible = false;
            this.bnRegistros.Buttons.Remove.Enabled = false;
            this.bnRegistros.Buttons.Remove.Visible = false;
            this.bnRegistros.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.bnRegistros.Location = new System.Drawing.Point(171, 48);
            this.bnRegistros.LookAndFeel.SkinName = "Metropolis";
            this.bnRegistros.Name = "bnRegistros";
            this.bnRegistros.Size = new System.Drawing.Size(274, 27);
            this.bnRegistros.TabIndex = 252;
            this.bnRegistros.TextStringFormat = "";
            // 
            // txtClave
            // 
            this.txtClave.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.buqueBindingSource, "BuqueId", true));
            this.txtClave.Location = new System.Drawing.Point(101, 81);
            this.txtClave.Name = "txtClave";
            this.txtClave.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtClave.Properties.Appearance.Options.UseBackColor = true;
            this.txtClave.Size = new System.Drawing.Size(104, 20);
            this.txtClave.TabIndex = 251;
            // 
            // buqueBindingSource
            // 
            this.buqueBindingSource.DataSource = typeof(ControlPatio.Buque);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(64, 84);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 250;
            this.labelControl2.Text = "Clave:";
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.buqueBindingSource, "BuqueNombre", true));
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(101, 107);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(344, 20);
            this.txtNombre.TabIndex = 249;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(54, 110);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 13);
            this.labelControl4.TabIndex = 248;
            this.labelControl4.Text = "Nombre:";
            // 
            // txtNaviera
            // 
            this.txtNaviera.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.buqueBindingSource, "Naviera.NavieraNombre", true));
            this.txtNaviera.EditValue = "";
            this.txtNaviera.Location = new System.Drawing.Point(101, 133);
            this.txtNaviera.Name = "txtNaviera";
            this.txtNaviera.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtNaviera.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtNaviera.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.txtNaviera.Size = new System.Drawing.Size(344, 20);
            this.txtNaviera.TabIndex = 254;
            this.txtNaviera.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtNaviera_ButtonClick);
            this.txtNaviera.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNaviera_KeyDown);
            // 
            // txtNavieraId
            // 
            this.txtNavieraId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.buqueBindingSource, "BuqueNavieraId", true));
            this.txtNavieraId.Location = new System.Drawing.Point(101, 133);
            this.txtNavieraId.Name = "txtNavieraId";
            this.txtNavieraId.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNavieraId.Properties.Appearance.Options.UseBackColor = true;
            this.txtNavieraId.Size = new System.Drawing.Size(18, 20);
            this.txtNavieraId.TabIndex = 255;
            // 
            // navieraBindingSource
            // 
            this.navieraBindingSource.DataSource = typeof(ControlPatio.Naviera);
            // 
            // FCatBuques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 359);
            this.Controls.Add(this.txtNavieraId);
            this.Controls.Add(this.txtNaviera);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.bnRegistros);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FCatBuques";
            this.Text = "Catálogo de Buques";
            this.Load += new System.EventHandler(this.FCatBuques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MsgError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNaviera.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNavieraId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navieraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider MsgError;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnGuardar;
        private DevExpress.XtraBars.BarButtonItem btnEditar;
        private DevExpress.XtraBars.BarButtonItem btnDeshacer;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
        private DevExpress.XtraBars.BarButtonItem btnBuscar;
        private DevExpress.XtraBars.BarButtonItem btnImprimir;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DataNavigator bnRegistros;
        private DevExpress.XtraEditors.TextEdit txtClave;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtNavieraId;
        private System.Windows.Forms.BindingSource buqueBindingSource;
        private DevExpress.XtraEditors.ButtonEdit txtNaviera;
        private System.Windows.Forms.BindingSource navieraBindingSource;
    }
}