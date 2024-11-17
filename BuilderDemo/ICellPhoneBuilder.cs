namespace BuilderDemo
{
    public interface ICellPhoneBuilder //This is the builder 
    {
        CellPhone GetPhone();
        ICellPhoneBuilder SetBattery(int battery);
        ICellPhoneBuilder SetCamera(int camera);
        ICellPhoneBuilder SetOs(string processor);
        ICellPhoneBuilder SetScreenSize(double screenSize);
    }
}