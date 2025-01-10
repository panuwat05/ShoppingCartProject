using System;
using System.Windows.Forms;

namespace ShoppingCart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Calculate total price from selected items
        double getPriceFromSelectedItems()
        {
            // Retrieve prices and quantities
            double coffeePrice = chbCoffee.Checked ? double.Parse(tbCoffeePrice.Text) : 0;
            double coffeeQuantity = chbCoffee.Checked ? double.Parse(tbCoffeeQuantity.Text) : 0;
            double greenTeaPrice = chbGreenTea.Checked ? double.Parse(tbGreenTeaPrice.Text) : 0;
            double greenTeaQuantity = chbGreenTea.Checked ? double.Parse(tbGreenTeaQuantity.Text) : 0;
            double noodlePrice = chbNoodle.Checked ? double.Parse(tbNoodlePrice.Text) : 0;
            double noodleQuantity = chbNoodle.Checked ? double.Parse(tbNoodleQuantity.Text) : 0;
            double pizzaPrice = chbPizza.Checked ? double.Parse(tbPizzaPrice.Text) : 0;
            double pizzaQuantity = chbPizza.Checked ? double.Parse(tbPizzaQuantity.Text) : 0;

            // Calculate totals
            double totalCoffee = coffeePrice * coffeeQuantity;
            double totalGreenTea = greenTeaPrice * greenTeaQuantity;
            double totalNoodle = noodlePrice * noodleQuantity;
            double totalPizza = pizzaPrice * pizzaQuantity;

            double total = totalCoffee + totalGreenTea + totalNoodle + totalPizza;

            // Display the total
            tbTotal.Text = total.ToString("F2");
            return total;
        }

        // Calculate final price after discount
        double getDiscountPrice(double total)
        {
            double discountAll = chbAll.Checked ? double.Parse(tbAll.Text) : 0;          // ส่วนลดทั้งหมด
            double discountBeverage = chbBeverage.Checked ? double.Parse(tbBeverage.Text) : 0;  // ส่วนลดเครื่องดื่ม
            double discountFood = chbFood.Checked ? double.Parse(tbFood.Text) : 0;      // ส่วนลดอาหาร

            double beverageTotal = (chbCoffee.Checked ? double.Parse(tbCoffeePrice.Text) * double.Parse(tbCoffeeQuantity.Text) : 0) +
                                   (chbGreenTea.Checked ? double.Parse(tbGreenTeaPrice.Text) * double.Parse(tbGreenTeaQuantity.Text) : 0);

            double foodTotal = (chbNoodle.Checked ? double.Parse(tbNoodlePrice.Text) * double.Parse(tbNoodleQuantity.Text) : 0) +
                               (chbPizza.Checked ? double.Parse(tbPizzaPrice.Text) * double.Parse(tbPizzaQuantity.Text) : 0);

            // คำนวณส่วนลดสำหรับเครื่องดื่มและอาหารแยกส่วน
            double discountedBeverage = beverageTotal - (beverageTotal * discountBeverage / 100);
            double discountedFood = foodTotal - (foodTotal * discountFood / 100);

            // รวมส่วนลดทั้งหมด (All) เข้าไปในราคาสุทธิ
            double discountedTotal = (discountedBeverage + discountedFood) - ((discountedBeverage + discountedFood) * discountAll / 100);

            return discountedTotal;
        }


        // Checkout button click event
        private void btCheckOut_Click(object sender, EventArgs e)
        {
            tbTotal.Text = getPriceFromSelectedItems().ToString("F2");
        }

        // Finalize purchase and calculate change
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double total = getPriceFromSelectedItems();
                double discountedTotal = getDiscountPrice(total);
                double cash = double.Parse(tbCash.Text);

                if (cash < discountedTotal)
                {
                    MessageBox.Show("Insufficient cash provided.");
                    return;
                }

                double change = cash - discountedTotal;

                // Calculate change in denominations
                double[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1,0.50,0.25 };
                TextBox[] denominationTextBoxes = { tb1000, tb500, tb100, tb50, tb20, tb10, tb5, tb1,tb0_50,tb0_25};

                foreach (var textBox in denominationTextBoxes)
                {
                    textBox.Text = "0";
                }

                for (int i = 0; i < denominations.Length; i++)
                {
                    int count = (int)(change / denominations[i]);
                    if (count > 0)
                    {
                        denominationTextBoxes[i].Text = count.ToString();
                        change %= denominations[i];
                    }
                }

                tbChange.Text = (cash - discountedTotal).ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
