class Utama
{
    public static void Main()
    {

        string nama = Console.ReadLine();
        HaloGeneric haloGeneric = new HaloGeneric();
        haloGeneric.sapaUser(nama);
        DataGenerics<string> dataGenerics = new DataGenerics<string>(Console.ReadLine());
        dataGenerics.printData();
    }
}

class HaloGeneric
{
    public void sapaUser<T>(T data)
    {
        Console.WriteLine("Halo user " + data);

        

    }
}

class DataGenerics<T>
{
    private T data;

    public DataGenerics(T data)
    {
        this.data = data;
    }

    public void printData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);

    }
}