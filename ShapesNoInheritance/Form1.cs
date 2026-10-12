using ShapesInheritanceExample;
using System.Collections;

namespace ShapesInheritanceExample
{
    public partial class Form1 : Form
    {

        ArrayList Shapes = new ArrayList();
       
        public Form1()
        {
            InitializeComponent();

            //add a few shapes
            Shapes.Add(new Circle(Color.Purple, 10, 100, 100)); //create a red circle at (10,100) of radius 100
            Shapes.Add(new Circle(Color.Chartreuse, 100, 10, 50)); //apparently it's green
            Shapes.Add(new Rect(Color.Blue, 150, 150, 50, 100));
            Shapes.Add(new Circle(Color.Red, 10, 100, 100)); //why does the rectangle disappear now that we've changed the handling code?
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("paint called");
            Graphics g = e.Graphics;


            for (int i = 0; i < Shapes.Count; i++)
            {
                Shape S;

                S = (Shape)Shapes[i];
                S.draw(g);
                Console.WriteLine(S.ToString());

            }
           
        }
    }
}