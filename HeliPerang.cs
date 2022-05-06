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
    internal class HeliPerang
    {
        List<Asset3d> helikopter = new List<Asset3d>();

        double _time;
        public HeliPerang()
        {

        }






        public void Load(int x, int y)
        {

            var badan1 = new Asset3d(new Vector3(0.447f, 0.509f, 0.309f));
            var badan2 = new Asset3d(new Vector3(0.447f, 0.509f, 0.309f));
            var ekor = new Asset3d(new Vector3(0.592f, 0.619f, 0.525f));
            var sayap = new Asset3d(new Vector3(0.509f, 0.4f, 0.0039f));
            var baling1 = new Asset3d(new Vector3(0.196f, 0.231f, 0.121f));
            var baling2 = new Asset3d(new Vector3(0.196f, 0.231f, 0.121f));
            var baling3 = new Asset3d(new Vector3(0.196f, 0.231f, 0.121f));
            var baling4 = new Asset3d(new Vector3(0.196f, 0.231f, 0.121f));
            var kotangBaling = new Asset3d(new Vector3(0.592f, 0.619f, 0.525f));
          
            var rudalTengah1 = new Asset3d(new Vector3(1.0f, 0.796f, 0.643f));
            var rudalTengah2 = new Asset3d(new Vector3(1.0f, 0.796f, 0.643f));
            var moncongRudalVBelakang1 = new Asset3d(new Vector3(0.542f, 0.44f, 0.191f));
            var moncongRudalVBelakang2 = new Asset3d(new Vector3(0.542f, 0.44f, 0.191f));
            var moncongRudalVBelakang3 = new Asset3d(new Vector3(0.542f, 0.44f, 0.191f));
            var moncongRudalVBelakang4 = new Asset3d(new Vector3(0.542f, 0.44f, 0.191f));
            var moncongRudalVBelakang5 = new Asset3d(new Vector3(0.542f, 0.44f, 0.191f));
            var moncongRudalVBelakang6 = new Asset3d(new Vector3(0.542f, 0.44f, 0.191f));
            var rudal1 = new Asset3d(new Vector3(0.592f, 0.619f, 0.525f));
            var rudal2 = new Asset3d(new Vector3(0.592f, 0.619f, 0.525f));
            var rudal3 = new Asset3d(new Vector3(0.592f, 0.619f, 0.525f));
            var rudal4 = new Asset3d(new Vector3(0.592f, 0.619f, 0.525f));
            var moncongRudal1 = new Asset3d(new Vector3(0.542f, 0.44f, 0.191f));
            var moncongRudal2 = new Asset3d(new Vector3(0.542f, 0.44f, 0.191f));
            var moncongRudal3 = new Asset3d(new Vector3(0.542f, 0.44f, 0.191f));
            var moncongRudal4 = new Asset3d(new Vector3(0.542f, 0.44f, 0.191f));
            var jendela1 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var jendela2 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var jendela3 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var jendela4 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var jendela5 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var jendela6 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var jendelaPilot1 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var jendelaPilot2 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var pintu1 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var pintu2 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));


            var senjata1 = new Asset3d(new Vector3(0.517f, 0.639f, 0.250f));
            var senjata2 = new Asset3d(new Vector3(0.517f, 0.639f, 0.250f));
            var moncong1 = new Asset3d(new Vector3(0.509f, 0.4f, 0.0039f));
            var moncong2 = new Asset3d(new Vector3(0.509f, 0.4f, 0.0039f));


            var roda1 = new Asset3d(new Vector3(0.019f, 0.019f, 0.019f));
            var roda2 = new Asset3d(new Vector3(0.019f, 0.019f, 0.019f));
            var roda3 = new Asset3d(new Vector3(0.019f, 0.019f, 0.019f));
            var roda4 = new Asset3d(new Vector3(0.019f, 0.019f, 0.019f));
            var roda5 = new Asset3d(new Vector3(0.019f, 0.019f, 0.019f));
            var roda6 = new Asset3d(new Vector3(0.019f, 0.019f, 0.019f));


            var kaki1 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var kaki2 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var kaki3 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var kaki4 = new Asset3d(new Vector3(0.196f, 0.231f, 0.121f));



            badan1.createBodyVertices(0.0f, 0.25f+0.2f , 0, 0.5f);
            badan2.createBodyBackVertices(0.5f, 0.25f + 0.2f , 0, 0.5f);

            ekor.createTailVertices(1.4f, 0.25f + 0.2f, 0, 0.5f);

            sayap.createEllipsoid(0.1f, 0.05f, 1.2f, 0.0f, 0.25f + 0.15f , 0.0f);

        
            kotangBaling.createSphere(0.0f, 0.25f + 0.6f, 0.0f, 0.1f, 500, 500);
            baling1.createRectangle1Vertices(0.1f, 0.25f + 0.75f, 0, 0.35f);
            baling2.createRectangle2Vertices(-0.1f, 0.25f + 0.75f, 0, 0.35f);
            baling3.createRectangle3Vertices(0.0f, 0.25f + 0.75f , 0.1f, 0.35f);
            baling4.createRectangle4Vertices(0.0f, 0.25f + 0.75f , -0.1f, 0.35f);
            kaki4.createFootVertices(0.0f, 0.155f + 0.6f, -0.008f, 0.1f);


            kaki1.createFootVertices(-0.50f, 0.25f + -0.1f, 0.0f, 0.15f);
            kaki2.createFootVertices(0.45f, 0.25f + -0.1f, 0.15f, 0.15f);
            kaki3.createFootVertices(0.45f, 0.25f + -0.1f, -0.15f, 0.15f);

            roda1.createTorus(0.425f, 0.26f - 0.25f, 0.110f, 0.05f, 0.03f, 100, 100);
            roda1.rotate(roda1._centerPosition, Vector3.UnitX, 90.0f);

            roda2.createTorus(0.425f, 0.26f - 0.25f, 0.240f, 0.05f, 0.03f, 100, 100);
            roda2.rotate(roda2._centerPosition, Vector3.UnitX, 90.0f);
            roda3.createTorus(0.425f, 0.26f - 0.25f, -0.054f, 0.05f, 0.03f, 100, 100);
            roda3.rotate(roda3._centerPosition, Vector3.UnitX, 90.0f);
            roda4.createTorus(0.425f, 0.26f - 0.25f, -0.2f, 0.05f, 0.03f, 100, 100);
            roda4.rotate(roda4._centerPosition, Vector3.UnitX, 90.0f);
            roda5.createTorus(-0.52f, 0.26f - 0.25f, 0.1f, 0.05f, 0.03f, 100, 100);
            roda5.rotate(roda5._centerPosition, Vector3.UnitX, 90.0f);
            roda6.createTorus(-0.52f, 0.26f - 0.25f, -0.04f, 0.05f, 0.03f, 100, 100);
            roda6.rotate(roda6._centerPosition, Vector3.UnitX, 90.0f);

            rudalTengah1.createEllipsoid(0.06f, 0.057f, 0.05f, 0.0f, 0.25f + 0.055f, 0.66f);
            rudalTengah2.createEllipsoid(0.06f, 0.057f, 0.05f, 0.0f, 0.25f + 0.055f, -0.66f);

            moncongRudalVBelakang1.createEllipsoid(0.015f, 0.012f, 0.01f, 0.18f, 0.25f + 0.03f, 0.66f);
            moncongRudalVBelakang2.createEllipsoid(0.015f, 0.012f, 0.01f, 0.18f, 0.25f + 0.08f, 0.69f);
            moncongRudalVBelakang3.createEllipsoid(0.015f, 0.012f, 0.01f, 0.18f, 0.25f + 0.08f, 0.63f);
            moncongRudalVBelakang4.createEllipsoid(0.015f, 0.012f, 0.01f, 0.18f, 0.25f + 0.03f, -0.66f);
            moncongRudalVBelakang5.createEllipsoid(0.015f, 0.012f, 0.01f, 0.18f, 0.25f + 0.08f, -0.69f);
            moncongRudalVBelakang6.createEllipsoid(0.015f, 0.012f, 0.01f, 0.18f, 0.25f + 0.08f, -0.63f);

            rudal1.createEllipsoid(0.08f, 0.047f, 0.037f, -0.15f, 0.25f + 0.08f , 0.4f);
            rudal2.createEllipsoid(0.08f, 0.047f, 0.037f, -0.15f, 0.25f + 0.08f , -0.4f);
            rudal3.createEllipsoid(0.08f, 0.047f, 0.037f, -0.15f, 0.25f + 0.08f , 0.9f);
            rudal4.createEllipsoid(0.08f, 0.047f, 0.037f, -0.15f, 0.25f + 0.08f , -0.9f);

            moncongRudal1.createEllipsoid(0.015f, 0.012f, 0.01f, -0.4f, 0.25f + 0.08f , 0.4f);
            moncongRudal2.createEllipsoid(0.015f, 0.012f, 0.01f, -0.4f, 0.25f + 0.08f , -0.4f);
            moncongRudal3.createEllipsoid(0.015f, 0.012f, 0.01f, -0.4f, 0.25f + 0.08f , 0.9f);
            moncongRudal4.createEllipsoid(0.015f, 0.012f, 0.01f, -0.4f, 0.25f + 0.08f , -0.9f);

            jendela1.createEllipsoid(0.02f, 0.06f, 0.01f, 0.95f, 0.25f + 0.16f, -0.15f);
            jendela2.createEllipsoid(0.02f, 0.06f, 0.01f, 0.95f, 0.25f + 0.16f, 0.15f);
            jendela3.createEllipsoid(0.02f, 0.06f, 0.01f, 0.75f, 0.25f + 0.16f, -0.15f);
            jendela4.createEllipsoid(0.02f, 0.06f, 0.01f, 0.75f, 0.25f + 0.16f , 0.15f);
            jendela5.createEllipsoid(0.02f, 0.06f, 0.01f, 0.55f, 0.25f + 0.16f , -0.15f);
            jendela6.createEllipsoid(0.02f, 0.06f, 0.01f, 0.55f, 0.25f + 0.16f , 0.15f);

            jendelaPilot1.createBodyVertices(-0.27f, 0.25f + 0.3f , 0.09f, 0.19f);
            jendelaPilot2.createBodyVertices(-0.27f, 0.25f + 0.3f , -0.09f, 0.19f);

            pintu1.createRectangle(0.0f, 0.25f+ 0.3f, 0.215f, 0.075f, 0.15f);
            pintu2.createRectangle(0.0f, 0.25f+ 0.3f, -0.215f,  0.075f, 0.15f);


            senjata1.createEllipsoid(0.1f, 0.023f, 0.016f, -0.22f, 0.25f + 0.4f , 0.25f);
            senjata2.createEllipsoid(0.1f, 0.023f, 0.016f, -0.22f, 0.25f + 0.4f , -0.25f);
            moncong1.createEllipsoid(0.015f, 0.012f, 0.01f, -0.535f, 0.25f + 0.4f, 0.25f);
            moncong2.createEllipsoid(0.015f, 0.012f, 0.01f, -0.535f, 0.25f + 0.4f, -0.25f);

            
            helikopter.Add(baling1);
            helikopter.Add(baling2);
            helikopter.Add(baling3);
            helikopter.Add(baling4);
            helikopter.Add(kotangBaling);
            helikopter.Add(badan1);
            helikopter.Add(badan2);
            helikopter.Add(ekor);
            helikopter.Add(sayap);
            helikopter.Add(kaki1);
            helikopter.Add(kaki2);
            helikopter.Add(kaki3);
            helikopter.Add(roda1);
            helikopter.Add(roda2);
            helikopter.Add(roda3);
            helikopter.Add(roda4);
            helikopter.Add(roda5);
            helikopter.Add(roda6);
            helikopter.Add(rudalTengah1);
            helikopter.Add(rudalTengah2);
            helikopter.Add(moncongRudalVBelakang1);
            helikopter.Add(moncongRudalVBelakang2);
            helikopter.Add(moncongRudalVBelakang3);
            helikopter.Add(moncongRudalVBelakang4);
            helikopter.Add(moncongRudalVBelakang5);
            helikopter.Add(moncongRudalVBelakang6);
            helikopter.Add(rudal1);
            helikopter.Add(rudal2);
            helikopter.Add(rudal3);
            helikopter.Add(rudal4);
            helikopter.Add(moncongRudal1);
            helikopter.Add(moncongRudal2);
            helikopter.Add(moncongRudal3);
            helikopter.Add(moncongRudal4);
            helikopter.Add(jendela1);
            helikopter.Add(jendela2);
            helikopter.Add(jendela3);
            helikopter.Add(jendela4);
            helikopter.Add(jendela5);
            helikopter.Add(jendela6);
            helikopter.Add(jendelaPilot1);
            helikopter.Add(jendelaPilot2);
            helikopter.Add(pintu1);
            helikopter.Add(pintu2);

            helikopter.Add(senjata1);
            helikopter.Add(senjata2);
            helikopter.Add(moncong1);
            helikopter.Add(moncong2);
            helikopter.Add(kaki4);

             int count = 0;
            foreach (Asset3d i in helikopter)
            {

                i.load(Constants.path + "shader.vert", Constants.path + "shader.frag", x, y);
                i.scale(1.01f, 1.01f, 1.01f);
                
            }

        }


        public void Render(FrameEventArgs args, Camera _camera, KeyboardState input)
        {

        
            _time = 0;
            float timeRotate = -0.35f;
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
