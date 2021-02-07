using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agua : MonoBehaviour
{
    Color flor1 = new Color(0.85f, 0.45f, 0.36f);
    Color flor2 = new Color(0.95f, 0.87f, 0.81f);
    // Start is called before the first frame update
    void Start()
    {
        //Agua
        GameObject plane1  = GameObject.CreatePrimitive(PrimitiveType.Plane);
        plane1.transform.position = new Vector3(0, 0, -5);
        var planeRenderer1 = plane1.GetComponent<Renderer>();
        Color azulOscuro = new Color(0.32f, 0.68f, 0.84f);
         planeRenderer1.material.SetColor("_Color", azulOscuro);
         plane1.transform.localScale=new Vector3(3, 1,1);
         Reflejos();
         Plantas();
         Flores();
    }
    void Reflejos()
    {
         //reflejos del agua
         Vector3 v1=new Vector3(0, 0.01f, -8);
         Vector3 v2=new Vector3(0.05f, 1,0.009f);
         reflejo(v1,v2);

         v1=new Vector3(3, 0.01f, -7.5f);
         v2=new Vector3(0.05f, 1,0.009f);
         reflejo(v1,v2);

         v1=new Vector3(-1, 0.01f, -7);
         v2=new Vector3(0.05f, 1,0.009f);
         reflejo(v1,v2);
    }
    void reflejo(Vector3 v1, Vector3 v2)
    {
        GameObject plane1  = GameObject.CreatePrimitive(PrimitiveType.Plane);
        plane1.transform.position =v1;
        var planeRenderer1 = plane1.GetComponent<Renderer>();
        Color azulClaro = new Color(0.5f, 0.7f, 0.9f);
        planeRenderer1.material.SetColor("_Color", azulClaro);
        plane1.transform.localScale = v2;
    }
    void Plantas()
    {
        // plantas acuaticas claras
         Vector3 v1=new Vector3(-1.95f, -0.48f, -7.45f);
         Vector3 v2=new Vector3(0.5f ,0.5f,0.5f);
         Color c=new Color(0.7f, 0.8f, 0.3f);
         planta(v1,v2,c);

         v1=new Vector3(3.7f, -0.28f, -6.45f);
         v2=new Vector3(0.3f ,0.3f,0.3f);
         planta(v1,v2,c);

         v1=new Vector3(1.75f, -0.38f, -7.1f);
         v2=new Vector3(0.4f ,0.4f,0.4f);
         planta(v1,v2,c);

         //pantas acuaticas medianas
         v1=new Vector3(2.25f, -0.37f, -7.29f);
         v2=new Vector3(0.5f ,0.4f,0.5f);
         c=new Color(0.4f, 0.8f, 0.3f);
         planta(v1,v2,c);
         
         v1=new Vector3(1.97f, -0.37f, -6.6f);
         v2=new Vector3(0.5f ,0.4f,0.5f);
         planta(v1,v2,c);

        v1=new Vector3(-0.47f, -0.37f, -6.78f);
         v2=new Vector3(0.8f ,0.4f,0.8f);
         planta(v1,v2,c);

        v1=new Vector3(0.34f, -0.37f, -6.6f);
         v2=new Vector3(0.5f ,0.4f,0.5f);
         planta(v1,v2,c);

        v1=new Vector3(-0.05f, -0.37f, -7.59f);
         v2=new Vector3(0.5f ,0.4f,0.5f);
         planta(v1,v2,c);

         //pantas acuaticas oscuras
         v1=new Vector3(-2.63f, -0.37f, -7.01f);
         v2=new Vector3(0.5f ,0.4f,0.5f);
         c=new Color(0.3f, 0.6f, 0.14f);
         planta(v1,v2,c);

         v1=new Vector3(-2.44f, -0.37f, -7.94f);
         v2=new Vector3(0.5f ,0.4f,0.5f);
         planta(v1,v2,c);

         v1=new Vector3(3.17f, -0.37f, -6.69f);
         v2=new Vector3(0.5f ,0.4f,0.5f);
         planta(v1,v2,c);
    }
    void planta(Vector3 v1, Vector3 v2, Color c)
    {
        GameObject cylinder1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder1.transform.position = v1;
        cylinder1.transform.Rotate (0.0f, 0.0f, 0.0f, Space.Self );
        var cylinderRenderer1 = cylinder1.GetComponent<Renderer>();
        cylinder1.transform.localScale = v2;
        Color color = c;
        cylinderRenderer1.material.SetColor("_Color", color);
    }
    void Flores()
    {
        Vector3 vc1=new Vector3(-0.227f, 0.032f, -6.457f);
        Vector3 vc2=new Vector3(-0.179f, 0.032f, -6.457f);
        Color c1=flor1;
        Vector3 vc3=new Vector3(-0.124f, 0.032f, -6.457f);
        Vector3 vc4=new Vector3(0.2f ,0.03f,0.1f);
        Vector3 vc5=new Vector3(0.2f ,0.02f,0.1f);
        Vector3 vc6=new Vector3(0.2f ,0.03f,0.1f);
        Color c2=flor2;
        Flor(vc1,vc2,vc3,vc4,vc5,vc6,c1,c2);

        vc1=new Vector3(3.345f, 0.032f, -6.453f);
        vc2=new Vector3(3.402f, 0.032f, -6.457f);
        c1=flor1;
        vc3=new Vector3(3.442f, 0.032f, -6.457f);
        vc4=new Vector3(0.2f ,0.03f,0.1f);
        vc5=new Vector3(0.2f ,0.02f,0.2f);
        vc6=new Vector3(0.2f ,0.03f,0.1f);
        c2=flor2;
        Flor(vc1,vc2,vc3,vc4,vc5,vc6,c1,c2);

        vc1=new Vector3(-1.817f, 0.032f, -7.241f);
        vc2=new Vector3(-1.765f, 0.032f, -7.234f);
        c1=flor1;
        vc3=new Vector3(-1.71f, 0.032f, -7.234f);
        vc4=new Vector3(0.2f ,0.03f,0.1f);
        vc5=new Vector3(0.2f ,0.02f,0.2f);
        vc6=new Vector3(0.2f ,0.03f,0.1f);
        c2=flor2;
        Flor(vc1,vc2,vc3,vc4,vc5,vc6,c1,c2);

    }
    void Flor(Vector3 vc1,Vector3 vc2, Vector3 vc3,Vector3 vc4,Vector3 vc5,Vector3 vc6, Color c1, Color c2)
    {
        GameObject cylinder1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder1.transform.position = vc1;
        cylinder1.transform.Rotate (0.0f, -99f, 90f, Space.Self );
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
        cylinder3.transform.Rotate (0.0f, -99f, 90f, Space.Self );
        var  cylinderRenderer3 = cylinder3.GetComponent<Renderer>();
        cylinderRenderer3.material.SetColor("_Color", c1);         
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
