namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomeTheaterFacade homeTheaterFacade = new HomeTheaterFacade();
            
           Console.WriteLine("Film opzetten ");
           
           homeTheaterFacade.setUp();
           
           Console.WriteLine("Film opgezet ");
           
           homeTheaterFacade.watchMovie("Breaking bad");
           
           Console.WriteLine("Speelt nu film af: Breaking bad");

           homeTheaterFacade.endMovie();
           
           Console.WriteLine("Film afgelopen, en uitgezet ");
           
        }
    }
}