
using UnityEngine;

public class TankController
{
    private TankView tankView;
    private Tankmodel tankModel;

    public TankController(TankView tankView,Tankmodel tankModel)
    {       
        this.tankModel = tankModel;
        this.tankView = GameObject.Instantiate<TankView>(tankView);
        tankModel.SetTankController(this);
        tankView.SetTankController(this);
    }

}
