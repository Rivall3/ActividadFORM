
namespace ActividadFORM
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboCurso = new System.Windows.Forms.ComboBox();
            this.gridAlum = new System.Windows.Forms.DataGridView();
            this.gridProfe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfe)).BeginInit();
            this.SuspendLayout();
            // 
            // comboCurso
            // 
            this.comboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCurso.FormattingEnabled = true;
            this.comboCurso.Location = new System.Drawing.Point(61, 88);
            this.comboCurso.Name = "comboCurso";
            this.comboCurso.Size = new System.Drawing.Size(176, 24);
            this.comboCurso.TabIndex = 0;
            this.comboCurso.SelectedIndexChanged += new System.EventHandler(this.comboCurso_SelectedIndexChanged);
            // 
            // gridAlum
            // 
            this.gridAlum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlum.Location = new System.Drawing.Point(336, 79);
            this.gridAlum.Name = "gridAlum";
            this.gridAlum.RowHeadersWidth = 51;
            this.gridAlum.RowTemplate.Height = 24;
            this.gridAlum.Size = new System.Drawing.Size(431, 141);
            this.gridAlum.TabIndex = 1;
            // 
            // gridProfe
            // 
            this.gridProfe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProfe.Location = new System.Drawing.Point(336, 248);
            this.gridProfe.Name = "gridProfe";
            this.gridProfe.RowHeadersWidth = 51;
            this.gridProfe.RowTemplate.Height = 24;
            this.gridProfe.Size = new System.Drawing.Size(431, 143);
            this.gridProfe.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridProfe);
            this.Controls.Add(this.gridAlum);
            this.Controls.Add(this.comboCurso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAlum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCurso;
        private System.Windows.Forms.DataGridView gridAlum;
        private System.Windows.Forms.DataGridView gridProfe;
    }
}

