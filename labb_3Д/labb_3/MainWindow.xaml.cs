using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SharpDX.Direct2D1;
using SharpDX.Direct3D9;
using System.Windows.Media.Media3D;
using static System.Windows.Media.Media3D.MeshGeometry3D;
using SolidColorBrush = System.Windows.Media.SolidColorBrush;
using System.Reflection;
using System.Runtime.InteropServices;

namespace labb_3
{
    public partial class MainWindow : Window
    {
        ModelVisual3D visual = new ModelVisual3D();
        DiffuseMaterial material = new DiffuseMaterial(new SolidColorBrush(Colors.Red));
        MeshGeometry3D mesh = new MeshGeometry3D();
        GeometryModel3D model = new GeometryModel3D();
        PerspectiveCamera camera = new PerspectiveCamera();
        private Point _lastMousePosition;
        public MainWindow()
        {

            InitializeComponent();
            model.Geometry = mesh;
            model.Material = material;
            visual.Content = model;
            mainViewport.Children.Add(visual);
            
            camera.Position = new Point3D(0, 0, 28); 
            camera.LookDirection = new Vector3D(0, 0, -1);
            camera.UpDirection = new Vector3D(0, 1, 0); 

            
            mainViewport.Camera = camera;

            mainViewport.MouseMove += MainViewport_MouseMove;
            mainViewport.MouseLeftButtonDown += MainViewport_MouseLeftButtonDown;
            mainViewport.MouseLeftButtonUp += MainViewport_MouseLeftButtonUp;

            mesh.Positions.Add(new Point3D(-1, -1, 1)); // 0. 
            mesh.Positions.Add(new Point3D(0.5, -1, 1)); // 1. 
            mesh.Positions.Add(new Point3D(0.5, 5, 1)); // 2. 
            mesh.Positions.Add(new Point3D(-1, 5, 1)); // 3. 
            mesh.Positions.Add(new Point3D(-1, -1, -1)); // 4. 
            mesh.Positions.Add(new Point3D(0.5, -1, -1)); // 5. 
            mesh.Positions.Add(new Point3D(0.5, 5, -1));// 6. 
            mesh.Positions.Add(new Point3D(-1, 5, -1));// 7. 

            mesh.Positions.Add(new Point3D(-1, 3, 1)); // 8. 
            mesh.Positions.Add(new Point3D(-1, 1, 1)); // 9. 
            mesh.Positions.Add(new Point3D(3, 3, 1)); // 10.
            mesh.Positions.Add(new Point3D(3, 1, 1)); // 11.

            mesh.Positions.Add(new Point3D(4, -1, 1)); // 12.
            mesh.Positions.Add(new Point3D(2.5, -1, 1)); // 13.
            mesh.Positions.Add(new Point3D(2.5, 5, 1)); // 14.
            mesh.Positions.Add(new Point3D(4, 5, 1)); // 15.
            mesh.Positions.Add(new Point3D(4, -1, -1)); // 16.
            mesh.Positions.Add(new Point3D(2.5, -1, -1)); // 17.
            mesh.Positions.Add(new Point3D(2.5, 5, -1)); // 18.
            mesh.Positions.Add(new Point3D(4, 5, -1)); // 19.


            mesh.Positions.Add(new Point3D(-3.5, -1, 1));//20 левый низ
            mesh.Positions.Add(new Point3D(-2, -1, 1));//21 правый низ
            mesh.Positions.Add(new Point3D(-2, 1, 1));//22 правый верх
            mesh.Positions.Add(new Point3D(-3.5, 1, 1));//23 левый верх

            mesh.Positions.Add(new Point3D(-3.5, -1, -1));//24 левый низ даль
            mesh.Positions.Add(new Point3D(-2, -1, -1));//25 правый низ даль
            mesh.Positions.Add(new Point3D(-2, 1, -1));//26 правый верх даль
            mesh.Positions.Add(new Point3D(-3.5, 1, -1));//27 левый верх даль

            mesh.TriangleIndices.Add(20); mesh.TriangleIndices.Add(21);
            mesh.TriangleIndices.Add(22);// Спереди.
            mesh.TriangleIndices.Add(22); mesh.TriangleIndices.Add(23);
            mesh.TriangleIndices.Add(20);

            mesh.TriangleIndices.Add(24); mesh.TriangleIndices.Add(25);
            mesh.TriangleIndices.Add(26);// Сзади.
            mesh.TriangleIndices.Add(26); mesh.TriangleIndices.Add(27);
            mesh.TriangleIndices.Add(24);

            mesh.TriangleIndices.Add(21); mesh.TriangleIndices.Add(25);
            mesh.TriangleIndices.Add(26);// Справа.
            mesh.TriangleIndices.Add(26); mesh.TriangleIndices.Add(22);
            mesh.TriangleIndices.Add(21);

            mesh.TriangleIndices.Add(24); mesh.TriangleIndices.Add(20);
            mesh.TriangleIndices.Add(23);// Слева.
            mesh.TriangleIndices.Add(23); mesh.TriangleIndices.Add(27);
            mesh.TriangleIndices.Add(24);

            mesh.TriangleIndices.Add(20); mesh.TriangleIndices.Add(21);
            mesh.TriangleIndices.Add(25);// Снизу.
            mesh.TriangleIndices.Add(25); mesh.TriangleIndices.Add(24);
            mesh.TriangleIndices.Add(20);

            mesh.TriangleIndices.Add(23); mesh.TriangleIndices.Add(22);
            mesh.TriangleIndices.Add(26);// Сверху.
            mesh.TriangleIndices.Add(26); mesh.TriangleIndices.Add(27);
            mesh.TriangleIndices.Add(23);

            mesh.Positions.Add(new Point3D(-7.5, -1, 1));//28 левый низ
            mesh.Positions.Add(new Point3D(-6, -1, 1));//29 правый низ
            mesh.Positions.Add(new Point3D(-6, 1, 1));//30 правый верх
            mesh.Positions.Add(new Point3D(-7.5, 1, 1));//31 левый верх

            mesh.Positions.Add(new Point3D(-7.5, -1, -1));//32 левый низ даль
            mesh.Positions.Add(new Point3D(-6, -1, -1));//33 правый низ даль
            mesh.Positions.Add(new Point3D(-6, 1, -1));//34 правый верх даль
            mesh.Positions.Add(new Point3D(-7.5, 1, -1));//35 левый верх даль

            mesh.TriangleIndices.Add(28); mesh.TriangleIndices.Add(29);
            mesh.TriangleIndices.Add(30);// Спереди.
            mesh.TriangleIndices.Add(30); mesh.TriangleIndices.Add(31);
            mesh.TriangleIndices.Add(28);

            mesh.TriangleIndices.Add(32); mesh.TriangleIndices.Add(33);
            mesh.TriangleIndices.Add(34);// Сзади.
            mesh.TriangleIndices.Add(34); mesh.TriangleIndices.Add(35);
            mesh.TriangleIndices.Add(32);

            mesh.TriangleIndices.Add(29); mesh.TriangleIndices.Add(33);
            mesh.TriangleIndices.Add(34);// Справа.
            mesh.TriangleIndices.Add(34); mesh.TriangleIndices.Add(30);
            mesh.TriangleIndices.Add(29);

            mesh.TriangleIndices.Add(32); mesh.TriangleIndices.Add(28);
            mesh.TriangleIndices.Add(31);// Слева.
            mesh.TriangleIndices.Add(31); mesh.TriangleIndices.Add(35);
            mesh.TriangleIndices.Add(32);

            mesh.TriangleIndices.Add(28); mesh.TriangleIndices.Add(29);
            mesh.TriangleIndices.Add(33);// Снизу.
            mesh.TriangleIndices.Add(33); mesh.TriangleIndices.Add(32);
            mesh.TriangleIndices.Add(28);

            mesh.TriangleIndices.Add(31); mesh.TriangleIndices.Add(30);
            mesh.TriangleIndices.Add(34);// Сверху.
            mesh.TriangleIndices.Add(34); mesh.TriangleIndices.Add(35);
            mesh.TriangleIndices.Add(31);

            //Нижняя палка
            mesh.Positions.Add(new Point3D(-7, 1, 1));//36 левый низ
            mesh.Positions.Add(new Point3D(-3, 1, 1));//37 правый низ
            mesh.Positions.Add(new Point3D(-3, 2, 1));//38 правый верх
            mesh.Positions.Add(new Point3D(-7, 2, 1));//39 левый верх

            mesh.TriangleIndices.Add(36); mesh.TriangleIndices.Add(37);
            mesh.TriangleIndices.Add(38);// Спереди.
            mesh.TriangleIndices.Add(38); mesh.TriangleIndices.Add(39);
            mesh.TriangleIndices.Add(36);

            //левая палка
            mesh.Positions.Add(new Point3D(-7, 1.5, 1));//40 левый низ
            mesh.Positions.Add(new Point3D(-6, 1.5, 1));//41 правый низ
            mesh.Positions.Add(new Point3D(-6, 5, 1));//42 правый верх
            mesh.Positions.Add(new Point3D(-7, 5, 1));//43 левый верх

            mesh.TriangleIndices.Add(40); mesh.TriangleIndices.Add(41);
            mesh.TriangleIndices.Add(42);// Спереди.
            mesh.TriangleIndices.Add(42); mesh.TriangleIndices.Add(43);
            mesh.TriangleIndices.Add(40);

            //Верхняя палка
            mesh.Positions.Add(new Point3D(-7, 5, 1));//44 левый низ
            mesh.Positions.Add(new Point3D(-3, 5, 1));//45 правый низ
            mesh.Positions.Add(new Point3D(-3, 7, 1));//46 правый верх
            mesh.Positions.Add(new Point3D(-7, 7, 1));//47 левый верх

            mesh.TriangleIndices.Add(44); mesh.TriangleIndices.Add(45);
            mesh.TriangleIndices.Add(46);// Спереди.
            mesh.TriangleIndices.Add(46); mesh.TriangleIndices.Add(47);
            mesh.TriangleIndices.Add(44);

            //правая палка 
            mesh.Positions.Add(new Point3D(-4, 1.5, 1));//48 левый низ
            mesh.Positions.Add(new Point3D(-3, 1.5, 1));//49 правый низ
            mesh.Positions.Add(new Point3D(-3, 5, 1));//50 правый верх
            mesh.Positions.Add(new Point3D(-4, 5, 1));//51 левый верх

            mesh.TriangleIndices.Add(48); mesh.TriangleIndices.Add(49);
            mesh.TriangleIndices.Add(50);// Спереди.
            mesh.TriangleIndices.Add(50); mesh.TriangleIndices.Add(51);
            mesh.TriangleIndices.Add(48);

        }
        private void MainViewport_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _lastMousePosition = e.GetPosition(mainViewport);
        }

        private void MainViewport_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Point newMousePosition = e.GetPosition(mainViewport);
                double deltaX = newMousePosition.X - _lastMousePosition.X;
                double deltaY = newMousePosition.Y - _lastMousePosition.Y;

                
                double angleX = deltaX * -1;
                double angleY = deltaY * -1;

                
                RotateTransform3D rotateTransformX = new RotateTransform3D(new AxisAngleRotation3D(new Vector3D(1, 0, 0), angleY));
                RotateTransform3D rotateTransformY = new RotateTransform3D(new AxisAngleRotation3D(new Vector3D(0, 1, 0), -angleX));

                
                Transform3DGroup transformGroup = new Transform3DGroup();
                transformGroup.Children.Add(rotateTransformX);
                transformGroup.Children.Add(rotateTransformY);
                model.Transform = transformGroup;

                _lastMousePosition = newMousePosition;
            }
        }

        private void MainViewport_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            _lastMousePosition = new Point();
        }
    }
}