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
        float x1=6.539f;
        float x2=6.909f;
        float x3=7.27f;
        float y=0.471f;
        float z1y3=-2.667f;
        float z2=-2.688f;
        float xt1y3=1f;
        float xt2=0.8f;
        float yt=0.2f;
        float zt1y3=0.5f;
        float zt2=0.8f;
        float x1yx2=diferencia(x2,x1);
        float x1yx3=diferencia(x3,x1);
        float z1yz2=diferencia(z2,z1y3);
        Color c1=verdeMedio;
        Color c2=verdeOscuro;
        Vector3 vc1=new Vector3(x1, y, z1y3);
        Vector3 vc2=new Vector3(x2, y, z2);
        Vector3 vc3=new Vector3(x3, y, z1y3);
        Vector3 vc4=new Vector3(xt1y3 ,yt,zt1y3);
        Vector3 vc5=new Vector3(xt2 ,yt,zt2);
        Vector3 vc6=new Vector3(xt1y3 ,yt,zt1y3);
        Arbusto(vc1,vc2,vc3,vc4,vc5,vc6,c1,c2);
        
        x1=1.348f;
        x2=x1+x1yx2;
        x3=x1+x1yx3;
        y=0.471f;
        z1y3=-2.307f;
        z2=z1y3+z1yz2;
        c1=verdeMedio;
        c2=verdeOscuro;
        vc1=new Vector3(x1, y, z1y3);
        vc2=new Vector3(x2, y, z2);
        vc3=new Vector3(x3, y, z1y3);
        vc4=new Vector3(xt1y3 ,yt,zt1y3);
        vc5=new Vector3(xt2 ,yt,zt2);
        vc6=new Vector3(xt1y3 ,yt,zt1y3);
        Arbusto(vc1,vc2,vc3,vc4,vc5,vc6,c1,c2);

        x1=-8.731f;
        x2=x1+x1yx2;
        x3=x1+x1yx3;
        y=0.471f;
        z1y3=-2.307f;
        z2=z1y3+z1yz2;
        c1=verdeMedio;
        c2=verdeOscuro;
        vc1=new Vector3(x1, y, z1y3);
        vc2=new Vector3(x2, y, z2);
        vc3=new Vector3(x3, y, z1y3);
        vc4=new Vector3(xt1y3 ,yt,zt1y3);
        vc5=new Vector3(xt2 ,yt,zt2);
        vc6=new Vector3(xt1y3 ,yt,zt1y3);
        Arbusto(vc1,vc2,vc3,vc4,vc5,vc6,c1,c2);

        x1=-3.56f;
        x2=x1+x1yx2;
        x3=x1+x1yx3;
        y=0.471f;
        z1y3=-4.105f;
        z2=z1y3+z1yz2;
        c1=verdeMedio;
        c2=verdeOscuro;
        vc1=new Vector3(x1, y, z1y3);
        vc2=new Vector3(x2, y, z2);
        vc3=new Vector3(x3, y, z1y3);
        vc4=new Vector3(xt1y3 ,yt,zt1y3);
        vc5=new Vector3(xt2 ,yt,zt2);
        vc6=new Vector3(xt1y3 ,yt,zt1y3);
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
        float x1=-3.443f;
        float x2=-3.436f;
        float y1=0.471f;
        float y2=0.631f;
        float z1=-4.429f;
        float z2=-4.422f;
        float xt1=0.1f;
        float xt2=0.15f;
        float yt1=0.1f;
        float yt2=0.05f;
        float zt1=0.1f;
        float zt2=0.25f;
        float x1yx2=diferencia(x1,x2);
        float y1y2=diferencia(y2,y1);
        float z1yz2=diferencia(z1,z2);
        Color c1=base1;
        Color c2=detalle2;
        Vector3 vc1=new Vector3(x1, y1, z1);
        Vector3 vc3=new Vector3(xt1 ,yt1,zt1);
        Vector3 vc2=new Vector3(x2, y2, z2);
        Vector3 vc4=new Vector3(xt2 ,yt2,zt2);
        Ongo(vc1,vc2,vc3,vc4,c1,c2);

        x1=-3.16f;
        x2=x1+x1yx2;
        y1=0.504f;
        y2=y1+y1y2;
        z1=-4.429f;
        z2=z1+z1yz2;
        vc1=new Vector3(x1, y1, z1);
        vc2=new Vector3(x2, y2, z2);
        Ongo(vc1,vc2,vc3,vc4,c1,c2);

        x1=-5.346f;
        x2=x1+x1yx2;
        y1=0.471f;
        y2=y1+y1y2;
        z1=-3.278f;
        z2=z1+z1yz2;
        vc1=new Vector3(x1, y1, z1);
        vc2=new Vector3(x2, y2, z2);
        Ongo(vc1,vc2,vc3,vc4,c1,c2);

        x1=0.97f;
        x2=x1+x1yx2;
        y1=0.471f;
        y2=y1+y1y2;
        z1=-3.278f;
        z2=z1+z1yz2;
        vc1=new Vector3(x1, y1, z1);
        vc2=new Vector3(x2, y2, z2);
        Ongo(vc1,vc2,vc3,vc4,c1,c2);
        
        x1=7.05f;
        x2=x1+x1yx2;
        y1=0.471f;
        y2=y1+y1y2;
        z1=-3.36f;
        z2=z1+z1yz2;
        vc1=new Vector3(x1, y1, z1);
        vc2=new Vector3(x2, y2, z2);
        Ongo(vc1,vc2,vc3,vc4,c1,c2);

        x1=6.888f;
        x2=x1+x1yx2;
        y1=0.471f;
        y2=y1+y1y2;
        z1=-3.177f;
        z2=z1+z1yz2;
        vc1=new Vector3(x1, y1, z1);
        vc2=new Vector3(x2, y2, z2);
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
    float diferencia( float v1, float v2)
    {
        return v1-v2;
    }
}
