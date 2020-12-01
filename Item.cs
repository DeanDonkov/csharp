namespace asdfg
{

    public class Item
    {

        public double price { get; set; }
        public string name { get; set; }

        public Item(string name, double price)
        {
            this.price = price;
            this.name = name;
        }
    }
}