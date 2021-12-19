using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DefnderButton : MonoBehaviour
{
    [SerializeField] Defmder defenderPrefab;

    private void Start()
    {
        LabelButtonWithCost();
    }

    private void LabelButtonWithCost()
    {
        Text costText = GetComponentInChildren<Text>();
        if(!costText)
        {
            Debug.LogError("dfgdfg");
        }
        else
        {
        }
    }

   private void OnMouseDown()
   {
       var buttons = FindObjectsOfType<DefnderButton>();
       foreach (DefnderButton button in buttons)
       {
           button.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 255);
       }
       GetComponent<SpriteRenderer>().color = Color.white;
       FindObjectOfType<Defnderspwn>().SetDefender(defenderPrefab);
   }
}
