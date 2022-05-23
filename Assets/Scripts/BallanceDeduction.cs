using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallanceDeduction : MonoBehaviour
{
    public TextMeshProUGUI textUI;
    public int Ballance = 1000;
    public int afterDeduction=100;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Deduction()
    {
        Ballance -= afterDeduction;
        textUI.text = "Ballance: $" + Ballance;
    }
}
