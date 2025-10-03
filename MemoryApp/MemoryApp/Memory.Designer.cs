namespace MemoryApp
{
    partial class frmMemory
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
            tblMain = new TableLayoutPanel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtPlayer1 = new TextBox();
            txtPlayer2 = new TextBox();
            lblTurn = new Label();
            tblTurn = new TableLayoutPanel();
            lblPlayerTurn = new Label();
            btnStart = new Button();
            tblP1Score = new TableLayoutPanel();
            lblPlayer1 = new Label();
            lblP1Score = new Label();
            tblP2Score = new TableLayoutPanel();
            lblPlayer2 = new Label();
            lblP2Score = new Label();
            tblTiles = new TableLayoutPanel();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn10 = new Button();
            btn11 = new Button();
            btn12 = new Button();
            btn13 = new Button();
            btn14 = new Button();
            btn15 = new Button();
            btn16 = new Button();
            btn17 = new Button();
            btn18 = new Button();
            btn19 = new Button();
            btn20 = new Button();
            tblMain.SuspendLayout();
            tblTurn.SuspendLayout();
            tblP1Score.SuspendLayout();
            tblP2Score.SuspendLayout();
            tblTiles.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblMain.Controls.Add(txtPlayer1, 0, 0);
            tblMain.Controls.Add(txtPlayer2, 0, 1);
            tblMain.Controls.Add(tblTurn, 0, 2);
            tblMain.Controls.Add(btnStart, 2, 2);
            tblMain.Controls.Add(tblP1Score, 0, 4);
            tblMain.Controls.Add(tblP2Score, 2, 4);
            tblMain.Controls.Add(tblTiles, 0, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 6;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.Size = new Size(910, 1331);
            tblMain.TabIndex = 0;
            // 
            // txtPlayer1
            // 
            tblMain.SetColumnSpan(txtPlayer1, 3);
            txtPlayer1.Dock = DockStyle.Fill;
            txtPlayer1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPlayer1.Location = new Point(25, 25);
            txtPlayer1.Margin = new Padding(25);
            txtPlayer1.Multiline = true;
            txtPlayer1.Name = "txtPlayer1";
            txtPlayer1.PlaceholderText = "Player 1";
            txtPlayer1.Size = new Size(860, 83);
            txtPlayer1.TabIndex = 0;
            // 
            // txtPlayer2
            // 
            tblMain.SetColumnSpan(txtPlayer2, 3);
            txtPlayer2.Dock = DockStyle.Fill;
            txtPlayer2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPlayer2.Location = new Point(25, 158);
            txtPlayer2.Margin = new Padding(25);
            txtPlayer2.Multiline = true;
            txtPlayer2.Name = "txtPlayer2";
            txtPlayer2.PlaceholderText = "Player 2";
            txtPlayer2.Size = new Size(860, 83);
            txtPlayer2.TabIndex = 1;
            // 
            // lblTurn
            // 
            lblTurn.AutoSize = true;
            lblTurn.Dock = DockStyle.Fill;
            lblTurn.Location = new Point(3, 0);
            lblTurn.Name = "lblTurn";
            lblTurn.Size = new Size(174, 127);
            lblTurn.TabIndex = 2;
            lblTurn.Text = "TURN:";
            lblTurn.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tblTurn
            // 
            tblTurn.ColumnCount = 3;
            tblMain.SetColumnSpan(tblTurn, 2);
            tblTurn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblTurn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblTurn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblTurn.Controls.Add(lblTurn, 0, 0);
            tblTurn.Controls.Add(lblPlayerTurn, 1, 0);
            tblTurn.Dock = DockStyle.Fill;
            tblTurn.Location = new Point(3, 269);
            tblTurn.Name = "tblTurn";
            tblTurn.RowCount = 1;
            tblTurn.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblTurn.Size = new Size(600, 127);
            tblTurn.TabIndex = 3;
            // 
            // lblPlayerTurn
            // 
            lblPlayerTurn.AutoSize = true;
            lblPlayerTurn.Dock = DockStyle.Fill;
            lblPlayerTurn.Location = new Point(183, 0);
            lblPlayerTurn.Name = "lblPlayerTurn";
            lblPlayerTurn.Size = new Size(294, 127);
            lblPlayerTurn.TabIndex = 3;
            lblPlayerTurn.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnStart
            // 
            btnStart.Dock = DockStyle.Fill;
            btnStart.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(609, 269);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(298, 127);
            btnStart.TabIndex = 4;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // tblP1Score
            // 
            tblP1Score.ColumnCount = 2;
            tblP1Score.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tblP1Score.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblP1Score.Controls.Add(lblPlayer1, 0, 0);
            tblP1Score.Controls.Add(lblP1Score, 1, 0);
            tblP1Score.Location = new Point(3, 934);
            tblP1Score.Name = "tblP1Score";
            tblP1Score.RowCount = 1;
            tblP1Score.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblP1Score.Size = new Size(297, 127);
            tblP1Score.TabIndex = 5;
            // 
            // lblPlayer1
            // 
            lblPlayer1.AutoSize = true;
            lblPlayer1.Dock = DockStyle.Fill;
            lblPlayer1.Location = new Point(3, 0);
            lblPlayer1.Name = "lblPlayer1";
            lblPlayer1.Size = new Size(201, 127);
            lblPlayer1.TabIndex = 0;
            lblPlayer1.Text = "Player 1:";
            lblPlayer1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblP1Score
            // 
            lblP1Score.AutoSize = true;
            lblP1Score.Dock = DockStyle.Fill;
            lblP1Score.Location = new Point(210, 0);
            lblP1Score.Name = "lblP1Score";
            lblP1Score.Size = new Size(84, 127);
            lblP1Score.TabIndex = 1;
            lblP1Score.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblP2Score
            // 
            tblP2Score.ColumnCount = 2;
            tblP2Score.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tblP2Score.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblP2Score.Controls.Add(lblPlayer2, 0, 0);
            tblP2Score.Controls.Add(lblP2Score, 1, 0);
            tblP2Score.Location = new Point(609, 934);
            tblP2Score.Name = "tblP2Score";
            tblP2Score.RowCount = 1;
            tblP2Score.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblP2Score.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblP2Score.Size = new Size(298, 127);
            tblP2Score.TabIndex = 6;
            // 
            // lblPlayer2
            // 
            lblPlayer2.AutoSize = true;
            lblPlayer2.Dock = DockStyle.Fill;
            lblPlayer2.Location = new Point(3, 0);
            lblPlayer2.Name = "lblPlayer2";
            lblPlayer2.Size = new Size(202, 127);
            lblPlayer2.TabIndex = 0;
            lblPlayer2.Text = "Player 2:";
            lblPlayer2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblP2Score
            // 
            lblP2Score.AutoSize = true;
            lblP2Score.Dock = DockStyle.Fill;
            lblP2Score.Location = new Point(211, 0);
            lblP2Score.Name = "lblP2Score";
            lblP2Score.Size = new Size(84, 127);
            lblP2Score.TabIndex = 1;
            lblP2Score.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblTiles
            // 
            tblTiles.ColumnCount = 5;
            tblMain.SetColumnSpan(tblTiles, 3);
            tblTiles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblTiles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblTiles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblTiles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblTiles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblTiles.Controls.Add(btn1, 0, 0);
            tblTiles.Controls.Add(btn2, 1, 0);
            tblTiles.Controls.Add(btn3, 2, 0);
            tblTiles.Controls.Add(btn4, 3, 0);
            tblTiles.Controls.Add(btn5, 4, 0);
            tblTiles.Controls.Add(btn6, 0, 1);
            tblTiles.Controls.Add(btn7, 1, 1);
            tblTiles.Controls.Add(btn8, 2, 1);
            tblTiles.Controls.Add(btn9, 3, 1);
            tblTiles.Controls.Add(btn10, 4, 1);
            tblTiles.Controls.Add(btn11, 0, 2);
            tblTiles.Controls.Add(btn12, 1, 2);
            tblTiles.Controls.Add(btn13, 2, 2);
            tblTiles.Controls.Add(btn14, 3, 2);
            tblTiles.Controls.Add(btn15, 4, 2);
            tblTiles.Controls.Add(btn16, 0, 3);
            tblTiles.Controls.Add(btn17, 1, 3);
            tblTiles.Controls.Add(btn18, 2, 3);
            tblTiles.Controls.Add(btn19, 3, 3);
            tblTiles.Controls.Add(btn20, 4, 3);
            tblTiles.Dock = DockStyle.Fill;
            tblTiles.Font = new Font("Wingdings", 20F, FontStyle.Bold, GraphicsUnit.Point, 2);
            tblTiles.Location = new Point(3, 402);
            tblTiles.Name = "tblTiles";
            tblTiles.RowCount = 4;
            tblTiles.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblTiles.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblTiles.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblTiles.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblTiles.Size = new Size(904, 526);
            tblTiles.TabIndex = 7;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Fill;
            btn1.Location = new Point(3, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(174, 125);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Fill;
            btn2.Location = new Point(183, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(174, 125);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Fill;
            btn3.Location = new Point(363, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(174, 125);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Fill;
            btn4.Location = new Point(543, 3);
            btn4.Name = "btn4";
            btn4.Size = new Size(174, 125);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Fill;
            btn5.Location = new Point(723, 3);
            btn5.Name = "btn5";
            btn5.Size = new Size(178, 125);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Dock = DockStyle.Fill;
            btn6.Location = new Point(3, 134);
            btn6.Name = "btn6";
            btn6.Size = new Size(174, 125);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Dock = DockStyle.Fill;
            btn7.Location = new Point(183, 134);
            btn7.Name = "btn7";
            btn7.Size = new Size(174, 125);
            btn7.TabIndex = 7;
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Dock = DockStyle.Fill;
            btn8.Location = new Point(363, 134);
            btn8.Name = "btn8";
            btn8.Size = new Size(174, 125);
            btn8.TabIndex = 8;
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Dock = DockStyle.Fill;
            btn9.Location = new Point(543, 134);
            btn9.Name = "btn9";
            btn9.Size = new Size(174, 125);
            btn9.TabIndex = 9;
            btn9.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            btn10.Dock = DockStyle.Fill;
            btn10.Location = new Point(723, 134);
            btn10.Name = "btn10";
            btn10.Size = new Size(178, 125);
            btn10.TabIndex = 10;
            btn10.UseVisualStyleBackColor = true;
            // 
            // btn11
            // 
            btn11.Dock = DockStyle.Fill;
            btn11.Location = new Point(3, 265);
            btn11.Name = "btn11";
            btn11.Size = new Size(174, 125);
            btn11.TabIndex = 11;
            btn11.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            btn12.Dock = DockStyle.Fill;
            btn12.Location = new Point(183, 265);
            btn12.Name = "btn12";
            btn12.Size = new Size(174, 125);
            btn12.TabIndex = 12;
            btn12.UseVisualStyleBackColor = true;
            // 
            // btn13
            // 
            btn13.Dock = DockStyle.Fill;
            btn13.Location = new Point(363, 265);
            btn13.Name = "btn13";
            btn13.Size = new Size(174, 125);
            btn13.TabIndex = 13;
            btn13.UseVisualStyleBackColor = true;
            // 
            // btn14
            // 
            btn14.Dock = DockStyle.Fill;
            btn14.Location = new Point(543, 265);
            btn14.Name = "btn14";
            btn14.Size = new Size(174, 125);
            btn14.TabIndex = 14;
            btn14.UseVisualStyleBackColor = true;
            // 
            // btn15
            // 
            btn15.Dock = DockStyle.Fill;
            btn15.Location = new Point(723, 265);
            btn15.Name = "btn15";
            btn15.Size = new Size(178, 125);
            btn15.TabIndex = 15;
            btn15.UseVisualStyleBackColor = true;
            // 
            // btn16
            // 
            btn16.Dock = DockStyle.Fill;
            btn16.Location = new Point(3, 396);
            btn16.Name = "btn16";
            btn16.Size = new Size(174, 127);
            btn16.TabIndex = 16;
            btn16.UseVisualStyleBackColor = true;
            // 
            // btn17
            // 
            btn17.Dock = DockStyle.Fill;
            btn17.Location = new Point(183, 396);
            btn17.Name = "btn17";
            btn17.Size = new Size(174, 127);
            btn17.TabIndex = 17;
            btn17.UseVisualStyleBackColor = true;
            // 
            // btn18
            // 
            btn18.Dock = DockStyle.Fill;
            btn18.Location = new Point(363, 396);
            btn18.Name = "btn18";
            btn18.Size = new Size(174, 127);
            btn18.TabIndex = 18;
            btn18.UseVisualStyleBackColor = true;
            // 
            // btn19
            // 
            btn19.Dock = DockStyle.Fill;
            btn19.Location = new Point(543, 396);
            btn19.Name = "btn19";
            btn19.Size = new Size(174, 127);
            btn19.TabIndex = 19;
            btn19.UseVisualStyleBackColor = true;
            // 
            // btn20
            // 
            btn20.Dock = DockStyle.Fill;
            btn20.Location = new Point(723, 396);
            btn20.Name = "btn20";
            btn20.Size = new Size(178, 127);
            btn20.TabIndex = 20;
            btn20.UseVisualStyleBackColor = true;
            // 
            // frmMemory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 1331);
            Controls.Add(tblMain);
            Name = "frmMemory";
            Text = "Memory";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblTurn.ResumeLayout(false);
            tblTurn.PerformLayout();
            tblP1Score.ResumeLayout(false);
            tblP1Score.PerformLayout();
            tblP2Score.ResumeLayout(false);
            tblP2Score.PerformLayout();
            tblTiles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtPlayer1;
        private TextBox txtPlayer2;
        private Label lblTurn;
        private TableLayoutPanel tblTurn;
        private Label lblPlayerTurn;
        private Button btnStart;
        private TableLayoutPanel tblP1Score;
        private Label lblPlayer1;
        private Label lblP1Score;
        private TableLayoutPanel tblP2Score;
        private Label lblPlayer2;
        private Label lblP2Score;
        private TableLayoutPanel tblTiles;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn10;
        private Button btn11;
        private Button btn12;
        private Button btn13;
        private Button btn14;
        private Button btn15;
        private Button btn16;
        private Button btn17;
        private Button btn18;
        private Button btn19;
        private Button btn20;
    }
}