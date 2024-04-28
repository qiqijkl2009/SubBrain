using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropManager
{
    private static PropManager _instance;

    private PropManager() { }

    public static PropManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new PropManager();
            }
            return _instance;
        }
    }

    public void GetProp(List<Transform> propGroup)
    {
        int counter = 0;

        for (int i = 0; i < propGroup.Count; i++)
        {
            if (propGroup[i].gameObject.activeInHierarchy == false)
            {
                propGroup[i].gameObject.SetActive(true);
                counter = 0;
                break;
            }
            else
            {
                counter++;
            }
        }

        if (counter == propGroup.Count)
        {
            Debug.Log("µÀ¾ßÒÑÂú");
        }
    }

    public void UseProp(Transform prop)
    {
        prop.gameObject.SetActive(false);
    }


}
