using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ChangeMedal : MonoBehaviour
{
  
    public int bronze;
    public int silver;
    public int gold;
    public GameObject bronzeMedal;
    public GameObject SilverMedal;
    public GameObject GoldMedal;
    GameObject medal;

    public void Checkmedal(int score)
    {

        if (score == bronze) {

            medal = Instantiate(bronzeMedal,transform.position, Quaternion.identity) ;
            
        }
        else if (score == silver)
        {
            Destroy(medal);
            medal = Instantiate(SilverMedal, transform.position, Quaternion.identity);
          
        }
        else if (score == gold)
        {
            Destroy(medal);
            medal = Instantiate(GoldMedal, transform.position, Quaternion.identity);
        }
    }
}
