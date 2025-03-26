namespace Pizza02
{
    partial class FormPizzaCadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblId = new Label();
            label2 = new Label();
            lblPreco = new Label();
            textId = new TextBox();
            textPizza = new TextBox();
            textPreco = new TextBox();
            btnSalvar = new Button();
            btnExcluir = new Button();
            dtgEstoque = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgEstoque).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(37, 26);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 26);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Sabor da Pizza";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(256, 26);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 2;
            lblPreco.Text = "Preço";
            // 
            // textId
            // 
            textId.Enabled = false;
            textId.Location = new Point(37, 44);
            textId.Name = "textId";
            textId.Size = new Size(52, 23);
            textId.TabIndex = 3;
            // 
            // textPizza
            // 
            textPizza.Location = new Point(120, 44);
            textPizza.Name = "textPizza";
            textPizza.Size = new Size(100, 23);
            textPizza.TabIndex = 4;
            // 
            // textPreco
            // 
            textPreco.Location = new Point(256, 44);
            textPreco.Name = "textPreco";
            textPreco.Size = new Size(100, 23);
            textPreco.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(209, 88);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(333, 88);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dtgEstoque
            // 
            dtgEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEstoque.Location = new Point(0, 149);
            dtgEstoque.Name = "dtgEstoque";
            dtgEstoque.Size = new Size(431, 268);
            dtgEstoque.TabIndex = 8;
            dtgEstoque.CellDoubleClick += dtgEstoque_CellDoubleClick;
            // 
            // FormPizzaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 408);
            Controls.Add(dtgEstoque);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(textPreco);
            Controls.Add(textPizza);
            Controls.Add(textId);
            Controls.Add(lblPreco);
            Controls.Add(label2);
            Controls.Add(lblId);
            Name = "FormPizzaCadastro";
            Text = "Form1";
            Load += FormPizzaCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)dtgEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label label2;
        private Label lblPreco;
        private TextBox textId;
        private TextBox textPizza;
        private TextBox textPreco;
        private Button btnSalvar;
        private Button btnExcluir;
        private DataGridView dtgEstoque;
    }
}
