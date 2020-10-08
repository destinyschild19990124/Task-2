using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class GameEngine
    {

        private Map map;

        public GameEngine(int min_width,int max_width,int min_height,int max_height,int num_enemies)
        {
            map = new Map(min_width, max_width, min_height, max_height, num_enemies);
        }

        public Tile[,] getMapView()
        {
            return map.getMap();
        }

        public int getWidth()
        {
            return map.getWidth();
        }

        public int getHeight()
        {
            return map.getHeight();
        }

        public string getHeroStats()
        {
            return map.getHero().ToString();
        }

        public string getEnemiesRemaining()
        {
            string info = "";

            for(int i = 0; i < map.getEnemies().Length; ++i)
            {
                if (i <= 5)
                {
                    info += map.getEnemies()[i].ToString() + "\n\n";
                }
            }

            if (map.getEnemies().Length > 6)
            {
                info += "+" + (map.getEnemies().Length - 6) + " more enem" + ((map.getEnemies().Length - 6)>1?"ies":"y");
            }

            return info;
        }

        public string getAttackingOptions()
        {
            string info = "";

            if(map.getHero().getVision()[0] is Enemy) { info += "[UP]  " + map.getHero().getVision()[0].ToString() + "\n\n"; }
            if(map.getHero().getVision()[1] is Enemy) { info += "[DOWN]  " + map.getHero().getVision()[1].ToString() + "\n\n"; }
            if(map.getHero().getVision()[2] is Enemy) { info += "[LEFT]  " + map.getHero().getVision()[2].ToString() + "\n\n"; }
            if(map.getHero().getVision()[3] is Enemy) { info += "[RIGHT]  " + map.getHero().getVision()[3].ToString() + "\n\n"; }

            return info;
        }

        public Boolean movePlayer(Character.Movement dir)
        {
            if (map.getHero().returnMove(dir) != Character.Movement.None)
            {
                map.updateCharaterPosition(map.getHero(), dir);
                moveEnemies();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool remainStill()
        {
            moveEnemies();
            return true;
        }

        private void moveEnemies()
        {
            Enemy[] enemies = map.getEnemies();

            for(int i = 0; i < enemies.Length; ++i)
            {
                Character.Movement direction = enemies[i].returnMove(Character.Movement.None);  //None is just a placeholder
                map.updateCharaterPosition(enemies[i], direction);
            }
        }

        public String attackEnemy(Character.Movement dir)
        {
            Hero h = map.getHero();
            Tile target = new EmptyTile(0,0); // Set as an empty tile for placeholding

            switch (dir)
            {
                case Character.Movement.Up:
                    target = map.getMap()[h.getY() - 1, h.getX()];
                    break;
                case Character.Movement.Down:
                    target = map.getMap()[h.getY() + 1, h.getX()];
                    break;
                case Character.Movement.Left:
                    target = map.getMap()[h.getY(), h.getX() - 1];
                    break;
                case Character.Movement.Right:
                    target = map.getMap()[h.getY(), h.getX() + 1];
                    break;
            }

            if(target is Enemy)
            {

                h.attack((Character)target);
                Character c_target = (Character)target;

                if (c_target.isDead())
                {
                    map.removeFromMap(c_target);
                }

                moveEnemies();

                if (!c_target.isDead())
                {
                    return "1" + c_target.ToString();     //Returning 1 infront of string indicates success
                }
                else
                {
                    return "1The enemy is dead";    
                }
                
            }
            else
            {
                return "0";                         //Returning 0 infront of string indicates failure
            }

            
        }

    }
}
