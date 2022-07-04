using Microsoft.Xna.Framework;
using SimPhy_Jun2021.GameObjects;
using SimPhy_Jun2022.GameObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseProject.GameStates
{
    class PlayingState : GameObjectList
    {
        private PlayerCircle player;
        Puck puck;
        Wall upperWall, lowerWall, leftWall, rightWall;
        Pusher pusher;
        Obstacle obstacle;

        /// <summary>
        /// PlayState constructor which adds the different gameobjects and lists in the correct order of drawing.
        /// </summary>
        public PlayingState()
        {
            player = new PlayerCircle(new Vector2(400, 300), "circle");
            Add(player);

            pusher = new Pusher(Vector2.Zero);
            Add(pusher);

            puck = new Puck(Vector2.Zero);
            Add(puck);

            obstacle = new Obstacle(Vector2.Zero);
            Add(obstacle);

            upperWall = new Wall(Vector2.Zero, "spr_wall");
            Add(upperWall);

            lowerWall = new Wall(Vector2.Zero, "spr_wall");
            Add(lowerWall);

            leftWall = new Wall(Vector2.Zero, "spr_wall_gate");
            Add(leftWall);

            rightWall = new Wall(Vector2.Zero, "spr_wall_gate");
            Add(rightWall);

            // Add initialization logic here
        }

        /// <summary>
        /// Updates the PlayState.
        /// </summary>
        /// <param name="gameTime"></param>
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            // Add update logic here
        }
    }

}
