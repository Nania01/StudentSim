using UnityEngine;

public class GameManager : MonoBehaviour
{
    public StudentData playerStats;

    public void LiveWeek()
    {
        playerStats.hunger -= 20;
        playerStats.health -= 5;
        playerStats.moralState -= 10;
        
        playerStats.knowledge += 10;
        
        playerStats.currentWeek++;

        Debug.Log("Прошла неделя! Голод: " + playerStats.hunger);
    }
}
