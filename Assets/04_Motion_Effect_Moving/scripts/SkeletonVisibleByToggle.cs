using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SkeletonVisibleByToggle : MonoBehaviour
{
    private static string skeletonParticleName = "MotionParticle";
    private List<GameObject> skeletonParticles = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        findAllChildrenClass(transform);
        bool isOn = PlayerPrefs.GetInt("isSkeletonVisible") == 1;
        foreach (GameObject particle in skeletonParticles) {
            particle.GetComponent<MeshRenderer>().enabled = isOn;
        }
    }

    void Update()
    {
        bool isOn = PlayerPrefs.GetInt("isSkeletonVisible") == 1;
        foreach (GameObject particle in skeletonParticles) {
            particle.GetComponent<MeshRenderer>().enabled = isOn;
        }
    }

    private void findAllChildrenClass(Transform target) {
        for (int i =0; i < target.childCount; i++) {
            if (target.GetChild(i).name == skeletonParticleName) {
                skeletonParticles.Add(target.GetChild(i).gameObject); //gameobject는 왜 transform으로부터 참조해야 할까.
            }
            findAllChildrenClass(target.GetChild(i));
        }
    }
}
