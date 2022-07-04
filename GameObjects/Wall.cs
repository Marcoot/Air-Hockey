using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace SimPhy_Jun2022.GameObjects
{
    class Wall : SpriteGameObject
    {
        //wall met in argument een positie
        public Wall(Vector2 position, String assetName) : base(assetName)
        {
            this.position = position;
        }
    }
}
