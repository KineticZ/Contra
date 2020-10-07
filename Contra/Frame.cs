using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contra
{
    class Frame
    {
        public Rectangle CutoutFrame { get; set; }
        public Vector2 RotationOrigin
        {
            get
            {
                return RotationOrigin;
            }
            set
            {
                float x = CutoutFrame.X + (int)OriginOffset.X;
                float y = CutoutFrame.Y + (int)OriginOffset.Y;
                new Vector2(x, y);
            }
        }
        public Vector2 OriginOffset { get; set; }
        public Frame(Rectangle CutoutFrame, Vector2 OriginOffset)
        {
            this.CutoutFrame = CutoutFrame;
            this.OriginOffset = OriginOffset;
        }
    }
}
