using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartStop : MonoBehaviour
{
    Animator anim;
    public int direction;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnStartStop()
    {
        bool s = !anim.GetBool("truck");
        anim.SetBool("truck", s);
    }
    public void OnSwitch()
    {
        if (direction == 0)
        {
            direction = 1;
        }
        else
        {
            direction = 0;
        }
        SceneManager.LoadScene(direction);
    }
}
