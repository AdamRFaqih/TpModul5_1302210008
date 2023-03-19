class Utama
{
    public static void Main()
    {
        string nama = Console.ReadLine();
        HaloGeneric haloGeneric = new HaloGeneric();
        haloGeneric.sapaUser(nama);
    }
}

class HaloGeneric
{
    public void sapaUser<T>(T data)
    {
        Console.WriteLine("Halo user " + data);
    }
}