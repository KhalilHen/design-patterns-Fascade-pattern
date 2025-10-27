namespace FacadePattern;

internal class HomeTheaterFacade
{


    private  Amplifier amplifier;
    private CdPlayer cdPlayer;
    private DvdPlayer dvdPlayer;
    private Tuner tuner;
    private Projector projector;
    private Screen screen;
    private TheaterLights theaterLights;
    private PopcornPopper popcornPopper;
    private LawOfDementer lawOfDementer;
 public    HomeTheaterFacade(Projector projector, CdPlayer cdPlayer, DvdPlayer dvdPlayer, LawOfDementer lawOfDementer, PopcornPopper popcornPopper, TheaterLights theaterLights, Tuner tuner, Amplifier amplifier, Screen screen)
    {
          this.projector = projector;
        this.cdPlayer = cdPlayer;
        this.dvdPlayer = dvdPlayer;
        this.lawOfDementer = lawOfDementer;
        this.popcornPopper = popcornPopper;
        this.theaterLights = theaterLights;
        this.tuner = tuner;
        this.amplifier = amplifier;
        this.screen = screen;
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
   // Moet ik hier nadat film uitgezet is de instantie  verbreken?   
      
  }

}