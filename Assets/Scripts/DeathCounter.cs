using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathCounter : MonoBehaviour
{
    [SerializeField] int deathNumber;
    Text albertText;
    // Start is called before the first frame update
    void Start()
    {
        albertText = GetComponent<Text>();
    }

   public void deathCount()
    {
        deathNumber = deathNumber + 1;
        albertText.text = deathNumber.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
