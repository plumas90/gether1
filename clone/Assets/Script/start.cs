using Microsoft.Unity.VisualStudio.Editor;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using static Unity.Burst.Intrinsics.X86;

public class start : MonoBehaviour
{
    [SerializeField] public Sprite sprite;
    public GameObject pickup;
    public GameObject so1;
    public GameObject so2;
    public GameObject so3;

    public TMP_InputField inputField;
    public GameObject nameSet;
    string playername;


    // Start is called before the first frame update
    public void Startbtn()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void NameBtn()
    {
        nameSet.SetActive(true);
    }
    public void NameSetBtn() 
    {
        //gameManager.I.playerName = inputField.GetComponent<TextMeshPro>().text;
        //gameManager.I.nameText.text = inputField.text;
        gameManager.I.test = inputField.text;
        //gameManager.I.playerName = inputField.text;
        nameSet.SetActive(false);
        
    }
    public void ChaBtn()
    {
        PickCha();
    }

    public void PickCha()
    {
        pickup.SetActive(true);
    }
    public void Pick1()
    {
        //스프라이트=이미지
        so1.GetComponent<UnityEngine.UI.Image>().sprite = so2.GetComponent<UnityEngine.UI.Image>().sprite;
        gameManager.I.chatype = 1;
        pickup.SetActive(false);
    }
    public void Pick2()
    {
        so1.GetComponent<UnityEngine.UI.Image>().sprite = so3.GetComponent<UnityEngine.UI.Image>().sprite;
        gameManager.I.chatype = 2;
        pickup.SetActive(false);
    }
}
