using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNewPlace : MonoBehaviour
{
    [SerializeField] string newPlaceName;
    [SerializeField] private bool needsClick; 
    

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            if(!needsClick)
            {
                SceneManager.LoadScene(newPlaceName);
            }
            
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        bool makesClick = Input.GetMouseButtonDown(0);
        if(needsClick && makesClick)
        {
            SceneManager.LoadScene(newPlaceName);
        }
    }
}
