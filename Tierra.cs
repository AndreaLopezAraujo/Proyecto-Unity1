using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tierra : MonoBehaviour
{
    Color base1 = new Color(0.95f, 0.87f, 0.81f);
    Color detalle1 = new Color(0.95f, 0.75f, 0.57f);
    Color detalle2 = new Color(0.85f, 0.59f, 0.36f);
    Color verdeMedio = new Color(0.4f, 0.8f, 0.3f);
    Color verdeOscuro = new Color(0.3f, 0.6f, 0.14f);
    // Start is called before the first frame update
    void Start()
    {
        //tierra de abajo
        GameObject cube0 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube0.transform.position = new Vector3(0, -0.39f, -0.97f);
        cube0.transform.localScale = new Vector3(25, 1,10);
        var cubeRenderer0 = cube0.GetComponent<Renderer>();
        Color cafeClaro = new Color(0.5f, 0.3f, 0.07f);
        cubeRenderer0.material.SetColor("_Color", cafeClaro);

        //tierra de medio
        GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1.transform.position = new Vector3(0, -0.21f, -0.88f);
        cube1.transform.localScale = new Vector3(25, 1,10);
        var cubeRenderer1 = cube1.GetComponent<Renderer>();
        Color cafeOscuro = new Color(0.47f, 0.25f, 0.05f);
        cubeRenderer1.material.SetColor("_Color", cafeOscuro);

        //Pasto
         GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube2.transform.position = new Vector3(0, -0.12f, -0.71f);
        cube2.transform.localScale = new Vector3(25, 1,10);
        var cubeRenderer2 = cube2.GetComponent<Renderer>();
        Color verdeClaro = new Color(0.7f, 0.8f, 0.3f);
        cubeRenderer2.material.SetColor("_Color", verdeClaro);

        Ongos();
        Arbustos();
        
    }
    void Arbustos()
    {
        Vector3 vc1=new Vector3(6.539f, 0.471f, -2.667f);
        Vector3 vc2=new Vector3(6.909f, 0.471f, -2.688f);
        Color c1=verdeMedio;
        Vector3 vc3=new Vector3(7.27f, 0.471f, -2.667f);
        Vector3 vc4=new Vector3(1f ,0.2f,0.5f);
        Vector3 vc5=new Vector3(0.8f ,0.2f,0.8f);
        Vector3 vc6=new Vector3(1f ,0.2f,0.5f);
        Color c2=verdeOscuro;
        Arbusto(vc1,vc2,vc3,vc4,vc5,vc6,c1,c2);

        vc1=new Vector3(1.348f, 0.471f, -2.307f);
        vc2=new Vector3(1.75f, 0.471f, -2.341f);
        c1=verdeMedio;
        vc3=new Vector3(2.153f, 0.471f, -2.318f);
        vc4=new Vector3(1f ,0.2f,0.5f);
        vc5=new Vector3(0.8f ,0.2f,0.8f);
        vc6=new Vector3(1f ,0.2f,0.5f);
        c2=verdeOscuro;
        Arbusto(vc1,vc2,vc3,vc4,vc5,vc6,c1,c2);

        vc1=new Vector3(-8.731f, 0.471f, -2.307f);
        vc2=new Vector3(-8.356f, 0.471f, -2.341f);
        c1=verdeMedio;
        vc3=new Vector3(-7.944f, 0.471f, -2.318f);
        vc4=new Vector3(1f ,0.2f,0.5f);
        vc5=new Vector3(0.8f ,0.2f,0.8f);
        vc6=new Vector3(1f ,0.2f,0.5f);
        c2=verdeOscuro;
        Arbusto(vc1,vc2,vc3,vc4,vc5,vc6,c1,c2);

        vc1=new Vector3(-3.74f, 0.471f, -4.105f);
        vc2=new Vector3(-3.36f, 0.471f, -4.078f);
        c1=verdeMedio;
        vc3=new Vector3(-2.93f, 0.471f, -4.145f);
        vc4=new Vector3(1f ,0.2f,0.5f);
        vc5=new Vector3(0.8f ,0.2f,0.8f);
        vc6=new Vector3(1f ,0.2f,0.5f);
        c2=verdeOscuro;
        Arbusto(vc1,vc2,vc3,vc4,vc5,vc6,c1,c2);
    }
    void Arbusto(Vector3 vc1,Vector3 vc2, Vector3 vc3,Vector3 vc4,Vector3 vc5,Vector3 vc6, Color c1, Color c2)
    {
        GameObject cylinder1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder1.transform.position = vc1;
        cylinder1.transform.Rotate (0.0f, 90.0f, 90.0f, Space.Self );
        var cylinderRenderer1 = cylinder1.GetComponent<Renderer>();
        cylinder1.transform.localScale = vc4;
        cylinderRenderer1.material.SetColor("_Color", c1);

        GameObject cylinder0 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder0.transform.position = vc2;
        cylinder0.transform.localScale = vc5;
        cylinder0.transform.Rotate (0.0f, 90f, 90f, Space.Self );
        var cylinderRenderer0 =   cylinder0.GetComponent<Renderer>();
        cylinderRenderer0.material.SetColor("_Color", c2);

        GameObject cylinder3 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder3.transform.position = vc3;
        cylinder3.transform.localScale = vc6;
        cylinder3.transform.Rotate (0.0f, 90f, 90f, Space.Self );
        var  cylinderRenderer3 = cylinder3.GetComponent<Renderer>();
        cylinderRenderer3.material.SetColor("_Color", c1);         
    }
    void Ongos()
    {
        Vector3 vc1=new Vector3(-3.443f, 0.471f, -4.429f);
        Vector3 vc3=new Vector3(0.1f ,0.1f,0.1f);
        Color c1=base1;
        Vector3 vc2=new Vector3(-3.436f, 0.631f, -4.422f);
        Vector3 vc4=new Vector3(0.15f ,0.05f,0.25f);
        Color c2=detalle2;
        Ongo(vc1,vc2,vc3,vc4,c1,c2);

        vc1=new Vector3(-3.16f, 0.504f, -4.429f);
        vc3=new Vector3(0.1f ,0.1f,0.1f);
        c1=base1;
        vc2=new Vector3(-3.162f, 0.669f, -4.422f);
        vc4=new Vector3(0.15f ,0.05f,0.25f);
        c2=detalle2;
        Ongo(vc1,vc2,vc3,vc4,c1,c2);

        vc1=new Vector3(-5.346f, 0.471f, -3.278f);
        vc3=new Vector3(0.1f ,0.1f,0.1f);
        c1=base1;
        vc2=new Vector3(-5.341f, 0.631f, -3.279f);
        vc4=new Vector3(0.15f ,0.05f,0.25f);
        c2=detalle2;
        Ongo(vc1,vc2,vc3,vc4,c1,c2);

        vc1=new Vector3(0.255f, 0.471f, -3.278f);
        vc3=new Vector3(0.1f ,0.1f,0.1f);
        c1=base1;
        vc2=new Vector3(0.26f, 0.631f, -3.3f);
        vc4=new Vector3(0.15f ,0.05f,0.25f);
        c2=detalle2;
        Ongo(vc1,vc2,vc3,vc4,c1,c2);

        vc1=new Vector3(7.05f, 0.471f, -3.36f);
        vc3=new Vector3(0.1f ,0.1f,0.1f);
        c1=base1;
        vc2=new Vector3(7.037f, 0.631f, -3.356f);
        vc4=new Vector3(0.15f ,0.05f,0.25f);
        c2=detalle2;
        Ongo(vc1,vc2,vc3,vc4,c1,c2);

        vc1=new Vector3(6.888f, 0.471f, -3.177f);
        vc3=new Vector3(0.1f ,0.1f,0.1f);
        c1=base1;
        vc2=new Vector3(6.901f, 0.631f, -3.184f);
        vc4=new Vector3(0.15f ,0.05f,0.25f);
        c2=detalle2;
        Ongo(vc1,vc2,vc3,vc4,c1,c2);
    }
    void Ongo(Vector3 vc1,Vector3 vc2, Vector3 vc3,Vector3 vc4, Color c1, Color c2)
    {
        GameObject cylinder1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder1.transform.position = vc1;
        cylinder1.transform.Rotate (0.0f, 0.0f, 0.0f, Space.Self );
        var cylinderRenderer1 = cylinder1.GetComponent<Renderer>();
        cylinder1.transform.localScale = vc3;
        cylinderRenderer1.material.SetColor("_Color", c1);

        GameObject cylinder0 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder0.transform.position = vc2;
        cylinder0.transform.localScale = vc4;
        cylinder0.transform.Rotate (0.0f, 90f, 90f, Space.Self );
        var cylinderRenderer0 =   cylinder0.GetComponent<Renderer>();
        cylinderRenderer0.material.SetColor("_Color", c2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
