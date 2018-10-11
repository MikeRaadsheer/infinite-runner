    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

    public GameObject background;

    public List<GameObject> levelChunks; 

    private bool isInstanciated = false;

    private void Start()
    {
        gameObject.name = "Background";
    }


    // Update is called once per frame
    void Update ()
    {
        background.transform.position -= new Vector3(5f * Time.deltaTime, 0f, 0f);

        if (background.transform.position.x <= -10 && !isInstanciated)
        {
            int chunk = Random.RandomRange(0, levelChunks.Count);


            Instantiate(levelChunks[chunk], new Vector3(background.transform.position.x + 90f, 0f, 0f), Quaternion.identity);
            isInstanciated = true;
        }

        //76f

        if (background.transform.position.x <= -90)
        {
            Destroy(background);
        }
    }
}
