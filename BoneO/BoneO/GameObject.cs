using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoneO
{
    class GameObject
    {
        //Fields
        private Texture2D _texture;
        private Vector2 _position;
        private Color _color;

        //Properties
        public Texture2D Texture
        {
            get { return _texture; }
            set { _texture = value; }
        }

        public Vector2 Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        //Constructor
        public GameObject(Texture2D texture, Vector2 position, Color color)
        {
            _texture = texture;
            _position = position;
            _color = color;
        }

        //Methods
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _position, _color);
        }

        public void randomFunctionToTestGitHub()
        {
            Console.WriteLine("testertsz");
        }
			
        public void hallo()
        {
            Console.WriteLine("dwa");
        }
    }
}
