using System.Collections.Generic;
using UnityEngine;

public class HideObjects : MonoBehaviour
{

    public GameObject AnimalsBtn;
    public GameObject PlantsBtn;
    public GameObject CountriesBtn;
    public GameObject ElectronicBtn;
   
   
    public List<GameObject> objectsToHide;

    void HideAll()
    {
        foreach (GameObject obj in objectsToHide)
        {
            if (obj != null)
                obj.SetActive(false);
        }
    }

    public void Function1()
    {
        HideAll();
        AnimalsBtn.SetActive(true);
    }

    public void Function2()
    {
        HideAll();
        PlantsBtn.SetActive(true);
    }

    public void Function3()
    {
        HideAll();
        CountriesBtn.SetActive(true);
    }

    public void Function4()
    {
        HideAll();
        ElectronicBtn.SetActive(true);
    }
}
