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
    internal class Awan
    {
        List<Asset3d> awan = new List<Asset3d>();
        double _timeBaling;
        double _time;
        public Awan()
        {

        }


        public void Load(int x, int y)
        {

            var awan1 = new Asset3d(new Vector3(255, 255, 255));
            var awan2 = new Asset3d(new Vector3(255, 255, 255));
            var awan3 = new Asset3d(new Vector3(255, 255, 255));
            var awan4 = new Asset3d(new Vector3(255, 255, 255));
            var awan5 = new Asset3d(new Vector3(255, 255, 255));

            var awan11 = new Asset3d(new Vector3(255, 255, 255));
            var awan21 = new Asset3d(new Vector3(255, 255, 255));
            var awan31 = new Asset3d(new Vector3(255, 255, 255));
            var awan41 = new Asset3d(new Vector3(255, 255, 255));
            var awan51 = new Asset3d(new Vector3(255, 255, 255));

            var awan12 = new Asset3d(new Vector3(255, 255, 255));
            var awan22 = new Asset3d(new Vector3(255, 255, 255));
            var awan32 = new Asset3d(new Vector3(255, 255, 255));
            var awan42 = new Asset3d(new Vector3(255, 255, 255));
            var awan52 = new Asset3d(new Vector3(255, 255, 255));

            var awan13 = new Asset3d(new Vector3(255, 255, 255));
            var awan23 = new Asset3d(new Vector3(255, 255, 255));
            var awan33 = new Asset3d(new Vector3(255, 255, 255));
            var awan43 = new Asset3d(new Vector3(255, 255, 255));
            var awan53 = new Asset3d(new Vector3(255, 255, 255));

            var awan14 = new Asset3d(new Vector3(255, 255, 255));
            var awan24 = new Asset3d(new Vector3(255, 255, 255));
            var awan34 = new Asset3d(new Vector3(255, 255, 255));
            var awan44 = new Asset3d(new Vector3(255, 255, 255));
            var awan54 = new Asset3d(new Vector3(255, 255, 255));



            awan1.createEllipsoid(0.03f, 0.06f, -0.3f, 0.55f, 0.35f + 0.5f + 0.5f, 0.5f);
            awan2.createEllipsoid(0.01f, 0.07f, -0.4f, 0.6f, 0.4f + 0.5f + 0.5f, 0.3f);
            awan3.createEllipsoid(0.06f, 0.06f, -0.5f, 0.8f, 0.4f + 0.5f + 0.5f, 0.4f);
            awan4.createEllipsoid(0.05f, 0.062f, -0.3f, 0.8f, 0.5f + 0.5f + 0.5f, 0.3f);
            awan5.createEllipsoid(0.03f, 0.063f, -0.2f, 0.6f, 0.5f + 0.5f + 0.5f, 0.3f);

            awan11.createEllipsoid(0.03f, 0.06f, -0.3f, 0.55f - 1.0f, 0.35f + 0.5f + 0.5f, 0.5f - 1.5f);
            awan21.createEllipsoid(0.01f, 0.07f, -0.4f, 0.6f - 1.0f, 0.4f + 0.5f + 0.5f, 0.3f - 1.5f);
            awan31.createEllipsoid(0.06f, 0.06f, -0.5f, 0.8f - 1.0f, 0.4f + 0.5f + 0.5f, 0.4f - 1.5f);
            awan41.createEllipsoid(0.05f, 0.062f, -0.3f, 0.8f - 1.0f, 0.5f + 0.5f + 0.5f, 0.3f - 1.5f);
           

            awan12.createEllipsoid(0.03f, 0.06f, -0.3f, 0.55f - 2.0f, 0.35f + 0.5f + 0.3f, 0.5f - 1.0f);
            awan22.createEllipsoid(0.01f, 0.07f, -0.4f, 0.6f - 2.0f, 0.4f + 0.5f + 0.3f, 0.3f - 1.0f);
            awan32.createEllipsoid(0.06f, 0.06f, -0.5f, 0.8f - 2.0f, 0.4f + 0.5f + 0.3f, 0.4f - 1.0f);
            awan42.createEllipsoid(0.05f, 0.062f, -0.3f, 0.8f - 2.0f, 0.5f + 0.5f + 0.3f, 0.3f - 1.0f);
          


            awan13.createEllipsoid(0.03f, 0.06f, -0.3f, 0.55f - 1.0f, 0.35f + 0.5f + 0.7f, 0.5f);
            awan23.createEllipsoid(0.01f, 0.07f, -0.4f, 0.6f - 1.0f, 0.4f + 0.5f + 0.7f, 0.3f);
            awan33.createEllipsoid(0.06f, 0.06f, -0.5f, 0.8f - 1.0f, 0.4f + 0.5f + 0.7f, 0.4f);
            awan43.createEllipsoid(0.05f, 0.062f, -0.3f, 0.8f - 1.0f, 0.5f + 0.5f + 0.7f, 0.3f);
            awan53.createEllipsoid(0.03f, 0.063f, -0.2f, 0.6f - 1.0f, 0.5f + 0.5f + 0.7f, 0.3f);


            awan14.createEllipsoid(0.03f, 0.06f, -0.3f, 0.55f - 2.5f, 0.35f + 0.5f + 0.7f, 0.5f - 0.5f);
            awan24.createEllipsoid(0.01f, 0.07f, -0.4f, 0.6f - 2.5f, 0.4f + 0.5f + 0.7f, 0.3f - 0.5f);
            awan34.createEllipsoid(0.06f, 0.06f, -0.5f, 0.8f - 2.5f, 0.4f + 0.5f + 0.7f, 0.4f - 0.5f);
            awan44.createEllipsoid(0.05f, 0.062f, -0.3f, 0.8f - 2.5f, 0.5f + 0.5f + 0.7f, 0.3f - 0.5f);
            awan54.createEllipsoid(0.03f, 0.063f, -0.2f, 0.6f - 2.5f, 0.5f + 0.5f + 0.7f, 0.3f - 0.5f);


            awan.Add(awan1);
            awan.Add(awan2);
            awan.Add(awan3);
            awan.Add(awan4);
            awan.Add(awan5);

            awan.Add(awan11);
            awan.Add(awan21);
            awan.Add(awan31);
            awan.Add(awan41);
            awan.Add(awan51);

            awan.Add(awan12);
            awan.Add(awan22);
            awan.Add(awan32);
            awan.Add(awan42);
            awan.Add(awan52);

            awan.Add(awan13);
            awan.Add(awan23);
            awan.Add(awan33);
            awan.Add(awan43);
            awan.Add(awan53);

            awan.Add(awan14);
            awan.Add(awan24);
            awan.Add(awan34);
            awan.Add(awan44);
            awan.Add(awan54);

            //  baseHeli.Add(tempath10);

            foreach (Asset3d i in awan)
            {
                i.load(Constants.path + "shader.vert", Constants.path + "shader.frag", x, y);

            }




        }


        public void Render(FrameEventArgs args, Camera _camera, KeyboardState input)
        {


            Matrix4 temp = Matrix4.Identity;
            _time = 0;
            int count = 0;
            


            foreach (Asset3d i in awan)
            {
                count++;
                i.render(3, _time, temp, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());
                i.rotate(Vector3.UnitX, Vector3.UnitY, -0.01f);
                i.translate(-0.0001f, 0.0f, 0.0f);

                if (count < 5)
                {
                    i.rotate(awan[3]._centerPosition, Vector3.UnitY, -0.015f);
                }else if(count < 10)
                {
                    i.rotate(awan[3]._centerPosition, Vector3.UnitY, -0.025f);
                }else if (count < 15)
                {
                    i.rotate(awan[3]._centerPosition, Vector3.UnitY, 0.015f);
                }else
                {
                    i.rotate(awan[3]._centerPosition, Vector3.UnitY, 0.025f);
                }

            }


        }
    }
}
