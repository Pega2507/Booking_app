namespace Booking_app
{
    public partial class MainWindow : Form
    {
        public DataBase db = null;
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                LoginWindow loginWindow = new LoginWindow();
                if(loginWindow.ShowDialog() != DialogResult.OK)
                {
                    throw new Exception("Invalid Login");
                }
                db = new DataBase();
            }
            catch(Exception ex) { 
               if(MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}