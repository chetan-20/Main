using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TankController
{
    private TankView tankView;
    private Tankmodel tankModel;
    private Rigidbody rb;
    public TankController(TankView tankView, Tankmodel tankModel)
    {        
        this.tankModel = tankModel;
        this.tankView = GameObject.Instantiate<TankView>(tankView);        
        this.tankView.SetTankController(this);
        this.tankModel.SetTankController(this);
        this.rb = this.tankView.GetTankRigidBody();
    }
    public void Move(float movement, float movementspeed)
    {       
        rb.velocity = tankView.transform.forward * movement * movementspeed;       
    }
    public void Rotate(float rotate, float rotatespeed)
    {
        Vector3 vector = new Vector3(0f, rotate * rotatespeed, 0f);
        Quaternion deltarotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltarotation);
    }    
}
