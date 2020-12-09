﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    void FixedUpdate()
    {
        if(PlayerController.dead)return;
        this.transform.position +=
            PlayerController.player.transform.forward * -0.15f;

        if(PlayerPrefs.GetInt("score") > 500){
            this.transform.position +=
            PlayerController.player.transform.forward * -0.16f /2;

        }else if(PlayerPrefs.GetInt("score") > 1000){
            this.transform.position +=
            PlayerController.player.transform.forward * -0.18f;
        }else if(PlayerPrefs.GetInt("score") > 2000){
            this.transform.position +=
            PlayerController.player.transform.forward * -0.19f;
        }
        if (PlayerController.currentPlatform == null) return;
        if (PlayerController.currentPlatform.tag == "stairs")
        {
            this.transform.Translate(0, -0.06f, 0);
        }
        if (PlayerController.currentPlatform.tag == "downStairs")
        {
            this.transform.Translate(0, 0.06f, 0);
        }
    }
}
