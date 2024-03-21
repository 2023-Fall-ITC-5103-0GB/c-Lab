namespace WinFormsApp_C__Lab_Week10
{
    partial class NewInventoryItem
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox_itemNO = new TextBox();
            textBox_Desc = new TextBox();
            textBox_Price = new TextBox();
            button_Save = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 52);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Item No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 99);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 189);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 2;
            label3.Text = "Price:";
            // 
            // textBox_itemNO
            // 
            textBox_itemNO.Location = new Point(214, 52);
            textBox_itemNO.Name = "textBox_itemNO";
            textBox_itemNO.Size = new Size(153, 27);
            textBox_itemNO.TabIndex = 3;
            // 
            // textBox_Desc
            // 
            textBox_Desc.Location = new Point(214, 99);
            textBox_Desc.Multiline = true;
            textBox_Desc.Name = "textBox_Desc";
            textBox_Desc.Size = new Size(153, 40);
            textBox_Desc.TabIndex = 4;
            // 
            // textBox_Price
            // 
            textBox_Price.Location = new Point(214, 186);
            textBox_Price.Name = "textBox_Price";
            textBox_Price.Size = new Size(153, 27);
            textBox_Price.TabIndex = 5;
            // 
            // button_Save
            // 
            button_Save.Location = new Point(209, 290);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(94, 29);
            button_Save.TabIndex = 6;
            button_Save.Text = "Save";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button_Save_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(407, 290);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // NewInventoryItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button_Save);
            Controls.Add(textBox_Price);
            Controls.Add(textBox_Desc);
            Controls.Add(textBox_itemNO);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewInventoryItem";
            Text = "NewInventoryItem";
            Load += NewInventoryItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_itemNO;
        private TextBox textBox_Desc;
        private TextBox textBox_Price;
        private Button button_Save;
        private Button button2;
    }
}