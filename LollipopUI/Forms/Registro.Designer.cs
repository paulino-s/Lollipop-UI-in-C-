namespace CProyect
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.usuariosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBVentasDataSet = new CProyect.DBVentasDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.usuariosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txt_user = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_contra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_nombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_apellido = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_telefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_pais = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_ciudad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_postal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_direccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_tarjeta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.usuariosTableAdapter = new CProyect.DBVentasDataSetTableAdapters.UsuariosTableAdapter();
            this.tableAdapterManager = new CProyect.DBVentasDataSetTableAdapters.TableAdapterManager();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_contrarep = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingNavigator)).BeginInit();
            this.usuariosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBVentasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // usuariosBindingNavigator
            // 
            this.usuariosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.usuariosBindingNavigator.BindingSource = this.usuariosBindingSource;
            this.usuariosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usuariosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.usuariosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.usuariosBindingNavigatorSaveItem});
            this.usuariosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usuariosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.usuariosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.usuariosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usuariosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usuariosBindingNavigator.Name = "usuariosBindingNavigator";
            this.usuariosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.usuariosBindingNavigator.Size = new System.Drawing.Size(538, 25);
            this.usuariosBindingNavigator.TabIndex = 0;
            this.usuariosBindingNavigator.Text = "bindingNavigator1";
            this.usuariosBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.dBVentasDataSet;
            // 
            // dBVentasDataSet
            // 
            this.dBVentasDataSet.DataSetName = "DBVentasDataSet";
            this.dBVentasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // usuariosBindingNavigatorSaveItem
            // 
            this.usuariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usuariosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosBindingNavigatorSaveItem.Image")));
            this.usuariosBindingNavigatorSaveItem.Name = "usuariosBindingNavigatorSaveItem";
            this.usuariosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.usuariosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.usuariosBindingNavigatorSaveItem.Click += new System.EventHandler(this.usuariosBindingNavigatorSaveItem_Click);
            // 
            // txt_user
            // 
            this.txt_user.Depth = 0;
            this.txt_user.Hint = "";
            this.txt_user.Location = new System.Drawing.Point(212, 96);
            this.txt_user.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_user.Name = "txt_user";
            this.txt_user.PasswordChar = '\0';
            this.txt_user.SelectedText = "";
            this.txt_user.SelectionLength = 0;
            this.txt_user.SelectionStart = 0;
            this.txt_user.Size = new System.Drawing.Size(425, 23);
            this.txt_user.TabIndex = 0;
            this.txt_user.UseSystemPasswordChar = false;
            // 
            // txt_contra
            // 
            this.txt_contra.Depth = 0;
            this.txt_contra.Hint = "";
            this.txt_contra.Location = new System.Drawing.Point(212, 133);
            this.txt_contra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.PasswordChar = '\0';
            this.txt_contra.SelectedText = "";
            this.txt_contra.SelectionLength = 0;
            this.txt_contra.SelectionStart = 0;
            this.txt_contra.Size = new System.Drawing.Size(425, 23);
            this.txt_contra.TabIndex = 1;
            this.txt_contra.UseSystemPasswordChar = true;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Depth = 0;
            this.txt_nombre.Hint = "";
            this.txt_nombre.Location = new System.Drawing.Point(212, 207);
            this.txt_nombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PasswordChar = '\0';
            this.txt_nombre.SelectedText = "";
            this.txt_nombre.SelectionLength = 0;
            this.txt_nombre.SelectionStart = 0;
            this.txt_nombre.Size = new System.Drawing.Size(425, 23);
            this.txt_nombre.TabIndex = 3;
            this.txt_nombre.UseSystemPasswordChar = false;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Depth = 0;
            this.txt_apellido.Hint = "";
            this.txt_apellido.Location = new System.Drawing.Point(212, 244);
            this.txt_apellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.PasswordChar = '\0';
            this.txt_apellido.SelectedText = "";
            this.txt_apellido.SelectionLength = 0;
            this.txt_apellido.SelectionStart = 0;
            this.txt_apellido.Size = new System.Drawing.Size(425, 23);
            this.txt_apellido.TabIndex = 4;
            this.txt_apellido.UseSystemPasswordChar = false;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Depth = 0;
            this.txt_telefono.Hint = "";
            this.txt_telefono.Location = new System.Drawing.Point(212, 281);
            this.txt_telefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.PasswordChar = '\0';
            this.txt_telefono.SelectedText = "";
            this.txt_telefono.SelectionLength = 0;
            this.txt_telefono.SelectionStart = 0;
            this.txt_telefono.Size = new System.Drawing.Size(425, 23);
            this.txt_telefono.TabIndex = 5;
            this.txt_telefono.UseSystemPasswordChar = false;
            // 
            // txt_pais
            // 
            this.txt_pais.Depth = 0;
            this.txt_pais.Hint = "";
            this.txt_pais.Location = new System.Drawing.Point(212, 318);
            this.txt_pais.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.PasswordChar = '\0';
            this.txt_pais.SelectedText = "";
            this.txt_pais.SelectionLength = 0;
            this.txt_pais.SelectionStart = 0;
            this.txt_pais.Size = new System.Drawing.Size(425, 23);
            this.txt_pais.TabIndex = 6;
            this.txt_pais.UseSystemPasswordChar = false;
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Depth = 0;
            this.txt_ciudad.Hint = "";
            this.txt_ciudad.Location = new System.Drawing.Point(212, 355);
            this.txt_ciudad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.PasswordChar = '\0';
            this.txt_ciudad.SelectedText = "";
            this.txt_ciudad.SelectionLength = 0;
            this.txt_ciudad.SelectionStart = 0;
            this.txt_ciudad.Size = new System.Drawing.Size(425, 23);
            this.txt_ciudad.TabIndex = 7;
            this.txt_ciudad.UseSystemPasswordChar = false;
            // 
            // txt_postal
            // 
            this.txt_postal.Depth = 0;
            this.txt_postal.Hint = "";
            this.txt_postal.Location = new System.Drawing.Point(212, 392);
            this.txt_postal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_postal.Name = "txt_postal";
            this.txt_postal.PasswordChar = '\0';
            this.txt_postal.SelectedText = "";
            this.txt_postal.SelectionLength = 0;
            this.txt_postal.SelectionStart = 0;
            this.txt_postal.Size = new System.Drawing.Size(425, 23);
            this.txt_postal.TabIndex = 8;
            this.txt_postal.UseSystemPasswordChar = false;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Depth = 0;
            this.txt_direccion.Hint = "";
            this.txt_direccion.Location = new System.Drawing.Point(212, 429);
            this.txt_direccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.PasswordChar = '\0';
            this.txt_direccion.SelectedText = "";
            this.txt_direccion.SelectionLength = 0;
            this.txt_direccion.SelectionStart = 0;
            this.txt_direccion.Size = new System.Drawing.Size(425, 23);
            this.txt_direccion.TabIndex = 9;
            this.txt_direccion.UseSystemPasswordChar = false;
            // 
            // txt_tarjeta
            // 
            this.txt_tarjeta.Depth = 0;
            this.txt_tarjeta.Hint = "";
            this.txt_tarjeta.Location = new System.Drawing.Point(212, 466);
            this.txt_tarjeta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_tarjeta.Name = "txt_tarjeta";
            this.txt_tarjeta.PasswordChar = '\0';
            this.txt_tarjeta.SelectedText = "";
            this.txt_tarjeta.SelectionLength = 0;
            this.txt_tarjeta.SelectionStart = 0;
            this.txt_tarjeta.Size = new System.Drawing.Size(425, 23);
            this.txt_tarjeta.TabIndex = 10;
            this.txt_tarjeta.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(43, 100);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Usuario";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(43, 137);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(86, 19);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "Contraseña";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(43, 211);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(71, 19);
            this.materialLabel3.TabIndex = 16;
            this.materialLabel3.Text = "Nombres";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(43, 248);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(72, 19);
            this.materialLabel4.TabIndex = 17;
            this.materialLabel4.Text = "Apellidos";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(43, 285);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(110, 19);
            this.materialLabel5.TabIndex = 18;
            this.materialLabel5.Text = "N° de Telefono";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(43, 322);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(38, 19);
            this.materialLabel6.TabIndex = 19;
            this.materialLabel6.Text = "Pais";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(43, 359);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(55, 19);
            this.materialLabel7.TabIndex = 20;
            this.materialLabel7.Text = "Ciudad";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(43, 396);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(104, 19);
            this.materialLabel8.TabIndex = 21;
            this.materialLabel8.Text = "Codigo Postal";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(43, 433);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(73, 19);
            this.materialLabel9.TabIndex = 22;
            this.materialLabel9.Text = "Direccion";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(43, 470);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(97, 19);
            this.materialLabel10.TabIndex = 23;
            this.materialLabel10.Text = "N° de Tarjeta";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(198, 522);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(106, 42);
            this.materialRaisedButton1.TabIndex = 11;
            this.materialRaisedButton1.Text = "Registrarse";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.materialRaisedButton2.Location = new System.Drawing.Point(376, 522);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(106, 42);
            this.materialRaisedButton2.TabIndex = 12;
            this.materialRaisedButton2.Text = "Salir";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = CProyect.DBVentasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(43, 174);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(137, 19);
            this.materialLabel11.TabIndex = 15;
            this.materialLabel11.Text = "Repetir Contraseña";
            // 
            // txt_contrarep
            // 
            this.txt_contrarep.Depth = 0;
            this.txt_contrarep.Hint = "";
            this.txt_contrarep.Location = new System.Drawing.Point(212, 170);
            this.txt_contrarep.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_contrarep.Name = "txt_contrarep";
            this.txt_contrarep.PasswordChar = '\0';
            this.txt_contrarep.SelectedText = "";
            this.txt_contrarep.SelectionLength = 0;
            this.txt_contrarep.SelectionStart = 0;
            this.txt_contrarep.Size = new System.Drawing.Size(425, 23);
            this.txt_contrarep.TabIndex = 2;
            this.txt_contrarep.UseSystemPasswordChar = true;
            // 
            // Registro
            // 
            this.AcceptButton = this.materialRaisedButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.materialRaisedButton2;
            this.ClientSize = new System.Drawing.Size(681, 586);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.txt_contrarep);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txt_tarjeta);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_postal);
            this.Controls.Add(this.txt_ciudad);
            this.Controls.Add(this.txt_pais);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_contra);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.usuariosBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Registro";
            this.ShowInTaskbar = false;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingNavigator)).EndInit();
            this.usuariosBindingNavigator.ResumeLayout(false);
            this.usuariosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBVentasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBVentasDataSet dBVentasDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DBVentasDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private DBVentasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usuariosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton usuariosBindingNavigatorSaveItem;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_user;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_contra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_nombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_apellido;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_telefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_pais;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_ciudad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_postal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_direccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_tarjeta;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_contrarep;
    }
}