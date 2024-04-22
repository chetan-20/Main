
using UnityEngine;

public class Tankmodel
{
    private TankController tankController;
    internal float movementSpeed;
    internal float rotationSpeed;
    public Tankmodel(float _movement,float _rotation) 
    {
        this.movementSpeed = _movement;
        this.rotationSpeed = _rotation;
    }
    public void SetTankController(TankController tankController)
    {
        this.tankController = tankController;
    }
}
