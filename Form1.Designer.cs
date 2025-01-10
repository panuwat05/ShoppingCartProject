namespace ShoppingCart
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
            chbCoffee = new CheckBox();
            chbGreenTea = new CheckBox();
            tbCoffeePrice = new TextBox();
            Total = new Label();
            tbGreenTeaPrice = new TextBox();
            btCheckOut = new Button();
            tbTotal = new TextBox();
            tbCoffeeQuantity = new TextBox();
            tbGreenTeaQuantity = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbCash = new TextBox();
            Cash = new Label();
            tbChange = new TextBox();
            tb1000 = new TextBox();
            tb500 = new TextBox();
            tb100 = new TextBox();
            tb50 = new TextBox();
            tb20 = new TextBox();
            tb10 = new TextBox();
            tb5 = new TextBox();
            tb1 = new TextBox();
            label4 = new Label();
            lb1000 = new Label();
            lb500 = new Label();
            lb100 = new Label();
            lb50 = new Label();
            lb20 = new Label();
            lb10 = new Label();
            lb5 = new Label();
            lb1 = new Label();
            button1 = new Button();
            Beverage = new GroupBox();
            groupBox2 = new GroupBox();
            tbPizzaQuantity = new TextBox();
            chbNoodle = new CheckBox();
            chbPizza = new CheckBox();
            tbNoodlePrice = new TextBox();
            tbPizzaPrice = new TextBox();
            tbNoodleQuantity = new TextBox();
            label3 = new Label();
            label5 = new Label();
            dDiscountBev = new GroupBox();
            chbFood = new CheckBox();
            tbFood = new TextBox();
            chbAll = new CheckBox();
            chbBeverage = new CheckBox();
            tbAll = new TextBox();
            tbBeverage = new TextBox();
            label6 = new Label();
            label7 = new Label();
            tb0_25 = new TextBox();
            tb0_50 = new TextBox();
            Beverage.SuspendLayout();
            groupBox2.SuspendLayout();
            dDiscountBev.SuspendLayout();
            SuspendLayout();
            // 
            // chbCoffee
            // 
            chbCoffee.AutoSize = true;
            chbCoffee.Location = new Point(21, 42);
            chbCoffee.Name = "chbCoffee";
            chbCoffee.Size = new Size(61, 19);
            chbCoffee.TabIndex = 0;
            chbCoffee.Text = "Coffee";
            chbCoffee.UseVisualStyleBackColor = true;
            // 
            // chbGreenTea
            // 
            chbGreenTea.AutoSize = true;
            chbGreenTea.Location = new Point(21, 71);
            chbGreenTea.Name = "chbGreenTea";
            chbGreenTea.Size = new Size(77, 19);
            chbGreenTea.TabIndex = 1;
            chbGreenTea.Text = "Green Tea";
            chbGreenTea.UseVisualStyleBackColor = true;
            // 
            // tbCoffeePrice
            // 
            tbCoffeePrice.Location = new Point(104, 42);
            tbCoffeePrice.Name = "tbCoffeePrice";
            tbCoffeePrice.Size = new Size(100, 23);
            tbCoffeePrice.TabIndex = 2;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Location = new Point(625, 94);
            Total.Name = "Total";
            Total.Size = new Size(32, 15);
            Total.TabIndex = 3;
            Total.Text = "Total";
            // 
            // tbGreenTeaPrice
            // 
            tbGreenTeaPrice.Location = new Point(104, 71);
            tbGreenTeaPrice.Name = "tbGreenTeaPrice";
            tbGreenTeaPrice.Size = new Size(100, 23);
            tbGreenTeaPrice.TabIndex = 4;
            // 
            // btCheckOut
            // 
            btCheckOut.Location = new Point(458, 37);
            btCheckOut.Name = "btCheckOut";
            btCheckOut.Size = new Size(75, 376);
            btCheckOut.TabIndex = 5;
            btCheckOut.Text = "Check Out";
            btCheckOut.UseVisualStyleBackColor = true;
            btCheckOut.Click += btCheckOut_Click;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(674, 91);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(100, 23);
            tbTotal.TabIndex = 6;
            // 
            // tbCoffeeQuantity
            // 
            tbCoffeeQuantity.Location = new Point(221, 42);
            tbCoffeeQuantity.Name = "tbCoffeeQuantity";
            tbCoffeeQuantity.Size = new Size(100, 23);
            tbCoffeeQuantity.TabIndex = 7;
            // 
            // tbGreenTeaQuantity
            // 
            tbGreenTeaQuantity.Location = new Point(221, 71);
            tbGreenTeaQuantity.Name = "tbGreenTeaQuantity";
            tbGreenTeaQuantity.Size = new Size(100, 23);
            tbGreenTeaQuantity.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 12);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 9;
            label1.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 12);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 10;
            label2.Text = "Quantity";
            // 
            // tbCash
            // 
            tbCash.Location = new Point(585, 36);
            tbCash.Name = "tbCash";
            tbCash.Size = new Size(100, 23);
            tbCash.TabIndex = 11;
            // 
            // Cash
            // 
            Cash.AutoSize = true;
            Cash.Location = new Point(617, 18);
            Cash.Name = "Cash";
            Cash.Size = new Size(33, 15);
            Cash.TabIndex = 12;
            Cash.Text = "Cash";
            // 
            // tbChange
            // 
            tbChange.Location = new Point(674, 120);
            tbChange.Name = "tbChange";
            tbChange.Size = new Size(100, 23);
            tbChange.TabIndex = 13;
            // 
            // tb1000
            // 
            tb1000.Location = new Point(674, 149);
            tb1000.Name = "tb1000";
            tb1000.Size = new Size(100, 23);
            tb1000.TabIndex = 14;
            // 
            // tb500
            // 
            tb500.Location = new Point(674, 178);
            tb500.Name = "tb500";
            tb500.Size = new Size(100, 23);
            tb500.TabIndex = 15;
            // 
            // tb100
            // 
            tb100.Location = new Point(674, 207);
            tb100.Name = "tb100";
            tb100.Size = new Size(100, 23);
            tb100.TabIndex = 16;
            // 
            // tb50
            // 
            tb50.Location = new Point(674, 236);
            tb50.Name = "tb50";
            tb50.Size = new Size(100, 23);
            tb50.TabIndex = 17;
            // 
            // tb20
            // 
            tb20.Location = new Point(674, 265);
            tb20.Name = "tb20";
            tb20.Size = new Size(100, 23);
            tb20.TabIndex = 18;
            // 
            // tb10
            // 
            tb10.Location = new Point(674, 294);
            tb10.Name = "tb10";
            tb10.Size = new Size(100, 23);
            tb10.TabIndex = 19;
            // 
            // tb5
            // 
            tb5.Location = new Point(674, 323);
            tb5.Name = "tb5";
            tb5.Size = new Size(100, 23);
            tb5.TabIndex = 20;
            // 
            // tb1
            // 
            tb1.Location = new Point(674, 352);
            tb1.Name = "tb1";
            tb1.Size = new Size(100, 23);
            tb1.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(620, 123);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 22;
            label4.Text = "Change";
            // 
            // lb1000
            // 
            lb1000.AutoSize = true;
            lb1000.Location = new Point(630, 152);
            lb1000.Name = "lb1000";
            lb1000.Size = new Size(31, 15);
            lb1000.TabIndex = 23;
            lb1000.Text = "1000";
            // 
            // lb500
            // 
            lb500.AutoSize = true;
            lb500.Location = new Point(630, 181);
            lb500.Name = "lb500";
            lb500.Size = new Size(25, 15);
            lb500.TabIndex = 24;
            lb500.Text = "500";
            // 
            // lb100
            // 
            lb100.AutoSize = true;
            lb100.Location = new Point(630, 210);
            lb100.Name = "lb100";
            lb100.Size = new Size(25, 15);
            lb100.TabIndex = 25;
            lb100.Text = "100";
            // 
            // lb50
            // 
            lb50.AutoSize = true;
            lb50.Location = new Point(630, 239);
            lb50.Name = "lb50";
            lb50.Size = new Size(19, 15);
            lb50.TabIndex = 26;
            lb50.Text = "50";
            // 
            // lb20
            // 
            lb20.AutoSize = true;
            lb20.Location = new Point(630, 268);
            lb20.Name = "lb20";
            lb20.Size = new Size(19, 15);
            lb20.TabIndex = 27;
            lb20.Text = "20";
            // 
            // lb10
            // 
            lb10.AutoSize = true;
            lb10.Location = new Point(630, 297);
            lb10.Name = "lb10";
            lb10.Size = new Size(19, 15);
            lb10.TabIndex = 28;
            lb10.Text = "10";
            // 
            // lb5
            // 
            lb5.AutoSize = true;
            lb5.Location = new Point(631, 326);
            lb5.Name = "lb5";
            lb5.Size = new Size(13, 15);
            lb5.TabIndex = 29;
            lb5.Text = "5";
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(631, 356);
            lb1.Name = "lb1";
            lb1.Size = new Size(13, 15);
            lb1.TabIndex = 30;
            lb1.Text = "1";
            // 
            // button1
            // 
            button1.Location = new Point(699, 10);
            button1.Name = "button1";
            button1.Size = new Size(75, 66);
            button1.TabIndex = 31;
            button1.Text = "Pay";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Beverage
            // 
            Beverage.Controls.Add(tbGreenTeaQuantity);
            Beverage.Controls.Add(chbCoffee);
            Beverage.Controls.Add(chbGreenTea);
            Beverage.Controls.Add(tbCoffeePrice);
            Beverage.Controls.Add(tbGreenTeaPrice);
            Beverage.Controls.Add(tbCoffeeQuantity);
            Beverage.Controls.Add(label1);
            Beverage.Controls.Add(label2);
            Beverage.Location = new Point(60, 24);
            Beverage.Name = "Beverage";
            Beverage.Size = new Size(339, 100);
            Beverage.TabIndex = 32;
            Beverage.TabStop = false;
            Beverage.Text = "Beverage";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbPizzaQuantity);
            groupBox2.Controls.Add(chbNoodle);
            groupBox2.Controls.Add(chbPizza);
            groupBox2.Controls.Add(tbNoodlePrice);
            groupBox2.Controls.Add(tbPizzaPrice);
            groupBox2.Controls.Add(tbNoodleQuantity);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(60, 134);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(339, 100);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Food";
            // 
            // tbPizzaQuantity
            // 
            tbPizzaQuantity.Location = new Point(221, 71);
            tbPizzaQuantity.Name = "tbPizzaQuantity";
            tbPizzaQuantity.Size = new Size(100, 23);
            tbPizzaQuantity.TabIndex = 8;
            // 
            // chbNoodle
            // 
            chbNoodle.AutoSize = true;
            chbNoodle.Location = new Point(21, 42);
            chbNoodle.Name = "chbNoodle";
            chbNoodle.Size = new Size(65, 19);
            chbNoodle.TabIndex = 0;
            chbNoodle.Text = "Noodle";
            chbNoodle.UseVisualStyleBackColor = true;
            // 
            // chbPizza
            // 
            chbPizza.AutoSize = true;
            chbPizza.Location = new Point(21, 71);
            chbPizza.Name = "chbPizza";
            chbPizza.Size = new Size(52, 19);
            chbPizza.TabIndex = 1;
            chbPizza.Text = "Pizza";
            chbPizza.UseVisualStyleBackColor = true;
            // 
            // tbNoodlePrice
            // 
            tbNoodlePrice.Location = new Point(104, 42);
            tbNoodlePrice.Name = "tbNoodlePrice";
            tbNoodlePrice.Size = new Size(100, 23);
            tbNoodlePrice.TabIndex = 2;
            // 
            // tbPizzaPrice
            // 
            tbPizzaPrice.Location = new Point(104, 71);
            tbPizzaPrice.Name = "tbPizzaPrice";
            tbPizzaPrice.Size = new Size(100, 23);
            tbPizzaPrice.TabIndex = 4;
            // 
            // tbNoodleQuantity
            // 
            tbNoodleQuantity.Location = new Point(221, 42);
            tbNoodleQuantity.Name = "tbNoodleQuantity";
            tbNoodleQuantity.Size = new Size(100, 23);
            tbNoodleQuantity.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 12);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 9;
            label3.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(245, 12);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 10;
            label5.Text = "Quantity";
            // 
            // dDiscountBev
            // 
            dDiscountBev.Controls.Add(chbFood);
            dDiscountBev.Controls.Add(tbFood);
            dDiscountBev.Controls.Add(chbAll);
            dDiscountBev.Controls.Add(chbBeverage);
            dDiscountBev.Controls.Add(tbAll);
            dDiscountBev.Controls.Add(tbBeverage);
            dDiscountBev.Location = new Point(60, 254);
            dDiscountBev.Name = "dDiscountBev";
            dDiscountBev.Size = new Size(339, 154);
            dDiscountBev.TabIndex = 33;
            dDiscountBev.TabStop = false;
            dDiscountBev.Text = "Discount";
            // 
            // chbFood
            // 
            chbFood.AutoSize = true;
            chbFood.Location = new Point(21, 102);
            chbFood.Name = "chbFood";
            chbFood.Size = new Size(53, 19);
            chbFood.TabIndex = 11;
            chbFood.Text = "Food";
            chbFood.UseVisualStyleBackColor = true;
            // 
            // tbFood
            // 
            tbFood.Location = new Point(104, 102);
            tbFood.Name = "tbFood";
            tbFood.Size = new Size(194, 23);
            tbFood.TabIndex = 12;
            // 
            // chbAll
            // 
            chbAll.AutoSize = true;
            chbAll.Location = new Point(21, 42);
            chbAll.Name = "chbAll";
            chbAll.Size = new Size(40, 19);
            chbAll.TabIndex = 0;
            chbAll.Text = "All";
            chbAll.UseVisualStyleBackColor = true;
            // 
            // chbBeverage
            // 
            chbBeverage.AutoSize = true;
            chbBeverage.Location = new Point(21, 71);
            chbBeverage.Name = "chbBeverage";
            chbBeverage.Size = new Size(74, 19);
            chbBeverage.TabIndex = 1;
            chbBeverage.Text = "Beverage";
            chbBeverage.UseVisualStyleBackColor = true;
            // 
            // tbAll
            // 
            tbAll.Location = new Point(104, 42);
            tbAll.Name = "tbAll";
            tbAll.Size = new Size(194, 23);
            tbAll.TabIndex = 2;
            // 
            // tbBeverage
            // 
            tbBeverage.Location = new Point(104, 71);
            tbBeverage.Name = "tbBeverage";
            tbBeverage.Size = new Size(194, 23);
            tbBeverage.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(631, 419);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 37;
            label6.Text = "0.25";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(631, 389);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 36;
            label7.Text = "0.50";
            // 
            // tb0_25
            // 
            tb0_25.Location = new Point(674, 415);
            tb0_25.Name = "tb0_25";
            tb0_25.Size = new Size(100, 23);
            tb0_25.TabIndex = 35;
            // 
            // tb0_50
            // 
            tb0_50.Location = new Point(674, 386);
            tb0_50.Name = "tb0_50";
            tb0_50.Size = new Size(100, 23);
            tb0_50.TabIndex = 34;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(tb0_25);
            Controls.Add(tb0_50);
            Controls.Add(dDiscountBev);
            Controls.Add(groupBox2);
            Controls.Add(Beverage);
            Controls.Add(button1);
            Controls.Add(lb1);
            Controls.Add(lb5);
            Controls.Add(lb10);
            Controls.Add(lb20);
            Controls.Add(lb50);
            Controls.Add(lb100);
            Controls.Add(lb500);
            Controls.Add(lb1000);
            Controls.Add(label4);
            Controls.Add(tb1);
            Controls.Add(tb5);
            Controls.Add(tb10);
            Controls.Add(tb20);
            Controls.Add(tb50);
            Controls.Add(tb100);
            Controls.Add(tb500);
            Controls.Add(tb1000);
            Controls.Add(tbChange);
            Controls.Add(Cash);
            Controls.Add(tbCash);
            Controls.Add(tbTotal);
            Controls.Add(btCheckOut);
            Controls.Add(Total);
            Name = "Form1";
            Text = "Form1";
            Beverage.ResumeLayout(false);
            Beverage.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            dDiscountBev.ResumeLayout(false);
            dDiscountBev.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chbCoffee;
        private CheckBox chbGreenTea;
        private TextBox tbCoffeePrice;
        private Label Total;
        private TextBox tbGreenTeaPrice;
        private Button btCheckOut;
        private TextBox tbTotal;
        private TextBox tbCoffeeQuantity;
        private TextBox tbGreenTeaQuantity;
        private Label label1;
        private Label label2;
        private TextBox tbCash;
        private Label Cash;
        private TextBox tbChange;
        private TextBox tb1000;
        private TextBox tb500;
        private TextBox tb100;
        private TextBox tb50;
        private TextBox tb20;
        private TextBox tb10;
        private TextBox tb5;
        private TextBox tb1;
        private Label label4;
        private Label lb1000;
        private Label lb500;
        private Label lb100;
        private Label lb50;
        private Label lb20;
        private Label lb10;
        private Label lb5;
        private Label lb1;
        private Button button1;
        private GroupBox Beverage;
        private GroupBox groupBox2;
        private TextBox tbPizzaQuantity;
        private CheckBox chbNoodle;
        private CheckBox chbPizza;
        private TextBox tbNoodlePrice;
        private TextBox tbPizzaPrice;
        private TextBox tbNoodleQuantity;
        private Label label3;
        private Label label5;
        private GroupBox dDiscountBev;
        private CheckBox chbAll;
        private TextBox tbAll;
        private CheckBox chbFood;
        private TextBox tbFood;
        private CheckBox chbBeverage;
        private TextBox tbBeverage;
        private Label label6;
        private Label label7;
        private TextBox tb0_25;
        private TextBox tb0_50;
    }
}
