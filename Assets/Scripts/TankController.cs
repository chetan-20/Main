
using UnityEngine;

public class TankController
{
    private TankView tankView;
    private Tankmodel tankModel;

    public TankController(TankView tankView,Tankmodel tankModel)
    {
        this.tankView = tankView;
        this.tankModel = tankModel;
        GameObject.Instantiate(tankView.gameObject);
        tankModel.SetTankController(this);
        tankView.SetTankController(this);
    }

}
