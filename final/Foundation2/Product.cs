public class Product
{
    Random rnd = new Random();
    private string prod_name;
    private string prod_id;
    private double prod_price;
    private int prod_quantity;
    int choice;
    //potential items to choose from


    public string chooseProducts()
    {
        choice = rnd.Next(1, 8);
        prod_quantity = rnd.Next(1, 5);
        
        switch(choice)
        {
            case 1:
                prod_id = "492b50245f357e4d";
                prod_name = "Hammock";
                prod_price = 20;
                break;
            case 2:
                prod_id = "5ac33ed1f6589cb4";
                prod_name = "2 Person Tent";
                prod_price = 30;
                break;
            case 3:
                prod_id = "cc632aaf4c699b1c";
                prod_name = "4 Person Tent";
                prod_price = 50;
                break;
            case 4:
                prod_id = "76505dc32f7a97d9";
                prod_name = "8 Person Tent";
                prod_price = 70;
                break;
            case 5:
                prod_id = "aa7d0d9a38b25a2a";
                prod_name = "Backpack (Small)";
                prod_price = 30;
                break;
            case 6:
                prod_id = "b2c2f0d092c993ae";
                prod_name = "Backpack (Large)";
                prod_price = 30;
                break;
            case 7:
                prod_id = "b42e014d005cf8eb";
                prod_name = "First Aid Kit (Small)";
                prod_price = 30;
                break;
            case 8:
                prod_id = "7ff1bbf431b36c4d";
                prod_name = "First Aid Kit (Large)";
                prod_price = 30;
                break;
            default:
                break;
        }
        return $"Product Name: {prod_name}\nID: {prod_id}\nQuantity: {prod_quantity}";
    }
    public double returnTotal()
    {
        double final_total = prod_price * prod_quantity;
        return final_total;
    }
}