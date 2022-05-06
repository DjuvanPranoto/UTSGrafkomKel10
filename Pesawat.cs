using System;
using System.Collections.Generic;
using System.Text;
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
    internal class Pesawat
    {
        List<Asset3d> pesawat = new List<Asset3d>();
        double _angle;
        double _time;
        Camera _camera;
        public Pesawat()
        {

        }

        public void Load(int x, int y)
        {

            var badan1 = new Asset3d(new Vector3(0.270f, 0.478f, 0.639f));
            var badan2 = new Asset3d(new Vector3(0.270f, 0.478f, 0.639F));
            var ekor = new Asset3d(new Vector3(0.364f, 0.604f, 0.651f));
            var sayap = new Asset3d(new Vector3(0.309f, 0.404f, 0.611f));
            
            var rudalTengah1 = new Asset3d(new Vector3(0.815f, 0.843f, 0.858f));
            var rudalTengah2 = new Asset3d(new Vector3(0.815f, 0.843f, 0.858f));

            var jendela1 = new Asset3d(new Vector3(0.855f, 0.929f, 0.827f));
            var jendela2 = new Asset3d(new Vector3(0.855f, 0.929f, 0.827f));
            var jendela3 = new Asset3d(new Vector3(0.855f, 0.929f, 0.827f));
            var jendela4 = new Asset3d(new Vector3(0.855f, 0.929f, 0.827f));
            var jendela5 = new Asset3d(new Vector3(0.855f, 0.929f, 0.827f));
            var jendela6 = new Asset3d(new Vector3(0.855f, 0.929f, 0.827f));
            var jendelaPilot1 = new Asset3d(new Vector3(0.855f, 0.929f, 0.827f));
            var jendelaPilot2 = new Asset3d(new Vector3(0.855f, 0.929f, 0.827f));
            var pintu1 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var pintu2 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));


            var roda1 = new Asset3d(new Vector3(0.019f, 0.019f, 0.019f));
            var roda2 = new Asset3d(new Vector3(0.019f, 0.019f, 0.019f));
            var roda3 = new Asset3d(new Vector3(0.019f, 0.019f, 0.019f));
            var roda4 = new Asset3d(new Vector3(0.019f, 0.019f, 0.019f));
            var roda5 = new Asset3d(new Vector3(0.019f, 0.019f, 0.019f));
            var roda6 = new Asset3d(new Vector3(0.019f, 0.019f, 0.019f));


            var kaki1 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var kaki2 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));
            var kaki3 = new Asset3d(new Vector3(0.68f, 0.573f, 0.386f));

            var sayapBelakang = new Asset3d(new Vector3(0.239f, 0.313f, 0.329f));



            badan1.createBodyVertices(0.0f,2.7f+ 0.2f, 0, 0.5f);
            badan2.createBodyBackVertices(0.5f, 2.7f + 0.2f, 0, 0.5f);
            ekor.createTailVertices(1.4f, 2.7f + 0.2f, 0, 0.5f);
            sayap.createEllipsoid(0.1f, 0.05f, 1.2f, 0.0f, 2.7f + 0.15f, 0.0f);
            rudalTengah1.createEllipsoid(0.06f, 0.067f, 0.057f, 0.0f, 2.7f + 0.055f, 0.66f);
            rudalTengah2.createEllipsoid(0.06f, 0.067f, 0.057f, 0.0f, 2.7f + 0.055f, -0.66f);
            jendela1.createEllipsoid(0.02f, 0.06f, 0.01f, 0.95f, 2.7f + 0.16f, -0.15f);
            jendela2.createEllipsoid(0.02f, 0.06f, 0.01f, 0.95f, 2.7f + 0.16f, 0.15f);
            jendela3.createEllipsoid(0.02f, 0.06f, 0.01f, 0.75f, 2.7f + 0.16f, -0.15f);
            jendela4.createEllipsoid(0.02f, 0.06f, 0.01f, 0.75f, 2.7f + 0.16f, 0.15f);
            jendela5.createEllipsoid(0.02f, 0.06f, 0.01f, 0.55f, 2.7f + 0.16f, -0.15f);
            jendela6.createEllipsoid(0.02f, 0.06f, 0.01f, 0.55f, 2.7f + 0.16f, 0.15f);
            jendelaPilot1.createBodyVertices(-0.27f, 2.7f + 0.3f, 0.09f, 0.19f);
            jendelaPilot2.createBodyVertices(-0.27f, 2.7f + 0.3f, -0.09f, 0.19f);
            pintu1.createRectangle(0.0f, 2.7f + 0.3f, 0.215f, 0.075f, 0.15f);
            pintu2.createRectangle(0.0f, 2.7f + 0.3f, -0.215f, 0.075f, 0.15f);


        
            roda1.createTorus(0.425f, 2.7f + -0.25f, 0.110f, 0.05f, 0.03f, 100, 100);
            roda1.rotate(roda1._centerPosition, Vector3.UnitX, 90.0f);

            roda2.createTorus(0.425f, 2.7f + -0.25f, 0.240f, 0.05f, 0.03f, 100, 100);
            roda2.rotate(roda2._centerPosition, Vector3.UnitX, 90.0f);
            roda3.createTorus(0.425f, 2.7f + -0.25f, -0.054f, 0.05f, 0.03f, 100, 100);
            roda3.rotate(roda3._centerPosition, Vector3.UnitX, 90.0f);
            roda4.createTorus(0.425f, 2.7f + -0.25f, -0.2f, 0.05f, 0.03f, 100, 100);
            roda4.rotate(roda4._centerPosition, Vector3.UnitX, 90.0f);
            roda5.createTorus(-0.52f, 2.7f + -0.25f, 0.1f, 0.05f, 0.03f, 100, 100);
            roda5.rotate(roda5._centerPosition, Vector3.UnitX, 90.0f);
            roda6.createTorus(-0.52f, 2.7f + -0.25f, -0.04f, 0.05f, 0.03f, 100, 100);
            roda6.rotate(roda6._centerPosition, Vector3.UnitX, 90.0f);


            kaki1.createFootVertices(-0.50f, 2.7f + -0.1f, 0.0f, 0.15f);
            kaki2.createFootVertices(0.45f, 2.7f + -0.1f, 0.15f, 0.15f);
            kaki3.createFootVertices(0.45f, 2.7f + -0.1f, -0.15f, 0.15f);
            sayapBelakang.createEllipsoid(0.065f, 0.05f, 0.3f, 1.45f, 2.7f + 0.2f, 0.0f);

            pesawat.Add(badan1);
            pesawat.Add(badan2);
            pesawat.Add(ekor);
            pesawat.Add(sayap);

            pesawat.Add(rudalTengah1);
            pesawat.Add(rudalTengah2);

    
            pesawat.Add(jendela1);
            pesawat.Add(jendela2);
            pesawat.Add(jendela3);
            pesawat.Add(jendela4);
            pesawat.Add(jendela5);
            pesawat.Add(jendela6);
            pesawat.Add(jendelaPilot1);
            pesawat.Add(jendelaPilot2);
            pesawat.Add(pintu1);
            pesawat.Add(pintu2);

            pesawat.Add(roda1);
            pesawat.Add(roda2);
            pesawat.Add(roda3);
            pesawat.Add(roda4);
            pesawat.Add(roda5);
            pesawat.Add(roda6);

            pesawat.Add(kaki1);
            pesawat.Add(kaki2);
            pesawat.Add(kaki3);
            pesawat.Add(sayapBelakang);

            foreach (Asset3d i in pesawat)
            {
                i.load(Constants.path + "shader.vert", Constants.path + "shader.frag", x, y);
             //   i.rotate(Vector3.UnitX, Vector3.UnitY, -90);
             //   i.translate(-1.0f, -2.8f, 1.5f);
                i.scale(1.01f, 1.01f, 1.01f);

            }


            

        }


        public void Render(FrameEventArgs args, Camera _camera, KeyboardState input)
        {


            _time = 0;
            float timeRotate = -0.5f;
            float timeBaling = 5.0f;
            Matrix4 temp = Matrix4.Identity;
            int count = 0;

            foreach (Asset3d i in pesawat)
            {

                i.render(3, _time, temp, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());
                i.rotate(Vector3.UnitX, Vector3.UnitY, (float)timeRotate);
                i.translate(-0.05f, 0.0f, 0.0f);

            }


        }

    }
}
