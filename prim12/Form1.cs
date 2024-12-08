namespace prim12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void begin(object sender, EventArgs e)
        {
            int num = 0;
            int i = 0;
            for (i = 0; i<1; i++)
            {
                if((sender as Button).Name == "c" + Convert.ToString(i))
                {
                    num = i;
                }
            }
            
            switch (num)
            {
                case 0:
                    label1.Text = "0";
                    c0.Visible = false;
                    c1.Visible = false;
                    break;
                case 1:
                    label1.Text = "1";
                    c0.Visible = false;
                    c1.Visible = false;
                    break;
            }
        }
        private void game(object sender, EventArgs e)
        {
            int[,] map = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            string b_name = (sender as Button).Name;
            int J_line = Convert.ToInt32(b_name[2]) - 48;
            int I_line = Convert.ToInt32(b_name[1]) - 48;
            if ((sender as Button).Text == "X" || (sender as Button).Text == "O")
            {

            }
            else
            {
                if (label1.Text == "0")
                {
                    (sender as Button).Text = "X";
                    label1.Text = "1";
                }
                else
                {
                    (sender as Button).Text = "O";
                    label1.Text = "0";
                }
            }
        }

    }
}
