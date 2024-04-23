
using UnityEngine;

public class Tankmodel
{
    private TankController tankController;
    internal float movementSpeed;
    internal float rotationSpeed;
    internal TankTypes types;
    internal Material color;
    public Tankmodel(TankTypes tanktypes,Material col,float _movement,float _rotation) 
    {
        this.movementSpeed = _movement;
        this.rotationSpeed = _rotation;
        types = tanktypes;
        color = col;
    }
    public void SetTankController(TankController tankController)
    {
        this.tankController = tankController;
    }
}
