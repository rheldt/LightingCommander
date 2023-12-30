using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LightingCommander.Controls
{
    // Adapted from: stackoverflow.com/questions/416897/how-do-i-rotate-a-label-in-c/1088958
    public class DarkLabel : Label
    {
        private double _RotationAngle;
        private string _Text;
        private Orientation _TextOrientation;
        private Direction _TextDirection;

        public DarkLabel()
        {
            _RotationAngle = 0d;
            _TextOrientation = Orientation.Rotate;
            this.Size = new Size(20, 230);
            this.Margin = new Padding(0, 0, 10, 0);
            this.Padding = new Padding(0);
        }

        [Description("Rotation Angle"), Category("Appearance")]
        public double RotationAngle
        {
            get
            {
                return _RotationAngle;
            }
            set
            {
                _RotationAngle = value;
                this.Invalidate();
            }
        }

        [Description("Kind of Text Orientation"), Category("Appearance")]
        public Orientation TextOrientation
        {
            get
            {
                return _TextOrientation;
            }
            set
            {
                _TextOrientation = value;
                this.Invalidate();
            }
        }

        [Description("Direction of the Text"), Category("Appearance")]
        public Direction TextDirection
        {
            get
            {
                return _TextDirection;
            }
            set
            {
                _TextDirection = value;
                this.Invalidate();
            }
        }

        [Description("Display Text"), Category("Appearance")]
        public override string Text
        {
            get
            {
                return _Text;
            }
            set
            {
                _Text = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.Trimming = StringTrimming.None;

            Brush textBrush = new SolidBrush(this.ForeColor);

            //Getting the width and height of the text, which we are going to write
            float width = graphics.MeasureString(_Text, this.Font).Width;
            float height = graphics.MeasureString(_Text, this.Font).Height;

            //The radius is set to 0.9 of the width or height, b'cos not to
            //hide and part of the text at any stage
            float radius = 0f;
            if (ClientRectangle.Width < ClientRectangle.Height)
            {
                radius = ClientRectangle.Width * 0.9f / 2;
            }
            else
            {
                radius = ClientRectangle.Height * 0.9f / 2;
            }

            //Setting the text according to the selection
            switch (_TextOrientation)
            {
                case Orientation.Arc:
                    {
                        //Arc angle must be get from the length of the text.
                        float arcAngle = (2 * width / radius) / _Text.Length;
                        if (_TextDirection == Direction.Clockwise)
                        {
                            for (int i = 0; i < _Text.Length; i++)
                            {
                                graphics.TranslateTransform(
                                    (float)(radius * (1 - Math.Cos(arcAngle * i + _RotationAngle / 180 * Math.PI))),
                                    (float)(radius * (1 - Math.Sin(arcAngle * i + _RotationAngle / 180 * Math.PI))));
                                graphics.RotateTransform((-90 + (float)_RotationAngle + 180 * arcAngle * i / (float)Math.PI));
                                graphics.DrawString(_Text[i].ToString(), this.Font, textBrush, 0, 0);
                                graphics.ResetTransform();
                            }
                        }
                        else
                        {
                            for (int i = 0; i < _Text.Length; i++)
                            {
                                graphics.TranslateTransform(
                                    (float)(radius * (1 - Math.Cos(arcAngle * i + _RotationAngle / 180 * Math.PI))),
                                    (float)(radius * (1 + Math.Sin(arcAngle * i + _RotationAngle / 180 * Math.PI))));
                                graphics.RotateTransform((-90 - (float)_RotationAngle - 180 * arcAngle * i / (float)Math.PI));
                                graphics.DrawString(_Text[i].ToString(), this.Font, textBrush, 0, 0);
                                graphics.ResetTransform();
                            }
                        }
                        break;
                    }
                case Orientation.Circle:
                    {
                        if (_TextDirection == Direction.Clockwise)
                        {
                            for (int i = 0; i < _Text.Length; i++)
                            {
                                graphics.TranslateTransform(
                                    (float)(radius * (1 - Math.Cos((2 * Math.PI / _Text.Length) * i + _RotationAngle / 180 * Math.PI))),
                                    (float)(radius * (1 - Math.Sin((2 * Math.PI / _Text.Length) * i + _RotationAngle / 180 * Math.PI))));
                                graphics.RotateTransform(-90 + (float)_RotationAngle + (360 / _Text.Length) * i);
                                graphics.DrawString(_Text[i].ToString(), this.Font, textBrush, 0, 0);
                                graphics.ResetTransform();
                            }
                        }
                        else
                        {
                            for (int i = 0; i < _Text.Length; i++)
                            {
                                graphics.TranslateTransform(
                                    (float)(radius * (1 - Math.Cos((2 * Math.PI / _Text.Length) * i + _RotationAngle / 180 * Math.PI))),
                                    (float)(radius * (1 + Math.Sin((2 * Math.PI / _Text.Length) * i + _RotationAngle / 180 * Math.PI))));
                                graphics.RotateTransform(-90 - (float)_RotationAngle - (360 / _Text.Length) * i);
                                graphics.DrawString(_Text[i].ToString(), this.Font, textBrush, 0, 0);
                                graphics.ResetTransform();
                            }

                        }
                        break;
                    }

                case Orientation.Rotate:
                    {
                        //For rotation, who about rotation?
                        double angle = (_RotationAngle / 180) * Math.PI;
                        graphics.TranslateTransform(
                            (ClientRectangle.Width + (float)(height * Math.Sin(angle)) - (float)(width * Math.Cos(angle))) / 2,
                            (ClientRectangle.Height - (float)(height * Math.Cos(angle)) - (float)(width * Math.Sin(angle))) / 2);
                        graphics.RotateTransform((float)_RotationAngle);
                        graphics.DrawString(_Text, this.Font, textBrush, 0, 0);
                        graphics.ResetTransform();

                        break;
                    }
            }
        }

        public enum Orientation
        {
            Circle,
            Arc,
            Rotate
        }

        public enum Direction
        {
            Clockwise,
            AntiClockwise
        }
    }
}