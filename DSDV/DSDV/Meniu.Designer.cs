namespace DSDV
{
    partial class Meniu
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRouterToDelete = new System.Windows.Forms.TextBox();
            this.buttonRouterToDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLinkToDeleteA = new System.Windows.Forms.TextBox();
            this.textBoxLinkToDeleteB = new System.Windows.Forms.TextBox();
            this.buttonLinkToDelete = new System.Windows.Forms.Button();
            this.labelInfoLine = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRefreshTime = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAddRouter = new System.Windows.Forms.TextBox();
            this.textBoxAddLinkA = new System.Windows.Forms.TextBox();
            this.textBoxAddLinkB = new System.Windows.Forms.TextBox();
            this.buttonDeleteLink = new System.Windows.Forms.Button();
            this.buttonAddRouter = new System.Windows.Forms.Button();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMessageAt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.PRINT = new System.Windows.Forms.CheckBox();
            this.buttonNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxRefreshTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Router";
            // 
            // textBoxRouterToDelete
            // 
            this.textBoxRouterToDelete.Location = new System.Drawing.Point(57, 36);
            this.textBoxRouterToDelete.Name = "textBoxRouterToDelete";
            this.textBoxRouterToDelete.Size = new System.Drawing.Size(252, 20);
            this.textBoxRouterToDelete.TabIndex = 1;
            // 
            // buttonRouterToDelete
            // 
            this.buttonRouterToDelete.Location = new System.Drawing.Point(332, 39);
            this.buttonRouterToDelete.Name = "buttonRouterToDelete";
            this.buttonRouterToDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonRouterToDelete.TabIndex = 2;
            this.buttonRouterToDelete.Text = "Delete";
            this.buttonRouterToDelete.UseVisualStyleBackColor = true;
            this.buttonRouterToDelete.Click += new System.EventHandler(this.buttonRouterToDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Link";
            // 
            // textBoxLinkToDeleteA
            // 
            this.textBoxLinkToDeleteA.Location = new System.Drawing.Point(57, 64);
            this.textBoxLinkToDeleteA.Name = "textBoxLinkToDeleteA";
            this.textBoxLinkToDeleteA.Size = new System.Drawing.Size(127, 20);
            this.textBoxLinkToDeleteA.TabIndex = 4;
            // 
            // textBoxLinkToDeleteB
            // 
            this.textBoxLinkToDeleteB.Location = new System.Drawing.Point(190, 64);
            this.textBoxLinkToDeleteB.Name = "textBoxLinkToDeleteB";
            this.textBoxLinkToDeleteB.Size = new System.Drawing.Size(119, 20);
            this.textBoxLinkToDeleteB.TabIndex = 5;
            // 
            // buttonLinkToDelete
            // 
            this.buttonLinkToDelete.Location = new System.Drawing.Point(332, 67);
            this.buttonLinkToDelete.Name = "buttonLinkToDelete";
            this.buttonLinkToDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonLinkToDelete.TabIndex = 6;
            this.buttonLinkToDelete.Text = "Delete";
            this.buttonLinkToDelete.UseVisualStyleBackColor = true;
            this.buttonLinkToDelete.Click += new System.EventHandler(this.buttonLinkToDelete_Click);
            // 
            // labelInfoLine
            // 
            this.labelInfoLine.AutoSize = true;
            this.labelInfoLine.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoLine.ForeColor = System.Drawing.Color.Black;
            this.labelInfoLine.Location = new System.Drawing.Point(19, 263);
            this.labelInfoLine.Name = "labelInfoLine";
            this.labelInfoLine.Size = new System.Drawing.Size(0, 18);
            this.labelInfoLine.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Refresh time";
            // 
            // textBoxRefreshTime
            // 
            this.textBoxRefreshTime.Location = new System.Drawing.Point(413, 14);
            this.textBoxRefreshTime.Name = "textBoxRefreshTime";
            this.textBoxRefreshTime.Size = new System.Drawing.Size(50, 20);
            this.textBoxRefreshTime.TabIndex = 26;
            this.textBoxRefreshTime.ValueChanged += new System.EventHandler(this.textBoxRefreshTime_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Router";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Link";
            // 
            // textBoxAddRouter
            // 
            this.textBoxAddRouter.Location = new System.Drawing.Point(57, 93);
            this.textBoxAddRouter.Name = "textBoxAddRouter";
            this.textBoxAddRouter.Size = new System.Drawing.Size(252, 20);
            this.textBoxAddRouter.TabIndex = 8;
            // 
            // textBoxAddLinkA
            // 
            this.textBoxAddLinkA.Location = new System.Drawing.Point(57, 121);
            this.textBoxAddLinkA.Name = "textBoxAddLinkA";
            this.textBoxAddLinkA.Size = new System.Drawing.Size(32, 20);
            this.textBoxAddLinkA.TabIndex = 11;
            // 
            // textBoxAddLinkB
            // 
            this.textBoxAddLinkB.Location = new System.Drawing.Point(95, 121);
            this.textBoxAddLinkB.Name = "textBoxAddLinkB";
            this.textBoxAddLinkB.Size = new System.Drawing.Size(32, 20);
            this.textBoxAddLinkB.TabIndex = 12;
            // 
            // buttonDeleteLink
            // 
            this.buttonDeleteLink.Location = new System.Drawing.Point(332, 119);
            this.buttonDeleteLink.Name = "buttonDeleteLink";
            this.buttonDeleteLink.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteLink.TabIndex = 14;
            this.buttonDeleteLink.Text = "Add";
            this.buttonDeleteLink.UseVisualStyleBackColor = true;
            this.buttonDeleteLink.Click += new System.EventHandler(this.buttonAddLink_Click);
            // 
            // buttonAddRouter
            // 
            this.buttonAddRouter.Location = new System.Drawing.Point(332, 96);
            this.buttonAddRouter.Name = "buttonAddRouter";
            this.buttonAddRouter.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRouter.TabIndex = 9;
            this.buttonAddRouter.Text = "Add";
            this.buttonAddRouter.UseVisualStyleBackColor = true;
            this.buttonAddRouter.Click += new System.EventHandler(this.buttonAddRouter_Click);
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(137, 121);
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownWeight.TabIndex = 13;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(190, 195);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 21;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(73, 197);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(32, 20);
            this.textBoxFrom.TabIndex = 18;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(137, 197);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(32, 20);
            this.textBoxTo.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "To";
            // 
            // textBoxMessageAt
            // 
            this.textBoxMessageAt.Enabled = false;
            this.textBoxMessageAt.Location = new System.Drawing.Point(137, 221);
            this.textBoxMessageAt.Name = "textBoxMessageAt";
            this.textBoxMessageAt.Size = new System.Drawing.Size(33, 20);
            this.textBoxMessageAt.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Message at";
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(413, 119);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 15;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click_1);
            // 
            // PRINT
            // 
            this.PRINT.AutoSize = true;
            this.PRINT.Location = new System.Drawing.Point(429, 40);
            this.PRINT.Name = "PRINT";
            this.PRINT.Size = new System.Drawing.Size(59, 17);
            this.PRINT.TabIndex = 27;
            this.PRINT.Text = "PRINT";
            this.PRINT.UseVisualStyleBackColor = true;
            this.PRINT.CheckedChanged += new System.EventHandler(this.PRINT_CheckedChanged);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(190, 219);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 22;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(498, 324);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.PRINT);
            this.Controls.Add(this.numericUpDownWeight);
            this.Controls.Add(this.textBoxRefreshTime);
            this.Controls.Add(this.labelInfoLine);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDeleteLink);
            this.Controls.Add(this.buttonLinkToDelete);
            this.Controls.Add(this.buttonAddRouter);
            this.Controls.Add(this.buttonRouterToDelete);
            this.Controls.Add(this.textBoxAddLinkB);
            this.Controls.Add(this.textBoxLinkToDeleteB);
            this.Controls.Add(this.textBoxAddLinkA);
            this.Controls.Add(this.textBoxMessageAt);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.textBoxLinkToDeleteA);
            this.Controls.Add(this.textBoxAddRouter);
            this.Controls.Add(this.textBoxRouterToDelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Meniu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meniu";
            ((System.ComponentModel.ISupportInitialize)(this.textBoxRefreshTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRouterToDelete;
        private System.Windows.Forms.Button buttonRouterToDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLinkToDeleteA;
        private System.Windows.Forms.TextBox textBoxLinkToDeleteB;
        private System.Windows.Forms.Button buttonLinkToDelete;
        private System.Windows.Forms.Label labelInfoLine;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown textBoxRefreshTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAddRouter;
        private System.Windows.Forms.TextBox textBoxAddLinkA;
        private System.Windows.Forms.TextBox textBoxAddLinkB;
        private System.Windows.Forms.Button buttonDeleteLink;
        private System.Windows.Forms.Button buttonAddRouter;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMessageAt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.CheckBox PRINT;
        private System.Windows.Forms.Button buttonNext;
    }
}