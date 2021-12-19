using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defnderspwn : MonoBehaviour
{
   Defmder defender;
   GameObject defenderParent;

private void OnMouseDown()
{
   AttempToPlaceDefenderAt(GetSquareClicked());
}

public void SetDefender(Defmder defenderToSelect)
{
    defender = defenderToSelect;
}

private void Start()
{
    CreateDefenderParent();
}

private void CreateDefenderParent()
{
}

private void AttempToPlaceDefenderAt(Vector2 gridPos)
{
    var StarDisplay = FindObjectOfType<StarDisplay>();
    int defenderCost = defender.GetStarCost();
    if (StarDisplay.HaveEnoughStars(defenderCost))
    {
        SpawnDefender(gridPos);
        StarDisplay.spendStars(defenderCost);
    }
}

private Vector2 GetSquareClicked()
{
    Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
    Vector2 gridPos = SnapToGrid(worldPos);
    return gridPos;
}

private Vector2 SnapToGrid(Vector2 rawWorldPos)
{
    float newX = Mathf.RoundToInt(rawWorldPos.x);
    float newY = Mathf.RoundToInt(rawWorldPos.y);
    return new Vector2(newX, newY);

}

private void SpawnDefender(Vector2 worldPos)
{
    Defmder newDefender = Instantiate(defender, worldPos, Quaternion.identity) as Defmder;
}

}


