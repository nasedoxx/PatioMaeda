namespace ControlPatio
{
    partial class FPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPrincipal));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnEntradas = new DevExpress.XtraBars.BarButtonItem();
            this.btnSalidas = new DevExpress.XtraBars.BarButtonItem();
            this.btnEIR = new DevExpress.XtraBars.BarButtonItem();
            this.btnClientes = new DevExpress.XtraBars.BarButtonItem();
            this.btnTransporte = new DevExpress.XtraBars.BarButtonItem();
            this.btnAgente = new DevExpress.XtraBars.BarButtonItem();
            this.btnEconomicos = new DevExpress.XtraBars.BarButtonItem();
            this.btnContenedores = new DevExpress.XtraBars.BarButtonItem();
            this.btnNavieras = new DevExpress.XtraBars.BarButtonItem();
            this.btnBuque = new DevExpress.XtraBars.BarButtonItem();
            this.btnRepEntSal = new DevExpress.XtraBars.BarButtonItem();
            this.btnRepAA = new DevExpress.XtraBars.BarButtonItem();
            this.btnRepCliente = new DevExpress.XtraBars.BarButtonItem();
            this.btnRepTransporte = new DevExpress.XtraBars.BarButtonItem();
            this.btnRepManiobra = new DevExpress.XtraBars.BarButtonItem();
            this.btnRepBuque = new DevExpress.XtraBars.BarButtonItem();
            this.btnRepBooking = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.btnCalidad = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnEntradas,
            this.btnSalidas,
            this.btnEIR,
            this.btnClientes,
            this.btnTransporte,
            this.btnAgente,
            this.btnEconomicos,
            this.btnContenedores,
            this.btnNavieras,
            this.btnBuque,
            this.btnRepEntSal,
            this.btnRepAA,
            this.btnRepCliente,
            this.btnRepTransporte,
            this.btnRepManiobra,
            this.btnRepBuque,
            this.btnRepBooking,
            this.btnCalidad});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 20;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(960, 147);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnEntradas
            // 
            this.btnEntradas.Caption = "Control de Entradas";
            this.btnEntradas.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEntradas.Glyph")));
            this.btnEntradas.Id = 1;
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnEntradas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEntradas_ItemClick);
            // 
            // btnSalidas
            // 
            this.btnSalidas.Caption = "Control de Salidas";
            this.btnSalidas.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSalidas.Glyph")));
            this.btnSalidas.Id = 2;
            this.btnSalidas.Name = "btnSalidas";
            this.btnSalidas.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSalidas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalidas_ItemClick);
            // 
            // btnEIR
            // 
            this.btnEIR.Caption = "Elaboración de EIR\'s";
            this.btnEIR.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEIR.Glyph")));
            this.btnEIR.Id = 3;
            this.btnEIR.Name = "btnEIR";
            this.btnEIR.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnEIR.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEIR_ItemClick);
            // 
            // btnClientes
            // 
            this.btnClientes.Caption = "Clientes";
            this.btnClientes.Glyph = ((System.Drawing.Image)(resources.GetObject("btnClientes.Glyph")));
            this.btnClientes.Id = 4;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnClientes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClientes_ItemClick);
            // 
            // btnTransporte
            // 
            this.btnTransporte.Caption = "Transportes";
            this.btnTransporte.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTransporte.Glyph")));
            this.btnTransporte.Id = 5;
            this.btnTransporte.Name = "btnTransporte";
            this.btnTransporte.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTransporte.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTransporte_ItemClick);
            // 
            // btnAgente
            // 
            this.btnAgente.Caption = "Agente Aduanal";
            this.btnAgente.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAgente.Glyph")));
            this.btnAgente.Id = 6;
            this.btnAgente.Name = "btnAgente";
            this.btnAgente.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnAgente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAgente_ItemClick);
            // 
            // btnEconomicos
            // 
            this.btnEconomicos.Caption = "Económicos";
            this.btnEconomicos.Glyph = global::ControlPatio.Properties.Resources._1446469364_truck;
            this.btnEconomicos.Id = 7;
            this.btnEconomicos.Name = "btnEconomicos";
            this.btnEconomicos.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnContenedores
            // 
            this.btnContenedores.Caption = "Tipo de Conentedores";
            this.btnContenedores.Glyph = ((System.Drawing.Image)(resources.GetObject("btnContenedores.Glyph")));
            this.btnContenedores.Id = 8;
            this.btnContenedores.Name = "btnContenedores";
            this.btnContenedores.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnNavieras
            // 
            this.btnNavieras.Caption = "Navieras";
            this.btnNavieras.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNavieras.Glyph")));
            this.btnNavieras.Id = 9;
            this.btnNavieras.Name = "btnNavieras";
            this.btnNavieras.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnBuque
            // 
            this.btnBuque.Caption = "Buques";
            this.btnBuque.Glyph = global::ControlPatio.Properties.Resources.normal_ian_symbol_freight_cargo_ship_1;
            this.btnBuque.Id = 10;
            this.btnBuque.Name = "btnBuque";
            this.btnBuque.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBuque.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBuque_ItemClick);
            // 
            // btnRepEntSal
            // 
            this.btnRepEntSal.Caption = "Entradas - Salidas";
            this.btnRepEntSal.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRepEntSal.Glyph")));
            this.btnRepEntSal.Id = 11;
            this.btnRepEntSal.Name = "btnRepEntSal";
            this.btnRepEntSal.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnRepEntSal.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRepEntSal_ItemClick);
            // 
            // btnRepAA
            // 
            this.btnRepAA.Caption = "Agente Aduanal";
            this.btnRepAA.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRepAA.Glyph")));
            this.btnRepAA.Id = 12;
            this.btnRepAA.Name = "btnRepAA";
            this.btnRepAA.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnRepCliente
            // 
            this.btnRepCliente.Caption = "Cliente";
            this.btnRepCliente.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRepCliente.Glyph")));
            this.btnRepCliente.Id = 13;
            this.btnRepCliente.Name = "btnRepCliente";
            this.btnRepCliente.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnRepTransporte
            // 
            this.btnRepTransporte.Caption = "Transporte";
            this.btnRepTransporte.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRepTransporte.Glyph")));
            this.btnRepTransporte.Id = 14;
            this.btnRepTransporte.Name = "btnRepTransporte";
            this.btnRepTransporte.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnRepManiobra
            // 
            this.btnRepManiobra.Caption = "Tipo Maniobra";
            this.btnRepManiobra.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRepManiobra.Glyph")));
            this.btnRepManiobra.Id = 15;
            this.btnRepManiobra.Name = "btnRepManiobra";
            this.btnRepManiobra.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnRepBuque
            // 
            this.btnRepBuque.Caption = "Buque";
            this.btnRepBuque.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRepBuque.Glyph")));
            this.btnRepBuque.Id = 16;
            this.btnRepBuque.Name = "btnRepBuque";
            this.btnRepBuque.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnRepBooking
            // 
            this.btnRepBooking.Caption = "Booking";
            this.btnRepBooking.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRepBooking.Glyph")));
            this.btnRepBooking.Id = 18;
            this.btnRepBooking.Name = "btnRepBooking";
            this.btnRepBooking.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Catálogos";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnClientes);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTransporte);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnAgente);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnEconomicos);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnContenedores);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNavieras);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBuque);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCalidad);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Operaciones";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEntradas);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSalidas);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnEIR);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Reportes";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnRepEntSal);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnRepAA);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnRepCliente);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnRepTransporte);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnRepManiobra);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnRepBuque);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnRepBooking);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 544);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(960, 23);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.Appearance.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabbedMdiManager1.Appearance.Options.UseFont = true;
            this.xtraTabbedMdiManager1.AppearancePage.Header.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabbedMdiManager1.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.BackColor = System.Drawing.SystemColors.HotTrack;
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // btnCalidad
            // 
            this.btnCalidad.Caption = "Calidad";
            this.btnCalidad.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCalidad.Glyph")));
            this.btnCalidad.Id = 19;
            this.btnCalidad.Name = "btnCalidad";
            this.btnCalidad.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnCalidad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCalidad_ItemClick);
            // 
            // FPrincipal
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 567);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FPrincipal";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Control Patio Maeda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FPrincipal_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem btnEntradas;
        private DevExpress.XtraBars.BarButtonItem btnSalidas;
        private DevExpress.XtraBars.BarButtonItem btnEIR;
        private DevExpress.XtraBars.BarButtonItem btnClientes;
        private DevExpress.XtraBars.BarButtonItem btnTransporte;
        private DevExpress.XtraBars.BarButtonItem btnAgente;
        private DevExpress.XtraBars.BarButtonItem btnEconomicos;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnContenedores;
        private DevExpress.XtraBars.BarButtonItem btnNavieras;
        private DevExpress.XtraBars.BarButtonItem btnBuque;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnRepEntSal;
        private DevExpress.XtraBars.BarButtonItem btnRepAA;
        private DevExpress.XtraBars.BarButtonItem btnRepCliente;
        private DevExpress.XtraBars.BarButtonItem btnRepTransporte;
        private DevExpress.XtraBars.BarButtonItem btnRepManiobra;
        private DevExpress.XtraBars.BarButtonItem btnRepBuque;
        private DevExpress.XtraBars.BarButtonItem btnRepBooking;
        private DevExpress.XtraBars.BarButtonItem btnCalidad;
    }
}