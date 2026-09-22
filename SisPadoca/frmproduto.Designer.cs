namespace SisPadoca
{
    partial class frmproduto
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
            components = new System.ComponentModel.Container();
            lblNCM = new Label();
            txbncm = new TextBox();
            btnNovo = new Button();
            pbximagem = new PictureBox();
            txbunidademedida = new ComboBox();
            lbldescricao = new Label();
            txbdescricao = new TextBox();
            lblcodigobarras = new Label();
            txbcodigo = new TextBox();
            lblunidade = new Label();
            lblLote = new Label();
            txblote = new TextBox();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            btnfechar = new Button();
            imglista = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pbximagem).BeginInit();
            SuspendLayout();
            // 
            // lblNCM
            // 
            lblNCM.AutoSize = true;
            lblNCM.Location = new Point(219, 38);
            lblNCM.Name = "lblNCM";
            lblNCM.Size = new Size(52, 25);
            lblNCM.TabIndex = 0;
            lblNCM.Text = "NCM";
            lblNCM.Click += label1_Click;
            // 
            // txbncm
            // 
            txbncm.Location = new Point(219, 66);
            txbncm.Name = "txbncm";
            txbncm.Size = new Size(148, 31);
            txbncm.TabIndex = 1;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(76, 272);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(112, 34);
            btnNovo.TabIndex = 2;
            btnNovo.Text = "novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // pbximagem
            // 
            pbximagem.Image = Properties.Resources.pao;
            pbximagem.Location = new Point(50, 59);
            pbximagem.Name = "pbximagem";
            pbximagem.Size = new Size(150, 194);
            pbximagem.SizeMode = PictureBoxSizeMode.CenterImage;
            pbximagem.TabIndex = 4;
            pbximagem.TabStop = false;
            pbximagem.Click += pbximagem_Click;
            // 
            // txbunidademedida
            // 
            txbunidademedida.FormattingEnabled = true;
            txbunidademedida.Location = new Point(554, 137);
            txbunidademedida.Name = "txbunidademedida";
            txbunidademedida.Size = new Size(182, 33);
            txbunidademedida.TabIndex = 5;
            // 
            // lbldescricao
            // 
            lbldescricao.AutoSize = true;
            lbldescricao.Location = new Point(219, 111);
            lbldescricao.Name = "lbldescricao";
            lbldescricao.Size = new Size(88, 25);
            lbldescricao.TabIndex = 6;
            lbldescricao.Text = "Descrição";
            // 
            // txbdescricao
            // 
            txbdescricao.Location = new Point(219, 139);
            txbdescricao.Name = "txbdescricao";
            txbdescricao.Size = new Size(301, 31);
            txbdescricao.TabIndex = 7;
            // 
            // lblcodigobarras
            // 
            lblcodigobarras.AutoSize = true;
            lblcodigobarras.Location = new Point(219, 194);
            lblcodigobarras.Name = "lblcodigobarras";
            lblcodigobarras.Size = new Size(147, 25);
            lblcodigobarras.TabIndex = 8;
            lblcodigobarras.Text = "código de barras";
            // 
            // txbcodigo
            // 
            txbcodigo.Location = new Point(219, 222);
            txbcodigo.Name = "txbcodigo";
            txbcodigo.Size = new Size(301, 31);
            txbcodigo.TabIndex = 9;
            // 
            // lblunidade
            // 
            lblunidade.AutoSize = true;
            lblunidade.Location = new Point(554, 111);
            lblunidade.Name = "lblunidade";
            lblunidade.Size = new Size(143, 25);
            lblunidade.TabIndex = 10;
            lblunidade.Text = "Unidade medida";
            // 
            // lblLote
            // 
            lblLote.AutoSize = true;
            lblLote.Location = new Point(554, 194);
            lblLote.Name = "lblLote";
            lblLote.Size = new Size(42, 25);
            lblLote.TabIndex = 11;
            lblLote.Text = "lote";
            // 
            // txblote
            // 
            txblote.Location = new Point(554, 222);
            txblote.Name = "txblote";
            txblote.Size = new Size(179, 31);
            txblote.TabIndex = 12;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(219, 272);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += button2_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(360, 272);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(112, 34);
            btnExcluir.TabIndex = 14;
            btnExcluir.Text = "excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(501, 272);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(112, 34);
            btnLimpar.TabIndex = 15;
            btnLimpar.Text = "limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnfechar
            // 
            btnfechar.Location = new Point(648, 272);
            btnfechar.Name = "btnfechar";
            btnfechar.Size = new Size(112, 34);
            btnfechar.TabIndex = 16;
            btnfechar.Text = "fechar";
            btnfechar.UseVisualStyleBackColor = true;
            // 
            // imglista
            // 
            imglista.ColorDepth = ColorDepth.Depth32Bit;
            imglista.ImageSize = new Size(16, 16);
            imglista.TransparentColor = Color.Transparent;
            // 
            // frmproduto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 512);
            Controls.Add(btnfechar);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(txblote);
            Controls.Add(lblLote);
            Controls.Add(lblunidade);
            Controls.Add(txbcodigo);
            Controls.Add(lblcodigobarras);
            Controls.Add(txbdescricao);
            Controls.Add(lbldescricao);
            Controls.Add(txbunidademedida);
            Controls.Add(pbximagem);
            Controls.Add(btnNovo);
            Controls.Add(txbncm);
            Controls.Add(lblNCM);
            Name = "frmproduto";
            Text = "frmproduto";
            ((System.ComponentModel.ISupportInitialize)pbximagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNCM;
        private TextBox txbncm;
        private Button btnNovo;
        private PictureBox pbximagem;
        private ComboBox txbunidademedida;
        private Label lbldescricao;
        private TextBox txbdescricao;
        private Label lblcodigobarras;
        private TextBox txbcodigo;
        private Label lblunidade;
        private Label lblLote;
        private TextBox txblote;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnLimpar;
        private Button btnfechar;
        private ImageList imglista;
    }
}