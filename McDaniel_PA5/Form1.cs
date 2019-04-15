using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McDaniel_PA5
{
    public partial class Form1 : Form
    {
        public string mypizza;
        public string cstmr_name;
        public string delivery_select;
        public double pizza_price;
        public int top_count;
        public string toppings;
        public double top_price;
        public double tax = .10;
        public double prom;
        public double baseprice;
        public Form1()
        {
            InitializeComponent();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            cstmr_name = name.Text;


        }

        

        private void small_pizza_CheckedChanged(object sender, EventArgs e)
        {
            mypizza = "small";
            pizza_price = 7.99;
        }

        private void medium_pizza_CheckedChanged(object sender, EventArgs e)
        {
            mypizza = "medium";
            pizza_price = 9.99;
        }

        private void large_pizza_CheckedChanged(object sender, EventArgs e)
        {
            mypizza = "large";
            pizza_price = 13.99;
        }


        private void pickup_CheckedChanged(object sender, EventArgs e)
        {
            delivery_select = "Pickup";
        }

        private void delivery_CheckedChanged(object sender, EventArgs e)
        {
            delivery_select = "Delivery";
        }

        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

      

        private void promo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void reset_Click(object sender, EventArgs e)
        {
            // creates new form when user clicks reset button
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

        private void pepp_top_CheckedChanged(object sender, EventArgs e)
        {
            top_count += 1;
            top_price += 0.50;
            toppings += "- Pepperoni \n";

        }

        private void saus_top_CheckedChanged(object sender, EventArgs e)
        {
            top_count += 1;
            top_price += 0.50;
            toppings += "- Italian Sausage \n";
        }

        private void pine_top_CheckedChanged(object sender, EventArgs e)
        {
            top_count += 1;
            top_price += 0.50;
            toppings += "- Pineapples \n";
        }



        private void checkout_Click(object sender, EventArgs e)
        {
            baseprice = pizza_price + top_price;


            if (mypizza == "small" || mypizza == "medium" || mypizza == "large")
            {



                if (delivery_select == "Delivery" || delivery_select == "Pickup")
                {





                    if (promo.Text == "SAVE2" || promo.Text == "save2")
                    {
                        prom = 2.00;

                        richTextBox1.Text = String.Format("Order for {0}" +  // name of person ordering pizza
                        "\n{1} pizza" +                                 // size of pizza
                        "\n{2} toppings" +                             // toppings count
                        "\n {3} " +                                   // toppings 
                        "{4}" +                                      // delivery or no delivery option
                        "\n Base Cost : {5:C} " +                   // base cost
                        "\n Promo : ({6:C})" +                     // promo
                        "\n Tax @10% : {7:C}" +                   // tax times base cost gets this value
                        "\n Total Cost : {8:C}"                  // total 


                        , cstmr_name, mypizza, top_count, toppings, delivery_select, baseprice, prom, (baseprice - prom) * tax, baseprice - prom + ((baseprice - prom) * tax));

                    }

                    else
                    {

                        richTextBox1.Text = String.Format("Order for {0}" +  // name of person ordering pizza
                            "\n{1} pizza" +                                 // size of pizza
                            "\n{2} toppings" +                             // toppings count
                            "\n {3} " +                                   // toppings 
                            "{4}" +                                      // delivery or no delivery option
                            "\n Base Cost : {5:C} " +                   // base cost
                            "\n Tax @10% : {6:C}" +                    // tax times base cost gets this value
                            "\n Total Cost : {7:C}"                   // total 


                            , cstmr_name, mypizza, top_count, toppings, delivery_select, baseprice, tax * baseprice, baseprice + (tax * baseprice));

                    }
                }
                else
                {
                    MessageBox.Show("Must select Delivery or Pickup Option!!");
                }
            }
            else
            {
                MessageBox.Show("Must select pizza size!!");
            }
        }




    }
}
