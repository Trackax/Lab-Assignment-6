// Donovan Peckham, Collin Rogers

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesertScene : MonoBehaviour
{
    public int sizeOfForest;

    void Start()
    {
        // create plane
        GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
        plane.transform.localScale = new Vector3(1, 1, 1);

        Forest();
        Pyramid();
    }

    void Forest()
    {
        // parent object
        GameObject forestParent = new GameObject("Forest");

        for (int i = 0; i < sizeOfForest; i++)
        {
            // random height and placement
            int xz = Random.Range(1, 2);
            int y = Random.Range(1, 4);

            GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            cylinder.transform.parent = forestParent.transform;
            cylinder.transform.position = new Vector3(Random.Range(1, 5), y, Random.Range(1, 5));
            cylinder.transform.localScale = new Vector3(xz, y, xz);

            // random color
            var render = cylinder.GetComponent<Renderer>();
            Color greenShade = new Color(0, Random.Range(0.2f, 1), 0);
            render.material.SetColor("_Color", greenShade);
        }
    }
    void Pyramid()
    {
        // create parent and random color
        GameObject pyramidParent = new GameObject("Pyramid");
        Color randomColor = new Color(Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f));

        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 5; j++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.parent = pyramidParent.transform;
                cube.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                cube.transform.position = new Vector3((-1 - (0.6f * j)), 0.3f, (-1 - (0.6f * i)));

                var render = cube.GetComponent<Renderer>();
                render.material.SetColor("_Color", randomColor);
            }
        }

        // change color between layers
        randomColor = new Color(Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f));

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.parent = pyramidParent.transform;
                cube.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                cube.transform.position = new Vector3((-1.3f - (0.6f * j)), 0.9f, (-1.3f - (0.6f * i)));

                var render = cube.GetComponent<Renderer>();
                render.material.SetColor("_Color", randomColor);
            }
        }

        randomColor = new Color(Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f));

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.parent = pyramidParent.transform;
                cube.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                cube.transform.position = new Vector3((-1.6f - (0.6f * j)), 1.5f, (-1.6f - (0.6f * i)));

                var render = cube.GetComponent<Renderer>();
                render.material.SetColor("_Color", randomColor);
            }
        }

        randomColor = new Color(Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f));

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.parent = pyramidParent.transform;
                cube.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                cube.transform.position = new Vector3((-1.9f - (0.6f * j)), 2.1f, (-1.9f - (0.6f * i)));

                var render = cube.GetComponent<Renderer>();
                render.material.SetColor("_Color", randomColor);
            }
        }

        randomColor = new Color(Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f));

        GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1.transform.parent = pyramidParent.transform;
        cube1.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        cube1.transform.position = new Vector3(-2.2f, 2.7f, -2.2f);

        var render1 = cube1.GetComponent<Renderer>();
        render1.material.SetColor("_Color", randomColor);
    }
}
