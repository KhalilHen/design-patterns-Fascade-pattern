namespace FacadePattern;

public class HomeTheaterFacade
{
    private Projector projector;
    private CdPlayer cdPlayer;
    private DvdPlayer dvdPlayer;
    private LawOfDementer lawOfDementer;
    private PopcornPopper popcornPopper;
    private TheaterLights theaterLights;
    private Tuner tuner;
    private Amplifier amplifier;
    private Screen screen;



    public void setUp()
    {
        amplifier = new Amplifier();
        cdPlayer = new CdPlayer(amplifier);
        dvdPlayer = new DvdPlayer(amplifier);
        tuner = new Tuner(amplifier);
         projector = new Projector();
         lawOfDementer = new LawOfDementer();
         popcornPopper = new PopcornPopper();
         theaterLights = new TheaterLights();
         screen = new Screen();


    }
  public void    watchMovie(String movieName)
  {
      popcornPopper.On();
            popcornPopper.Pop();
      
      
            theaterLights.Dim(10);

            screen.Down();

            projector.On();
            projector.SetInput(dvdPlayer);
            projector.WideScreenMode();

            amplifier.On();
            amplifier.SetDvd(dvdPlayer);
            amplifier.SetSurroundSound();
            amplifier.SetVolume(5);

            dvdPlayer.On();
            dvdPlayer.Play(movieName);
      
  }
  
  public void endMovie()
  {
      
      
      
      theaterLights.Off();

      screen.Up();

      projector.Off();

          
      
      amplifier.Off();

      dvdPlayer.Off();
      dvdPlayer.Stop();
  }

}