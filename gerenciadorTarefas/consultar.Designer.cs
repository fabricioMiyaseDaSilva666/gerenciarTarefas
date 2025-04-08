namespace gerenciadorTarefas
{
    partial class consultar
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
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.atualizarTarefa = new System.Windows.Forms.Button();
            this.novaTarefa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(227)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(222)))), ((int)(((byte)(227)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(576, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 29);
            this.button2.TabIndex = 56;
            this.button2.Text = "5      Consultar tarefas";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(175)))), ((int)(((byte)(223)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(175)))), ((int)(((byte)(223)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Swis721 WGL4 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.AliceBlue;
            this.button4.Location = new System.Drawing.Point(-1, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(800, 64);
            this.button4.TabIndex = 55;
            this.button4.Text = "TAREFAS";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(239)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(239)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(410, 73);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 29);
            this.button5.TabIndex = 54;
            this.button5.Text = "3       Editar tarefa";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // atualizarTarefa
            // 
            this.atualizarTarefa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.atualizarTarefa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.atualizarTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atualizarTarefa.ForeColor = System.Drawing.Color.Black;
            this.atualizarTarefa.Location = new System.Drawing.Point(242, 73);
            this.atualizarTarefa.Name = "atualizarTarefa";
            this.atualizarTarefa.Size = new System.Drawing.Size(135, 29);
            this.atualizarTarefa.TabIndex = 53;
            this.atualizarTarefa.Text = "2       Adicionar tarefa";
            this.atualizarTarefa.UseVisualStyleBackColor = false;
            this.atualizarTarefa.Click += new System.EventHandler(this.atualizarTarefa_Click);
            // 
            // novaTarefa
            // 
            this.novaTarefa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(238)))), ((int)(((byte)(227)))));
            this.novaTarefa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(238)))), ((int)(((byte)(227)))));
            this.novaTarefa.FlatAppearance.BorderSize = 4;
            this.novaTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novaTarefa.ForeColor = System.Drawing.Color.Black;
            this.novaTarefa.Location = new System.Drawing.Point(73, 73);
            this.novaTarefa.Name = "novaTarefa";
            this.novaTarefa.Size = new System.Drawing.Size(135, 29);
            this.novaTarefa.TabIndex = 52;
            this.novaTarefa.Text = "1        Listar Tarefas";
            this.novaTarefa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.novaTarefa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.novaTarefa.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(159, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 234);
            this.dataGridView1.TabIndex = 57;
            // 
            // consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 466);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.atualizarTarefa);
            this.Controls.Add(this.novaTarefa);
            this.Name = "consultar";
            this.Text = "consultar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button atualizarTarefa;
        private System.Windows.Forms.Button novaTarefa;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}