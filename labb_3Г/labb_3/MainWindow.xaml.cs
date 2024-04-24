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
            
            camera.Position = new Point3D(0, 0, 25); 
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

            mesh.Positions.Add(new Point3D(-1, 5, 1)); // 8. 
            mesh.Positions.Add(new Point3D(-1, 3, 1)); // 9. 
            mesh.Positions.Add(new Point3D(3, 5, 1)); // 10.
            mesh.Positions.Add(new Point3D(3, 3, 1)); // 11.


            mesh.TriangleIndices.Add(0); mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2); // Спереди.
            mesh.TriangleIndices.Add(2); mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(1); mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(6); // Справа.
            mesh.TriangleIndices.Add(1); mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(3); mesh.TriangleIndices.Add(2);
            mesh.TriangleIndices.Add(6); // Сверху.
            mesh.TriangleIndices.Add(3); mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(0); mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(1); // Снизу.
            mesh.TriangleIndices.Add(0); mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(0); mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(7); // Слева.
            mesh.TriangleIndices.Add(0); mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(7); mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(5); // Сзади.
            mesh.TriangleIndices.Add(7); mesh.TriangleIndices.Add(5);
            mesh.TriangleIndices.Add(4);

            mesh.TriangleIndices.Add(8); mesh.TriangleIndices.Add(9);
            mesh.TriangleIndices.Add(10);

            mesh.TriangleIndices.Add(11); mesh.TriangleIndices.Add(10);
            mesh.TriangleIndices.Add(9);

           
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