using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace SimPhy_Jun2022.GameObjects
{
    class Puck : SpriteGameObject
    {
        public Puck(Vector2 startPosition) : base("spr_puck")
        {
            this.position = startPosition;
        }
    }
}
