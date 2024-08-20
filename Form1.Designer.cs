namespace TicTacToeGame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnNewGame;

        private void InitializeComponent()
        {
            this.btn00 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Buttons setup
            this.btn00.Location = new System.Drawing.Point(10, 10);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(60, 60);
            this.btn00.TabIndex = 0;
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.Button_Click);

            this.btn01.Location = new System.Drawing.Point(80, 10);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(60, 60);
            this.btn01.TabIndex = 1;
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.Button_Click);

            this.btn02.Location = new System.Drawing.Point(150, 10);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(60, 60);
            this.btn02.TabIndex = 2;
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.Button_Click);

            this.btn10.Location = new System.Drawing.Point(10, 80);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(60, 60);
            this.btn10.TabIndex = 3;
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.Button_Click);

            this.btn11.Location = new System.Drawing.Point(80, 80);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(60, 60);
            this.btn11.TabIndex = 4;
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.Button_Click);

            this.btn12.Location = new System.Drawing.Point(150, 80);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(60, 60);
            this.btn12.TabIndex = 5;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.Button_Click);

            this.btn20.Location = new System.Drawing.Point(10, 150);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(60, 60);
            this.btn20.TabIndex = 6;
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.Button_Click);

            this.btn21.Location = new System.Drawing.Point(80, 150);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(60, 60);
            this.btn21.TabIndex = 7;
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Click += new System.EventHandler(this.Button_Click);

            this.btn22.Location = new System.Drawing.Point(150, 150);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(60, 60);
            this.btn22.TabIndex = 8;
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.Click += new System.EventHandler(this.Button_Click);

            // Label Status setup
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(10, 220);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Player X's Turn";

            // Button New Game setup
            this.btnNewGame.Location = new System.Drawing.Point(10, 260);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(100, 30);
            this.btnNewGame.TabIndex = 10;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
        }
    }
}
