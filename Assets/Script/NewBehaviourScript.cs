using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;

    private void Awake()
    {
        player.SetActive(true);
    }

    void Start()
    {
        Debug.Log("Start"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
