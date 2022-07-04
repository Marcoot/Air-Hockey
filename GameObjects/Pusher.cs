using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace SimPhy_Jun2022.GameObjects
{
    class Pusher : SpriteGameObject
    {
        public Pusher(Vector2 startPosition) : base("spr_pusher")
        {
            this.position = startPosition;
        }
    }
}
