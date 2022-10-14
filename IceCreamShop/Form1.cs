namespace IceCreamShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbCone.Checked = true;
            rbChocolate.Checked = true;
            lblTotal.Text = "£1.50";

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rbBananaSplit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pbCone_Click(object sender, EventArgs e)
        {
            rbCone.PerformClick();
        } 
        
        private void rbConeClick(object sender, EventArgs e)
        {
            clearAll();
            rbCone.Checked = true;
            cbFlake.Enabled = true;
            cbSprinkles.Enabled = true;
            cbSyrup.Enabled = true;
            rbChocolate.Checked=true;
            lblTotal.Text = "£1.50";            
        }

        private void pbSundae_Click(object sender, EventArgs e)
        {
            rbSundae.PerformClick();
        }

        private void rbSundae_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbsundaeClick(object sender, EventArgs e)
        {
            clearAll();
            rbSundae.Checked = true;
            cbSyrup.Checked = true;
            rbVanilla.Checked = true;
            lblTotal.Text = "£2.10";
            cbFlake.Enabled=true;
            cbSprinkles.Enabled=true;
            cbSyrup.Enabled=true;

        }

        private void pbBananaSplit_Click(object sender, EventArgs e)
        {
            clearAll();
            rbBananaSplit.PerformClick();
        }

        private void rbBananaSplitClick(object sender, EventArgs e)
        {
            cbFlake.Enabled = false;
            cbSprinkles.Enabled = false;
            cbSyrup.Enabled=false;
            lblTotal.Text = "£2.50";
            MessageBox.Show("Your banana split comes with chocolate, vanilla and strawberry ice cream", "Ice Cream Flavours", MessageBoxButtons.OK);
                                   
        }
        
        private void clearAll()
        {
            rbBananaSplit.Checked = false;
            rbSundae.Checked = false;
            rbCone.Checked = false; 

            rbChocolate.Checked = false;
            rbStrawberry.Checked = false;
            rbVanilla.Checked=false;

            cbFlake.Checked = false;
            cbSprinkles.Checked = false;
            cbSyrup.Checked = false;

            lblTotal.Text = "£0.0";

            cbSyrup.Enabled=true;
            cbSprinkles.Enabled=true;
            cbFlake.Enabled=true;

        }

        private void clickToppings(object sender, EventArgs e)
        {
            if (rbSundae.Checked)
            {
                float total_price = 1.90f;
                if (cbFlake.Checked){total_price += 0.20f;lblTotal.Text = $"£{total_price.ToString("F")}";}
                if (cbSyrup.Checked){total_price += 0.20f;lblTotal.Text = $"£{total_price.ToString("F")}";}
                if (cbSprinkles.Checked){total_price += 0.20f;lblTotal.Text =$"£{total_price.ToString("F")}";}
                if (!cbFlake.Checked && !cbSprinkles.Checked && !cbSyrup.Checked)
                {
                    lblTotal.Text = "£1.90";
                }
            }

            if (rbCone.Checked)
            {
                float total_price = 1.50f;
                if (cbFlake.Checked) { total_price += 0.20f; lblTotal.Text = $"£{total_price.ToString("F")}";}
                if (cbSyrup.Checked) { total_price += 0.20f; lblTotal.Text = $"£{total_price.ToString("F")}";}
                if (cbSprinkles.Checked) { total_price += 0.20f; lblTotal.Text = $"£{total_price.ToString("F")}"; } 
                if(!cbFlake.Checked && !cbSprinkles.Checked && !cbSyrup.Checked)
                {
                    lblTotal.Text = "£1.50";
                }
            }
            
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string iceCreamChoice = "";
            string toppings = "";
            string flavour="";
            if (rbCone.Checked) { iceCreamChoice = "Cone"; }
            else if(rbSundae.Checked){ iceCreamChoice = "Sundae"; }
            else if (rbBananaSplit.Checked){ iceCreamChoice = "Banana Split"; }

            if (cbSprinkles.Checked) { toppings += "Sprinkles"; }
            if (cbSyrup.Checked) { toppings += "Syrup"; }
            if (cbFlake.Checked) { toppings += "Flake"; }


            if (rbStrawberry.Checked) { flavour = "Strawberry"; }
            if (rbChocolate.Checked) { flavour = "Chocolate"; }
            if(rbVanilla.Checked) { flavour = "Vanilla"; }

            if (toppings == "")
            {
                MessageBox.Show($"You have ordered an Ice cream {iceCreamChoice} with\n{flavour} flavoured Ice Cream with no toppings.\n\nPlease pay the cashier {lblTotal.Text}", "You have ordered", MessageBoxButtons.OK);
            }
            else { MessageBox.Show($"You have ordered an Ice cream {iceCreamChoice} with\n{flavour} flavoured Ice Cream with a {toppings}.\n\nPlease pay the cashier {lblTotal.Text}","You have ordered",MessageBoxButtons.OK ); }

            rbCone.PerformClick();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes);
            { Application.Exit(); }
        }     
    }
}