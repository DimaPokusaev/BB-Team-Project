﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace BrickBreaker
{
    /// <summary>
    /// Ball for Brick Breaker
    /// </summary>
    public class Ball
    {
        public int xSpeed, ySpeed, size;
        public double Xangle, Yangle, x, y;
        public Color colour;

        public static Random rand = new Random();
        
        public Ball(int _x, int _y, int _xSpeed, int _ySpeed, int _ballSize, double _Xangle, double _Yangle)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            size = _ballSize;
            Xangle = _Xangle;
            Yangle = _Yangle;      
        }

        public bool side_collision(Rectangle rec)
        {
            Rectangle ball = new Rectangle(Convert.ToInt32(x), Convert.ToInt32(y), Convert.ToInt32(size), Convert.ToInt32(size));
            if (ball.IntersectsWith(rec))
            {
                return true;
            }
            return false;
        }

        public void Move()
        {
            x = x + xSpeed*Xangle;
            y = y + ySpeed*Yangle;
        }

        //testing method
        public void GameOverMove()
        {
            y = y + ySpeed;
        }

        public void WinMove()
        {
            y = y - ySpeed;
        }

        //testing explosions
        public void ExplosionLeft()
        {
            x = x - size;
            y = y - ySpeed;
        }

        public void ExplosionRight()
        {
            x = x + size;
            y = y - ySpeed;
        }

        public bool BlockCollision(Block b)
        {
            Rectangle blockRec = new Rectangle(Convert.ToInt32(b.x), Convert.ToInt32(b.y), b.width, b.height);
            Rectangle ballRec = new Rectangle(Convert.ToInt32(x), Convert.ToInt32(y), size, size);

            if (ballRec.IntersectsWith(blockRec))
            {
                ySpeed *= -1;
            }

            return blockRec.IntersectsWith(ballRec);         
        }

        public void PaddleCollision(Paddle p, bool pMovingLeft, bool pMovingRight)
        {
            Rectangle ballRec = new Rectangle(Convert.ToInt32(x), Convert.ToInt32(y), size, size);
            Rectangle paddleRec = new Rectangle(p.x, p.y - 2, p.width, p.height);

            if (ballRec.IntersectsWith(paddleRec))
            {
                ySpeed *= -1;

                if (pMovingLeft)
                    xSpeed = -Math.Abs(xSpeed);
                else if (pMovingRight)
                    xSpeed = Math.Abs(xSpeed);

                // Makes the ball have a dinamic angle, comment out to remove the feature
                GameScreen.angleposition = rand.Next(1, 7);
            }
        }

        public void WallCollision(UserControl UC)
        {
            // Collision with left wall
            if (x <= 0)
            {
                x = 1;
                xSpeed *= -1;
            }
            // Collision with right wall
            if (x >= (UC.Width - size))
            {
                x = UC.Width - size - 1;
                xSpeed *= -1;
            }
            // Collision with top wall
            if (y <= 2)
            {
                y = 0;
                ySpeed *= -1;
            }
        }

        public bool BottomCollision(UserControl UC, Paddle p)
        {
            if (y >= UC.Height + 10)
            {
                return true;
            }

            return false;
        }
        //Testing Purposes: Collision Method
        public bool ScoreTracker(Block bl)
        {
            Rectangle ball = new Rectangle(Convert.ToInt32(x), Convert.ToInt32(y), size, size);
            Rectangle block = new Rectangle(bl.x, bl.y, bl.width, bl.height);

            if (ball.IntersectsWith(block))
            {
                //Adding values to score 
                return true;
                
            }
            return false;
        }
    }
}
