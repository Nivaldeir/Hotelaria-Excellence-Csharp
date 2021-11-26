
namespace HotelExcellence.Telas.Nv2.listagem
{
    partial class estoqueFRM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(estoqueFRM));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dtgEstoque = new Guna.UI.WinForms.GunaDataGridView();
            this.Icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.Status = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Deletar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtPesquisa = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnADD = new Guna.UI.WinForms.GunaButton();
            this.btnEntrada = new Guna.UI.WinForms.GunaButton();
            this.ScrolBar = new Guna.UI.WinForms.GunaVScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.dtgEstoque;
            // 
            // dtgEstoque
            // 
            this.dtgEstoque.AllowUserToAddRows = false;
            this.dtgEstoque.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            this.dtgEstoque.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEstoque.BackgroundColor = System.Drawing.Color.White;
            this.dtgEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgEstoque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgEstoque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgEstoque.ColumnHeadersHeight = 40;
            this.dtgEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Icon,
            this.Status,
            this.Editar,
            this.Deletar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgEstoque.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgEstoque.EnableHeadersVisualStyles = false;
            this.dtgEstoque.GridColor = System.Drawing.Color.White;
            this.dtgEstoque.Location = new System.Drawing.Point(11, 48);
            this.dtgEstoque.MultiSelect = false;
            this.dtgEstoque.Name = "dtgEstoque";
            this.dtgEstoque.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEstoque.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgEstoque.RowHeadersVisible = false;
            this.dtgEstoque.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgEstoque.RowTemplate.Height = 30;
            this.dtgEstoque.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEstoque.Size = new System.Drawing.Size(785, 355);
            this.dtgEstoque.StandardTab = true;
            this.dtgEstoque.TabIndex = 18;
            this.dtgEstoque.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Green;
            this.dtgEstoque.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Honeydew;
            this.dtgEstoque.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgEstoque.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgEstoque.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgEstoque.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgEstoque.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgEstoque.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dtgEstoque.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.dtgEstoque.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgEstoque.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgEstoque.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgEstoque.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgEstoque.ThemeStyle.HeaderStyle.Height = 40;
            this.dtgEstoque.ThemeStyle.ReadOnly = true;
            this.dtgEstoque.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgEstoque.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgEstoque.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgEstoque.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgEstoque.ThemeStyle.RowsStyle.Height = 30;
            this.dtgEstoque.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.dtgEstoque.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgEstoque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgQuartos_CellClick);
            this.dtgEstoque.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgEstoque_ColumnHeaderMouseClick);
            this.dtgEstoque.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgEstoque_RowsAdded);
            this.dtgEstoque.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgEstoque_RowsRemoved);
            this.dtgEstoque.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dtgEstoque_Scroll);
            // 
            // Icon
            // 
            this.Icon.FillWeight = 90.82655F;
            this.Icon.HeaderText = "";
            this.Icon.Image = ((System.Drawing.Image)(resources.GetObject("Icon.Image")));
            this.Icon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Icon.Name = "Icon";
            this.Icon.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.FillWeight = 54.39717F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Editar
            // 
            this.Editar.FillWeight = 33.83131F;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Deletar
            // 
            this.Deletar.FillWeight = 35.26983F;
            this.Deletar.HeaderText = "Excluir";
            this.Deletar.Image = ((System.Drawing.Image)(resources.GetObject("Deletar.Image")));
            this.Deletar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Deletar.Name = "Deletar";
            this.Deletar.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 44.32486F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::HotelExcellence.Properties.Resources.produto_DTG;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 231;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.FillWeight = 44.32486F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::HotelExcellence.Properties.Resources.editar_lapis;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn3.FillWeight = 44.32486F;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::HotelExcellence.Properties.Resources.deletar_color;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.AcceptsReturn = false;
            this.txtPesquisa.AcceptsTab = false;
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.AnimationSpeed = 100;
            this.txtPesquisa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPesquisa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPesquisa.BackColor = System.Drawing.Color.White;
            this.txtPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPesquisa.BackgroundImage")));
            this.txtPesquisa.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(111)))), ((int)(((byte)(70)))));
            this.txtPesquisa.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPesquisa.BorderColorHover = System.Drawing.Color.Empty;
            this.txtPesquisa.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPesquisa.BorderRadius = 8;
            this.txtPesquisa.BorderThickness = 1;
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPesquisa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisa.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtPesquisa.DefaultText = "";
            this.txtPesquisa.FillColor = System.Drawing.Color.White;
            this.txtPesquisa.HideSelection = true;
            this.txtPesquisa.IconLeft = null;
            this.txtPesquisa.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisa.IconPadding = 6;
            this.txtPesquisa.IconRight = global::HotelExcellence.Properties.Resources.search;
            this.txtPesquisa.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisa.Lines = new string[0];
            this.txtPesquisa.Location = new System.Drawing.Point(35, 5);
            this.txtPesquisa.MaxLength = 32767;
            this.txtPesquisa.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPesquisa.Modified = false;
            this.txtPesquisa.Multiline = false;
            this.txtPesquisa.Name = "txtPesquisa";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(111)))), ((int)(((byte)(70)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPesquisa.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPesquisa.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Empty;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPesquisa.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPesquisa.OnIdleState = stateProperties4;
            this.txtPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.txtPesquisa.PasswordChar = '\0';
            this.txtPesquisa.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPesquisa.PlaceholderText = "Pesquisa";
            this.txtPesquisa.ReadOnly = false;
            this.txtPesquisa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.SelectionLength = 0;
            this.txtPesquisa.SelectionStart = 0;
            this.txtPesquisa.ShortcutsEnabled = true;
            this.txtPesquisa.Size = new System.Drawing.Size(746, 37);
            this.txtPesquisa.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtPesquisa.TabIndex = 17;
            this.txtPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPesquisa.TextMarginBottom = 0;
            this.txtPesquisa.TextMarginLeft = 3;
            this.txtPesquisa.TextMarginTop = 0;
            this.txtPesquisa.TextPlaceholder = "Pesquisa";
            this.txtPesquisa.UseSystemPasswordChar = false;
            this.txtPesquisa.WordWrap = true;
            this.txtPesquisa.TextChange += new System.EventHandler(this.txtPesquisa_TextChange);
            // 
            // btnADD
            // 
            this.btnADD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnADD.AnimationHoverSpeed = 0.1F;
            this.btnADD.AnimationSpeed = 0.1F;
            this.btnADD.BackColor = System.Drawing.Color.Transparent;
            this.btnADD.BaseColor = System.Drawing.Color.White;
            this.btnADD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(111)))), ((int)(((byte)(70)))));
            this.btnADD.BorderSize = 1;
            this.btnADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnADD.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnADD.FocusedColor = System.Drawing.Color.Empty;
            this.btnADD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(111)))), ((int)(((byte)(70)))));
            this.btnADD.Image = null;
            this.btnADD.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnADD.ImageSize = new System.Drawing.Size(20, 20);
            this.btnADD.Location = new System.Drawing.Point(653, 411);
            this.btnADD.Name = "btnADD";
            this.btnADD.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(174)))), ((int)(((byte)(127)))));
            this.btnADD.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.btnADD.OnHoverForeColor = System.Drawing.Color.White;
            this.btnADD.OnHoverImage = null;
            this.btnADD.OnPressedColor = System.Drawing.Color.Black;
            this.btnADD.Radius = 3;
            this.btnADD.Size = new System.Drawing.Size(143, 30);
            this.btnADD.TabIndex = 19;
            this.btnADD.Text = "Adicionar";
            this.btnADD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEntrada.AnimationHoverSpeed = 0.1F;
            this.btnEntrada.AnimationSpeed = 0.1F;
            this.btnEntrada.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrada.BaseColor = System.Drawing.Color.White;
            this.btnEntrada.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(111)))), ((int)(((byte)(70)))));
            this.btnEntrada.BorderSize = 1;
            this.btnEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrada.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEntrada.FocusedColor = System.Drawing.Color.Empty;
            this.btnEntrada.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(111)))), ((int)(((byte)(70)))));
            this.btnEntrada.Image = null;
            this.btnEntrada.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEntrada.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEntrada.Location = new System.Drawing.Point(11, 411);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(174)))), ((int)(((byte)(127)))));
            this.btnEntrada.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.btnEntrada.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEntrada.OnHoverImage = null;
            this.btnEntrada.OnPressedColor = System.Drawing.Color.Black;
            this.btnEntrada.Radius = 3;
            this.btnEntrada.Size = new System.Drawing.Size(157, 30);
            this.btnEntrada.TabIndex = 19;
            this.btnEntrada.Text = "Entrada de produto";
            this.btnEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // ScrolBar
            // 
            this.ScrolBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrolBar.LargeChange = 10;
            this.ScrolBar.Location = new System.Drawing.Point(804, 87);
            this.ScrolBar.Maximum = 100;
            this.ScrolBar.Name = "ScrolBar";
            this.ScrolBar.ScrollIdleColor = System.Drawing.Color.Silver;
            this.ScrolBar.Size = new System.Drawing.Size(10, 316);
            this.ScrolBar.TabIndex = 20;
            this.ScrolBar.ThumbColor = System.Drawing.Color.DimGray;
            this.ScrolBar.ThumbHoverColor = System.Drawing.Color.Gray;
            this.ScrolBar.ThumbPressedColor = System.Drawing.Color.DarkGray;
            this.ScrolBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrolBar_Scroll);
            // 
            // estoqueFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.ScrolBar);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.dtgEstoque);
            this.Controls.Add(this.txtPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "estoqueFRM";
            this.Text = "estoqueFRM";
            this.Load += new System.EventHandler(this.estoqueFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox txtPesquisa;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private Guna.UI.WinForms.GunaDataGridView dtgEstoque;
        private System.Windows.Forms.DataGridViewImageColumn Icon;
        private System.Windows.Forms.DataGridViewImageColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Deletar;
        private Guna.UI.WinForms.GunaButton btnADD;
        private Guna.UI.WinForms.GunaButton btnEntrada;
        private Guna.UI.WinForms.GunaVScrollBar ScrolBar;
    }
}