//    ******* !!! CREATED BY @MIGU-404  ON GITHUB !!! *******
// @                                                            @
// @    /\    /\    |  |----   |    |   |   |  |----|  |   |    @
// @   /  \  /  \   |  |  --|  |    |___|___|  |    |  |___|    @
// @  /    \/    \  |  |____|  |____|       |  |____|      |    @
// @                                                            @
// @    /\    /\  \    /\    /  |    |    |----|  |---          @
// @   /  \  /  \  \  /  \  /   |    |    |    |  |---          @
// @  /    \/    \  \/    \/    |__  |__  |____|  |___          @
// 
//    ******* !!! CREATED BY @MIGU-404! ON GITHUB !!! *******
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace CH_9_PP_1___Vending_Machine
{
    //Creating the cumulitive for the total sales here
    /*enum Sodas
    {
        Cola, Root_Beer, Lemon_Lime, Grape, Cream
    }*/

    //Creating a structure for reference
    struct SodaType
    {
        //public string name;
        public decimal cost;
        public int quantity;
    }
    public partial class vendingMachinePP2 : Form
    {

        public vendingMachinePP2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Declaring total amount to reference
        decimal total = 0m;

        //creating array for types of sodas
        SodaType[] drinks = new SodaType[5];


        private void totalTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void colaPictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                //creating an instance to reference it onward
                SodaType cola = new SodaType();

                //assigning the different amounts
                cola.cost = 1.00m;
                cola.quantity = 20;
                drinks[0] = cola;

                cola.quantity = int.Parse(colaOutputLabel.Text);


                if (cola.quantity >= 1)
                {
                    //subtracting quantity & displaying total & also converting to string
                    total = cola.cost + total;
                    cola.quantity = int.Parse(colaOutputLabel.Text);
                    cola.quantity--;
                    colaOutputLabel.Text = cola.quantity.ToString();
                    totalSalesOutputLabel.Text = total.ToString();
                }
                else
                {
                    //display empty soda message
                    MessageBox.Show("Sorry, there are no more Cola drinks.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void colaOutputLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void rootBeerPictureBox_Click(object sender, EventArgs e)
        {
            //creating an instance to reference it onward
            SodaType rootBeer = new SodaType();

            //assigning the different amounts
            rootBeer.cost = 1.00m;
            rootBeer.quantity = 20;
            drinks[1] = rootBeer;
            rootBeer.quantity = int.Parse(rootBeerOutputLabel.Text);



            if (rootBeer.quantity >= 1)
            {
                //subtracting quantity & displaying total & also converting to string
                total = rootBeer.cost + total;
                rootBeer.quantity = int.Parse(rootBeerOutputLabel.Text);
                rootBeer.quantity--;
                rootBeerOutputLabel.Text = rootBeer.quantity.ToString();
                totalSalesOutputLabel.Text = total.ToString();
            }
            else
            {
                //display empty soda message
                MessageBox.Show("Sorry, there are no more Root Beer drinks.");
            }
        }

        private void lemonPictureBox_Click(object sender, EventArgs e)
        {
            //creating an instance to reference it onward
            SodaType lemon = new SodaType();

            //assigning the different amounts
            lemon.cost = 1.00m;
            lemon.quantity = 20;
            drinks[2] = lemon;
            lemon.quantity = int.Parse(lemonOutputLabel.Text);



            if (lemon.quantity >= 1)
            {
                //subtracting quantity & displaying total & also converting to string
                total = lemon.cost + total;
                lemon.quantity = int.Parse(lemonOutputLabel.Text);
                lemon.quantity--;
                lemonOutputLabel.Text = lemon.quantity.ToString();
                totalSalesOutputLabel.Text = total.ToString();
            }
            else
            {
                //display empty soda message
                MessageBox.Show("Sorry, there are no more Lemon Lime drinks.");
            }
        }

        private void grapePictureBox_Click(object sender, EventArgs e)
        {
            //creating an instance to reference it onward
            SodaType grape = new SodaType();

            //assigning the different amounts
            grape.cost = 1.50m;
            grape.quantity = 20;
            drinks[3] = grape;
            grape.quantity = int.Parse(grapeOutputLabel.Text);



            if (grape.quantity >= 1)
            {
                //subtracting quantity & displaying total & also converting to string
                total = grape.cost + total;
                grape.quantity = int.Parse(grapeOutputLabel.Text);
                grape.quantity--;
                grapeOutputLabel.Text = grape.quantity.ToString();
                totalSalesOutputLabel.Text = total.ToString();
            }
            else
            {
                //display empty soda message
                MessageBox.Show("Sorry, there are no more Grape drinks.");
            }
        }

        private void creamPictureBox_Click(object sender, EventArgs e)
        {
            //creating an instance to reference it onward
            SodaType cream = new SodaType();

            //assigning the different amounts
            cream.cost = 1.50m;
            cream.quantity = 20;
            drinks[4] = cream;
            cream.quantity = int.Parse(creamOutputLabel.Text);



            if (cream.quantity >= 1)
            {
                //subtracting quantity & displaying total & also converting to string
                total = cream.cost + total;
                cream.quantity = int.Parse(creamOutputLabel.Text);
                cream.quantity--;
                creamOutputLabel.Text = cream.quantity.ToString();
                totalSalesOutputLabel.Text = total.ToString();
            }
            else
            {
                //display empty soda message
                MessageBox.Show("Sorry, there are no more Cream Soda drinks.");
            }
        }

        private void grabDrinksButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
