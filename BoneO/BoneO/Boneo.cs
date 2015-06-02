using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoneO
{
    class Boneo : GameObject
    {
        //Fields
        private float _speed;
        private int _health;
        private int _bones;

        //Properties
        public void loseHealth(int damage)
        {
            _health -= damage;
        }

        //Constructor
        public Boneo(Texture2D texture, Vector2 position, Color color, int bones)
            : base(texture, position, color)
        {
            _speed = 1;
            _health = 3;
            _bones = bones;
        }

        //Methods
        public void Move(Viewport viewport)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Left) && !Keyboard.GetState().IsKeyDown(Keys.Right) && Position.X > 0)
            {
                Position = new Vector2(Position.X - _speed, Position.Y);
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Right) && !Keyboard.GetState().IsKeyDown(Keys.Left) && Position.X + Texture.Width > viewport.Width)
            {
                Position = new Vector2(Position.X + _speed, Position.Y);
            }
        }

        public void Throw()
        {

        }
    }
}
