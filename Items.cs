namespace Shopkeeper
{


    class Items
    {

        private int _ageToBuy;
        private string _name;
        private double _value;

        public Items(string name, double itemValue, int ageToBuy)
        {
            _name = name;
            _value = itemValue;
            _ageToBuy = ageToBuy;
        }

        public int getAgeToBuy() { return _ageToBuy; }
        public string getName() { return _name; }
        public double getValue() { return _value; }

        public void setAgeToBuy(int ageToBuy) { _ageToBuy = ageToBuy; }
        public void setName(string name) { _name = name; }
        public void setValue(double itemValue) { _value = itemValue; }

        public void PrintItems() {
            Console.WriteLine($"Name: {_name}" +
                              $"Value: {_value}");
        }
    }
}
