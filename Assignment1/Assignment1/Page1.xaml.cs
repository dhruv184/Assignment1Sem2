namespace Assignment1;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        string userName = NameEntry.Text;
        int itemNumber = int.Parse(NumberOfItemsEntry.Text);

        if (double.TryParse(PriceEntry.Text, out double price))
        {
            double discount = GetDiscount();
            double discountedPrice = calDiscountPrice(price, itemNumber, discount);

            Label1.Text = $"Customer Name : {userName}";
            PricePerItemLabel.Text = $"Price Per Item : {price}";
            NumberOfItemsLabel.Text = $"Number Of Items : {itemNumber}";
            DiscountLabel.Text = $"Discount : {discount}";
            TotalPriceLabel.Text = $"Total Price : {discountedPrice:C}";
        }
        else
        {
            Label1.Text = "Invalid price Entered";
        }
    }

    private double GetDiscount()
    {
        if (percent5.IsChecked)
            return 0.05;
        else if (percent10.IsChecked)
            return 0.10;
        else if (percent15.IsChecked)
            return 0.15;
        else if (percent20.IsChecked)
            return 0.20;
        else
            return 0.0;
    }
    private double calDiscountPrice(double price, double itemNumber, double discount)
    {
        return (itemNumber * price * 1.13) - (itemNumber * price * 1.13 * discount);
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

        NameEntry.Text = string.Empty;
        PriceEntry.Text = string.Empty;
        NumberOfItemsEntry.Text = string.Empty;
        Label1.Text = string.Empty;
        PricePerItemLabel.Text = string.Empty;
        NumberOfItemsLabel.Text = string.Empty;
        DiscountLabel.Text = string.Empty;
        TotalPriceLabel.Text = string.Empty;
    }
}
