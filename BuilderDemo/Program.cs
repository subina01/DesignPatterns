namespace BuilderDemo
{ //This pattern follows single responsibility principle
    class Program
    {
        public static void Main(string[] args)
        {

            Shop shop = new Shop();
            CellPhone samsungPhone = shop.ConstructSamsungPhone();
            Console.WriteLine(samsungPhone);
        }
    }

    //Director
    class Shop
    {
        public CellPhone ConstructSamsungPhone()
        {
            ICellPhoneBuilder b = new SamsungPhoneBuilder();
            return b.SetScreenSize(4).GetPhone();
        }
    }
}   