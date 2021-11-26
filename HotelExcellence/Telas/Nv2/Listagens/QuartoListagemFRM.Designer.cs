
namespace HotelExcellence.Telas
{
    partial class quartosFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quartosFRM));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.btnADD = new Guna.UI.WinForms.GunaButton();
            this.dtgQuartos = new Guna.UI.WinForms.GunaDataGridView();
            this.Icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Deletar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtgQuartoEclipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtPesquisa = new Bunifu.UI.WinForms.BunifuTextBox();
            this.ScrolBar = new Guna.UI.WinForms.GunaVScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.dtgQuartos)).BeginInit();
            this.SuspendLayout();
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
            this.btnADD.Location = new System.Drawing.Point(872, 503);
            this.btnADD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnADD.Name = "btnADD";
            this.btnADD.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(174)))), ((int)(((byte)(127)))));
            this.btnADD.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnADD.OnHoverForeColor = System.Drawing.Color.White;
            this.btnADD.OnHoverImage = null;
            this.btnADD.OnPressedColor = System.Drawing.Color.Black;
            this.btnADD.Radius = 3;
            this.btnADD.Size = new System.Drawing.Size(191, 37);
            this.btnADD.TabIndex = 2;
            this.btnADD.Text = "Adicionar";
            this.btnADD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // dtgQuartos
            // 
            this.dtgQuartos.AllowUserToAddRows = false;
            this.dtgQuartos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            this.dtgQuartos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgQuartos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgQuartos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgQuartos.BackgroundColor = System.Drawing.Color.White;
            this.dtgQuartos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgQuartos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgQuartos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgQuartos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgQuartos.ColumnHeadersHeight = 40;
            this.dtgQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgQuartos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Icon,
            this.Editar,
            this.Deletar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgQuartos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgQuartos.EnableHeadersVisualStyles = false;
            this.dtgQuartos.GridColor = System.Drawing.Color.White;
            this.dtgQuartos.Location = new System.Drawing.Point(16, 59);
            this.dtgQuartos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgQuartos.MultiSelect = false;
            this.dtgQuartos.Name = "dtgQuartos";
            this.dtgQuartos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgQuartos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgQuartos.RowHeadersVisible = false;
            this.dtgQuartos.RowHeadersWidth = 51;
            this.dtgQuartos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgQuartos.RowTemplate.Height = 30;
            this.dtgQuartos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgQuartos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgQuartos.Size = new System.Drawing.Size(1047, 437);
            this.dtgQuartos.StandardTab = true;
            this.dtgQuartos.TabIndex = 2;
            this.dtgQuartos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Green;
            this.dtgQuartos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Honeydew;
            this.dtgQuartos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgQuartos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgQuartos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgQuartos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgQuartos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgQuartos.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dtgQuartos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.dtgQuartos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgQuartos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgQuartos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgQuartos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgQuartos.ThemeStyle.HeaderStyle.Height = 40;
            this.dtgQuartos.ThemeStyle.ReadOnly = true;
            this.dtgQuartos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgQuartos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgQuartos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgQuartos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgQuartos.ThemeStyle.RowsStyle.Height = 30;
            this.dtgQuartos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.dtgQuartos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgQuartos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgQuartos_CellClick);
            this.dtgQuartos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgQuartos_CellContentClick);
            this.dtgQuartos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgQuartos_RowsAdded);
            this.dtgQuartos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgQuartos_RowsRemoved);
            this.dtgQuartos.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dtgQuartos_Scroll);
            // 
            // Icon
            // 
            this.Icon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Icon.FillWeight = 81.07022F;
            this.Icon.Frozen = true;
            this.Icon.HeaderText = "";
            this.Icon.Image = ((System.Drawing.Image)(resources.GetObject("Icon.Image")));
            this.Icon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Icon.MinimumWidth = 6;
            this.Icon.Name = "Icon";
            this.Icon.ReadOnly = true;
            this.Icon.Width = 30;
            // 
            // Editar
            // 
            this.Editar.FillWeight = 15.84476F;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Deletar
            // 
            this.Deletar.FillWeight = 17.40988F;
            this.Deletar.HeaderText = "Excluir";
            this.Deletar.Image = ((System.Drawing.Image)(resources.GetObject("Deletar.Image")));
            this.Deletar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Deletar.MinimumWidth = 6;
            this.Deletar.Name = "Deletar";
            this.Deletar.ReadOnly = true;
            // 
            // dtgQuartoEclipse
            // 
            this.dtgQuartoEclipse.ElipseRadius = 5;
            this.dtgQuartoEclipse.TargetControl = this.dtgQuartos;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 30F;
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::HotelExcellence.Properties.Resources.quarto;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 103;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 15F;
            this.dataGridViewImageColumn2.HeaderText = "Column2";
            this.dataGridViewImageColumn2.Image = global::HotelExcellence.Properties.Resources.deletar;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 344;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Editar";
            this.dataGridViewImageColumn3.Image = global::HotelExcellence.Properties.Resources.editar_lapis;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn3.Width = 6;
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
            this.txtPesquisa.Location = new System.Drawing.Point(35, 6);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtPesquisa.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesquisa.PasswordChar = '\0';
            this.txtPesquisa.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPesquisa.PlaceholderText = "Pesquisa";
            this.txtPesquisa.ReadOnly = false;
            this.txtPesquisa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.SelectionLength = 0;
            this.txtPesquisa.SelectionStart = 0;
            this.txtPesquisa.ShortcutsEnabled = true;
            this.txtPesquisa.Size = new System.Drawing.Size(1011, 46);
            this.txtPesquisa.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPesquisa.TextMarginBottom = 0;
            this.txtPesquisa.TextMarginLeft = 3;
            this.txtPesquisa.TextMarginTop = 0;
            this.txtPesquisa.TextPlaceholder = "Pesquisa";
            this.txtPesquisa.UseSystemPasswordChar = false;
            this.txtPesquisa.WordWrap = true;
            this.txtPesquisa.TextChange += new System.EventHandler(this.txtPesquisa_TextChange_1);
            // 
            // ScrolBar
            // 
            this.ScrolBar.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.ScrolBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrolBar.LargeChange = 10;
            this.ScrolBar.Location = new System.Drawing.Point(1071, 111);
            this.ScrolBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ScrolBar.Maximum = 100;
            this.ScrolBar.Name = "ScrolBar";
            this.ScrolBar.ScrollbarSize = 14;
            this.ScrolBar.ScrollIdleColor = System.Drawing.Color.Silver;
            this.ScrolBar.Size = new System.Drawing.Size(13, 385);
            this.ScrolBar.TabIndex = 1;
            this.ScrolBar.ThumbColor = System.Drawing.Color.DimGray;
            this.ScrolBar.ThumbHoverColor = System.Drawing.Color.Gray;
            this.ScrolBar.ThumbPressedColor = System.Drawing.Color.DarkGray;
            this.ScrolBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrolBar_Scroll);
            // 
            // quartosFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 554);
            this.Controls.Add(this.ScrolBar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dtgQuartos);
            this.Controls.Add(this.btnADD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "quartosFRM";
            this.Text = "quartosFRM";
            this.Load += new System.EventHandler(this.quartosFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgQuartos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaButton btnADD;
        private Guna.UI.WinForms.GunaDataGridView dtgQuartos;
        private Bunifu.Framework.UI.BunifuElipse dtgQuartoEclipse;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private Bunifu.UI.WinForms.BunifuTextBox txtPesquisa;
        private Guna.UI.WinForms.GunaVScrollBar ScrolBar;
        private System.Windows.Forms.DataGridViewImageColumn Icon;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Deletar;
    }
}