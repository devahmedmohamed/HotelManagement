using D16EF02Task.Context;

namespace D16EF02Task
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            context = new HotelContext();
            this.FormClosed += (s, e) => context.Dispose();
        }

        HotelContext context;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUserName.Text;
            var password = txtPassword.Text;

            var managerLoginFrontend = context.ManagerLoginFrontend.FirstOrDefault(x => x.Username == username && x.Password == password);
            var managerLoginKitchen = context.ManagerLoginKitchen.FirstOrDefault(x => x.Username == username && x.Password == password);

            if (managerLoginFrontend != null)
            {
                this.Hide();  
                var hotelReservation = new Frontend();
                hotelReservation.ShowDialog();  

                this.Show(); 
            }
            else if (managerLoginKitchen != null)
            {
                this.Hide();
                var kitchen = new Kitchen();
                kitchen.ShowDialog();

                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
