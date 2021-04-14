using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    private float gravityScale;
    private float timeSinceLevelLoad;
    private void Awake()
    {
        this.gravityScale = GetComponent<Rigidbody2D>().gravityScale;
        this.timeSinceLevelLoad = Time.timeScale;

        //Debug.Log("In Awake.");
        //Debug.Log("timeSinceLevelLoad: " + this.timeSinceLevelLoad);
        //Debug.Log("gravityScale: " + this.gravityScale);
    }
    void Start()
    {
        Debug.Log("timeSinceLevelLoad: " + this.timeSinceLevelLoad);
        this.gravityScale += this.timeSinceLevelLoad / 100f;
        Debug.Log("gravityScale: " + this.gravityScale);
    }
    void Update()
    {
        if (transform.position.y < -2f)
        {
            Destroy(gameObject);
        }    
    }
}
