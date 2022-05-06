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
    internal class Base
    {
        List<Asset3d> baseHeli = new List<Asset3d>();
        
        double _timeBaling;
        double _time;
        public Base()
        {

        }


        public void Load(int x, int y)
        {

            var tempat1 = new Asset3d(new Vector3(0.125f, 0.501f, 0));
            var tempat2 = new Asset3d(new Vector3(0, 0, 0));
            var tempat3 = new Asset3d(new Vector3(0, 0, 0));
            var tempath1 = new Asset3d(new Vector3(255,255,255));
            var tempath2 = new Asset3d(new Vector3(255, 255, 255));
            var tempath3 = new Asset3d(new Vector3(255, 255, 255));
            var tempath4 = new Asset3d(new Vector3(255, 255, 255));
            var tempath5 = new Asset3d(new Vector3(255, 255, 255));
            var tempath6 = new Asset3d(new Vector3(255, 255, 255));



            //kiri atas
            var pohon1 = new Asset3d(new Vector3(0.45f, 0.3f, 0.05f));
            var pohon2 = new Asset3d(new Vector3(0.25f, 0.75f, 0.45f));
            var pohon3 = new Asset3d(new Vector3(0.3f, 0.85f, 0.4f));
            var pohon4 = new Asset3d(new Vector3(0.35f, 1.0f, 0.25f));

            var pohon11 = new Asset3d(new Vector3(0.45f, 0.3f, 0.05f));
            var pohon21 = new Asset3d(new Vector3(0.25f, 0.75f, 0.45f));
            var pohon31 = new Asset3d(new Vector3(0.3f, 0.85f, 0.4f));
            var pohon41 = new Asset3d(new Vector3(0.35f, 1.0f, 0.25f));


            var pohon12 = new Asset3d(new Vector3(0.45f, 0.3f, 0.05f));
            var pohon22 = new Asset3d(new Vector3(0.25f, 0.75f, 0.45f));
            var pohon32 = new Asset3d(new Vector3(0.3f, 0.85f, 0.4f));
            var pohon42 = new Asset3d(new Vector3(0.35f, 1.0f, 0.25f));


            var pohon13 = new Asset3d(new Vector3(0.45f, 0.3f, 0.05f));
            var pohon23 = new Asset3d(new Vector3(0.25f, 0.75f, 0.45f));
            var pohon33 = new Asset3d(new Vector3(0.3f, 0.85f, 0.4f));
            var pohon43 = new Asset3d(new Vector3(0.35f, 1.0f, 0.25f));


            var pohon14 = new Asset3d(new Vector3(0.45f, 0.3f, 0.05f));
            var pohon24 = new Asset3d(new Vector3(0.25f, 0.75f, 0.45f));
            var pohon34 = new Asset3d(new Vector3(0.3f, 0.85f, 0.4f));
            var pohon44 = new Asset3d(new Vector3(0.35f, 1.0f, 0.25f));

            var pohon15 = new Asset3d(new Vector3(0.45f, 0.3f, 0.05f));
            var pohon25 = new Asset3d(new Vector3(0.25f, 0.75f, 0.45f));
            var pohon35 = new Asset3d(new Vector3(0.3f, 0.85f, 0.4f));
            var pohon45 = new Asset3d(new Vector3(0.35f, 1.0f, 0.25f));




            //kanan bawah
            var pohon111 = new Asset3d(new Vector3(0.45f, 0.3f, 0.05f));
            var pohon211 = new Asset3d(new Vector3(0.25f, 0.75f, 0.45f));
            var pohon311 = new Asset3d(new Vector3(0.3f, 0.85f, 0.4f));
            var pohon411 = new Asset3d(new Vector3(0.35f, 1.0f, 0.25f));


            var pohon122 = new Asset3d(new Vector3(0.45f, 0.3f, 0.05f));
            var pohon222 = new Asset3d(new Vector3(0.25f, 0.75f, 0.45f));
            var pohon322 = new Asset3d(new Vector3(0.3f, 0.85f, 0.4f));
            var pohon422 = new Asset3d(new Vector3(0.35f, 1.0f, 0.25f));


            var pohon133 = new Asset3d(new Vector3(0.45f, 0.3f, 0.05f));
            var pohon233 = new Asset3d(new Vector3(0.25f, 0.75f, 0.45f));
            var pohon333 = new Asset3d(new Vector3(0.3f, 0.85f, 0.4f));
            var pohon433 = new Asset3d(new Vector3(0.35f, 1.0f, 0.25f));


            var pohon144 = new Asset3d(new Vector3(0.45f, 0.3f, 0.05f));
            var pohon244 = new Asset3d(new Vector3(0.25f, 0.75f, 0.45f));
            var pohon344 = new Asset3d(new Vector3(0.3f, 0.85f, 0.4f));
            var pohon444 = new Asset3d(new Vector3(0.35f, 1.0f, 0.25f));


            var pohon155 = new Asset3d(new Vector3(0.45f, 0.3f, 0.05f));
            var pohon255 = new Asset3d(new Vector3(0.25f, 0.75f, 0.45f));
            var pohon355= new Asset3d(new Vector3(0.3f, 0.85f, 0.4f));
            var pohon455 = new Asset3d(new Vector3(0.35f, 1.0f, 0.25f));

            var pohon156 = new Asset3d(new Vector3(0.45f, 0.3f, 0.05f));
            var pohon256 = new Asset3d(new Vector3(0.25f, 0.75f, 0.45f));
            var pohon356 = new Asset3d(new Vector3(0.3f, 0.85f, 0.4f));
            var pohon456 = new Asset3d(new Vector3(0.35f, 1.0f, 0.25f));

            var pohon157 = new Asset3d(new Vector3(0.45f, 0.3f, 0.05f));
            var pohon257 = new Asset3d(new Vector3(0.25f, 0.75f, 0.45f));
            var pohon357 = new Asset3d(new Vector3(0.3f, 0.85f, 0.4f));
            var pohon457 = new Asset3d(new Vector3(0.35f, 1.0f, 0.25f));





            var helipad = new Asset3d(new Vector3(0.831f, 0.705f, 0));
            var helipad2 = new Asset3d(new Vector3(0.831f, 0.705f, 0));


            var hurufH1 = new Asset3d(new Vector3(0.831f, 0.705f, 0));
            var hurufH2 = new Asset3d(new Vector3(0.831f, 0.705f, 0));
            var hurufH3 = new Asset3d(new Vector3(0.831f, 0.705f, 0));
            var hurufH11 = new Asset3d(new Vector3(0.831f, 0.705f, 0));
            var hurufH12 = new Asset3d(new Vector3(0.831f, 0.705f, 0));
            var hurufH13 = new Asset3d(new Vector3(0.831f, 0.705f, 0));

            var panggung1 = new Asset3d(new Vector3(0.45f, 0.3f, 0.05f));
            var panggung2 = new Asset3d(new Vector3(0.45f, 0.3f, 0.05f));
            var panggung3 = new Asset3d(new Vector3(0.45f, 0.3f, 0.05f));
            var panggung4 = new Asset3d(new Vector3(0.45f, 0.3f, 0.05f));

            var ayunan1 = new Asset3d(new Vector3(46/255f , 158/255f, 94/255f));
            var ayunan2 = new Asset3d(new Vector3(46/255f, 158/255f, 94/255f));
            var ayunan3 = new Asset3d(new Vector3(0, 0, 0));
            var ayunan4 = new Asset3d(new Vector3(0, 0, 0));
            var ayunan5 = new Asset3d(new Vector3(0, 0, 0));
            var ayunan6 = new Asset3d(new Vector3(0, 0, 0));

            var ayunan11 = new Asset3d(new Vector3(46 / 255f, 158 / 255f, 94 / 255f));
            var ayunan21 = new Asset3d(new Vector3(46 / 255f, 158 / 255f, 94 / 255f));
            var ayunan31 = new Asset3d(new Vector3(0, 0, 0));
            var ayunan41 = new Asset3d(new Vector3(0, 0, 0));
            var ayunan51 = new Asset3d(new Vector3(0, 0, 0));
            var ayunan61 = new Asset3d(new Vector3(0, 0, 0));

            var ayunan12 = new Asset3d(new Vector3(46 / 255f, 158 / 255f, 94 / 255f));
            var ayunan22 = new Asset3d(new Vector3(46 / 255f, 158 / 255f, 94 / 255f));
            var ayunan32 = new Asset3d(new Vector3(0, 0, 0));
            var ayunan42 = new Asset3d(new Vector3(0, 0, 0));
            var ayunan52 = new Asset3d(new Vector3(0, 0, 0));
            var ayunan62 = new Asset3d(new Vector3(0, 0, 0));

            var ayunan13 = new Asset3d(new Vector3(46 / 255f, 158 / 255f, 94 / 255f));
            var ayunan23 = new Asset3d(new Vector3(46 / 255f, 158 / 255f, 94 / 255f));
            var ayunan33 = new Asset3d(new Vector3(0, 0, 0));
            var ayunan43 = new Asset3d(new Vector3(0, 0, 0));
            var ayunan53 = new Asset3d(new Vector3(0, 0, 0));
            var ayunan63 = new Asset3d(new Vector3(0, 0, 0));

            var daunPanggung1 = new Asset3d(new Vector3(0.3f, 0.85f, 0.4f));
            var daunPanggung2= new Asset3d(new Vector3(0.3f, 0.85f, 0.4f));
            var daunPanggung3 = new Asset3d(new Vector3(0.3f, 0.85f, 0.4f));
            var daunPanggung4 = new Asset3d(new Vector3(0.3f, 0.85f, 0.4f));

  


            Asset3d kabel = new Asset3d();
            kabel.prepareVertices();
            kabel.setControlCoordinate(-1.8f, 0.5f, -1.55f);
            kabel.setControlCoordinate(-1.8f, 0.5f, -1.55f);
            kabel.setControlCoordinate(1.8f, 0.1f, -1.55f);
            kabel.setControlCoordinate(1.8f, 0.1f, -1.55f);
            kabel.setVertices(kabel.createCurveBazier());



            Asset3d kabel2 = new Asset3d();
            kabel2.prepareVertices();
            kabel2.setControlCoordinate(-1.8f, 0.5f, -1.85f);
            kabel2.setControlCoordinate(-1.8f, 0.5f, -1.85f);
            kabel2.setControlCoordinate(1.8f, 0.1f, -1.85f);
            kabel2.setControlCoordinate(1.8f, 0.1f, -1.85f);
            kabel2.setVertices(kabel2.createCurveBazier());


            Asset3d kabel3 = new Asset3d();
            kabel3.prepareVertices();
            kabel3.setControlCoordinate(-1.55f, 0.48f, -1.55f);
            kabel3.setControlCoordinate(-1.55f, 0.5f, -1.6f);
            kabel3.setControlCoordinate(-1.55f, 0.3f, -1.6f);
            kabel3.setControlCoordinate(-1.55f, 0.3f, -1.6f);
            kabel3.setVertices(kabel3.createCurveBazier());

            Asset3d kabel4 = new Asset3d();
            kabel4.prepareVertices();
            kabel4.setControlCoordinate(-1.55f, 0.48f, -1.85f);
            kabel4.setControlCoordinate(-1.55f, 0.5f, -1.8f);
            kabel4.setControlCoordinate(-1.55f, 0.3f, -1.8f);
            kabel4.setControlCoordinate(-1.55f, 0.3f, -1.8f);
            kabel4.setVertices(kabel4.createCurveBazier());


            Asset3d kabel5 = new Asset3d();
            kabel5.prepareVertices();
            kabel5.setControlCoordinate(-1.55f +1.0f, 0.48f - 0.12f, -1.55f);
            kabel5.setControlCoordinate(-1.55f + 1.0f, 0.5f - 0.12f, -1.6f);
            kabel5.setControlCoordinate(-1.55f + 1.0f, 0.3f - 0.12f, -1.6f);
            kabel5.setControlCoordinate(-1.55f + 1.0f, 0.3f - 0.12f, -1.6f);
            kabel5.setVertices(kabel5.createCurveBazier());

            Asset3d kabel6 = new Asset3d();
            kabel6.prepareVertices();
            kabel6.setControlCoordinate(-1.55f + 1.0f, 0.48f - 0.12f, -1.85f);
            kabel6.setControlCoordinate(-1.55f + 1.0f, 0.5f - 0.12f, -1.8f);
            kabel6.setControlCoordinate(-1.55f + 1.0f, 0.3f - 0.12f, -1.8f);
            kabel6.setControlCoordinate(-1.55f + 1.0f, 0.3f - 0.12f, -1.8f);
            kabel6.setVertices(kabel6.createCurveBazier());


            Asset3d kabel7 = new Asset3d();
            kabel7.prepareVertices();
            kabel7.setControlCoordinate(-1.55f + 2.0f, 0.48f - 0.23f, -1.55f);
            kabel7.setControlCoordinate(-1.55f + 2.0f, 0.5f - 0.23f, -1.6f);
            kabel7.setControlCoordinate(-1.55f + 2.0f, 0.3f - 0.23f, -1.6f);
            kabel7.setControlCoordinate(-1.55f + 2.0f, 0.3f - 0.23f, -1.6f);
            kabel7.setVertices(kabel7.createCurveBazier());

            Asset3d kabel8 = new Asset3d();
            kabel8.prepareVertices();
            kabel8.setControlCoordinate(-1.55f + 2.0f, 0.48f - 0.23f, -1.85f);
            kabel8.setControlCoordinate(-1.55f + 2.0f, 0.5f - 0.23f, -1.8f);
            kabel8.setControlCoordinate(-1.55f + 2.0f, 0.3f - 0.23f, -1.8f);
            kabel8.setControlCoordinate(-1.55f + 2.0f, 0.3f - 0.23f, -1.8f);
            kabel8.setVertices(kabel8.createCurveBazier());


            Asset3d kabel9 = new Asset3d();
            kabel9.prepareVertices();
            kabel9.setControlCoordinate(-1.55f + 3.0f, 0.48f - 0.34f, -1.55f);
            kabel9.setControlCoordinate(-1.55f + 3.0f, 0.5f - 0.34f, -1.6f);
            kabel9.setControlCoordinate(-1.55f + 3.0f, 0.3f - 0.34f, -1.6f);
            kabel9.setControlCoordinate(-1.55f + 3.0f, 0.3f - 0.34f, -1.6f);
            kabel9.setVertices(kabel9.createCurveBazier());

            Asset3d kabel10 = new Asset3d();
            kabel10.prepareVertices();
            kabel10.setControlCoordinate(-1.55f + 3.0f, 0.48f - 0.34f, -1.85f);
            kabel10.setControlCoordinate(-1.55f + 3.0f, 0.5f - 0.34f, -1.8f);
            kabel10.setControlCoordinate(-1.55f + 3.0f, 0.3f - 0.34f, -1.8f);
            kabel10.setControlCoordinate(-1.55f + 3.0f, 0.3f - 0.34f, -1.8f);
            kabel10.setVertices(kabel10.createCurveBazier());

            panggung1.createCylinder(0.9f + 0.9f, -0.255f, -0.825f - 0.73f, 0.05f, 0.325f, 0.05f, 100, 100);
            panggung2.createCylinder(0.9f + 0.9f, -0.255f, -1.125f - 0.73f, 0.05f, 0.325f, 0.05f, 100, 100);
            panggung3.createCylinder(-0.9f + -0.9f, -0.255f, -0.825f - 0.73f, 0.05f, 0.525f, 0.05f, 100, 100);
            panggung4.createCylinder(-0.9f + -0.9f, -0.255f, -1.125f - 0.73f, 0.05f, 0.525f, 0.05f, 100, 100);

            daunPanggung1.createCone(-1.8f, 0.7f, -1.55f, 0.1f, 0.2f, 0.1f, 100, 100);
            daunPanggung1.rotate(daunPanggung1._centerPosition, Vector3.UnitX, 180);

            daunPanggung2.createCone(-1.8f, 0.7f, -1.85f, 0.1f, 0.2f, 0.1f, 100, 100);
            daunPanggung2.rotate(daunPanggung2._centerPosition, Vector3.UnitX, 180);

            daunPanggung3.createCone(1.8f, 1.0f, -1.85f, 0.1f, 0.2f, 0.1f, 100, 100);
            daunPanggung3.rotate(daunPanggung2._centerPosition, Vector3.UnitX, 180);

            daunPanggung4.createCone(1.8f, 1.0f, -2.15f, 0.1f, 0.2f, 0.1f, 100, 100);
            daunPanggung4.rotate(daunPanggung2._centerPosition, Vector3.UnitX, 180);

            ayunan1.createBlock2(-1.5f, 0.2f + 0.05f, -1.7f, 0.13f, 0.0155f, 0.215f);
            ayunan2.createBlock2(-1.55f, 0.25f + 0.05f, -1.7f, 0.02f, 0.1075f, 0.225f);
            ayunan3.createBlock2(-1.52f, 0.25f + 0.05f, -1.58f, 0.08f, 0.01f, 0.02f);
            ayunan4.createBlock2(-1.48f, 0.225f + 0.05f, -1.58f, 0.02f, 0.06f, 0.02f);
            ayunan5.createBlock2(-1.52f, 0.25f + 0.05f, -1.82f, 0.08f, 0.01f, 0.02f);
            ayunan6.createBlock2(-1.48f, 0.225f + 0.05f, -1.82f, 0.02f, 0.06f, 0.02f);

            ayunan11.createBlock2(-1.5f + 1.0f, 0.2f - 0.05f , -1.7f, 0.13f, 0.0155f, 0.215f);
            ayunan21.createBlock2(-1.55f + 1.0f, 0.25f - 0.05f, -1.7f, 0.02f, 0.1075f, 0.225f);
            ayunan31.createBlock2(-1.52f + 1.0f, 0.25f - 0.05f, -1.58f, 0.08f, 0.01f, 0.02f);
            ayunan41.createBlock2(-1.48f + 1.0f, 0.225f - 0.05f, -1.58f, 0.02f, 0.06f, 0.02f);
            ayunan51.createBlock2(-1.52f + 1.0f, 0.25f - 0.05f, -1.82f, 0.08f, 0.01f, 0.02f);
            ayunan61.createBlock2(-1.48f + 1.0f, 0.225f - 0.05f, -1.82f, 0.02f, 0.06f, 0.02f);


            ayunan12.createBlock2(-1.5f + 2.0f, 0.2f - 0.15f, -1.7f, 0.13f, 0.0155f, 0.215f);
            ayunan22.createBlock2(-1.55f + 2.0f, 0.25f - 0.15f, -1.7f, 0.02f, 0.1075f, 0.225f);
            ayunan32.createBlock2(-1.52f + 2.0f, 0.25f - 0.15f, -1.58f, 0.08f, 0.01f, 0.02f);
            ayunan42.createBlock2(-1.48f + 2.0f, 0.225f - 0.15f, -1.58f, 0.02f, 0.06f, 0.02f);
            ayunan52.createBlock2(-1.52f + 2.0f, 0.25f - 0.15f, -1.82f, 0.08f, 0.01f, 0.02f);
            ayunan62.createBlock2(-1.48f + 2.0f, 0.225f - 0.15f, -1.82f, 0.02f, 0.06f, 0.02f);

            ayunan13.createBlock2(-1.5f + 3.0f, 0.2f - 0.25f, -1.7f, 0.13f, 0.0155f, 0.215f);
            ayunan23.createBlock2(-1.55f + 3.0f, 0.25f - 0.25f, -1.7f, 0.02f, 0.1075f, 0.225f);
            ayunan33.createBlock2(-1.52f + 3.0f, 0.25f - 0.25f, -1.58f, 0.08f, 0.01f, 0.02f);
            ayunan43.createBlock2(-1.48f + 3.0f, 0.225f - 0.25f, -1.58f, 0.02f, 0.06f, 0.02f);
            ayunan53.createBlock2(-1.52f + 3.0f, 0.25f - 0.25f, -1.82f, 0.08f, 0.01f, 0.02f);
            ayunan63.createBlock2(-1.48f + 3.0f, 0.225f - 0.25f, -1.82f, 0.02f, 0.06f, 0.02f);

          //  gantungan1.createEllipsoid(0.005f, 0.3f, 0.005f, 1.0f, 1.0f, 1.0f);
        


            tempat1.createRectangle(0, -0.5f, 0, 4.0f, 0.1f);
            tempat2.createBlock2(0, -0.455f, 0.2f, 0.525f, 0.0175f, 3.0f);
            tempath1.createBlock2(0, -0.45f, 0.0f, 0.05f, 0.0175f, 0.2f);
            tempath2.createBlock2(0, -0.45f, 0.5f, 0.05f, 0.0175f, 0.2f);
            tempath3.createBlock2(0, -0.45f, 1.0f, 0.05f, 0.0175f, 0.2f);
            tempath4.createBlock2(0, -0.45f, 1.5f, 0.05f, 0.0175f, 0.2f);
            tempath5.createBlock2(0, -0.45f, -0.5f, 0.05f, 0.0175f, 0.2f);
            tempath6.createBlock2(0, -0.45f, -1.0f, 0.05f, 0.0175f, 0.2f);

            //bagian kiri atas
            pohon1.createCylinder(-0.625f,-0.255f, -0.125f, 0.02f, 0.125f, 0.02f, 100, 100);
            pohon2.createCone(-0.625f, -0.095f, -0.125f, 0.145f, 0.2f, 0.145f, 100, 100);
            pohon2.rotate(pohon2._centerPosition, Vector3.UnitX, 180);
            pohon3.createCone(-0.625f, -0.02f, -0.125f, 0.125f, 0.2f, 0.125f, 100, 100);
            pohon3.rotate(pohon3._centerPosition, Vector3.UnitX, 180);
            pohon4.createCone(-0.625f, 0.055f, -0.125f, 0.1f, 0.2f, 0.1f, 100, 100);
            pohon4.rotate(pohon4._centerPosition, Vector3.UnitX, 180);

           
            pohon11.createCylinder(-0.625f + -0.3f, -0.255f, -0.125f - 0.5f, 0.02f, 0.125f, 0.02f, 100, 100);
            pohon21.createCone(-0.625f + -0.3f, -0.095f, -0.125f + 0.5f, 0.13f, 0.2f, 0.13f, 100, 100);
            pohon21.rotate(pohon2._centerPosition, Vector3.UnitX, 180);
            pohon31.createCone(-0.625f + -0.3f, -0.02f, -0.125f + 0.5f, 0.115f, 0.2f, 0.115f, 100, 100);
            pohon31.rotate(pohon3._centerPosition, Vector3.UnitX, 180);
            pohon41.createCone(-0.625f + -0.3f, 0.055f, -0.125f + 0.5f, 0.105f, 0.2f, 0.105f, 100, 100);
            pohon41.rotate(pohon4._centerPosition, Vector3.UnitX, 180);


            pohon12.createCylinder(-0.625f + -0.7f, -0.255f, -0.125f - 0.3f, 0.02f, 0.125f, 0.02f, 100, 100);
            pohon22.createCone(-0.625f + -0.7f, -0.095f, -0.125f + 0.3f, 0.153f, 0.2f, 0.153f, 100, 100);
            pohon22.rotate(pohon2._centerPosition, Vector3.UnitX, 180);
            pohon32.createCone(-0.625f + -0.7f, -0.02f, -0.125f + 0.3f, 0.125f, 0.2f, 0.125f, 100, 100);
            pohon32.rotate(pohon3._centerPosition, Vector3.UnitX, 180);
            pohon42.createCone(-0.625f + -0.7f, 0.055f, -0.125f + 0.3f, 0.105f, 0.2f, 0.105f, 100, 100);
            pohon42.rotate(pohon4._centerPosition, Vector3.UnitX, 180);


            pohon13.createCylinder(-0.625f + -0.1f, -0.255f, -0.125f - 0.9f, 0.02f, 0.125f, 0.02f, 100, 100);
            pohon23.createCone(-0.625f + -0.1f, -0.095f, -0.125f + 0.9f, 0.153f, 0.2f, 0.153f, 100, 100);
            pohon23.rotate(pohon2._centerPosition, Vector3.UnitX, 180);
            pohon33.createCone(-0.625f + -0.1f, -0.02f, -0.125f + 0.9f, 0.125f, 0.2f, 0.125f, 100, 100);
            pohon33.rotate(pohon3._centerPosition, Vector3.UnitX, 180);
            pohon43.createCone(-0.625f + -0.1f, 0.055f, -0.125f + 0.9f, 0.105f, 0.2f, 0.105f, 100, 100);
            pohon43.rotate(pohon4._centerPosition, Vector3.UnitX, 180);


            pohon14.createCylinder(-0.625f + -0.8f, -0.255f, -0.125f - 0.9f, 0.02f, 0.125f, 0.02f, 100, 100);
            pohon24.createCone(-0.625f + -0.8f, -0.095f, -0.125f + 0.9f, 0.153f, 0.2f, 0.153f, 100, 100);
            pohon24.rotate(pohon2._centerPosition, Vector3.UnitX, 180);
            pohon34.createCone(-0.625f + -0.8f, -0.02f, -0.125f + 0.9f, 0.125f, 0.2f, 0.125f, 100, 100);
            pohon34.rotate(pohon3._centerPosition, Vector3.UnitX, 180);
            pohon44.createCone(-0.625f + -0.8f, 0.055f, -0.125f + 0.9f, 0.105f, 0.2f, 0.105f, 100, 100);
            pohon44.rotate(pohon4._centerPosition, Vector3.UnitX, 180);


            pohon15.createCylinder(-0.625f + -0.4f, -0.255f, -0.125f, 0.02f, 0.125f, 0.02f, 100, 100);
            pohon25.createCone(-0.625f + -0.4f, -0.095f, -0.1f , 0.153f, 0.2f, 0.153f, 100, 100);
            pohon25.rotate(pohon2._centerPosition, Vector3.UnitX, 180);
            pohon35.createCone(-0.625f + -0.4f, -0.02f, -0.1f , 0.125f, 0.2f, 0.125f, 100, 100);
            pohon35.rotate(pohon3._centerPosition, Vector3.UnitX, 180);
            pohon45.createCone(-0.625f + -0.4f, 0.055f, -0.1f , 0.105f, 0.2f, 0.105f, 100, 100);
            pohon45.rotate(pohon4._centerPosition, Vector3.UnitX, 180);

            //kanan bawah

            pohon111.createCylinder(0.625f, -0.255f, 0.575f, 0.02f, 0.125f, 0.02f, 100, 100);
            pohon211.createCone(0.625f, -0.095f, -0.825f, 0.145f, 0.2f, 0.145f, 100, 100);
            pohon211.rotate(pohon2._centerPosition, Vector3.UnitX, 180);
            pohon311.createCone(0.625f, -0.02f, -0.825f, 0.125f, 0.2f, 0.125f, 100, 100);
            pohon311.rotate(pohon3._centerPosition, Vector3.UnitX, 180);
            pohon411.createCone(0.625f, 0.055f, -0.825f, 0.1f, 0.2f, 0.1f, 100, 100);
            pohon411.rotate(pohon4._centerPosition, Vector3.UnitX, 180);


            pohon122.createCylinder(0.625f + 0.5f, -0.255f, 0.825f , 0.02f, 0.125f, 0.02f, 100, 100);
            pohon222.createCone(0.625f + 0.5f, -0.095f, -0.825f - 0.25f, 0.13f, 0.2f, 0.13f, 100, 100);
            pohon222.rotate(pohon2._centerPosition, Vector3.UnitX, 180);
            pohon322.createCone(0.625f + 0.5f, -0.02f, -0.825f - 0.25f, 0.115f, 0.2f, 0.115f, 100, 100);
            pohon322.rotate(pohon3._centerPosition, Vector3.UnitX, 180);
            pohon422.createCone(0.625f + 0.5f, 0.055f, -0.825f - 0.25f, 0.105f, 0.2f, 0.105f, 100, 100);
            pohon422.rotate(pohon4._centerPosition, Vector3.UnitX, 180);


            pohon133.createCylinder(0.625f + 0.7f, -0.255f, 0.125f + 0.3f, 0.02f, 0.125f, 0.02f, 100, 100);
            pohon233.createCone(0.625f + 0.7f, -0.095f, -0.125f - 0.55f, 0.153f, 0.2f, 0.153f, 100, 100);
            pohon233.rotate(pohon2._centerPosition, Vector3.UnitX, 180);
            pohon333.createCone(0.625f + 0.7f, -0.02f, -0.125f - 0.55f, 0.125f, 0.2f, 0.125f, 100, 100);
            pohon333.rotate(pohon3._centerPosition, Vector3.UnitX, 180);
            pohon433.createCone(0.625f + 0.7f, 0.055f, -0.125f - 0.55f, 0.105f, 0.2f, 0.105f, 100, 100);
            pohon433.rotate(pohon4._centerPosition, Vector3.UnitX, 180);

           
            pohon144.createCylinder(0.625f + 0.1f, -0.255f, 0.625f + 0.65f, 0.02f, 0.125f, 0.02f, 100, 100);
            pohon244.createCone(0.625f + 0.1f, -0.095f, -0.625f - 0.9f, 0.153f, 0.2f, 0.153f, 100, 100);
            pohon244.rotate(pohon2._centerPosition, Vector3.UnitX, 180);
            pohon344.createCone(0.625f + 0.1f, -0.02f, -0.625f - 0.9f, 0.125f, 0.2f, 0.125f, 100, 100);
            pohon344.rotate(pohon3._centerPosition, Vector3.UnitX, 180);
            pohon444.createCone(0.625f + 0.1f, 0.055f, -0.625f - 0.9f, 0.105f, 0.2f, 0.105f, 100, 100);
            pohon444.rotate(pohon4._centerPosition, Vector3.UnitX, 180);

            
            pohon155.createCylinder(0.625f + 0.8f, -0.255f, 0.525f + 0.65f, 0.02f, 0.125f, 0.02f, 100, 100);
            pohon255.createCone(0.625f + 0.8f, -0.095f, -0.525f - 0.9f, 0.153f, 0.2f, 0.153f, 100, 100);
            pohon255.rotate(pohon2._centerPosition, Vector3.UnitX, 180);
            pohon355.createCone(0.625f + 0.8f, -0.02f, -0.525f - 0.9f, 0.125f, 0.2f, 0.125f, 100, 100);
            pohon355.rotate(pohon3._centerPosition, Vector3.UnitX, 180);
            pohon455.createCone(0.625f + 0.8f, 0.055f, -0.525f - 0.9f, 0.105f, 0.2f, 0.105f, 100, 100);
            pohon455.rotate(pohon4._centerPosition, Vector3.UnitX, 180);

            pohon156.createCylinder(0.625f + 0.5f, -0.255f, 0.525f + 0.95f, 0.02f, 0.125f, 0.02f, 100, 100);
            pohon256.createCone(0.625f + 0.5f, -0.095f, -0.525f - 1.2f, 0.153f, 0.2f, 0.153f, 100, 100);
            pohon256.rotate(pohon2._centerPosition, Vector3.UnitX, 180);
            pohon356.createCone(0.625f + 0.5f, -0.02f, -0.525f - 1.2f, 0.125f, 0.2f, 0.125f, 100, 100);
            pohon356.rotate(pohon3._centerPosition, Vector3.UnitX, 180);
            pohon456.createCone(0.625f + 0.5f, 0.055f, -0.525f - 1.2f, 0.105f, 0.2f, 0.105f, 100, 100);
            pohon456.rotate(pohon4._centerPosition, Vector3.UnitX, 180);


            pohon157.createCylinder(0.525f, -0.255f, 0.525f + 0.45f, 0.02f, 0.125f, 0.02f, 100, 100);
            pohon257.createCone(0.525f, -0.095f, -0.525f - 0.7f, 0.153f, 0.2f, 0.153f, 100, 100);
            pohon257.rotate(pohon2._centerPosition, Vector3.UnitX, 180);
            pohon357.createCone(0.525f , -0.02f, -0.525f - 0.7f, 0.125f, 0.2f, 0.125f, 100, 100);
            pohon357.rotate(pohon3._centerPosition, Vector3.UnitX, 180);
            pohon457.createCone(0.525f , 0.055f, -0.525f - 0.7f, 0.105f, 0.2f, 0.105f, 100, 100);
            pohon457.rotate(pohon4._centerPosition, Vector3.UnitX, 180);


            helipad.createTorus(-1.0f,-0.45f,1.0f,0.5f,0.02f,100,100);
            helipad2.createTorus(1.0f, -0.45f, -1.0f +0.5f, 0.5f, 0.02f, 100, 100);

            hurufH1.createH1Vertices(-1.3f, -0.3f, 1.2f, 0.28f);
            hurufH1.rotate(hurufH1._centerPosition, Vector3.UnitY, 90);
            hurufH2.createH1Vertices(-0.9f, -0.3f, 1.2f, 0.28f);
            hurufH2.rotate(hurufH2._centerPosition, Vector3.UnitY, 90);
            hurufH3.createH2Vertices(-1.3f, -0.3f, 1.1f, 0.2695f);
            hurufH3.rotate(hurufH3._centerPosition, Vector3.UnitY, 90);


            hurufH11.createH1Vertices(0.7f - 0.5f, -0.3f, 3.2f, 0.28f);
            hurufH11.rotate(hurufH1._centerPosition, Vector3.UnitY, 90);
            hurufH12.createH1Vertices(1.1f - 0.5f, -0.3f, 3.2f, 0.28f);
            hurufH12.rotate(hurufH2._centerPosition, Vector3.UnitY, 90);
            hurufH13.createH2Vertices(0.7f - 0.5f, -0.3f, 3.1f, 0.2695f);
            hurufH13.rotate(hurufH3._centerPosition, Vector3.UnitY, 90);



            baseHeli.Add(tempat1);
            baseHeli.Add(tempat2);
            baseHeli.Add(tempat3);
            baseHeli.Add(tempath1);
            baseHeli.Add(tempath2);
            baseHeli.Add(tempath3);

            baseHeli.Add(tempath4);
            baseHeli.Add(tempath5);
            baseHeli.Add(tempath6);
            baseHeli.Add(pohon1);
            baseHeli.Add(pohon2);
            baseHeli.Add(pohon3);
            baseHeli.Add(pohon4);


            baseHeli.Add(pohon11);
            baseHeli.Add(pohon21);
            baseHeli.Add(pohon31);
            baseHeli.Add(pohon41);



            baseHeli.Add(pohon12);
            baseHeli.Add(pohon22);
            baseHeli.Add(pohon32);
            baseHeli.Add(pohon42);



            baseHeli.Add(pohon13);
            baseHeli.Add(pohon23);
            baseHeli.Add(pohon33);
            baseHeli.Add(pohon43);



            baseHeli.Add(pohon14);
            baseHeli.Add(pohon24);
            baseHeli.Add(pohon34);
            baseHeli.Add(pohon44);

            baseHeli.Add(pohon15);
            baseHeli.Add(pohon25);
            baseHeli.Add(pohon35);
            baseHeli.Add(pohon45);

            baseHeli.Add(pohon111);
            baseHeli.Add(pohon211);
            baseHeli.Add(pohon311);
            baseHeli.Add(pohon411);



            baseHeli.Add(pohon122);
            baseHeli.Add(pohon222);
            baseHeli.Add(pohon322);
            baseHeli.Add(pohon422);



            baseHeli.Add(pohon133);
            baseHeli.Add(pohon233);
            baseHeli.Add(pohon333);
            baseHeli.Add(pohon433);



            baseHeli.Add(pohon144);
            baseHeli.Add(pohon244);
            baseHeli.Add(pohon344);
            baseHeli.Add(pohon444);


            baseHeli.Add(pohon155);
            baseHeli.Add(pohon255);
            baseHeli.Add(pohon355);
            baseHeli.Add(pohon455);

            baseHeli.Add(pohon156);
            baseHeli.Add(pohon256);
            baseHeli.Add(pohon356);
            baseHeli.Add(pohon456);

            baseHeli.Add(pohon157);
            baseHeli.Add(pohon257);
            baseHeli.Add(pohon357);
            baseHeli.Add(pohon457);



            baseHeli.Add(helipad);
            baseHeli.Add(helipad2);
            baseHeli.Add(hurufH1);
            baseHeli.Add(hurufH2);
            baseHeli.Add(hurufH3);
            baseHeli.Add(hurufH11);
            baseHeli.Add(hurufH12);
            baseHeli.Add(hurufH13);
            baseHeli.Add(kabel);
            baseHeli.Add(kabel2);
            baseHeli.Add(panggung1);
            baseHeli.Add(panggung2);
            baseHeli.Add(panggung3);
            baseHeli.Add(panggung4);
            baseHeli.Add(kabel2);

            baseHeli.Add(ayunan1);
            baseHeli.Add(ayunan2);
            baseHeli.Add(ayunan3);
            baseHeli.Add(ayunan4);
            baseHeli.Add(ayunan5);
            baseHeli.Add(ayunan6);


            baseHeli.Add(ayunan11);
            baseHeli.Add(ayunan21);
            baseHeli.Add(ayunan31);
            baseHeli.Add(ayunan41);
            baseHeli.Add(ayunan51);
            baseHeli.Add(ayunan61);


            baseHeli.Add(ayunan12);
            baseHeli.Add(ayunan22);
            baseHeli.Add(ayunan32);
            baseHeli.Add(ayunan42);
            baseHeli.Add(ayunan52);
            baseHeli.Add(ayunan62);


            baseHeli.Add(ayunan13);
            baseHeli.Add(ayunan23);
            baseHeli.Add(ayunan33);
            baseHeli.Add(ayunan43);
            baseHeli.Add(ayunan53);
            baseHeli.Add(ayunan63);

            baseHeli.Add(daunPanggung1);
            baseHeli.Add(daunPanggung2);
            baseHeli.Add(daunPanggung3);
            baseHeli.Add(daunPanggung4);



            baseHeli.Add(kabel3);
            baseHeli.Add(kabel4);

            baseHeli.Add(kabel5);
            baseHeli.Add(kabel6);

            baseHeli.Add(kabel7);
            baseHeli.Add(kabel8);

            baseHeli.Add(kabel9);
            baseHeli.Add(kabel10);


            //  baseHeli.Add(tempath10);

            foreach (Asset3d i in baseHeli)
            {
                i.load(Constants.path + "shader.vert", Constants.path + "shader.frag", x, y);
                
            }




        }


        public void Render(FrameEventArgs args, Camera _camera, KeyboardState input)
        {

          
            Matrix4 temp = Matrix4.Identity;
            _time = 0;



            foreach (Asset3d i in baseHeli)
            {
                i.render(3, _time, temp, _camera.GetViewMatrix(), _camera.GetProjectionMatrix());
               
            }


        }
    }
}
