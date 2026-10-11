namespace TH5C
{
    partial class fmMauListBox
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
            lstTrai = new ListBox();
            lstPhai = new ListBox();
            btnPhai = new Button();
            btnPhaiAll = new Button();
            btnTrai = new Button();
            btnTraiAll = new Button();
            btnTuyY = new Button();
            SuspendLayout();
            // 
            // lstTrai
            // 
            lstTrai.FormattingEnabled = true;
            lstTrai.Location = new Point(93, 93);
            lstTrai.Name = "lstTrai";
            lstTrai.SelectionMode = SelectionMode.MultiExtended;
            lstTrai.Size = new Size(150, 224);
            lstTrai.TabIndex = 0;
            // 
            // lstPhai
            // 
            lstPhai.FormattingEnabled = true;
            lstPhai.Location = new Point(534, 93);
            lstPhai.Name = "lstPhai";
            lstPhai.SelectionMode = SelectionMode.MultiExtended;
            lstPhai.Size = new Size(150, 224);
            lstPhai.TabIndex = 1;
            // 
            // btnPhai
            // 
            btnPhai.Location = new Point(332, 93);
            btnPhai.Name = "btnPhai";
            btnPhai.Size = new Size(94, 29);
            btnPhai.TabIndex = 2;
            btnPhai.Text = ">";
            btnPhai.UseVisualStyleBackColor = true;
            // 
            // btnPhaiAll
            // 
            btnPhaiAll.Location = new Point(332, 138);
            btnPhaiAll.Name = "btnPhaiAll";
            btnPhaiAll.Size = new Size(94, 29);
            btnPhaiAll.TabIndex = 3;
            btnPhaiAll.Text = ">>";
            btnPhaiAll.UseVisualStyleBackColor = true;
            // 
            // btnTrai
            // 
            btnTrai.Location = new Point(332, 191);
            btnTrai.Name = "btnTrai";
            btnTrai.Size = new Size(94, 29);
            btnTrai.TabIndex = 4;
            btnTrai.Text = "<";
            btnTrai.UseVisualStyleBackColor = true;
            // 
            // btnTraiAll
            // 
            btnTraiAll.Location = new Point(332, 239);
            btnTraiAll.Name = "btnTraiAll";
            btnTraiAll.Size = new Size(94, 29);
            btnTraiAll.TabIndex = 5;
            btnTraiAll.Text = "<<";
            btnTraiAll.UseVisualStyleBackColor = true;
            // 
            // btnTuyY
            // 
            btnTuyY.Location = new Point(301, 288);
            btnTuyY.Name = "btnTuyY";
            btnTuyY.Size = new Size(166, 29);
            btnTuyY.TabIndex = 6;
            btnTuyY.Text = "Chuyển tuỳ ý";
            btnTuyY.UseVisualStyleBackColor = true;
            // 
            // fmMauListBox
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 388);
            Controls.Add(btnTuyY);
            Controls.Add(btnTraiAll);
            Controls.Add(btnTrai);
            Controls.Add(btnPhaiAll);
            Controls.Add(btnPhai);
            Controls.Add(lstPhai);
            Controls.Add(lstTrai);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fmMauListBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sử dụng ListBox";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstTrai;
        private ListBox lstPhai;
        private Button btnPhai;
        private Button btnPhaiAll;
        private Button btnTrai;
        private Button btnTraiAll;
        private Button btnTuyY;
    }
}
