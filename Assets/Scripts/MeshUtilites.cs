using UnityEngine;
using System.Collections;
using UnityEditor;
public class MeshUtilites : MonoBehaviour {
    Vector3[] verts;
    Vector2[] uvs;
    int[] triangles;
    Mesh mesh;
    // Use this for initialization
    void Start() {
        Mesh smesh = (GetComponent<MeshFilter>().sharedMesh = (Mesh)Instantiate(GetComponent<MeshFilter>().sharedMesh));
        smesh.name = "table";
        int[] tris = new int[smesh.triangles.Length];
        smesh.triangles.CopyTo(tris, 0);
        int[] tris1 = new int[smesh.triangles.Length - 6];
        int[] tris2 = new int[6];
        tris2[0] = tris[0];
        tris2[1] = tris[1];
        tris2[2] = tris[2];
        tris2[3] = tris[3];
        tris2[4] = tris[4];
        tris2[5] = tris[5];
        for (int i = 6; i < tris.Length; i++)
        {
            tris1[i - 6] = tris[i];
        }
        smesh.subMeshCount = 2;
        smesh.SetTriangles(tris1, 0);
        smesh.SetTriangles(tris2, 1);

        AssetDatabase.CreateAsset(smesh, AssetDatabase.GenerateUniqueAssetPath("Assets/Meshes/table.asset"));
	}
}
