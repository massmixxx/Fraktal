namespace Fraktal
{
    partial class Form2
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.axoimInput = new System.Windows.Forms.TextBox();
            this.axoimLabel = new System.Windows.Forms.Label();
            this.roleInput_1 = new System.Windows.Forms.TextBox();
            this.roleInput_2 = new System.Windows.Forms.TextBox();
            this.roleInput_3 = new System.Windows.Forms.TextBox();
            this.roleInput_4 = new System.Windows.Forms.TextBox();
            this.roleInput_5 = new System.Windows.Forms.TextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.angleInput = new System.Windows.Forms.NumericUpDown();
            this.iterationsInput = new System.Windows.Forms.NumericUpDown();
            this.angleLabel = new System.Windows.Forms.Label();
            this.iterationsLabel = new System.Windows.Forms.Label();
            this.rolesLabel = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.item_sierpinski = new System.Windows.Forms.ToolStripMenuItem();
            this.sierpinski_item_triangles = new System.Windows.Forms.ToolStripMenuItem();
            this.sierpinski_item_curves = new System.Windows.Forms.ToolStripMenuItem();
            this.sierpinskie_item_carpet = new System.Windows.Forms.ToolStripMenuItem();
            this.item_koch = new System.Windows.Forms.ToolStripMenuItem();
            this.item_dragon = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.angleInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsInput)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.rolesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // axoimInput
            // 
            this.axoimInput.Location = new System.Drawing.Point(65, 33);
            this.axoimInput.Name = "axoimInput";
            this.axoimInput.Size = new System.Drawing.Size(232, 20);
            this.axoimInput.TabIndex = 0;
            this.axoimInput.Text = "A";
            // 
            // axoimLabel
            // 
            this.axoimLabel.AutoSize = true;
            this.axoimLabel.Location = new System.Drawing.Point(9, 33);
            this.axoimLabel.Name = "axoimLabel";
            this.axoimLabel.Size = new System.Drawing.Size(50, 13);
            this.axoimLabel.TabIndex = 1;
            this.axoimLabel.Text = "Aksjomat";
            // 
            // roleInput_1
            // 
            this.roleInput_1.Location = new System.Drawing.Point(0, 3);
            this.roleInput_1.Name = "roleInput_1";
            this.roleInput_1.Size = new System.Drawing.Size(241, 20);
            this.roleInput_1.TabIndex = 2;
            this.roleInput_1.Text = "A=B-A-B";
            // 
            // roleInput_2
            // 
            this.roleInput_2.Location = new System.Drawing.Point(0, 29);
            this.roleInput_2.Name = "roleInput_2";
            this.roleInput_2.Size = new System.Drawing.Size(241, 20);
            this.roleInput_2.TabIndex = 3;
            this.roleInput_2.Text = "B=A+B+A";
            // 
            // roleInput_3
            // 
            this.roleInput_3.Location = new System.Drawing.Point(0, 55);
            this.roleInput_3.Name = "roleInput_3";
            this.roleInput_3.Size = new System.Drawing.Size(241, 20);
            this.roleInput_3.TabIndex = 4;
            // 
            // roleInput_4
            // 
            this.roleInput_4.Location = new System.Drawing.Point(0, 81);
            this.roleInput_4.Name = "roleInput_4";
            this.roleInput_4.Size = new System.Drawing.Size(241, 20);
            this.roleInput_4.TabIndex = 5;
            // 
            // roleInput_5
            // 
            this.roleInput_5.Location = new System.Drawing.Point(0, 107);
            this.roleInput_5.Name = "roleInput_5";
            this.roleInput_5.Size = new System.Drawing.Size(241, 20);
            this.roleInput_5.TabIndex = 6;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(184, 250);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(75, 23);
            this.generateBtn.TabIndex = 7;
            this.generateBtn.Text = "Generuj";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // angleInput
            // 
            this.angleInput.Location = new System.Drawing.Point(12, 72);
            this.angleInput.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.angleInput.Name = "angleInput";
            this.angleInput.Size = new System.Drawing.Size(120, 20);
            this.angleInput.TabIndex = 9;
            this.angleInput.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // iterationsInput
            // 
            this.iterationsInput.Location = new System.Drawing.Point(142, 72);
            this.iterationsInput.Name = "iterationsInput";
            this.iterationsInput.Size = new System.Drawing.Size(120, 20);
            this.iterationsInput.TabIndex = 10;
            this.iterationsInput.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // angleLabel
            // 
            this.angleLabel.AutoSize = true;
            this.angleLabel.Location = new System.Drawing.Point(12, 56);
            this.angleLabel.Name = "angleLabel";
            this.angleLabel.Size = new System.Drawing.Size(23, 13);
            this.angleLabel.TabIndex = 11;
            this.angleLabel.Text = "Kąt";
            // 
            // iterationsLabel
            // 
            this.iterationsLabel.AutoSize = true;
            this.iterationsLabel.Location = new System.Drawing.Point(139, 56);
            this.iterationsLabel.Name = "iterationsLabel";
            this.iterationsLabel.Size = new System.Drawing.Size(71, 13);
            this.iterationsLabel.TabIndex = 12;
            this.iterationsLabel.Text = "Liczba iteracji";
            // 
            // rolesLabel
            // 
            this.rolesLabel.AutoSize = true;
            this.rolesLabel.Location = new System.Drawing.Point(12, 104);
            this.rolesLabel.Name = "rolesLabel";
            this.rolesLabel.Size = new System.Drawing.Size(42, 13);
            this.rolesLabel.TabIndex = 13;
            this.rolesLabel.Text = "Zasady";
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(316, 24);
            this.menuStrip2.TabIndex = 15;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_sierpinski,
            this.item_koch,
            this.item_dragon});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 20);
            this.toolStripMenuItem1.Text = "Gotowe wzory";
            // 
            // item_sierpinski
            // 
            this.item_sierpinski.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sierpinski_item_triangles,
            this.sierpinski_item_curves,
            this.sierpinskie_item_carpet});
            this.item_sierpinski.Name = "item_sierpinski";
            this.item_sierpinski.Size = new System.Drawing.Size(180, 22);
            this.item_sierpinski.Text = "Sierpiński";
            // 
            // sierpinski_item_triangles
            // 
            this.sierpinski_item_triangles.Name = "sierpinski_item_triangles";
            this.sierpinski_item_triangles.Size = new System.Drawing.Size(180, 22);
            this.sierpinski_item_triangles.Text = "Trójkąty";
            this.sierpinski_item_triangles.Click += new System.EventHandler(this.sierpinski_item_triangles_Click);
            // 
            // sierpinski_item_curves
            // 
            this.sierpinski_item_curves.Name = "sierpinski_item_curves";
            this.sierpinski_item_curves.Size = new System.Drawing.Size(180, 22);
            this.sierpinski_item_curves.Text = "Krzywe";
            this.sierpinski_item_curves.Click += new System.EventHandler(this.sierpinski_item_curves_Click);
            // 
            // sierpinskie_item_carpet
            // 
            this.sierpinskie_item_carpet.Name = "sierpinskie_item_carpet";
            this.sierpinskie_item_carpet.Size = new System.Drawing.Size(180, 22);
            this.sierpinskie_item_carpet.Text = "Dywan";
            this.sierpinskie_item_carpet.Click += new System.EventHandler(this.sierpinskie_item_carpet_Click);
            // 
            // item_koch
            // 
            this.item_koch.Name = "item_koch";
            this.item_koch.Size = new System.Drawing.Size(180, 22);
            this.item_koch.Text = "Śnieżynka Kocha";
            this.item_koch.Click += new System.EventHandler(this.item_koch_Click);
            // 
            // item_dragon
            // 
            this.item_dragon.Name = "item_dragon";
            this.item_dragon.Size = new System.Drawing.Size(180, 22);
            this.item_dragon.Text = "Dragon Curve";
            this.item_dragon.Click += new System.EventHandler(this.item_dragon_Click);
            // 
            // rolesPanel
            // 
            this.rolesPanel.Controls.Add(this.roleInput_1);
            this.rolesPanel.Controls.Add(this.roleInput_2);
            this.rolesPanel.Controls.Add(this.roleInput_3);
            this.rolesPanel.Controls.Add(this.roleInput_4);
            this.rolesPanel.Controls.Add(this.roleInput_5);
            this.rolesPanel.Location = new System.Drawing.Point(10, 120);
            this.rolesPanel.Name = "rolesPanel";
            this.rolesPanel.Size = new System.Drawing.Size(249, 131);
            this.rolesPanel.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 276);
            this.Controls.Add(this.rolesPanel);
            this.Controls.Add(this.rolesLabel);
            this.Controls.Add(this.iterationsLabel);
            this.Controls.Add(this.angleLabel);
            this.Controls.Add(this.iterationsInput);
            this.Controls.Add(this.angleInput);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.axoimLabel);
            this.Controls.Add(this.axoimInput);
            this.Controls.Add(this.menuStrip2);
            this.MaximumSize = new System.Drawing.Size(332, 315);
            this.MinimumSize = new System.Drawing.Size(332, 315);
            this.Name = "Form2";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.angleInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsInput)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.rolesPanel.ResumeLayout(false);
            this.rolesPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox axoimInput;
        private System.Windows.Forms.Label axoimLabel;
        private System.Windows.Forms.TextBox roleInput_1;
        private System.Windows.Forms.TextBox roleInput_2;
        private System.Windows.Forms.TextBox roleInput_3;
        private System.Windows.Forms.TextBox roleInput_4;
        private System.Windows.Forms.TextBox roleInput_5;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.NumericUpDown angleInput;
        private System.Windows.Forms.NumericUpDown iterationsInput;
        private System.Windows.Forms.Label angleLabel;
        private System.Windows.Forms.Label iterationsLabel;
        private System.Windows.Forms.Label rolesLabel;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem item_sierpinski;
        private System.Windows.Forms.ToolStripMenuItem item_koch;
        private System.Windows.Forms.ToolStripMenuItem item_dragon;
        private System.Windows.Forms.Panel rolesPanel;
        private System.Windows.Forms.ToolStripMenuItem sierpinski_item_triangles;
        private System.Windows.Forms.ToolStripMenuItem sierpinski_item_curves;
        private System.Windows.Forms.ToolStripMenuItem sierpinskie_item_carpet;
    }
}

