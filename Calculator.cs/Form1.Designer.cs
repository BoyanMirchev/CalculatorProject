namespace Calc
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblA = new Label();
            lblB = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            btnAdd = new Button();
            btnSub = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            lblResult = new Label();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(212, 83);
            lblA.Name = "lblA";
            lblA.Size = new Size(53, 15);
            lblA.TabIndex = 0;
            lblA.Text = "Число А";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(212, 114);
            lblB.Name = "lblB";
            lblB.Size = new Size(52, 15);
            lblB.TabIndex = 1;
            lblB.Text = "Число В";
            // 
            // txtA
            // 
            txtA.Location = new Point(320, 80);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 2;
            // 
            // txtB
            // 
            txtB.Location = new Point(320, 111);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(330, 160);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(330, 189);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(75, 23);
            btnSub.TabIndex = 5;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(330, 218);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(75, 23);
            btnMul.TabIndex = 6;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(330, 247);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(75, 23);
            btnDiv.TabIndex = 7;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(467, 99);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(57, 15);
            lblResult.TabIndex = 8;
            lblResult.Text = "Резултат:";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(530, 96);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(100, 23);
            txtResult.TabIndex = 9;
            // 
            // Form1
            // 
            ClientSize = new Size(839, 454);
            Controls.Add(txtResult);
            Controls.Add(lblResult);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblA;
        private Label lblB;
        private TextBox txtA;
        private TextBox txtB;
        private Button btnAdd;
        private Button btnSub;
        private Button btnMul;
        private Button btnDiv;
        private Label lblResult;
        private TextBox txtResult;
    }
}
