using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Destroy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }

        if (collision.gameObject.CompareTag("Collectible"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
