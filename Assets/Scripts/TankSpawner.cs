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
        Tankmodel tankModel = new Tankmodel();
        TankController tankController = new TankController(tankView,tankModel);        
    }    
}
