using UnityEngine;
using System.Collections;

public class Born : MonoBehaviour {

    public GameObject ball;
    GameObject newBall;
    float timer_f = 0f;
    int timer_i = 0;
	// Use this for initialization
	void Start () {
        CreateBall();
    }
	
	// Update is called once per frame
	void Update () {
        timer_f += Time.deltaTime;
        timer_i = (int)timer_f;
        if(timer_i == 3)
        {
            if (newBall != null)
                GameObject.Destroy(newBall);
            CreateBall();
            timer_f = 0;
        }
	}
    void CreateBall()
    {
        newBall = GameObject.Instantiate<GameObject>(ball);
        newBall.transform.position = new Vector3(0, 10, 0);
    }
}
