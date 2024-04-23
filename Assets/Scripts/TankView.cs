using UnityEngine;

public class TankView : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField]private MeshRenderer[] childs;
    private TankController tankController;
    private float movement;
    private float rotation;    
    private void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0f, 3f, -4f);
    }
    private void Update()
    {
        Movement();      
        if (movement != 0)
        {            
            tankController.Move(movement, tankController.GetTankModel().movementSpeed);
        }
        if(rotation != 0)
        {
            tankController.Rotate(rotation, tankController.GetTankModel().rotationSpeed);
        }
    }
    private void Movement()
    {        
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

    public void ChangeColor(Material color)
    {
        for(int i = 0;i<childs.Length;i++)
        {
            childs[i].material = color;
        }
    }
}
