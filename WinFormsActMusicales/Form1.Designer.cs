namespace WinFormsActMusicales
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            btnMostrar = new Button();
            txtNombre = new TextBox();
            txtDesc = new TextBox();
            txtLugar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            btnInsertar = new Button();
            button1 = new Button();
            btnEliminar = new Button();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(60, 338);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(853, 213);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(801, 566);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(112, 49);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Consultar tabla";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(60, 143);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(259, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(60, 200);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(259, 27);
            txtDesc.TabIndex = 3;
            // 
            // txtLugar
            // 
            txtLugar.Location = new Point(456, 200);
            txtLugar.Name = "txtLugar";
            txtLugar.Size = new Size(230, 27);
            txtLugar.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 111);
            label1.Name = "label1";
            label1.Size = new Size(168, 20);
            label1.TabIndex = 6;
            label1.Text = "Nombre de la Actividad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 177);
            label2.Name = "label2";
            label2.Size = new Size(187, 20);
            label2.TabIndex = 7;
            label2.Text = "Descrpcion de la Actividad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 247);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 8;
            label3.Text = "Tipo de Actividad";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(60, 279);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(456, 111);
            label4.Name = "label4";
            label4.Size = new Size(151, 20);
            label4.TabIndex = 11;
            label4.Text = "Fecha de la Actividad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(456, 177);
            label5.Name = "label5";
            label5.Size = new Size(150, 20);
            label5.TabIndex = 12;
            label5.Text = "Lugar de la Actividad";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(801, 121);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(112, 49);
            btnInsertar.TabIndex = 13;
            btnInsertar.Text = "Insertar Actividad";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(801, 189);
            button1.Name = "button1";
            button1.Size = new Size(112, 49);
            button1.TabIndex = 14;
            button1.Text = "Editar Actividad";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(801, 258);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 49);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar Actividad";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(456, 143);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 640);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnEliminar);
            Controls.Add(button1);
            Controls.Add(btnInsertar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLugar);
            Controls.Add(txtDesc);
            Controls.Add(txtNombre);
            Controls.Add(btnMostrar);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnMostrar;
        private TextBox txtNombre;
        private TextBox txtDesc;
        private TextBox txtLugar;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private Button btnInsertar;
        private Button button1;
        private Button btnEliminar;
        private DateTimePicker dateTimePicker1;
    }
}
