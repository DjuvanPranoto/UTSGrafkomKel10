using OpenTK.Windowing.Desktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnOpenTK.Common;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.GraphicsLibraryFramework;
using OpenTK.Mathematics;
namespace Pertemuan1
{
    internal class HeliBiasa
    {
        List<Asset3d> helikopter = new List<Asset3d>();
        double _angle;
        double _time;
        public HeliBiasa()
        {

        }

        public void Load(int x, int y)
        {

            var badan1 = new Asset3d(new Vector3(0.588f, 0.474f, 0.223f));
            var badan2 = new Asset3d(new Vector3(0.588f, 0.474f, 0.223f));
            var ekorDatar = new Asset3d(new Vector3(0.92f, 0.564f, 0.0f));
            var penyambungEkor = new Asset3d(new Vector3(0.92f, 0.564f, 0.0f));
            var ekorTrapesium = new Asset3d(new Vector3(0.92f, 0.564f, 0.0f));

            var baling1 = new Asset3d(new Vector3(0.321f, 0.266f, 0.152f));
            var baling2 = new Asset3d(new Vector3(0.321f, 0.266f, 0.152f));
            var baling3 = new Asset3d(new Vector3(0.321f, 0.266f, 0.152f));
            var baling4 = new Asset3d(new Vector3(0.321f, 0.266f, 0.152f));
            var kotangBaling = new Asset3d(new Vector3(0.92f, 0.564f, 0.0f));
            var kaki1 = new Asset3d(new Vector3(0.019f, 0.019f, 0.019f));
            var kaki2 = new Asset3d(new Vector3(0.019f, 0.019f, 0.019f));
            var kaki3 = new Asset3d(new Vector3(0.019f, 0.019f, 0.019f));
            var kaki4 = new Asset3d(new Vector3(0.019f, 0.019f, 0.019f));
            var kaki5 = new Asset3d(new Vector3(0.019f, 0.019f, 0.019f));
            var kaki6 = new Asset3d(new Vector3(0.019f, 0.019f, 0.019f));
         
            var jendela1 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var jendela2 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var jendela3 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var jendela4 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var jendela5 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var jendela6 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var jendela7 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var jendela8 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var jendela9 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var jendela10 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var jendela11 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var jendela12 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var jendelaPilot1 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var jendelaPilot2 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var pintu1 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var pintu2 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));


            var penahan1 = new Asset3d(new Vector3(0.509f, 0.4f, 0.0039f));
            var penahan2 = new Asset3d(new Vector3(0.509f, 0.4f, 0.0039f));

            var senjata1 = new Asset3d(new Vector3(0.517f, 0.639f, 0.250f));
            var senjata2 = new Asset3d(new Vector3(0.517f, 0.639f, 0.250f));
            var moncong1 = new Asset3d(new Vector3(0.509f, 0.4f, 0.0039f));
            var moncong2 = new Asset3d(new Vector3(0.509f, 0.4f, 0.0039f));

            var kaki7 = new Asset3d(new Vector3(0.321f, 0.266f, 0.152f));



            badan1.createBodyVertices(0.0f, 1.5f+0.2f, 0, 0.5f);
            badan2.createBodyBackVerticesBaru(0.5f, 1.5f + 0.2f, 0, 0.5f);

            ekorDatar.createTailVerticesBaru(1.4f, 1.5f + 0.2f, 0, 0.5f);
            ekorTrapesium.createCubeTailVertices(1.0f, 1.5f + 0.2f, 0, 0.5f);
            penyambungEkor.createBodyTailVerticesBaru(1.3f, 1.5f + 0.2f, 0, 0.5f);



            kotangBaling.createSphere(0.0f, 0.6f + 1.5f, 0.0f, 0.1f, 500, 500);
            baling1.createRectangle1Vertices(0.1f, 1.5f + 0.75f, 0, 0.35f);
            baling2.createRectangle2Vertices(-0.1f, 1.5f + 0.75f, 0, 0.35f);
            baling3.createRectangle3Vertices(0.0f, 1.5f + 0.75f, 0.1f, 0.35f);
            baling4.createRectangle4Vertices(0.0f, 1.5f + 0.75f, -0.1f, 0.35f);
            kaki7.createFootVertices(0.0f, 1.4f + 0.6f, -0.015f, 0.1f);

            kaki1.createFootVertices(-0.3f, 1.5f + -0.1f, 0.15f, 0.1f);
            kaki2.createFootVertices(-0.3f, 1.5f + -0.1f, -0.15f, 0.1f);
            kaki3.createFootVertices(0.45f, 1.5f + -0.1f, 0.15f, 0.1f);
            kaki4.createFootVertices(0.45f, 1.5f + -0.1f, -0.15f, 0.1f);
            kaki5.createFoot2Vertices(0.0f, 1.5f + -0.2f, 0.15f, 0.1f);
            kaki6.createFoot2Vertices(0.0f, 1.5f + -0.2f, -0.15f, 0.1f);

          

