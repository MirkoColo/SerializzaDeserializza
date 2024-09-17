namespace SerializzaDeserializza
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_titolo = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Titolo = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_autore = new System.Windows.Forms.TextBox();
            this.listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_titolo
            // 
            this.txt_titolo.Location = new System.Drawing.Point(372, 186);
            this.txt_titolo.Name = "txt_titolo";
            this.txt_titolo.Size = new System.Drawing.Size(100, 20);
            this.txt_titolo.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Titolo
            // 
            this.Titolo.AutoSize = true;
            this.Titolo.Location = new System.Drawing.Point(369, 170);
            this.Titolo.Name = "Titolo";
            this.Titolo.Size = new System.Drawing.Size(33, 13);
            this.Titolo.TabIndex = 2;
            this.Titolo.Text = "Titolo";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(210, 165);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(117, 61);
            this.btn_create.TabIndex = 3;
            this.btn_create.Text = "CREATE";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(210, 251);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(117, 61);
            this.btn_read.TabIndex = 4;
            this.btn_read.Text = "READ";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(210, 328);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(117, 61);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(210, 411);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(117, 61);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Autore";
            // 
            // txt_autore
            // 
            this.txt_autore.Location = new System.Drawing.Point(372, 251);
            this.txt_autore.Name = "txt_autore";
            this.txt_autore.Size = new System.Drawing.Size(100, 20);
            this.txt_autore.TabIndex = 7;
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.Location = new System.Drawing.Point(557, 170);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(234, 303);
            this.listbox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 835);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_autore);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.Titolo);
            this.Controls.Add(this.txt_titolo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_titolo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Titolo;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_autore;
        private System.Windows.Forms.ListBox listbox;
    }
}

