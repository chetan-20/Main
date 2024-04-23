using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] private TankView tankView;


    void Start()
    {
        CreateTank();        
    }

    private void CreateTank()
    {
        Tankmodel tankModel = new Tankmodel(Tanks[1].tankType, Tanks[1].color, Tanks[1].movementspeed, Tanks[1].rotationspeed);
        TankController tankController = new TankController(tankView,tankModel);        
    }
    
    [Serializable]
    public class Tank
    {
     public TankTypes tankType;
     public Material color;
     public float movementspeed;
     public float rotationspeed;
    }

    [SerializeField] private List<Tank> Tanks;
}
