namespace tpmodul5_1302223015
{
    internal class Program
    {

        public class DataGeneric<T>
        {
            private T data;
            public DataGeneric(T data)
            {
                this.data = data;

            }

            public void PrintData()
            {
                Console.WriteLine("Data yang tersimpan adalah " + data);
            }
        }

        public class HaloGeneric
        {
            public void SapaUser(String username)
            {
                Console.WriteLine("Halo User " + username);
            }
        }
        static void Main(string[] args)
        {
            HaloGeneric namaPanggilan = new HaloGeneric();
            namaPanggilan.SapaUser("Galang");

            DataGeneric<String> data = new DataGeneric<String>("1302223015");
            data.PrintData();
        }
    }
}