
namespace HotelExcellence.Telas.Nv3.listagem
{
    partial class listCargoFRM3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listCargoFRM3));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPesquisa = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuVScrollBar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.dtgCargos = new Guna.UI.WinForms.GunaDataGridView();
            this.Icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Deletar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCargos)).BeginInit();
            this.SuspendLayout();
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
            this.txtPesquisa.Location = new System.Drawing.Point(24, 9);
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
            this.txtPesquisa.Size = new System.Drawing.Size(748, 37);
            this.txtPesquisa.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtPesquisa.TabIndex = 13;
            this.txtPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPesquisa.TextMarginBottom = 0;
            this.txtPesquisa.TextMarginLeft = 3;
            this.txtPesquisa.TextMarginTop = 0;
            this.txtPesquisa.TextPlaceholder = "Pesquisa";
            this.txtPesquisa.UseSystemPasswordChar = false;
            this.txtPesquisa.WordWrap = true;
            // 
            // bunifuVScrollBar1
            // 
            this.bunifuVScrollBar1.AllowCursorChanges = true;
            this.bunifuVScrollBar1.AllowHomeEndKeysDetection = false;
            this.bunifuVScrollBar1.AllowIncrementalClickMoves = true;
            this.bunifuVScrollBar1.AllowMouseDownEffects = true;
            this.bunifuVScrollBar1.AllowMouseHoverEffects = true;
            this.bunifuVScrollBar1.AllowScrollingAnimations = true;
            this.bunifuVScrollBar1.AllowScrollKeysDetection = true;
            this.bunifuVScrollBar1.AllowScrollOptionsMenu = true;
            this.bunifuVScrollBar1.AllowShrinkingOnFocusLost = false;
            this.bunifuVScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuVScrollBar1.BackgroundColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuVScrollBar1.BackgroundImage")));
            this.bunifuVScrollBar1.BindingContainer = null;
            this.bunifuVScrollBar1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.BorderRadius = 14;
            this.bunifuVScrollBar1.BorderThickness = 1;
            this.bunifuVScrollBar1.DurationBeforeShrink = 2000;
            this.bunifuVScrollBar1.LargeChange = 10;
            this.bunifuVScrollBar1.Location = new System.Drawing.Point(796, 83);
            this.bunifuVScrollBar1.Maximum = 100;
            this.bunifuVScrollBar1.Minimum = 0;
            this.bunifuVScrollBar1.MinimumThumbLength = 18;
            this.bunifuVScrollBar1.Name = "bunifuVScrollBar1";
            this.bunifuVScrollBar1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuVScrollBar1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.ScrollBarColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar1.ShrinkSizeLimit = 3;
            this.bunifuVScrollBar1.Size = new System.Drawing.Size(18, 319);
            this.bunifuVScrollBar1.SmallChange = 1;
            this.bunifuVScrollBar1.TabIndex = 12;
            this.bunifuVScrollBar1.ThumbColor = System.Drawing.Color.Gray;
            this.bunifuVScrollBar1.ThumbLength = 31;
            this.bunifuVScrollBar1.ThumbMargin = 1;
            this.bunifuVScrollBar1.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.bunifuVScrollBar1.Value = 0;
            // 
            // dtgCargos
            // 
            this.dtgCargos.AllowUserToAddRows = false;
            this.dtgCargos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            this.dtgCargos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgCargos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCargos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCargos.BackgroundColor = System.Drawing.Color.White;
            this.dtgCargos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgCargos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgCargos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCargos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgCargos.ColumnHeadersHeight = 40;
            this.dtgCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgCargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dtgCargos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgCargos.EnableHeadersVisualStyles = false;
            this.dtgCargos.GridColor = System.Drawing.Color.White;
            this.dtgCargos.Location = new System.Drawing.Point(9, 52);
            this.dtgCargos.MultiSelect = false;
            this.dtgCargos.Name = "dtgCargos";
            this.dtgCargos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCargos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgCargos.RowHeadersVisible = false;
            this.dtgCargos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgCargos.RowTemplate.Height = 30;
            this.dtgCargos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgCargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCargos.Size = new System.Drawing.Size(785, 359);
            this.dtgCargos.StandardTab = true;
            this.dtgCargos.TabIndex = 11;
            this.dtgCargos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Green;
            this.dtgCargos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Honeydew;
            this.dtgCargos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgCargos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgCargos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgCargos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgCargos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgCargos.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dtgCargos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.dtgCargos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgCargos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgCargos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgCargos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgCargos.ThemeStyle.HeaderStyle.Height = 40;
            this.dtgCargos.ThemeStyle.ReadOnly = true;
            this.dtgCargos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgCargos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgCargos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgCargos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgCargos.ThemeStyle.RowsStyle.Height = 30;
            this.dtgCargos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.dtgCargos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Icon
            // 
            this.Icon.FillWeight = 44.32486F;
            this.Icon.HeaderText = "";
            this.Icon.Image = global::HotelExcellence.Properties.Resources.quarto;
            this.Icon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Icon.Name = "Icon";
            this.Icon.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Editar.FillWeight = 44.32486F;
            this.Editar.HeaderText = "";
            this.Editar.Image = global::HotelExcellence.Properties.Resources.editar_lapis;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Editar.Width = 5;
            // 
            // Deletar
            // 
            this.Deletar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Deletar.FillWeight = 44.32486F;
            this.Deletar.HeaderText = "";
            this.Deletar.Image = global::HotelExcellence.Properties.Resources.deletar_color;
            this.Deletar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Deletar.Name = "Deletar";
            this.Deletar.ReadOnly = true;
            this.Deletar.Width = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.AnimationHoverSpeed = 0.1F;
            this.btnAdd.AnimationSpeed = 0.1F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.White;
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(111)))), ((int)(((byte)(70)))));
            this.btnAdd.BorderSize = 1;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(111)))), ((int)(((byte)(70)))));
            this.btnAdd.Image = null;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(651, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(174)))), ((int)(((byte)(127)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 3;
            this.btnAdd.Size = new System.Drawing.Size(143, 30);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.dtgCargos;
            // 
            // listCargoFRM3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 454);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.bunifuVScrollBar1);
            this.Controls.Add(this.dtgCargos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listCargoFRM3";
            this.Text = "listCargoFRM3";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCargos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox txtPesquisa;
        private Bunifu.UI.WinForms.BunifuVScrollBar bunifuVScrollBar1;
        private Guna.UI.WinForms.GunaDataGridView dtgCargos;
        private System.Windows.Forms.DataGridViewImageColumn Icon;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Deletar;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}