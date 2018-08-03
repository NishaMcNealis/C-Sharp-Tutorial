using System;
namespace TreehouseDefense {
  abstract class Invader : IInvader {
    
    private int _pathStep = 0;
    private readonly Path _path;
    public MapLocation Location => _path.GetLocationAt(_pathStep); //Computed property location (updates based on _pathStep)

    protected virtual int StepSize{ get; } = 1;
    
    public abstract int Health {get; protected set;}
    
    public bool HasScored => (_pathStep >= _path.Length);
    
    public bool IsNeutralized => (Health <= 0);
    
    public bool IsActive => !(IsNeutralized || HasScored);
        
    public Invader(Path path){
      _path = path;

    }
    public void Move() => _pathStep += StepSize;
    
    public virtual void DecreaseHealth(int factor) => Health -= factor; //Reduces Health by given factor
  }
}