namespace Sandbox.Source {

    public class Sprite {


        public int OriginX { get; set; }
        public int OriginY { get; set; }
        public int Radius { get; set; } = 5;

        public int VelocityX { get; set; }
        public int VelocityY { get; set; }

        public float ScaleX { get; set; } = 1.0F;
        public float ScaleY { get; set; } = 1.0F;

        public int RotationAngle { get; set; }
        public int RotationVelocity { get; set; }

        public string Markup { get; set; } = String.Empty;
        public string InternalMarkup { get; set; } = String.Empty;


        public Sprite(int x, int y) {

            OriginX = x;
            OriginY = y;

        }

        public void Draw() {

            OriginX += VelocityX;
            OriginY += VelocityY;
            RotationAngle += RotationVelocity;

            Markup = $"<g transform=\"translate({OriginX} {OriginY}) rotate({RotationAngle}) scale({ScaleX} {ScaleY})\">{InternalMarkup}</g>";

        }

        

    }
}