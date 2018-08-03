using System;

namespace TreehouseDefense {
  class Game{
    public static void Main(){
      Map map = new Map(8, 5);
      
      try{
         Path path = new Path(
           new [] {
             new MapLocation(0, 2, map),
             new MapLocation(1, 2, map),
             new MapLocation(2, 2, map),
             new MapLocation(3, 2, map),
             new MapLocation(4, 2, map),
             new MapLocation(5, 2, map),
             new MapLocation(6, 2, map),
             new MapLocation(7, 2, map)
           }
         );
        IInvader[] invaders = {
          new ShieldedInvader(path),
          new FastInvader(path),
          new StrongInvader(path),
          new BasicInvader(path),
          new ResurrectingInvader(path)
        };
        Tower[] towers = {
          new PowerfulTower(new MapLocation(1, 1, map)),
          new SuperTower(new MapLocation(1, 1, map)),
          new Tower(new MapLocation(1, 1, map))
        };
        Level level = new Level(invaders) {Towers = towers};
        
        bool playerWon = level.Play();

        Console.WriteLine("Player " + (playerWon? "won" : "lost"));
        MapLocation p = new MapLocation(7, 0, map);
        if (path.IsOnPath(p)) {Console.WriteLine(p + " is on path.");}
      }
      catch(OutOfBoundsException ex){
        Console.WriteLine("OutOfBoundsException: " + ex.Message);
      }
      catch(TreehouseDefenseException){
        Console.WriteLine("Unhandled TreehouseDefenseException");
      }
      catch (Exception ex){
         Console.WriteLine("Unhandled Exception: " + ex);
      }
    }
  }
}