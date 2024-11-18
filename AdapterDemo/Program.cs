namespace AdapterDemo
{
    public class Client
    {
        public static void Main(string[] args)
        {
            oldCharger oc = new oldCharger();

            ITypeCPhone phone = new ChargerAdapter(oc);

            phone.ConnectTypeC();
        }
    }
}
