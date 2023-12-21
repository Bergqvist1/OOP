using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace OOP
{
    public class Wernow: Enemy
    {
        private Vector2 position;

        private Texture2D texture;

        private Player target;

        public Wernow(Texture2D texture, Player target)
        {
            this.texture = texture;
            this.target = target;

            position = new Vector2(100,100);
        }

        public void Update()
        {
            Vector2 direction = target.Position - position;
            direction.Normalize();

            position += direction;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle rec = new Rectangle();
            rec.Location = position.ToPoint();
            rec.Width = 25;
            rec.Height = 50;
            spriteBatch.Draw(texture, rec, Color.DarkRed);
        }
    }
}