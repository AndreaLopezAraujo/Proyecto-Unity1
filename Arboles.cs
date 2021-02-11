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
        float x1=4.45f;
        float x2=4.8f;
        float x3=3.65f;
        float x4=5.73f;
        float y1=0.96f;
        float y2=3.9f;
        float y3=4.53f;
        float y4=3.21f;
        float z1=0.89f;
        float z2=1.38f;
        float z3=1.33F;
        float z4=1.37F;
        float xt1=0.5f;
        float xt2=3;
        float xt3=0.5F;
        float xt4=1;
        float yt1=4f;
        float yt2=3;
        float yt3=1.5f;
        float yt4=1;
        float zt1=0.5f;
        float zt234=2;
        float dx1x2=diferencia(x2,x1);
        float dx1x3=diferencia(x3,x1);
        float dx1x4=diferencia(x4,x1);
        float dy1y2=diferencia(y2,y1);
        float dy1y3=diferencia(y3,y1);
        float dy1y4=diferencia(y4,y1);
        float dz1z2=diferencia(z2,z1);
        float dz1z3=diferencia(z3,z1);
        float dz1z4=diferencia(z4,z1);
        float dtx1x2=diferenciaEscala(xt1,xt2);
        float dtx1x3=diferenciaEscala(xt1,xt3);
        float dtx1x4=diferenciaEscala(xt1,xt4);
        float dty1y2=diferenciaEscala(yt1,yt2);
        float dty1y3=diferenciaEscala(yt2,yt3);
        float dty1y4=diferenciaEscala(yt2,yt4);
        float dtz1z234=diferenciaEscala(zt1,zt234);

        Vector3 vb1=new Vector3(x1, y1, z1);
        Vector3 vc1=new Vector3(x2, y2, z2);
        Vector3 vc2=new Vector3(x3, y3, z3);
        Vector3 vc3=new Vector3(x4, y4, z4);
        Vector3 vb2=new Vector3(xt1 ,yt1,zt1);
        Vector3 vc4=new Vector3(xt2, yt2,zt234);
        Vector3 vc5=new Vector3(xt3, yt3,zt234);
        Vector3 vc6=new Vector3(xt4, yt4,zt234);
        Color c1=verdeOscuro;
        Color c2=verdeClaro;
        Color c3=verdeMedio;
        Arbol1(vb1,vc1,vc2,vc3,c1,c2,c3,vb2,vc4,vc5,vc6);

        x1=-6.55f;
        x2=x1+dx1x2;
        x3=x1+dx1x3;
        x4=x1+dx1x4;
        y1=0.96f;
        y2=y1+dy1y2;
        y3=y1+dy1y3;
        y4=y1+dy1y4;
        z1=0.89f;
        z2=z1+dz1z2;
        z3=z1+dz1z3;
        z4=z1+dz1z4;
        xt1=0.5f;
        xt2=xt1*dtx1x2;
        xt3=xt1*dtx1x3;
        xt4=xt1*dtx1x4;
        yt1=4f;
        yt2=yt1*dty1y2;
        yt3=yt2*1/2;
        yt4=yt2*1/4;
        zt1=0.5f;
        zt234=zt1*dtz1z234;  
        vb1=new Vector3(x1, y1, z1);
        vc1=new Vector3(x2, y2, z2);
        vc2=new Vector3(x3, y3, z3);
        vc3=new Vector3(x4, y4, z4);
        vb2=new Vector3(xt1 ,yt1,zt1);
        vc4=new Vector3(xt2, yt2,zt234);
        vc5=new Vector3(xt3, yt3,zt234);
        vc6=new Vector3(xt4, yt4,zt234);
        c1=verdeMedio;
        c2=verdeOscuro;
        c3=verdeClaro;
        Arbol1(vb1,vc1,vc2,vc3,c1,c2,c3,vb2,vc4,vc5,vc6);

        x1=-6.55f;
        x2=x1+dx1x2;
        x3=x1+dx1x3;
        x4=x1+dx1x4;
        y1=0.96f;
        y2=y1+dy1y2;
        y3=y1+dy1y3;
        y4=y1+dy1y4;
        z1=0.89f;
        z2=z1+dz1z2;
        z3=z1+dz1z3;
        z4=z1+dz1z4;
        xt1=0.5f;
        xt2=xt1*dtx1x2;
        xt3=xt1*dtx1x3;
        xt4=xt1*dtx1x4;
        yt1=4f;
        yt2=yt1*dty1y2;
        yt3=yt2*1/2;
        yt4=yt2*1/4;
        zt1=0.5f;
        zt234=zt1*dtz1z234;  
        vb1=new Vector3(x1, y1, z1);
        vc1=new Vector3(x2, y2, z2);
        vc2=new Vector3(x3, y3, z3);
        vc3=new Vector3(x4, y4, z4);
        vb2=new Vector3(xt1 ,yt1,zt1);
        vc4=new Vector3(xt2, yt2,zt234);
        vc5=new Vector3(xt3, yt3,zt234);
        vc6=new Vector3(xt4, yt4,zt234);
        c1=verdeMedio;
        c2=verdeOscuro;
        c3=verdeClaro;
        Arbol1(vb1,vc1,vc2,vc3,c1,c2,c3,vb2,vc4,vc5,vc6);

        x1=-8.51f;
        x2=x1+dx1x2;
        x3=-8.89f;
        x4=-7.51f;
        y1=0.96f;
        y2=y1+dy1y2;
        y3=4.19f;
        y4=3.37f;
        z1=-1.86f;
        z2=z1+dz1z2;
        z3=z1+dz1z3;
        z4=z1+dz1z4;
        xt1=0.5f;
        xt2=2;
        xt3=xt2*1/4;
        xt4=xt2*1/4;
        yt1=4f;
        yt2=2;
        yt3=yt2*1/2;
        yt4=yt2*1/4;
        zt1=0.5f;
        zt234=zt1*dtz1z234;
        vb1=new Vector3(x1, y1, z1);
        vc1=new Vector3(x2, y2, z2);
        vc2=new Vector3(x3, y3, z3);
        vc3=new Vector3(x4, y4, z4);
        vb2=new Vector3(xt1 ,yt1,zt1);
        vc4=new Vector3(xt2, yt2,zt234);
        vc5=new Vector3(xt3, yt3,zt234);
        vc6=new Vector3(xt4, yt4,zt234);
        c1=verdeOscuro;
        c2=verdeMedio;
        c3=verdeClaro;
        Arbol1(vb1,vc1,vc2,vc3,c1,c2,c3,vb2,vc4,vc5,vc6);

        x1=1.7f;
        x2=x1+dx1x2;
        x3=1.27f;
        x4=2.63f;
        y1=0.96f;
        y2=y1+dy1y2;
        y3=4.15f;
        y4=3.36f;
        z1=-1.86f;
        z2=z1+dz1z2;
        z3=z1+dz1z3;
        z4=z1+dz1z4;
        xt1=0.5f;
        xt2=2;
        xt3=xt2*1/4;
        xt4=xt2*1/4;
        yt1=4f;
        yt2=2;
        yt3=yt2*1/2;
        yt4=yt2*1/4;
        zt1=0.5f;
        zt234=zt1*dtz1z234;
        vb1=new Vector3(x1, y1, z1);
        vc1=new Vector3(x2, y2, z2);
        vc2=new Vector3(x3, y3, z3);
        vc3=new Vector3(x4, y4, z4);
        vb2=new Vector3(xt1 ,yt1,zt1);
        vc4=new Vector3(xt2, yt2,zt234);
        vc5=new Vector3(xt3, yt3,zt234);
        vc6=new Vector3(xt4, yt4,zt234);
        c1=verdeMedio;
        c2=verdeOscuro;
        c3=verdeClaro;
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
        float x1=-0.3f;
        float x2=-0.41f;
        float x3=0.37f;
        float x4=-1.25f;
        float y1=0.96f;
        float y2=4.82f;
        float y3=3.32f;
        float y4=3.59f;
        float z1=0.89f;
        float z2=0.98f;
        float z3=0.84f;
        float z4=0.9f;
        float xt1=0.5f;
        float xt2=3f;
        float xt3=2f;
        float xt4=3f;
        float yt1=4f;
        float yt234=1;
        float zt1=0.5f;
        float zt24=4;
        float zt3=4;
        float dx1x2=diferencia(x2,x1);
        float dx1x3=diferencia(x3,x1);
        float dx1x4=diferencia(x4,x1);
        float dy1y2=diferencia(y2,y1);
        float dy1y3=diferencia(y3,y1);
        float dy1y4=diferencia(y4,y1);
        float dz1z2=diferencia(z2,z1);
        float dz1z3=diferencia(z3,z1);
        float dz1z4=diferencia(z4,z1);
        float dtx1x2=diferenciaEscala(xt1,xt2);
        float dtx1x3=diferenciaEscala(xt1,xt3);
        float dtx1x4=diferenciaEscala(xt1,xt4);
        float dty1y2=diferenciaEscala(yt1,yt234);
        float dtz1z3=diferenciaEscala(zt1,zt3);
        float dtz1z24=diferenciaEscala(zt1,zt24);
        Vector3 vb1=new Vector3(x1, y1, z1);
        Vector3 vc1=new Vector3(x2, y2, z2);
        Vector3 vc2=new Vector3(x3, y3, z3);
        Vector3 vc3=new Vector3(x4, y4, z4);
        Vector3 vb2=new Vector3(xt1 ,yt1,zt1);
        Vector3 vc4=new Vector3(xt2, yt234,zt24);
        Vector3 vc5=new Vector3(xt3, yt234,zt3);
        Vector3 vc6=new Vector3(xt4, yt234,zt24);
        Color c1=verdeClaro;
        Color c2=verdeMedio;
        Color c3=verdeOscuro;
        Arbol2(vb1,vc1,vc2,vc3,c1,c2,c3,vb2,vc4,vc5,vc6);

        x1=9.95f;
        x2=x1+dx1x2;
        x3=x1+dx1x3;
        x4=x1+dx1x4;
        y1=0.96f;
        y2=y1+dy1y2;
        y3=y1+dy1y3;
        y4=y1+dy1y4;
        z1=1.66f;
        z2=z1+dz1z2;
        z3=z1+dz1z3;
        z4=z1+dz1z4;
        xt1=0.5f;
        xt2=xt1*dtx1x2;
        xt3=xt1*dtx1x3;
        xt4=xt1*dtx1x4;
        yt1=4f;
        yt234=yt1*dty1y2;
        zt1=0.5f;
        zt3=zt1*dtz1z3;
        zt24=zt1*dtz1z24;
        vb1=new Vector3(x1, y1, z1);
        vc1=new Vector3(x2, y2, z2);
        vc2=new Vector3(x3, y3, z3);
        vc3=new Vector3(x4, y4, z4);
        vb2=new Vector3(xt1 ,yt1,zt1);
        vc4=new Vector3(xt2, yt234,zt24);
        vc5=new Vector3(xt3, yt234,zt3);
        vc6=new Vector3(xt4, yt234,zt24);
        c1=verdeOscuro;
        c2=verdeClaro;
        c3=verdeMedio;
        Arbol2(vb1,vc1,vc2,vc3,c1,c2,c3,vb2,vc4,vc5,vc6);

        x1=-11.44f;
        x2=x1+dx1x2;
        x3=x1+dx1x3;
        x4=x1+dx1x4;
        y1=0.96f;
        y2=y1+dy1y2;
        y3=y1+dy1y3;
        y4=y1+dy1y4;
        z1=1.66f;
        z2=z1+dz1z2;
        z3=z1+dz1z3;
        z4=z1+dz1z4;
        xt1=0.5f;
        xt2=xt1*dtx1x2;
        xt3=xt1*dtx1x3;
        xt4=xt1*dtx1x4;
        yt1=4f;
        yt234=yt1*dty1y2;
        zt1=0.5f;
        zt3=zt1*dtz1z3;
        zt24=zt1*dtz1z24;
        vb1=new Vector3(x1, y1, z1);
        vc1=new Vector3(x2, y2, z2);
        vc2=new Vector3(x3, y3, z3);
        vc3=new Vector3(x4, y4, z4);
        vb2=new Vector3(xt1 ,yt1,zt1);
        vc4=new Vector3(xt2, yt234,zt24);
        vc5=new Vector3(xt3, yt234,zt3);
        vc6=new Vector3(xt4, yt234,zt24);
        c1=verdeOscuro;
        c2=verdeClaro;
        c3=verdeMedio;
        Arbol2(vb1,vc1,vc2,vc3,c1,c2,c3,vb2,vc4,vc5,vc6);

        x1=11.06f;
        x2=x1+dx1x2;
        x3=x1+dx1x3;
        x4=x1+dx1x4;
        y1=0.96f;
        y2=y1+dy1y2;
        y3=y1+dy1y3;
        y4=y1+dy1y4;
        z1=-1.63f;
        z2=z1+dz1z2;
        z3=z1+dz1z3;
        z4=z1+dz1z4;
        xt1=0.5f;
        xt2=xt1*dtx1x2;
        xt3=xt1*dtx1x3;
        xt4=xt1*dtx1x4;
        yt1=4f;
        yt234=yt1*dty1y2;
        zt1=0.5f;
        zt3=zt1*dtz1z3;
        zt24=zt1*dtz1z24;
        vb1=new Vector3(x1, y1, z1);
        vc1=new Vector3(x2, y2, z2);
        vc2=new Vector3(x3, y3, z3);
        vc3=new Vector3(x4, y4, z4);
        vb2=new Vector3(xt1 ,yt1,zt1);
        vc4=new Vector3(xt2, yt234,zt24);
        vc5=new Vector3(xt3, yt234,zt3);
        vc6=new Vector3(xt4, yt234,zt24);
        c1=verdeClaro;
        c2=verdeMedio;
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
    float diferencia( float v1, float v2)
    {
        return v1-v2;
    }

    float diferenciaEscala( float v1, float v2)
    {
        return v2/v1;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
