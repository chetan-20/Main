using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    [SerializeField] private TankSpawner tankSpawner;
    public void GreenTankSelected()
    {
        tankSpawner.CreateTank(0);
        this.gameObject.SetActive(false);
    }
    public void BlueTankSelected()
    {
        tankSpawner.CreateTank(1);
        this.gameObject.SetActive(false);
    }
    public void RedTankSelected()
    {
        tankSpawner.CreateTank(2);
        this.gameObject.SetActive(false);
    }
}
