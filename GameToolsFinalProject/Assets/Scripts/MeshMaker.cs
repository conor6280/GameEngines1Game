using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshMaker : MonoBehaviour
{
    public float scale;
    public float waveSpeed;
    public float waveHeight;

    void Update()
    {
        CalcNoise();
    }

    void CalcNoise()
    {
        MeshFilter mf = GetComponent<MeshFilter>();

        Vector3[] verts = mf.mesh.vertices;


        for (int i = 0; i < verts.Length; i++)
        {
            float pX = (verts[i].x * scale) + (Time.time * waveSpeed);
            float pZ = (verts[i].z * scale) + (Time.time * waveSpeed);

            verts[i].y = Mathf.PerlinNoise(pX, pZ) * waveHeight;
        }

        mf.mesh.vertices = verts;
        mf.mesh.RecalculateNormals();
        mf.mesh.RecalculateBounds();
    }
}