            jendela1.createEllipsoid(0.02f, 0.06f, 0.01f, 0.0f, 1.5f + 0.16f, 0.0f);
            jendela2.createEllipsoid(0.02f, 0.06f, 0.01f, 0.0f, 1.5f + 0.16f, 0.0f);
            jendela3.createEllipsoid(0.02f, 0.06f, 0.01f, 0.0f, 1.5f + 0.16f, 0.0f);
            jendela4.createEllipsoid(0.02f, 0.06f, 0.01f, 0.0f, 1.5f + 0.16f, 0.0f);
            jendela5.createEllipsoid(0.02f, 0.06f, 0.01f, 0.0f, 1.5f + 0.16f, 0.0f);
            jendela6.createEllipsoid(0.02f, 0.06f, 0.01f, 0.0f, 1.5f + 0.16f, 0.0f);
            jendela7.createEllipsoid(0.02f, 0.06f, 0.01f, 0.0f, 1.5f + 0.16f, 0.0f);
            jendela8.createEllipsoid(0.02f, 0.06f, 0.01f, 0.0f, 1.5f + 0.16f, 0.0f);
            jendela9.createEllipsoid(0.02f, 0.06f, 0.01f, 0.0f, 1.5f + 0.16f, 0.0f);
            jendela10.createEllipsoid(0.02f, 0.06f, 0.01f, 0.0f, 1.5f + 0.16f, 0.0f);
            jendela11.createEllipsoid(0.02f, 0.06f, 0.01f, 0.0f, 1.5f + 0.16f, 0.0f);
            jendela12.createEllipsoid(0.02f, 0.06f, 0.01f, 0.0f, 1.5f + 0.16f, 0.0f);

            jendelaPilot1.createBodyVertices(-0.27f, 1.5f + 0.3f, 0.09f, 0.19f);
            jendelaPilot2.createBodyVertices(-0.27f, 1.5f + 0.3f, -0.09f, 0.19f);

            pintu1.createRectangle(0.0f, 1.5f + 0.3f, 0.215f, 0.075f, 0.15f);
            pintu2.createRectangle(0.0f, 1.5f + 0.3f, -0.215f, 0.075f, 0.15f);

            penahan1.createEllipsoid(0.1f, 0.1f, 0.1f, 0.0f, 1.5f + -0.08f, 0.3f);
            penahan2.createEllipsoid(0.1f, 0.1f, 0.1f, 0.0f, 1.5f + -0.08f, -0.3f);


            
            helikopter.Add(baling1);
            helikopter.Add(baling2);
            helikopter.Add(baling3);
            helikopter.Add(baling4);
            helikopter.Add(kotangBaling);
            helikopter.Add(badan1);
            helikopter.Add(badan2);
            helikopter.Add(ekorDatar);
            helikopter.Add(ekorTrapesium);
            helikopter.Add(penyambungEkor);

            helikopter.Add(kaki1);
            helikopter.Add(kaki2);
            helikopter.Add(kaki3);
            helikopter.Add(kaki4);
            helikopter.Add(kaki5);
            helikopter.Add(kaki6);
            helikopter.Add(kaki7);

            helikopter.Add(jendela1);
            helikopter.Add(jendela2);
            helikopter.Add(jendela3);
            helikopter.Add(jendela4);
            helikopter.Add(jendela5);
            helikopter.Add(jendela6);
            helikopter.Add(jendela7);
            helikopter.Add(jendela8);
            helikopter.Add(jendela9);
            helikopter.Add(jendela10);
            helikopter.Add(jendela11);
            helikopter.Add(jendela12);
            helikopter.Add(jendelaPilot1);
            helikopter.Add(jendelaPilot2);
            helikopter.Add(pintu1);
            helikopter.Add(pintu2);
            helikopter.Add(penahan1);
            helikopter.Add(penahan2);
            helikopter.Add(senjata1);
            helikopter.Add(senjata2);
            helikopter.Add(moncong1);
            helikopter.Add(moncong2);

            foreach (Asset3d i in helikopter)
            {
                i.load(Constants.path + "shader.vert", Constants.path + "shader.frag", x, y);
                i.translate(-0.0075f, 0.0f, 0.0f);
                i.scale(1.01f, 1.01f, 1.01f);
            }

        }


        public void Render(FrameEventArgs args, Camera _camera, KeyboardState input)
        {


            _time = 0.0;
            float timeRotate = -0.2f;
            float timeBaling = 7.0f;
            Matrix4 temp = Matrix4.Identity;
            int count = 0;

            foreach (Asset3d i in helikopter)
            {

             
                count++;
                i.render(3, _time, temp, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());
                i.rotate(Vector3.UnitX, Vector3.UnitY, (float)timeRotate);
                i.translate(-0.03f, 0.0f, 0.0f);
                if (count < 5)
                {

                    i.rotate(helikopter[4]._centerPosition, Vector3.UnitY, (float)timeBaling);
                }

            }


        }


    }

}

