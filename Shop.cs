namespace Shopkeeper
{


    class Shop
    {

        private int _input, _index = 1;
        private Items item;
        private Customer customer = new Customer(10, "Per", 300);

        private List<Items> shopItems = new List<Items>
        {
            new Items("Bread",24.23,0),
            new Items("Apple",12.23,0),
            new Items("Banan",13.66,0),
            new Items("Cucumber",10.12, 0),
            new Items("Milk",17.14, 0),
            new Items("Beer",25.99,18),
        };

        public Shop()
        {
            ShopMenu();
        }

        private void PrintItemListWithIndex()
        {

            foreach (Items item in shopItems)
            {
                Console.WriteLine($"Index: [{_index}]\n" +
                                  $"Name: {item.getName()}\n" +
                                  $"Price: {item.getValue}\n");
                _index++;
            }
        }

        private void BuyItem()
        {

            PrintItemListWithIndex();

            Console.WriteLine("Write the index of the item you want to buy");

            _input = Convert.ToInt32(Console.ReadLine());

            _index = _input - 1;

            if (customer.getCash() >= shopItems[_index].getValue() && customer.getAge() >= shopItems[_index].getAgeToBuy())
            {
                item = shopItems[_index];
                customer.AddItem(item);
                customer.setCash(customer.getCash() - item.getValue());
            }
            else if (customer.getCash() < shopItems[_index].getValue())
            {
                Console.WriteLine("You dont have enough money!");
            }
            else if (customer.getAge() < shopItems[_index].getAgeToBuy()) {
                Console.WriteLine("You are not old enough to buy this item!");
            }

            Console.WriteLine($"You have cash {customer.getCash()} left.");
            _index = 1;
        }

        public void ShopMenu()
        {

            while (true)
            {

                Console.WriteLine($"[1] Buy something\n" +
                                  "[2] Print customer info\n" +
                                  "[0] Exit");

                _input = Convert.ToInt32(Console.ReadLine());

                switch (_input)
                {
                    case 0:
                        return;
                    case 1:
                        BuyItem();
                        break;
                    case 2:
                        customer.PrintCustomerInfo();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

            }
        }
    }
}
