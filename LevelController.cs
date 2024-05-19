using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public static bool finished
    public Spawner spawner;
    public void Check()
    {
        if (spawner.spawnCounter <= 0)
        {
            Enemy[] enemies = FindObjectsOfType<Enemy>();
            if(enemies.Length <= 0)
            {
                Victory();
            }
        }

        if(Corn.singleton.health <=0) 
        { 
            Defeat();
        }
    }

    public void Victory()
    {
        print("Victory");
    }

    public void Defeat()
    {
        print("Defeat");
    }

    private void Update()
    {
        Check();
    }
}
