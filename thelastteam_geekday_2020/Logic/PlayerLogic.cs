﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using thelastteam_geekday_2020.Models;

namespace thelastteam_geekday_2020.Logic
{
    public class PlayerLogic
    {
        Data data;
        IEnumerable<Item> walls;
        IEnumerable<UnitData> units;

        Array movements = Enum.GetValues(typeof(movement));
        Random R = new Random();

        public string action()
        {
            return movements.GetValue(R.Next(movements.Length)).ToString();
        }
        public void addData(Data data)
        {
            this.data = data;
            this.walls = data.Items.Select(i => new Item { X = i.X, Y = i.Y, ItemId = i.ItemId });
            this.units = data.UnitDatas.Select(i => new UnitData { UnitId = i.UnitId,Ammo=i.Ammo, HealthPoint= i.HealthPoint, X= i.X, Y=i.Y }); 
        }

        public List<Item> notWall()
        {
            return walls.Where(x => x.ItemId != 1).ToList();
        }
        public IEnumerable<Player> PlayerMove() 
        {
            List<Player> players = new List<Player>();
            List<Item> enemies = notWall();
            for (int i = 0; i < 3; i++)
            {
                foreach (var item in units)
                {
                    var act = action();
                    Player temp = new Player();
                    temp.UnitId = item.UnitId;
                    if (act == "Shoot")
                    {
                        temp.TargetId = enemies[R.Next(0, enemies.Count())].ItemId;
                    }
                    temp.Action = act;
                    players.Add(temp);
                }
            }        

            return players;
        }

        public Data readData()
        {
            return this.data;
        }


        bool check(int x, int y)
        {
            
            foreach (var w in walls)
            {
                if (w.X == x && w.Y == y)
                {
                    return true;
                }
            }
            return false;
        }

        public string writeData()
        {
            StringBuilder b = new StringBuilder();

            for (int y = 1; y < 701; y++)
            {
                    for (int x = 1; x < 1001; x++)
                    {
                        if (this.check(x,y))
                        {
                            b.Append('|');
                        }
                        else
                        {
                            b.Append('.');
                        }
                    }
                b.AppendLine();
            }
            return b.ToString();
        }
    }
}