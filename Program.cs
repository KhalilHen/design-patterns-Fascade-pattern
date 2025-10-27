namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
    
            
        Amplifier  amplifier = new Amplifier();
        CdPlayer  cdPlayer = new CdPlayer(amplifier);
        DvdPlayer  dvdPlayer = new DvdPlayer(amplifier);
        Tuner  tuner = new Tuner(amplifier);
        Projector    projector = new Projector();
        LawOfDementer  lawOfDementer = new LawOfDementer();
        PopcornPopper   popcornPopper = new PopcornPopper();
        TheaterLights    theaterLights = new TheaterLights();
        Screen  screen = new Screen();
        
        
        
        
        HomeTheaterFacade homeTheater = new HomeTheaterFacade(
            projector, cdPlayer, dvdPlayer, lawOfDementer, popcornPopper, theaterLights, tuner, amplifier, screen
        );
        
        homeTheater.watchMovie("Breaking bad");
            
           // Console.WriteLine("Film opzetten ");
           //
           // homeTheaterFacade.setUp();
           //
           // Console.WriteLine("Film opgezet ");
           //
           // homeTheaterFacade.watchMovie("Breaking bad");
           //
           // Console.WriteLine("Speelt nu film af: Breaking bad");
           //
           // homeTheaterFacade.endMovie();
           //
           // Console.WriteLine("Film afgelopen, en uitgezet ");
           
        }
    }
}