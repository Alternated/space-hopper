using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontPlay : MonoBehaviour
{
     void Awake()
    {
        GameObject A = GameObject.FindGameObjectWithTag("Music");
        Destroy(A);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
