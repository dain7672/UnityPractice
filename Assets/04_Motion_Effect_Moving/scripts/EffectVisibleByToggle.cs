using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EffectVisibleByToggle : MonoBehaviour
{
    private static string effectParticleName = "EffectParticle";
    private List<GameObject> effectParticles = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        findAllChildrenClass(transform);
        bool isOn = PlayerPrefs.GetInt("isEffectVisible") == 1;
        foreach (GameObject particle in effectParticles) {
            particle.GetComponent<MeshRenderer>().enabled = isOn;
        }
    }

    void Update()
    {
        bool isOn = PlayerPrefs.GetInt("isEffectVisible") == 1;
        foreach (GameObject particle in effectParticles) {
            particle.GetComponent<MeshRenderer>().enabled = isOn;
        }
    }

    private void findAllChildrenClass(Transform target) {
        for (int i =0; i < target.childCount; i++) {
            if (target.GetChild(i).name == effectParticleName) {
                effectParticles.Add(target.GetChild(i).gameObject); //gameobject는 왜 transform으로부터 참조해야 할까.
            }
            findAllChildrenClass(target.GetChild(i));
        }
    }
}
