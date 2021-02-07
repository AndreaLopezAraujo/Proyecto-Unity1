using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arboles : MonoBehaviour
{
    Color cafeClaro = new Color(0.5f, 0.3f, 0.07f);
    Color cafeOscuro = new Color(0.47f, 0.25f, 0.05f);
    Color verdeClaro = new Color(0.7f, 0.8f, 0.3f);
    Color verdeMedio = new Color(0.4f, 0.8f, 0.3f);
    Color verdeOscuro = new Color(0.3f, 0.6f, 0.14f);
    // Start is called before the first frame update
    void Start()
    {
        Arboles1();
        Arboles2();
    }
    void Arboles1()
    {
        Vector3 vb1=new Vector3(4.45f, 0.96f, 0.89f);
        Vector3 vc1=new Vector3(4.8f, 3.9f, 1.38f);
        Vector3 vc2=new Vector3(3.65f, 4.53f, 1.33F);
        Vector3 vc3=new Vector3(5.73f, 3.21f, 1.37F);
        Vector3 vb2=new Vector3(0.5f ,4f,0.5f);
        Vector3 vc4=new Vector3(3, 3,2);
        Vector3 vc5=new Vector3(0.5F, 1.5f,2);
        Vector3 vc6=new Vector3(1, 1,2);
        Color c1=verdeOscuro;
        Color c2=verdeClaro;
        Color c3=verdeMedio;
        Arbol1(vb1,vc1,vc2,vc3,c1,c2,c3,vb2,vc4,vc5,vc6);

        vb1=new Vector3(-7.53f, 0.96f, 0.89f);
        vc1=new Vector3(-7.27f, 4.12f, 1.38f);
        vc2=new Vector3(-8.45f, 4.6f, 1.33F);
        vc3=new Vector3(-6.33f, 3.52f, 1.37F);
        vb2=new Vector3(0.5f ,4f,0.5f);
        vc4=new Vector3(3, 3,2);
        vc5=new Vector3(0.5F, 1.5f,2);
        vc6=new Vector3(1, 1,2);
        c1=verdeMedio;
        c2=verdeOscuro;
        c3=verdeClaro;
         Arbol1(vb1,vc1,vc2,vc3,c1,c2,c3,vb2,vc4,vc5,vc6);

        vb1=new Vector3(-8.69f, -0.93f, -1.83f);
        vc1=new Vector3(-8.6f, 3.31f, -1.64f);
        vc2=new Vector3(-9.43f, 3.67f, -1.65F);
        vc3=new Vector3(-7.831f, 3.084f, -1.912F);
        vb2=new Vector3(0.3f ,4f,0.3f);
        vc4=new Vector3(2, 2,1);
        vc5=new Vector3(0.3F, 1f,1);
        vc6=new Vector3(0.5f, 0.5f,0.5f);
        c1=verdeClaro;
        c2=verdeMedio;
        c3=verdeOscuro;
         Arbol1(vb1,vc1,vc2,vc3,c1,c2,c3,vb2,vc4,vc5,vc6);

        vb1=new Vector3(5.4f, -0.93f, -1.83f);
        vc1=new Vector3(5.41f, 3.17f, -1.64f);
        vc2=new Vector3(4.58f, 3.65f, -1.65F);
        vc3=new Vector3(6.14f, 2.89f, -1.912F);
        vb2=new Vector3(0.3f ,4f,0.3f);
        vc4=new Vector3(2, 2,1);
        vc5=new Vector3(0.3F, 1f,1);
        vc6=new Vector3(0.5f, 0.5f,0.5f);
        c1=verdeClaro;
        c2=verdeMedio;
        c3=verdeOscuro;
         Arbol1(vb1,vc1,vc2,vc3,c1,c2,c3,vb2,vc4,vc5,vc6);


    }
    void Arbol1(Vector3 vb1,Vector3 vc1,Vector3 vc2,Vector3 vc3,Color c1,Color c2,Color c3,Vector3 vb2,Vector3 vc4,Vector3 vc5,Vector3 vc6)
    {
        GameObject cylinder1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder1.transform.position = vb1;
        cylinder1.transform.Rotate (0.0f, 0.0f, 0.0f, Space.Self );
        var cylinderRenderer1 = cylinder1.GetComponent<Renderer>();
        cylinder1.transform.localScale = vb2;
        cylinderRenderer1.material.SetColor("_Color", cafeOscuro);

        GameObject cube0 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube0.transform.position = vc1;
        cube0.transform.localScale = vc4;
        cube0.transform.Rotate (0.0f, 0.0f, -30f, Space.Self );
        var cubeRenderer0 = cube0.GetComponent<Renderer>();
        cubeRenderer0.material.SetColor("_Color", c1);
        
        GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1.transform.position = vc2;
        cube1.transform.localScale = vc5;
        cube1.transform.Rotate (0.0f, 0.0f, -30f, Space.Self );
        var cubeRenderer1 = cube1.GetComponent<Renderer>();
        cubeRenderer1.material.SetColor("_Color", c2);
        
        GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube2.transform.position = vc3;
        cube2.transform.localScale = vc6;
        cube2.transform.Rotate (0.0f, 0.0f, -30f, Space.Self );
        var cubeRenderer2 = cube2.GetComponent<Renderer>();
        cubeRenderer2.material.SetColor("_Color", c3);
    }
    void Arboles2()
    {
        Vector3 vb1=new Vector3(-1.2f, 0.96f, 0.89f);
        Vector3 vc1=new Vector3(-1.24f, 4.82f, 0.98f);
        Vector3 vc2=new Vector3(-0.64f, 3.32f, 0.84f);
        Vector3 vc3=new Vector3(-2.02f, 3.59f, 0.9f);
        Vector3 vb2=new Vector3(0.5f ,4f,0.5f);
        Vector3 vc4=new Vector3(3f ,1f,4f);
        Vector3 vc5=new Vector3(2f ,1f,3f);
        Vector3 vc6=new Vector3(3f ,1f,4f);
        Color c1=verdeClaro;
        Color c2=verdeMedio;
        Color c3=verdeOscuro;
        Arbol2(vb1,vc1,vc2,vc3,c1,c2,c3,vb2,vc4,vc5,vc6);

        vb1=new Vector3(9.07f, 0.96f, 1.66f);
        vc1=new Vector3(9.36f, 4.82f, 1.1f);
        vc2=new Vector3(10.37f, 3.32f, 0.82f);
        vc3=new Vector3(9.28f, 3.59f, 0.94f);
        vb2=new Vector3(0.5f ,4f,0.5f);
        vc4=new Vector3(3f ,0.5f,4f);
        vc5=new Vector3(2f ,0.5f,3f);
        vc6=new Vector3(3f ,0.5f,4f);
        c1=verdeOscuro;
        c2=verdeClaro;
        c3=verdeMedio;
        Arbol2(vb1,vc1,vc2,vc3,c1,c2,c3,vb2,vc4,vc5,vc6);

        vb1=new Vector3(-11.44f, 0.96f, 1.66f);
        vc1=new Vector3(-11.74f, 4.82f, 0.78f);
        vc2=new Vector3(-11.11f, 3.32f, 0.82f);
        vc3=new Vector3(-12.81f, 3.59f, 0.94f);
        vb2=new Vector3(0.5f ,4f,0.5f);
        vc4=new Vector3(3f ,0.5f,4f);
        vc5=new Vector3(2f ,0.5f,3f);
        vc6=new Vector3(3f ,0.5f,4f);
        c1=verdeOscuro;
        c2=verdeClaro;
        c3=verdeMedio;
        Arbol2(vb1,vc1,vc2,vc3,c1,c2,c3,vb2,vc4,vc5,vc6);

        vb1=new Vector3(-4.43f, -0.75f, -2.04f);
        vc1=new Vector3(-4.44f, 3.38f, -1.74f);
        vc2=new Vector3(-3.91f, 2.55f, -1.82f);
        vc3=new Vector3(-4.75f, 2.66f, -1.79f);
        vb2=new Vector3(0.3f ,4f,0.3f);
        vc4=new Vector3(2f ,0.5f,3f);
        vc5=new Vector3(1f ,0.5f,2f);
        vc6=new Vector3(2f ,0.5f,3f);
        c1=verdeClaro;
        c2=verdeMedio;
        c3=verdeOscuro;
        Arbol2(vb1,vc1,vc2,vc3,c1,c2,c3,vb2,vc4,vc5,vc6);

        vb1=new Vector3(1.75f, -0.75f, -2.04f);
        vc1=new Vector3(1.7f, 3.38f, -1.74f);
        vc2=new Vector3(2.29f, 2.55f, -1.82f);
        vc3=new Vector3(1.15f, 2.66f, -1.79f);
        vb2=new Vector3(0.3f ,4f,0.3f);
        vc4=new Vector3(2f ,0.5f,3f);
        vc5=new Vector3(1f ,0.5f,2f);
        vc6=new Vector3(2f ,0.5f,3f);
        c1=verdeMedio;
        c2=verdeClaro;
        c3=verdeOscuro;
        Arbol2(vb1,vc1,vc2,vc3,c1,c2,c3,vb2,vc4,vc5,vc6);
    }
    void Arbol2(Vector3 vb1,Vector3 vc1,Vector3 vc2,Vector3 vc3,Color c1,Color c2,Color c3,Vector3 vb2,Vector3 vc4,Vector3 vc5,Vector3 vc6)
    {
        GameObject cylinder1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder1.transform.position = vb1;
        cylinder1.transform.Rotate (0.0f, 0.0f, 0.0f, Space.Self );
        var cylinderRenderer1 = cylinder1.GetComponent<Renderer>();
        cylinder1.transform.localScale = vb2;
        cylinderRenderer1.material.SetColor("_Color", cafeOscuro);

        GameObject cylinder0 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder0.transform.position = vc1;
        cylinder0.transform.localScale = vc4;
        cylinder0.transform.Rotate (0.0f, 90f, 90f, Space.Self );
        var cylinderRenderer0 =   cylinder0.GetComponent<Renderer>();
        cylinderRenderer0.material.SetColor("_Color", c1);

        GameObject cylinder3 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder3.transform.position = vc2;
        cylinder3.transform.localScale = vc5;
        cylinder3.transform.Rotate (0.0f, 90f, 90f, Space.Self );
        var  cylinderRenderer3 = cylinder3.GetComponent<Renderer>();
        cylinderRenderer3.material.SetColor("_Color", c2);

        GameObject cylinder2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder2.transform.position = vc3;
       cylinder2.transform.localScale = vc6;
       cylinder2.transform.Rotate (0.0f, 90f, 90f, Space.Self );
        var  cylinderRenderer2 =  cylinder2.GetComponent<Renderer>();
        cylinderRenderer2.material.SetColor("_Color", c3);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
