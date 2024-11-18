using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Planet : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    public int planetHealth = 100;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = $"Planet health: {planetHealth}";
        if(planetHealth <= 0)
        {
            print("Quit game");
            Application.Quit();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        planetHealth -= 1;
    }
}
