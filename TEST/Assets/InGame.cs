using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InGame : MonoBehaviour
{
    float num = 0;
    int lv = 0;
    int random;
    float pol = 0;
    float time = 0f;
    bool cancer = true;
    public GameObject StemCell;
    public GameObject Mid;
    public Slider EXP;
    public Text EXPText;
    public Slider Pol;
    public Text PolText;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello!");
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 5)
        {
            Random.seed = System.Environment.TickCount;
            random = Random.Range(0, 100);
            Debug.Log(random);
            if (random < 7)
                ChangeCancer();
            time -= 5;
        }
    }

    public void Click()
    {
        switch (lv)
        {
            case 0:
                StemCell.GetComponent<Animation>().Play();
                break;
            case 1:
                Debug.Log("mid");
                Mid.GetComponent<Animation>().Play();
                break;
        }

        Random.seed = System.Environment.TickCount;
        random = Random.Range(0,10);

        if (random < 7)
            num += 5;
        else
            pol += 10;

        Debug.Log(random);

        if (pol == 100)
            ChangeFungi();

        if (num == 100)
        {
            lv++;
            num = 0;
            pol = 0;
            if(lv == 1)
            {
                StemCell.SetActive(false);
                Mid.SetActive(true);
            }
            else
                ChangeMeat();
        }
        EXP.value = num;
        EXPText.text = string.Format("{0}/100", EXP.value);
        Pol.value = pol;
        PolText.text = string.Format("{0}/100", Pol.value);
    }

    public void ChangeCancer()
    {
        SceneManager.LoadScene("Cancer");
    }

    public void ChangeFungi()
    {
        SceneManager.LoadScene("Fungi");
    }

    public void ChangeMeat()
    {
        SceneManager.LoadScene("Meat");
    }
}