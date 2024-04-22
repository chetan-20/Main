using UnityEngine;

public class TankView : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    private TankController tankController;
    private float movement;
    private float rotation;
   
    private void Update()
    {
        Movement();      
        if (movement != 0)
        {            
            tankController.Move(movement, 30f);
        }
        if(rotation != 0)
        {
            tankController.Rotate(rotation,50f);
        }
    }
    private void Movement()
    {
        Debug.Log("4");
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }

    public void SetTankController(TankController tankController)
    {
        this.tankController = tankController;
    }
    public Rigidbody GetTankRigidBody()
    {
        return rb;
    }
}
