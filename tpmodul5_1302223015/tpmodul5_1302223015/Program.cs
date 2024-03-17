namespace tpmodul5_1302223015
{
    internal class Program
    {

        public class HaloGeneric
        {
            public void SapaUser(String username)
            {
                Console.WriteLine("Halo User" +" " + username);
            }
        }
        static void Main(string[] args)
        {
            HaloGeneric namaPanggilan = new HaloGeneric();
            namaPanggilan.SapaUser("Galang");
        }
    }
}
