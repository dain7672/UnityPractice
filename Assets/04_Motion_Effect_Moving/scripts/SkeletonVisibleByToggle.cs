using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SkeletonVisibleByToggle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //gameobject는 왜 transform으로부터 참조해야 할까.
        List<string> results = findAllChildrenClass("MotionParticle", transform, new List<GameObject>());
        foreach (string name in results) {
            Debug.Log(name);
        }
        // foreach (GameObject particle in results)
        // {
        //     Debug.Log(particle);
        // }
        // for (int i=0; i< components.Length; i++)
        // {
            // Debug.Log(components[i]);
        // }
        // bool isOn = PlayerPrefs.GetInt("isSkinVisible") == 1;
        // GetComponentsInChildren 참고
        // GetComponent<MotionParticle>().enabled = isOn;
    }

    private List<GameObject> findAllChildrenClass(string name, Transform target, List<GameObject> results)
    {
        if (results.Count > 5) {
            return results;
        }
        List<GameObject> resultsClone = results.ToList();
        if (target.transform.childCount == 0) {
            if (target.gameObject.name == name) {
                resultsClone.Add(target.gameObject);
            }
           return resultsClone;
        }
        
        for (int i = 0; i < target.transform.childCount; i++)
        {
            Transform child = target.transform.GetChild(i);
            Debug.Log(child.name);
            if (child.gameObject.name == name)
            {
                resultsClone.Add(child.gameObject);
            }
            // results.AddRange(findAllChildrenClass(name, child, results));
            List<GameObject> subResults = findAllChildrenClass(name, child, resultsClone);
            for (int j = 0; j < subResults.Count; j++)
            {
                GameObject child2 = subResults.ElementAt(j).gameObject;
                resultsClone.Add(child2);
            }

        }
        return resultsClone;
    }

    // Update is called once per frame
    void Update()
    {
        // bool isOn = PlayerPrefs.GetInt("isSkinVisible") == 1;
        // GetComponent<SkinnedMeshRenderer>().enabled = isOn;
    }
}
