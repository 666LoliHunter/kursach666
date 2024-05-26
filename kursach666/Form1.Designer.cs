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
            this.gBoxFilters = new System.Windows.Forms.GroupBox();
            this.btnSendQuery = new System.Windows.Forms.Button();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.gBoxOrderPrice = new System.Windows.Forms.GroupBox();
            this.tBoxPriceFilter = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.rBOrderPriceHigh = new System.Windows.Forms.RadioButton();
            this.rBOrderPriceDown = new System.Windows.Forms.RadioButton();
            this.gBoxType = new System.Windows.Forms.GroupBox();
            this.lBType = new System.Windows.Forms.ListBox();
            this.lType = new System.Windows.Forms.Label();
            this.gBoxProd = new System.Windows.Forms.GroupBox();
            this.lProd = new System.Windows.Forms.Label();
            this.lBProd = new System.Windows.Forms.ListBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTable)).BeginInit();
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
            this.dGVTable.Location = new System.Drawing.Point(30, 28);
            this.dGVTable.Name = "dGVTable";
            this.dGVTable.RowHeadersWidth = 82;
            this.dGVTable.Size = new System.Drawing.Size(610, 189);
            this.dGVTable.TabIndex = 0;
            // 
            // gBoxFilters
            // 
            this.gBoxFilters.Controls.Add(this.btnSendQuery);
            this.gBoxFilters.Controls.Add(this.btnClearFilter);
            this.gBoxFilters.Controls.Add(this.gBoxOrderPrice);
            this.gBoxFilters.Controls.Add(this.gBoxType);
            this.gBoxFilters.Controls.Add(this.gBoxProd);
            this.gBoxFilters.Location = new System.Drawing.Point(30, 230);
            this.gBoxFilters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBoxFilters.Name = "gBoxFilters";
            this.gBoxFilters.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBoxFilters.Size = new System.Drawing.Size(610, 150);
            this.gBoxFilters.TabIndex = 2;
            this.gBoxFilters.TabStop = false;
            this.gBoxFilters.Text = "Фильтры";
            // 
            // btnSendQuery
            // 
            this.btnSendQuery.Location = new System.Drawing.Point(415, 20);
            this.btnSendQuery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSendQuery.Name = "btnSendQuery";
            this.btnSendQuery.Size = new System.Drawing.Size(191, 61);
            this.btnSendQuery.TabIndex = 6;
            this.btnSendQuery.Text = "Выполнить запрос";
            this.btnSendQuery.UseVisualStyleBackColor = true;
            this.btnSendQuery.Click += new System.EventHandler(this.btnSendQuery_Click);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(415, 85);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(191, 58);
            this.btnClearFilter.TabIndex = 5;
            this.btnClearFilter.Text = "Сбросить фильтры";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // gBoxOrderPrice
            // 
            this.gBoxOrderPrice.Controls.Add(this.tBoxPriceFilter);
            this.gBoxOrderPrice.Controls.Add(this.btnFilter);
            this.gBoxOrderPrice.Controls.Add(this.labelPrice);
            this.gBoxOrderPrice.Controls.Add(this.rBOrderPriceHigh);
            this.gBoxOrderPrice.Controls.Add(this.rBOrderPriceDown);
            this.gBoxOrderPrice.Location = new System.Drawing.Point(212, 16);
            this.gBoxOrderPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBoxOrderPrice.Name = "gBoxOrderPrice";
            this.gBoxOrderPrice.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBoxOrderPrice.Size = new System.Drawing.Size(199, 128);
            this.gBoxOrderPrice.TabIndex = 4;
            this.gBoxOrderPrice.TabStop = false;
            this.gBoxOrderPrice.Text = "Цена:";
            // 
            // tBoxPriceFilter
            // 
            this.tBoxPriceFilter.Location = new System.Drawing.Point(92, 70);
            this.tBoxPriceFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tBoxPriceFilter.Name = "tBoxPriceFilter";
            this.tBoxPriceFilter.Size = new System.Drawing.Size(74, 20);
            this.tBoxPriceFilter.TabIndex = 3;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(167, 69);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(20, 21);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "✅";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(9, 71);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(82, 13);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Цена не выше:";
            // 
            // rBOrderPriceHigh
            // 
            this.rBOrderPriceHigh.AutoSize = true;
            this.rBOrderPriceHigh.Location = new System.Drawing.Point(12, 40);
            this.rBOrderPriceHigh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBOrderPriceHigh.Name = "rBOrderPriceHigh";
            this.rBOrderPriceHigh.Size = new System.Drawing.Size(108, 17);
            this.rBOrderPriceHigh.TabIndex = 1;
            this.rBOrderPriceHigh.TabStop = true;
            this.rBOrderPriceHigh.Text = "Сначала дороже";
            this.rBOrderPriceHigh.UseVisualStyleBackColor = true;
            this.rBOrderPriceHigh.CheckedChanged += new System.EventHandler(this.rBOrderPriceHigh_CheckedChanged);
            // 
            // rBOrderPriceDown
            // 
            this.rBOrderPriceDown.AutoSize = true;
            this.rBOrderPriceDown.Location = new System.Drawing.Point(12, 19);
            this.rBOrderPriceDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBOrderPriceDown.Name = "rBOrderPriceDown";
            this.rBOrderPriceDown.Size = new System.Drawing.Size(114, 17);
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
            this.gBoxType.Location = new System.Drawing.Point(112, 16);
            this.gBoxType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBoxType.Name = "gBoxType";
            this.gBoxType.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBoxType.Size = new System.Drawing.Size(97, 128);
            this.gBoxType.TabIndex = 3;
            this.gBoxType.TabStop = false;
            this.gBoxType.Text = "Тип:";
            // 
            // lBType
            // 
            this.lBType.FormattingEnabled = true;
            this.lBType.Items.AddRange(new object[] {
            "Лазерный",
            "Струйный",
            "МФУ"});
            this.lBType.Location = new System.Drawing.Point(11, 19);
            this.lBType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lBType.Name = "lBType";
            this.lBType.Size = new System.Drawing.Size(76, 43);
            this.lBType.TabIndex = 6;
            this.lBType.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(8, 14);
            this.lType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(0, 13);
            this.lType.TabIndex = 0;
            // 
            // gBoxProd
            // 
            this.gBoxProd.Controls.Add(this.lProd);
            this.gBoxProd.Controls.Add(this.lBProd);
            this.gBoxProd.Location = new System.Drawing.Point(3, 16);
            this.gBoxProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBoxProd.Name = "gBoxProd";
            this.gBoxProd.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBoxProd.Size = new System.Drawing.Size(106, 128);
            this.gBoxProd.TabIndex = 1;
            this.gBoxProd.TabStop = false;
            this.gBoxProd.Text = "Производитель:";
            // 
            // lProd
            // 
            this.lProd.AutoSize = true;
            this.lProd.Location = new System.Drawing.Point(3, 14);
            this.lProd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lProd.Name = "lProd";
            this.lProd.Size = new System.Drawing.Size(0, 13);
            this.lProd.TabIndex = 0;
            // 
            // lBProd
            // 
            this.lBProd.FormattingEnabled = true;
            this.lBProd.Items.AddRange(new object[] {
            "Pantum",
            "Xerox",
            "HP",
            "Kyocera",
            "Canon",
            "Brother",
            "Epson"});
            this.lBProd.Location = new System.Drawing.Point(14, 19);
            this.lBProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lBProd.Name = "lBProd";
            this.lBProd.Size = new System.Drawing.Size(76, 95);
            this.lBProd.TabIndex = 5;
            this.lBProd.SelectedIndexChanged += new System.EventHandler(this.lBProd_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 10;
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // prod
            // 
            this.prod.HeaderText = "Производитель";
            this.prod.MinimumWidth = 10;
            this.prod.Name = "prod";
            // 
            // type
            // 
            this.type.HeaderText = "Тип";
            this.type.MinimumWidth = 10;
            this.type.Name = "type";
            // 
            // model
            // 
            this.model.HeaderText = "Модель";
            this.model.MinimumWidth = 10;
            this.model.Name = "model";
            this.model.Width = 155;
            // 
            // price
            // 
            this.price.HeaderText = "Цена";
            this.price.MinimumWidth = 10;
            this.price.Name = "price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 388);
            this.Controls.Add(this.gBoxFilters);
            this.Controls.Add(this.dGVTable);
            this.Name = "Form1";
            this.Text = "Принтеры";
            ((System.ComponentModel.ISupportInitialize)(this.dGVTable)).EndInit();
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
        private System.Windows.Forms.GroupBox gBoxFilters;
        private System.Windows.Forms.Label lProd;
        private System.Windows.Forms.GroupBox gBoxProd;
        private System.Windows.Forms.GroupBox gBoxType;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.GroupBox gBoxOrderPrice;
        private System.Windows.Forms.RadioButton rBOrderPriceHigh;
        private System.Windows.Forms.RadioButton rBOrderPriceDown;
        private System.Windows.Forms.TextBox tBoxPriceFilter;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ListBox lBProd;
        private System.Windows.Forms.ListBox lBType;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnSendQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}

