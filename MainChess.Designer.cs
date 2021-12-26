
namespace CousreWork
{
    partial class MainChess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainChess));
            this.ButAdd = new System.Windows.Forms.Button();
            this.ButUpdate = new System.Windows.Forms.Button();
            this.DataGridMain = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ПН = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ВТ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СР = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ЧТ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ПТ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СБ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ВС = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTXT = new System.Windows.Forms.Button();
            this.ButRight = new System.Windows.Forms.Button();
            this.ButLeft = new System.Windows.Forms.Button();
            this.ButDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ButAdd
            // 
            this.ButAdd.Location = new System.Drawing.Point(43, 12);
            this.ButAdd.Name = "ButAdd";
            this.ButAdd.Size = new System.Drawing.Size(75, 23);
            this.ButAdd.TabIndex = 0;
            this.ButAdd.Text = "Add";
            this.ButAdd.UseVisualStyleBackColor = true;
            this.ButAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButUpdate
            // 
            this.ButUpdate.Location = new System.Drawing.Point(124, 12);
            this.ButUpdate.Name = "ButUpdate";
            this.ButUpdate.Size = new System.Drawing.Size(75, 23);
            this.ButUpdate.TabIndex = 1;
            this.ButUpdate.Text = "Update";
            this.ButUpdate.UseVisualStyleBackColor = true;
            this.ButUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // DataGridMain
            // 
            this.DataGridMain.AllowUserToAddRows = false;
            this.DataGridMain.AllowUserToDeleteRows = false;
            this.DataGridMain.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.ПН,
            this.ВТ,
            this.СР,
            this.ЧТ,
            this.ПТ,
            this.СБ,
            this.ВС});
            this.DataGridMain.Location = new System.Drawing.Point(43, 41);
            this.DataGridMain.Name = "DataGridMain";
            this.DataGridMain.ReadOnly = true;
            this.DataGridMain.Size = new System.Drawing.Size(843, 430);
            this.DataGridMain.TabIndex = 4;
            this.DataGridMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Time
            // 
            this.Time.Frozen = true;
            this.Time.HeaderText = "Время";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // ПН
            // 
            this.ПН.Frozen = true;
            this.ПН.HeaderText = "ПН";
            this.ПН.Name = "ПН";
            this.ПН.ReadOnly = true;
            // 
            // ВТ
            // 
            this.ВТ.Frozen = true;
            this.ВТ.HeaderText = "ВТ";
            this.ВТ.Name = "ВТ";
            this.ВТ.ReadOnly = true;
            // 
            // СР
            // 
            this.СР.Frozen = true;
            this.СР.HeaderText = "СР";
            this.СР.Name = "СР";
            this.СР.ReadOnly = true;
            // 
            // ЧТ
            // 
            this.ЧТ.Frozen = true;
            this.ЧТ.HeaderText = "ЧТ";
            this.ЧТ.Name = "ЧТ";
            this.ЧТ.ReadOnly = true;
            // 
            // ПТ
            // 
            this.ПТ.Frozen = true;
            this.ПТ.HeaderText = "ПТ";
            this.ПТ.Name = "ПТ";
            this.ПТ.ReadOnly = true;
            // 
            // СБ
            // 
            this.СБ.Frozen = true;
            this.СБ.HeaderText = "СБ";
            this.СБ.Name = "СБ";
            this.СБ.ReadOnly = true;
            // 
            // ВС
            // 
            this.ВС.Frozen = true;
            this.ВС.HeaderText = "ВС";
            this.ВС.Name = "ВС";
            this.ВС.ReadOnly = true;
            // 
            // CreateTXT
            // 
            this.CreateTXT.Location = new System.Drawing.Point(789, 12);
            this.CreateTXT.Name = "CreateTXT";
            this.CreateTXT.Size = new System.Drawing.Size(97, 23);
            this.CreateTXT.TabIndex = 5;
            this.CreateTXT.Text = "Create a TXT";
            this.CreateTXT.UseVisualStyleBackColor = true;
            this.CreateTXT.Visible = false;
            this.CreateTXT.Click += new System.EventHandler(this.button4_Click);
            // 
            // ButRight
            // 
            this.ButRight.Location = new System.Drawing.Point(10, 214);
            this.ButRight.Name = "ButRight";
            this.ButRight.Size = new System.Drawing.Size(27, 22);
            this.ButRight.TabIndex = 6;
            this.ButRight.Text = "<=";
            this.ButRight.UseVisualStyleBackColor = true;
            this.ButRight.Click += new System.EventHandler(this.button5_Click);
            // 
            // ButLeft
            // 
            this.ButLeft.Location = new System.Drawing.Point(892, 214);
            this.ButLeft.Name = "ButLeft";
            this.ButLeft.Size = new System.Drawing.Size(27, 22);
            this.ButLeft.TabIndex = 7;
            this.ButLeft.Text = "=>";
            this.ButLeft.UseVisualStyleBackColor = true;
            this.ButLeft.Click += new System.EventHandler(this.button6_Click);
            // 
            // ButDelete
            // 
            this.ButDelete.Location = new System.Drawing.Point(287, 11);
            this.ButDelete.Name = "ButDelete";
            this.ButDelete.Size = new System.Drawing.Size(75, 23);
            this.ButDelete.TabIndex = 8;
            this.ButDelete.Text = "Delete";
            this.ButDelete.UseVisualStyleBackColor = true;
            this.ButDelete.Click += new System.EventHandler(this.ButDelete_Click);
            // 
            // MainChess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(930, 484);
            this.Controls.Add(this.ButDelete);
            this.Controls.Add(this.ButLeft);
            this.Controls.Add(this.ButRight);
            this.Controls.Add(this.CreateTXT);
            this.Controls.Add(this.DataGridMain);
            this.Controls.Add(this.ButUpdate);
            this.Controls.Add(this.ButAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainChess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButAdd;
        private System.Windows.Forms.Button ButUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn ПН;
        private System.Windows.Forms.DataGridViewTextBoxColumn ВТ;
        private System.Windows.Forms.DataGridViewTextBoxColumn СР;
        private System.Windows.Forms.DataGridViewTextBoxColumn ЧТ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ПТ;
        private System.Windows.Forms.DataGridViewTextBoxColumn СБ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ВС;
        private System.Windows.Forms.Button CreateTXT;
        private System.Windows.Forms.Button ButRight;
        private System.Windows.Forms.Button ButLeft;
        private System.Windows.Forms.Button ButDelete;
        public System.Windows.Forms.DataGridView DataGridMain;
    }
}