using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using static Unity.VisualScripting.Dependencies.Sqlite.SQLite3;

public class player : MonoBehaviour
{
    
    public GameObject namepanel;
    public GameObject chapanel;

    public TMP_InputField nameSpace;
    public void Change()
    {

        if (gameManager.I.chatype == 1)
        {
            //Debug.Log("2번모드 들어오긴함?");
            //playerSprite.sprite= Resources.Load<Sprite>("new/penguin_atack_01");
           // playerSprite.sprite = Resources.Load<Sprite>("new/penguin_idle_02");
            //gameManager.I.playerSprite.sprite = gameManager.I.cha2;

            gameManager.I.playerSprite.sprite = Resources.Load<Sprite>("new/penguin_idle_02");
            //gameManager.I.playerSprite.sprite = Resources.Load<Sprite>("new/penguin_atack_01");
        }
        else
        {
           // Debug.Log("1번모드 들어오긴함?");
            gameManager.I.playerSprite.sprite = Resources.Load<Sprite>("new/penguin_atack_01");
            //gameManager.I.playerSprite.sprite = Resources.Load<Sprite>("new/penguin_idle_02");
            //gameManager.I.playerSprite.sprite = gameManager.I.cha1;
        }
    }
    public void seecha() 
    {
        chapanel.SetActive(true);
    }
    public void btn1() 
    {
        //Debug.Log("버튼들어오긴함?");
        gameManager.I.chatype = 1;
        Change();
        chapanel.SetActive(false);
    }
    public void btn2()
    {
        //Debug.Log("버튼들어오긴함?");
        gameManager.I.chatype = 2;
        Change();
        chapanel.SetActive(false);
    }

    public void namebtn() 
    {   
        namepanel.SetActive(true);

    }
    public void namebtn2()
    {
        gameManager.I.nameText.text = nameSpace.text;
        namepanel.SetActive(false);

    }
}
