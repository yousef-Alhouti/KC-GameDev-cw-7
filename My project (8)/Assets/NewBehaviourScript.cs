using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public float inc;
    
    public float minpos;
    public float maxpos;
    AudioSource Audio;

    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    void move()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x - inc, minpos, maxpos), transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x - inc, minpos, maxpos), transform.position.y, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x + inc, minpos, maxpos), transform.position.y, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x + inc, minpos, maxpos), transform.position.y, transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Invoke("restart", 1f);

            Audio.Play();
        }
    }
    void restart()
    {
        SceneManager.LoadScene(0);
    }
}
