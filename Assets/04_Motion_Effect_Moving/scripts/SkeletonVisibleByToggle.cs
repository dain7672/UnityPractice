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
        //gameobject는 왜 transform으로부터 참조해야 할까.
        findAllChildrenClass(transform);
        foreach (GameObject particle in skeletonParticles) {
            Debug.Log(particle.name);
        }
    }

    private void findAllChildrenClass(Transform target) {
        for (int i =0; i < target.childCount; i++) {
            if (target.GetChild(i).name == skeletonParticleName) {
                skeletonParticles.Add(target.GetChild(i).gameObject);
            }
            findAllChildrenClass(target.GetChild(i));
        }
    }

    // Update is called once per frame
    void Update() {
    }
}
