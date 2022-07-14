using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Data
{
    // 변수
    // 기본 접근 지정자는 private 입니다.
    public int price;
    public string name;
    public Sprite sprite;

    // 기본 생성자 
    // 생성자를 선언하지 않으면 자동으로 기본 생성자를 생성시켜줍니다.

}

public class LifeCycle : MonoBehaviour
{
    // 유니티에서는 소멸자가 존재하지 않습니다.
    public Data [] data;

    public Text[] priceUI;
    public Text[] nameUI;
    public Image[] spriteUI;

    private void Awake() // <- 1번째
    {
        for(int i = 0; i < data.Length; i++)
        {
            priceUI[i].text = data[i].price.ToString();
            nameUI[i].text = data[i].name;
            spriteUI[i].sprite = data[i].sprite;
        }
    }

    void Start()
    {
        Debug.Log("Tiger Start");
    }

    private void OnEnable()
    {
        Debug.Log("Tiger OnEnble");
    }

    private void FixedUpdate()
    {
        Debug.Log("Tiger FixedUpdate");
    }

    private void Update()
    {
        
    }
}
