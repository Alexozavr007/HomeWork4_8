namespace HomeWork4_8_2 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btn1 = new Button();
            btn2 = new Button();
            txtXml = new TextBox();
            propertyGrid1 = new PropertyGrid();
            propertyGrid2 = new PropertyGrid();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            rbSerializeDefault = new RadioButton();
            rbSerializeModified = new RadioButton();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(400, 179);
            btn1.Name = "btn1";
            btn1.Size = new Size(108, 44);
            btn1.TabIndex = 0;
            btn1.Text = "Сереалізувати";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(400, 352);
            btn2.Name = "btn2";
            btn2.Size = new Size(108, 44);
            btn2.TabIndex = 1;
            btn2.Text = "Десереалізувати";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // txtXml
            // 
            txtXml.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtXml.BackColor = Color.White;
            txtXml.Location = new Point(12, 245);
            txtXml.Multiline = true;
            txtXml.Name = "txtXml";
            txtXml.ReadOnly = true;
            txtXml.ScrollBars = ScrollBars.Vertical;
            txtXml.Size = new Size(886, 101);
            txtXml.TabIndex = 2;
            // 
            // propertyGrid1
            // 
            propertyGrid1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            propertyGrid1.HelpVisible = false;
            propertyGrid1.Location = new Point(12, 58);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.PropertySort = PropertySort.Alphabetical;
            propertyGrid1.Size = new Size(886, 115);
            propertyGrid1.TabIndex = 3;
            propertyGrid1.ToolbarVisible = false;
            // 
            // propertyGrid2
            // 
            propertyGrid2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            propertyGrid2.HelpVisible = false;
            propertyGrid2.Location = new Point(12, 422);
            propertyGrid2.Name = "propertyGrid2";
            propertyGrid2.PropertySort = PropertySort.Alphabetical;
            propertyGrid2.Size = new Size(886, 150);
            propertyGrid2.TabIndex = 3;
            propertyGrid2.ToolbarVisible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 227);
            label1.Name = "label1";
            label1.Size = new Size(155, 15);
            label1.TabIndex = 4;
            label1.Text = "XML результат сереалізації";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 4;
            label2.Text = "Об'єкт для сереалізації";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 404);
            label3.Name = "label3";
            label3.Size = new Size(185, 15);
            label3.TabIndex = 4;
            label3.Text = "Результат десереалізації (об'єкт)";
            // 
            // rbSerializeDefault
            // 
            rbSerializeDefault.AutoSize = true;
            rbSerializeDefault.Checked = true;
            rbSerializeDefault.Location = new Point(12, 12);
            rbSerializeDefault.Name = "rbSerializeDefault";
            rbSerializeDefault.Size = new Size(134, 19);
            rbSerializeDefault.TabIndex = 5;
            rbSerializeDefault.TabStop = true;
            rbSerializeDefault.Text = "Default сереалізація";
            rbSerializeDefault.UseVisualStyleBackColor = true;
            rbSerializeDefault.CheckedChanged += SerializationModeChanged;
            // 
            // rbSerializeModified
            // 
            rbSerializeModified.AutoSize = true;
            rbSerializeModified.Location = new Point(152, 12);
            rbSerializeModified.Name = "rbSerializeModified";
            rbSerializeModified.Size = new Size(234, 19);
            rbSerializeModified.TabIndex = 5;
            rbSerializeModified.Text = "Сереалізація властивостей в атрибути";
            rbSerializeModified.UseVisualStyleBackColor = true;
            rbSerializeModified.CheckedChanged += SerializationModeChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 584);
            Controls.Add(rbSerializeModified);
            Controls.Add(rbSerializeDefault);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(propertyGrid2);
            Controls.Add(propertyGrid1);
            Controls.Add(txtXml);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private TextBox txtXml;
        private PropertyGrid propertyGrid1;
        private PropertyGrid propertyGrid2;
        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton rbSerializeDefault;
        private RadioButton rbSerializeModified;
    }
}
