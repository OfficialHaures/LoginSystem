namespace LoginSystem
{
    public partial class Inlog : Form
    {
        public Inlog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                string user, pass;
                user = txtUser.Text;
                pass = textBox2.Text;
                if (user == "admin" && pass == "admin")
                {
                    MessageBox.Show("WELKOM TERUG Beheerder!");
                }
                else
                {
                    MessageBox.Show("U BENT GEEN BEHEERDER GA WEG!");
                }
            }
        }
    }

