namespace Loundry
{
    partial class frmppal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmppal));
            this.menuppal = new System.Windows.Forms.MenuStrip();
            this.sistema = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacion = new System.Windows.Forms.ToolStripMenuItem();
            this.cajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.facturaciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.productos = new System.Windows.Forms.ToolStripMenuItem();
            this.rubrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.remitosFacturasDeProveedoresInventariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresa = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chequesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.movimientosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracion = new System.Windows.Forms.ToolStripMenuItem();
            this.creaUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reseteaUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.actualizaReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programador = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarGestorDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cambioDePasswordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónRegionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarConfiguraciónRegionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemFactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanas = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblusuario = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSSLusuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLserver = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLModo = new System.Windows.Forms.ToolStripStatusLabel();
            this.pgBgral = new System.Windows.Forms.ToolStripProgressBar();
            this.menuppal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuppal
            // 
            this.menuppal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistema,
            this.facturacion,
            this.productos,
            this.empresa,
            this.configuracion,
            this.programador,
            this.ventanas});
            this.menuppal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuppal.Location = new System.Drawing.Point(0, 0);
            this.menuppal.MdiWindowListItem = this.ventanas;
            this.menuppal.Name = "menuppal";
            this.menuppal.Size = new System.Drawing.Size(981, 23);
            this.menuppal.TabIndex = 0;
            this.menuppal.Text = "menuStrip1";
            this.menuppal.Visible = false;
            this.menuppal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuppal_ItemClicked);
            // 
            // sistema
            // 
            this.sistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.salirToolStripMenuItem});
            this.sistema.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.sistema.MergeIndex = 2;
            this.sistema.Name = "sistema";
            this.sistema.Size = new System.Drawing.Size(60, 19);
            this.sistema.Text = "Sistema";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItem1.Text = "Versión";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItem3.Text = "Backup/Restore";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // facturacion
            // 
            this.facturacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cajaToolStripMenuItem,
            this.toolStripSeparator4,
            this.facturaciónToolStripMenuItem1,
            this.toolStripMenuItem2});
            this.facturacion.Name = "facturacion";
            this.facturacion.Size = new System.Drawing.Size(81, 19);
            this.facturacion.Text = "Facturación";
            // 
            // cajaToolStripMenuItem
            // 
            this.cajaToolStripMenuItem.Name = "cajaToolStripMenuItem";
            this.cajaToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.cajaToolStripMenuItem.Text = "Caja";
            this.cajaToolStripMenuItem.ToolTipText = "Abre y Cierra las cajas de dinero";
            this.cajaToolStripMenuItem.Click += new System.EventHandler(this.cajaToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(244, 6);
            // 
            // facturaciónToolStripMenuItem1
            // 
            this.facturaciónToolStripMenuItem1.BackgroundImage = global::Loundry.Properties.Resources.transfiere2;
            this.facturaciónToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.facturaciónToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.facturaciónToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.facturaciónToolStripMenuItem1.Name = "facturaciónToolStripMenuItem1";
            this.facturaciónToolStripMenuItem1.Size = new System.Drawing.Size(247, 22);
            this.facturaciónToolStripMenuItem1.Text = "Facturar";
            this.facturaciónToolStripMenuItem1.ToolTipText = "Para Facturar debe estar abierta una caja";
            this.facturaciónToolStripMenuItem1.Click += new System.EventHandler(this.facturaciónToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(247, 22);
            this.toolStripMenuItem2.Text = "Consulta Documentos en la AFIP";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // productos
            // 
            this.productos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rubrosToolStripMenuItem,
            this.productosDeVentaToolStripMenuItem,
            this.toolStripSeparator1,
            this.proveedoresToolStripMenuItem,
            this.toolStripSeparator2,
            this.remitosFacturasDeProveedoresInventariosToolStripMenuItem});
            this.productos.Name = "productos";
            this.productos.Size = new System.Drawing.Size(73, 19);
            this.productos.Text = "Productos";
            // 
            // rubrosToolStripMenuItem
            // 
            this.rubrosToolStripMenuItem.Name = "rubrosToolStripMenuItem";
            this.rubrosToolStripMenuItem.Size = new System.Drawing.Size(325, 22);
            this.rubrosToolStripMenuItem.Text = "Rubros";
            this.rubrosToolStripMenuItem.Click += new System.EventHandler(this.rubrosToolStripMenuItem_Click);
            // 
            // productosDeVentaToolStripMenuItem
            // 
            this.productosDeVentaToolStripMenuItem.Name = "productosDeVentaToolStripMenuItem";
            this.productosDeVentaToolStripMenuItem.Size = new System.Drawing.Size(325, 22);
            this.productosDeVentaToolStripMenuItem.Text = "Productos de venta";
            this.productosDeVentaToolStripMenuItem.ToolTipText = "Se deben tener cargado el o los rubros primero";
            this.productosDeVentaToolStripMenuItem.Click += new System.EventHandler(this.productosDeVentaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(322, 6);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(325, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(322, 6);
            // 
            // remitosFacturasDeProveedoresInventariosToolStripMenuItem
            // 
            this.remitosFacturasDeProveedoresInventariosToolStripMenuItem.Name = "remitosFacturasDeProveedoresInventariosToolStripMenuItem";
            this.remitosFacturasDeProveedoresInventariosToolStripMenuItem.Size = new System.Drawing.Size(325, 22);
            this.remitosFacturasDeProveedoresInventariosToolStripMenuItem.Text = "Remitos / Facturas de proveedores - Inventarios";
            this.remitosFacturasDeProveedoresInventariosToolStripMenuItem.ToolTipText = "Se debe tener cargado el Producto y los Proveedores";
            this.remitosFacturasDeProveedoresInventariosToolStripMenuItem.Click += new System.EventHandler(this.remitosFacturasDeProveedoresInventariosToolStripMenuItem_Click);
            // 
            // empresa
            // 
            this.empresa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.negocioToolStripMenuItem,
            this.toolStripSeparator6,
            this.clientesToolStripMenuItem,
            this.chequesToolStripMenuItem,
            this.toolStripSeparator7,
            this.movimientosToolStripMenuItem1});
            this.empresa.Name = "empresa";
            this.empresa.Size = new System.Drawing.Size(64, 19);
            this.empresa.Text = "Empresa";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.ToolTipText = "Carga los empleados de la empresa";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // negocioToolStripMenuItem
            // 
            this.negocioToolStripMenuItem.Name = "negocioToolStripMenuItem";
            this.negocioToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.negocioToolStripMenuItem.Text = "Negocio";
            this.negocioToolStripMenuItem.Click += new System.EventHandler(this.negocioToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(141, 6);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // chequesToolStripMenuItem
            // 
            this.chequesToolStripMenuItem.Name = "chequesToolStripMenuItem";
            this.chequesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.chequesToolStripMenuItem.Text = "Cheques";
            this.chequesToolStripMenuItem.Click += new System.EventHandler(this.chequesToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(141, 6);
            // 
            // movimientosToolStripMenuItem1
            // 
            this.movimientosToolStripMenuItem1.Name = "movimientosToolStripMenuItem1";
            this.movimientosToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.movimientosToolStripMenuItem1.Text = "Movimientos";
            this.movimientosToolStripMenuItem1.Click += new System.EventHandler(this.movimientosToolStripMenuItem1_Click);
            // 
            // configuracion
            // 
            this.configuracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creaUsuarioToolStripMenuItem,
            this.reseteaUsuarioToolStripMenuItem,
            this.toolStripSeparator3,
            this.actualizaReportesToolStripMenuItem});
            this.configuracion.Name = "configuracion";
            this.configuracion.Size = new System.Drawing.Size(95, 19);
            this.configuracion.Text = "Configuración";
            // 
            // creaUsuarioToolStripMenuItem
            // 
            this.creaUsuarioToolStripMenuItem.Name = "creaUsuarioToolStripMenuItem";
            this.creaUsuarioToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.creaUsuarioToolStripMenuItem.Text = "Crea Usuario";
            this.creaUsuarioToolStripMenuItem.ToolTipText = "Permite crear un usuario para el uso del sistema";
            this.creaUsuarioToolStripMenuItem.Click += new System.EventHandler(this.creaUsuarioToolStripMenuItem_Click);
            // 
            // reseteaUsuarioToolStripMenuItem
            // 
            this.reseteaUsuarioToolStripMenuItem.Name = "reseteaUsuarioToolStripMenuItem";
            this.reseteaUsuarioToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.reseteaUsuarioToolStripMenuItem.Text = "Resetea Usuario";
            this.reseteaUsuarioToolStripMenuItem.ToolTipText = "Permite resetear la clave de cualquier usuario";
            this.reseteaUsuarioToolStripMenuItem.Click += new System.EventHandler(this.reseteaUsuarioToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(168, 6);
            // 
            // actualizaReportesToolStripMenuItem
            // 
            this.actualizaReportesToolStripMenuItem.Name = "actualizaReportesToolStripMenuItem";
            this.actualizaReportesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.actualizaReportesToolStripMenuItem.Text = "Actualiza Reportes";
            this.actualizaReportesToolStripMenuItem.Click += new System.EventHandler(this.actualizaReportesToolStripMenuItem_Click);
            // 
            // programador
            // 
            this.programador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarGestorDeDatosToolStripMenuItem,
            this.toolStripSeparator5,
            this.cambioDePasswordToolStripMenuItem1,
            this.configuraciónRegionalToolStripMenuItem,
            this.cambiarConfiguraciónRegionalToolStripMenuItem,
            this.qrToolStripMenuItem,
            this.ejemFactToolStripMenuItem});
            this.programador.Name = "programador";
            this.programador.Size = new System.Drawing.Size(89, 19);
            this.programador.Text = "Programador";
            // 
            // configurarGestorDeDatosToolStripMenuItem
            // 
            this.configurarGestorDeDatosToolStripMenuItem.Name = "configurarGestorDeDatosToolStripMenuItem";
            this.configurarGestorDeDatosToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.configurarGestorDeDatosToolStripMenuItem.Text = "Configurar gestor de datos";
            this.configurarGestorDeDatosToolStripMenuItem.Click += new System.EventHandler(this.configurarGestorDeDatosToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(244, 6);
            // 
            // cambioDePasswordToolStripMenuItem1
            // 
            this.cambioDePasswordToolStripMenuItem1.Name = "cambioDePasswordToolStripMenuItem1";
            this.cambioDePasswordToolStripMenuItem1.Size = new System.Drawing.Size(247, 22);
            this.cambioDePasswordToolStripMenuItem1.Text = "Cambio de Password";
            this.cambioDePasswordToolStripMenuItem1.Click += new System.EventHandler(this.cambioDePasswordToolStripMenuItem1_Click);
            // 
            // configuraciónRegionalToolStripMenuItem
            // 
            this.configuraciónRegionalToolStripMenuItem.Name = "configuraciónRegionalToolStripMenuItem";
            this.configuraciónRegionalToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.configuraciónRegionalToolStripMenuItem.Text = "Configuración Regional";
            this.configuraciónRegionalToolStripMenuItem.Click += new System.EventHandler(this.configuraciónRegionalToolStripMenuItem_Click);
            // 
            // cambiarConfiguraciónRegionalToolStripMenuItem
            // 
            this.cambiarConfiguraciónRegionalToolStripMenuItem.Name = "cambiarConfiguraciónRegionalToolStripMenuItem";
            this.cambiarConfiguraciónRegionalToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.cambiarConfiguraciónRegionalToolStripMenuItem.Text = "Cambiar Configuración Regional";
            this.cambiarConfiguraciónRegionalToolStripMenuItem.Click += new System.EventHandler(this.cambiarConfiguraciónRegionalToolStripMenuItem_Click);
            // 
            // qrToolStripMenuItem
            // 
            this.qrToolStripMenuItem.Name = "qrToolStripMenuItem";
            this.qrToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.qrToolStripMenuItem.Text = "Qr";
            this.qrToolStripMenuItem.Click += new System.EventHandler(this.qrToolStripMenuItem_Click);
            // 
            // ejemFactToolStripMenuItem
            // 
            this.ejemFactToolStripMenuItem.Name = "ejemFactToolStripMenuItem";
            this.ejemFactToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.ejemFactToolStripMenuItem.Text = "EjemFact";
            this.ejemFactToolStripMenuItem.Click += new System.EventHandler(this.ejemFactToolStripMenuItem_Click);
            // 
            // ventanas
            // 
            this.ventanas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadaToolStripMenuItem});
            this.ventanas.Name = "ventanas";
            this.ventanas.Size = new System.Drawing.Size(66, 19);
            this.ventanas.Text = "Ventanas";
            // 
            // cascadaToolStripMenuItem
            // 
            this.cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            this.cascadaToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.cascadaToolStripMenuItem.Text = "Cascada";
            this.cascadaToolStripMenuItem.Click += new System.EventHandler(this.cascadaToolStripMenuItem_Click);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(12, 37);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(16, 13);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "...";
            this.lblusuario.Visible = false;
            this.lblusuario.TextChanged += new System.EventHandler(this.lblusuario_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSLusuario,
            this.tSSLserver,
            this.tSSLDatabase,
            this.tSSLVersion,
            this.tSSLModo,
            this.pgBgral});
            this.statusStrip1.Location = new System.Drawing.Point(0, 415);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(981, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            this.statusStrip1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.statusStrip1_MouseDoubleClick);
            // 
            // tSSLusuario
            // 
            this.tSSLusuario.Name = "tSSLusuario";
            this.tSSLusuario.Size = new System.Drawing.Size(56, 17);
            this.tSSLusuario.Text = "USUARIO";
            // 
            // tSSLserver
            // 
            this.tSSLserver.Name = "tSSLserver";
            this.tSSLserver.Size = new System.Drawing.Size(46, 17);
            this.tSSLserver.Text = "SERVER";
            // 
            // tSSLDatabase
            // 
            this.tSSLDatabase.Name = "tSSLDatabase";
            this.tSSLDatabase.Size = new System.Drawing.Size(63, 17);
            this.tSSLDatabase.Text = "DATABASE";
            // 
            // tSSLVersion
            // 
            this.tSSLVersion.Name = "tSSLVersion";
            this.tSSLVersion.Size = new System.Drawing.Size(45, 17);
            this.tSSLVersion.Text = "Versión";
            // 
            // tSSLModo
            // 
            this.tSSLModo.Name = "tSSLModo";
            this.tSSLModo.Size = new System.Drawing.Size(39, 17);
            this.tSSLModo.Text = "Modo";
            // 
            // pgBgral
            // 
            this.pgBgral.Name = "pgBgral";
            this.pgBgral.Size = new System.Drawing.Size(100, 16);
            this.pgBgral.Visible = false;
            // 
            // frmppal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loundry.Properties.Resources.frenteLava;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(981, 437);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.menuppal);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuppal;
            this.Name = "frmppal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loundry Esparza 92";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmppal_Activated);
            this.Deactivate += new System.EventHandler(this.frmppal_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmppal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmppal_FormClosed);
            this.Load += new System.EventHandler(this.frmppal_Load);
            this.menuppal.ResumeLayout(false);
            this.menuppal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuppal;
        private System.Windows.Forms.ToolStripMenuItem sistema;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacion;
        private System.Windows.Forms.ToolStripMenuItem cajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventanas;
        private System.Windows.Forms.ToolStripMenuItem cascadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productos;
        private System.Windows.Forms.ToolStripMenuItem productosDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remitosFacturasDeProveedoresInventariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rubrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.ToolStripMenuItem configuracion;
        private System.Windows.Forms.ToolStripMenuItem creaUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reseteaUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem programador;
        private System.Windows.Forms.ToolStripMenuItem configurarGestorDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioDePasswordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem empresa;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónRegionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarConfiguraciónRegionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem chequesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSSLusuario;
        private System.Windows.Forms.ToolStripStatusLabel tSSLserver;
        private System.Windows.Forms.ToolStripStatusLabel tSSLDatabase;
        private System.Windows.Forms.ToolStripStatusLabel tSSLVersion;
        private System.Windows.Forms.ToolStripStatusLabel tSSLModo;
        private System.Windows.Forms.ToolStripProgressBar pgBgral;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem actualizaReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemFactToolStripMenuItem;
    }
}

