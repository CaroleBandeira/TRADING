using TRADING.Modeles;

namespace TRADING
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            Trader Td1 = new Trader("Alice", "Lidell", new DateTime(1990, 1, 1), "f", "alice@example.com", 1234567890);
            Trader Td2 = new Trader("Bob", "Marley", new DateTime(1985, 5, 11), "m", "bob@example.com", 0987654321);
           
            Action2 A1 = new Action2("US0378331005", "Apple", 150.00);
            Action2 A2 = new Action2("US5949181045", "Microsoft", 200.00);

            CoursAction CA1 = new CoursAction(new DateTime (2023, 10, 29), 148.00, A1);
            CoursAction CA2 = new CoursAction(new DateTime(2023, 10, 30), 151.00, A1);

            CoursAction CA3 = new CoursAction(new DateTime(2023, 10, 29), 198.00, A2);
            CoursAction CA4 = new CoursAction(new DateTime(2023, 10, 30), 202.00, A2);

            Transaction Ts1 = new Transaction(new DateTime(2023, 10, 30), 10, "achat", Td1, A1);
            Transaction Ts2 = new Transaction(new DateTime(2023, 10, 30), 5, "achat", Td2, A2);

            Td1.Email = "alice_new@example.com";

            






        }




            private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
