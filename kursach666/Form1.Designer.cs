namespace kursach666
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGVTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBoxSQL = new System.Windows.Forms.GroupBox();
            this.btnSQL = new System.Windows.Forms.Button();
            this.tBoxSQL = new System.Windows.Forms.TextBox();
            this.lSQL = new System.Windows.Forms.Label();
            this.gBoxFilters = new System.Windows.Forms.GroupBox();
            this.gBoxOrderPrice = new System.Windows.Forms.GroupBox();
            this.tBoxPriceFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rBOrderPriceHigh = new System.Windows.Forms.RadioButton();
            this.rBOrderPriceDown = new System.Windows.Forms.RadioButton();
            this.gBoxType = new System.Windows.Forms.GroupBox();
            this.lType = new System.Windows.Forms.Label();
            this.gBoxProd = new System.Windows.Forms.GroupBox();
            this.lProd = new System.Windows.Forms.Label();
            this.lBProd = new System.Windows.Forms.ListBox();
            this.lBType = new System.Windows.Forms.ListBox();
            this.btnClearSQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTable)).BeginInit();
            this.gBoxSQL.SuspendLayout();
            this.gBoxFilters.SuspendLayout();
            this.gBoxOrderPrice.SuspendLayout();
            this.gBoxType.SuspendLayout();
            this.gBoxProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVTable
            // 
            this.dGVTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.prod,
            this.type,
            this.model,
            this.price});
            this.dGVTable.Location = new System.Drawing.Point(60, 54);
            this.dGVTable.Margin = new System.Windows.Forms.Padding(6);
            this.dGVTable.Name = "dGVTable";
            this.dGVTable.RowHeadersWidth = 82;
            this.dGVTable.Size = new System.Drawing.Size(1084, 363);
            this.dGVTable.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 10;
            this.id.Name = "id";
            this.id.Width = 200;
            // 
            // prod
            // 
            this.prod.HeaderText = "Производитель";
            this.prod.MinimumWidth = 10;
            this.prod.Name = "prod";
            this.prod.Width = 200;
            // 
            // type
            // 
            this.type.HeaderText = "Тип";
            this.type.MinimumWidth = 10;
            this.type.Name = "type";
            this.type.Width = 200;
            // 
            // model
            // 
            this.model.HeaderText = "Модель";
            this.model.MinimumWidth = 10;
            this.model.Name = "model";
            this.model.Width = 200;
            // 
            // price
            // 
            this.price.HeaderText = "Цена";
            this.price.MinimumWidth = 10;
            this.price.Name = "price";
            this.price.Width = 200;
            // 
            // gBoxSQL
            // 
            this.gBoxSQL.Controls.Add(this.btnSQL);
            this.gBoxSQL.Controls.Add(this.tBoxSQL);
            this.gBoxSQL.Controls.Add(this.lSQL);
            this.gBoxSQL.Location = new System.Drawing.Point(60, 454);
            this.gBoxSQL.Margin = new System.Windows.Forms.Padding(6);
            this.gBoxSQL.Name = "gBoxSQL";
            this.gBoxSQL.Padding = new System.Windows.Forms.Padding(6);
            this.gBoxSQL.Size = new System.Drawing.Size(1084, 119);
            this.gBoxSQL.TabIndex = 1;
            this.gBoxSQL.TabStop = false;
            // 
            // btnSQL
            // 
            this.btnSQL.Location = new System.Drawing.Point(922, 46);
            this.btnSQL.Margin = new System.Windows.Forms.Padding(6);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(150, 44);
            this.btnSQL.TabIndex = 2;
            this.btnSQL.Text = "Найти";
            this.btnSQL.UseVisualStyleBackColor = true;
            this.btnSQL.Click += new System.EventHandler(this.btnSQL_Click);
            // 
            // tBoxSQL
            // 
            this.tBoxSQL.Location = new System.Drawing.Point(80, 48);
            this.tBoxSQL.Margin = new System.Windows.Forms.Padding(6);
            this.tBoxSQL.Name = "tBoxSQL";
            this.tBoxSQL.Size = new System.Drawing.Size(826, 31);
            this.tBoxSQL.TabIndex = 1;
            this.tBoxSQL.Text = "select * from printers";
            // 
            // lSQL
            // 
            this.lSQL.AutoSize = true;
            this.lSQL.Location = new System.Drawing.Point(12, 54);
            this.lSQL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lSQL.Name = "lSQL";
            this.lSQL.Size = new System.Drawing.Size(54, 25);
            this.lSQL.TabIndex = 0;
            this.lSQL.Text = "SQL";
            // 
            // gBoxFilters
            // 
            this.gBoxFilters.Controls.Add(this.btnClearSQL);
            this.gBoxFilters.Controls.Add(this.gBoxOrderPrice);
            this.gBoxFilters.Controls.Add(this.gBoxType);
            this.gBoxFilters.Controls.Add(this.gBoxProd);
            this.gBoxFilters.Location = new System.Drawing.Point(60, 593);
            this.gBoxFilters.Name = "gBoxFilters";
            this.gBoxFilters.Size = new System.Drawing.Size(1084, 427);
            this.gBoxFilters.TabIndex = 2;
            this.gBoxFilters.TabStop = false;
            this.gBoxFilters.Text = "Фильтры";
            // 
            // gBoxOrderPrice
            // 
            this.gBoxOrderPrice.Controls.Add(this.tBoxPriceFilter);
            this.gBoxOrderPrice.Controls.Add(this.label1);
            this.gBoxOrderPrice.Controls.Add(this.rBOrderPriceHigh);
            this.gBoxOrderPrice.Controls.Add(this.rBOrderPriceDown);
            this.gBoxOrderPrice.Location = new System.Drawing.Point(737, 30);
            this.gBoxOrderPrice.Name = "gBoxOrderPrice";
            this.gBoxOrderPrice.Size = new System.Drawing.Size(335, 231);
            this.gBoxOrderPrice.TabIndex = 4;
            this.gBoxOrderPrice.TabStop = false;
            this.gBoxOrderPrice.Text = "Цена:";
            // 
            // tBoxPriceFilter
            // 
            this.tBoxPriceFilter.Location = new System.Drawing.Point(175, 113);
            this.tBoxPriceFilter.Name = "tBoxPriceFilter";
            this.tBoxPriceFilter.Size = new System.Drawing.Size(141, 31);
            this.tBoxPriceFilter.TabIndex = 3;
            this.tBoxPriceFilter.TextChanged += new System.EventHandler(this.tBoxPriceFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Цена не выше:";
            // 
            // rBOrderPriceHigh
            // 
            this.rBOrderPriceHigh.AutoSize = true;
            this.rBOrderPriceHigh.Location = new System.Drawing.Point(13, 74);
            this.rBOrderPriceHigh.Name = "rBOrderPriceHigh";
            this.rBOrderPriceHigh.Size = new System.Drawing.Size(210, 29);
            this.rBOrderPriceHigh.TabIndex = 1;
            this.rBOrderPriceHigh.TabStop = true;
            this.rBOrderPriceHigh.Text = "Сначала дороже";
            this.rBOrderPriceHigh.UseVisualStyleBackColor = true;
            this.rBOrderPriceHigh.CheckedChanged += new System.EventHandler(this.rBOrderPriceHigh_CheckedChanged);
            // 
            // rBOrderPriceDown
            // 
            this.rBOrderPriceDown.AutoSize = true;
            this.rBOrderPriceDown.Location = new System.Drawing.Point(13, 33);
            this.rBOrderPriceDown.Name = "rBOrderPriceDown";
            this.rBOrderPriceDown.Size = new System.Drawing.Size(223, 29);
            this.rBOrderPriceDown.TabIndex = 0;
            this.rBOrderPriceDown.TabStop = true;
            this.rBOrderPriceDown.Text = "Сначала дешевле";
            this.rBOrderPriceDown.UseVisualStyleBackColor = true;
            this.rBOrderPriceDown.CheckedChanged += new System.EventHandler(this.rBOrderPriceDown_CheckedChanged);
            // 
            // gBoxType
            // 
            this.gBoxType.Controls.Add(this.lBType);
            this.gBoxType.Controls.Add(this.lType);
            this.gBoxType.Location = new System.Drawing.Point(433, 30);
            this.gBoxType.Name = "gBoxType";
            this.gBoxType.Size = new System.Drawing.Size(274, 231);
            this.gBoxType.TabIndex = 3;
            this.gBoxType.TabStop = false;
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(16, 27);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(55, 25);
            this.lType.TabIndex = 0;
            this.lType.Text = "Тип:";
            // 
            // gBoxProd
            // 
            this.gBoxProd.Controls.Add(this.lProd);
            this.gBoxProd.Controls.Add(this.lBProd);
            this.gBoxProd.Location = new System.Drawing.Point(17, 30);
            this.gBoxProd.Name = "gBoxProd";
            this.gBoxProd.Size = new System.Drawing.Size(384, 231);
            this.gBoxProd.TabIndex = 1;
            this.gBoxProd.TabStop = false;
            // 
            // lProd
            // 
            this.lProd.AutoSize = true;
            this.lProd.Location = new System.Drawing.Point(6, 27);
            this.lProd.Name = "lProd";
            this.lProd.Size = new System.Drawing.Size(172, 25);
            this.lProd.TabIndex = 0;
            this.lProd.Text = "Производитель:";
            // 
            // lBProd
            // 
            this.lBProd.FormattingEnabled = true;
            this.lBProd.ItemHeight = 25;
            this.lBProd.Items.AddRange(new object[] {
            "Pantum",
            "Xerox",
            "HP",
            "Kyocera",
            "Canon",
            "Brother",
            "Epson"});
            this.lBProd.Location = new System.Drawing.Point(199, 27);
            this.lBProd.Name = "lBProd";
            this.lBProd.Size = new System.Drawing.Size(149, 179);
            this.lBProd.TabIndex = 5;
            this.lBProd.SelectedIndexChanged += new System.EventHandler(this.lBProd_SelectedIndexChanged);
            // 
            // lBType
            // 
            this.lBType.FormattingEnabled = true;
            this.lBType.ItemHeight = 25;
            this.lBType.Items.AddRange(new object[] {
            "Лазерный",
            "Струйный",
            "МФУ"});
            this.lBType.Location = new System.Drawing.Point(98, 27);
            this.lBType.Name = "lBType";
            this.lBType.Size = new System.Drawing.Size(149, 79);
            this.lBType.TabIndex = 6;
            this.lBType.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnClearSQL
            // 
            this.btnClearSQL.Location = new System.Drawing.Point(17, 284);
            this.btnClearSQL.Name = "btnClearSQL";
            this.btnClearSQL.Size = new System.Drawing.Size(1055, 118);
            this.btnClearSQL.TabIndex = 5;
            this.btnClearSQL.Text = "Отчистить поле ввода SQL запроса";
            this.btnClearSQL.UseVisualStyleBackColor = true;
            this.btnClearSQL.Click += new System.EventHandler(this.btnClearSQL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 1041);
            this.Controls.Add(this.gBoxFilters);
            this.Controls.Add(this.gBoxSQL);
            this.Controls.Add(this.dGVTable);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Принтеры";
            ((System.ComponentModel.ISupportInitialize)(this.dGVTable)).EndInit();
            this.gBoxSQL.ResumeLayout(false);
            this.gBoxSQL.PerformLayout();
            this.gBoxFilters.ResumeLayout(false);
            this.gBoxOrderPrice.ResumeLayout(false);
            this.gBoxOrderPrice.PerformLayout();
            this.gBoxType.ResumeLayout(false);
            this.gBoxType.PerformLayout();
            this.gBoxProd.ResumeLayout(false);
            this.gBoxProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.GroupBox gBoxSQL;
        private System.Windows.Forms.Label lSQL;
        private System.Windows.Forms.Button btnSQL;
        private System.Windows.Forms.TextBox tBoxSQL;
        private System.Windows.Forms.GroupBox gBoxFilters;
        private System.Windows.Forms.Label lProd;
        private System.Windows.Forms.GroupBox gBoxProd;
        private System.Windows.Forms.GroupBox gBoxType;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.GroupBox gBoxOrderPrice;
        private System.Windows.Forms.RadioButton rBOrderPriceHigh;
        private System.Windows.Forms.RadioButton rBOrderPriceDown;
        private System.Windows.Forms.TextBox tBoxPriceFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lBProd;
        private System.Windows.Forms.ListBox lBType;
        private System.Windows.Forms.Button btnClearSQL;
    }
}

