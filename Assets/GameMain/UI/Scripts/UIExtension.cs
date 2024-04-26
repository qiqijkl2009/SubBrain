using System.Collections.Generic;
using UnityEngine;

public static class UIExtension
{
    public static class Prop
    {
        public static void GetProp(List<Transform> propGroup)
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
    
        public static void UseProp(Transform prop)
        {
            prop.gameObject.SetActive(false);
        }
    }
}
