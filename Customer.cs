namespace Shopkeeper
{


    class Customer
    {

        private int _age;
        private string _name;
        private double _cash;

        public List<Items> items = new List<Items>();

        public Customer(int age, string name, double cash)
        {
            _age = age;
            _cash = cash;
            _name = name;
        }

        public string getName() { return _name; }
        public int getAge() { return _age; }
        public double getCash() { return _cash; }

        public void setName(string name) { _name = name; }
        public void setAge(int age) { _age = age; }
        public void setCash(double cash) { _cash = cash; }

        private void PrintItemList()
        {

            foreach (Items item in items)
            {

                Console.WriteLine($"Name: {item.getName()}\n" +
                                  $"Value: {item.getValue()}\n");
            }
        }

        public void PrintCustomerInfo()
        {
            Console.WriteLine($"Name: {_name}\n" +
                              $"Age: {_age}\n" +
                              $"Cash: {_cash}\n");
            PrintItemList();
        }

        public void AddItem(Items itemToAdd)
        {
            items.Add(itemToAdd);
        }
    }
}
