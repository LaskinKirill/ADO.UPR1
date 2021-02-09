
namespace WFUPR2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.подклБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отклБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSet1 = new System.Data.DataSet();
            this.asyncBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПодклToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Работа с БД";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подклБДToolStripMenuItem,
            this.отклБДToolStripMenuItem,
            this.asyncBDToolStripMenuItem,
            this.списокПодклToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 20);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // подклБДToolStripMenuItem
            // 
            this.подклБДToolStripMenuItem.Name = "подклБДToolStripMenuItem";
            this.подклБДToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.подклБДToolStripMenuItem.Text = "&ПодклБД";
            this.подклБДToolStripMenuItem.Click += new System.EventHandler(this.подклБДToolStripMenuItem_Click);
            // 
            // отклБДToolStripMenuItem
            // 
            this.отклБДToolStripMenuItem.Name = "отклБДToolStripMenuItem";
            this.отклБДToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отклБДToolStripMenuItem.Text = "&ОтклБД";
            this.отклБДToolStripMenuItem.Click += new System.EventHandler(this.отклБДToolStripMenuItem_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // asyncBDToolStripMenuItem
            // 
            this.asyncBDToolStripMenuItem.Name = "asyncBDToolStripMenuItem";
            this.asyncBDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.asyncBDToolStripMenuItem.Text = "&AsyncBD";
            this.asyncBDToolStripMenuItem.Click += new System.EventHandler(this.asyncBDToolStripMenuItem_Click);
            // 
            // списокПодклToolStripMenuItem
            // 
            this.списокПодклToolStripMenuItem.Name = "списокПодклToolStripMenuItem";
            this.списокПодклToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.списокПодклToolStripMenuItem.Text = "&СписокПодкл";
            this.списокПодклToolStripMenuItem.Click += new System.EventHandler(this.списокПодклToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem подклБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отклБДToolStripMenuItem;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.ToolStripMenuItem asyncBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПодклToolStripMenuItem;
    }
}

