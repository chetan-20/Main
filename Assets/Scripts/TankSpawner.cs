using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] private TankView tankView;
    public void CreateTank(int i)
    {
        Tankmodel tankModel = new Tankmodel(Tanks[i].tankType, Tanks[i].color, Tanks[i].movementspeed, Tanks[i].rotationspeed);
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
