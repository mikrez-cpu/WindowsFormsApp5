namespace WindowsFormsApp5
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
            this.components = new System.ComponentModel.Container();
            this.AnT = new OpenTK.GLControl();
            this.PointinGrap = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // AnT
            // 
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.Location = new System.Drawing.Point(13, 13);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(776, 426);
            this.AnT.TabIndex = 0;
            this.AnT.VSync = false;
            this.AnT.Load += new System.EventHandler(this.AnT_Load);
            this.AnT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseMove);
            // 
            // PointinGrap
            // 
            this.PointinGrap.Interval = 30;
            this.PointinGrap.Tick += new System.EventHandler(this.PointinGrap_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AnT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private OpenTK.GLControl AnT;
        private System.Windows.Forms.Timer PointinGrap;
    }
}

