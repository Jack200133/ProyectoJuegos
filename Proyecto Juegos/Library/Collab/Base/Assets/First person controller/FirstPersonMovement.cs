using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstPersonMovement : MonoBehaviour
{
    public float speed = 5;
    Vector2 velocity;
    public GameObject PauseMenu;
    

    void FixedUpdate()
    {
        if (PauseMenu.activeSelf == false)
        {
            velocity.y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            velocity.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            transform.Translate(velocity.x, 0, velocity.y);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Nivel2"))
        {            
            SceneManager.LoadScene(2);
        }
            
        if (other.gameObject.CompareTag("Nivel3"))
        {
            SceneManager.LoadScene(3);
        }
            


    }
}
