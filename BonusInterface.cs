using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusInterface : MonoBehaviour
{
    public Text text;
    public float bonus = 0;
    public float point;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        text.text = "BONUS " + point;
    }

    public void AddBonus(int point)
    {
        bonus += point;
        bonus++;
        text.text = "BONUS " + point;
    }
}
