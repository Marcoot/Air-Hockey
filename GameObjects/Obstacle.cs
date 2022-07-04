using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace SimPhy_Jun2022.GameObjects
{
    class Obstacle : SpriteGameObject
    {
        public Obstacle(Vector2 position) : base("spr_obstacle")
        {
            this.position = position;
        }
    }
}
