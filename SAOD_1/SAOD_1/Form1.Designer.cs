
namespace SAOD_1
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
            this.create = new System.Windows.Forms.Button();
            this.push = new System.Windows.Forms.Button();
            this.pop = new System.Windows.Forms.Button();
            this.top = new System.Windows.Forms.Button();
            this.tb_create = new System.Windows.Forms.TextBox();
            this.tb_push = new System.Windows.Forms.TextBox();
            this.tb_pop = new System.Windows.Forms.TextBox();
            this.tb_top = new System.Windows.Forms.TextBox();
            this.st_arr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(12, 12);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 0;
            this.create.Text = "CREATE";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // push
            // 
            this.push.Location = new System.Drawing.Point(12, 67);
            this.push.Name = "push";
            this.push.Size = new System.Drawing.Size(75, 23);
            this.push.TabIndex = 1;
            this.push.Text = "PUSH";
            this.push.UseVisualStyleBackColor = true;
            this.push.Click += new System.EventHandler(this.push_Click);
            // 
            // pop
            // 
            this.pop.Location = new System.Drawing.Point(12, 122);
            this.pop.Name = "pop";
            this.pop.Size = new System.Drawing.Size(75, 23);
            this.pop.TabIndex = 2;
            this.pop.Text = "POP";
            this.pop.UseVisualStyleBackColor = true;
            this.pop.Click += new System.EventHandler(this.pop_Click);
            // 
            // top
            // 
            this.top.Location = new System.Drawing.Point(12, 177);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(75, 23);
            this.top.TabIndex = 3;
            this.top.Text = "TOP";
            this.top.UseVisualStyleBackColor = true;
            this.top.Click += new System.EventHandler(this.top_Click);
            // 
            // tb_create
            // 
            this.tb_create.Location = new System.Drawing.Point(12, 41);
            this.tb_create.Name = "tb_create";
            this.tb_create.Size = new System.Drawing.Size(75, 20);
            this.tb_create.TabIndex = 4;
            // 
            // tb_push
            // 
            this.tb_push.Location = new System.Drawing.Point(12, 96);
            this.tb_push.Name = "tb_push";
            this.tb_push.Size = new System.Drawing.Size(75, 20);
            this.tb_push.TabIndex = 5;
            // 
            // tb_pop
            // 
            this.tb_pop.Location = new System.Drawing.Point(12, 151);
            this.tb_pop.Name = "tb_pop";
            this.tb_pop.Size = new System.Drawing.Size(75, 20);
            this.tb_pop.TabIndex = 6;
            // 
            // tb_top
            // 
            this.tb_top.Location = new System.Drawing.Point(12, 206);
            this.tb_top.Name = "tb_top";
            this.tb_top.Size = new System.Drawing.Size(75, 20);
            this.tb_top.TabIndex = 7;
            // 
            // st_arr
            // 
            this.st_arr.Location = new System.Drawing.Point(93, 12);
            this.st_arr.Multiline = true;
            this.st_arr.Name = "st_arr";
            this.st_arr.Size = new System.Drawing.Size(109, 214);
            this.st_arr.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 239);
            this.Controls.Add(this.st_arr);
            this.Controls.Add(this.tb_top);
            this.Controls.Add(this.tb_pop);
            this.Controls.Add(this.tb_push);
            this.Controls.Add(this.tb_create);
            this.Controls.Add(this.top);
            this.Controls.Add(this.pop);
            this.Controls.Add(this.push);
            this.Controls.Add(this.create);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button push;
        private System.Windows.Forms.Button pop;
        private System.Windows.Forms.Button top;
        private System.Windows.Forms.TextBox tb_create;
        private System.Windows.Forms.TextBox tb_push;
        private System.Windows.Forms.TextBox tb_pop;
        private System.Windows.Forms.TextBox tb_top;
        private System.Windows.Forms.TextBox st_arr;
    }
}

