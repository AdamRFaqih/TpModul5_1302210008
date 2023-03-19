class Utama
{
    public static void Main()
    {
        DataGenerics<string> dataGenerics = new DataGenerics<string>(Console.ReadLine());
        dataGenerics.printData();

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