using System;
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

        public void addData(Data data)
        {
            this.data = data;
        }

        public Player[] PlayerMove()
        {
            return null;
        }

        public Data readData()
        {
            return this.data;
        }


        bool check(int x, int y, IEnumerable<Item> walls)
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
            IEnumerable<Item> walls = data.Items.Select(i => new Item { X = i.X, Y = i.Y, ItemId=i.ItemId });

            for (int y = 1; y < 701; y++)
            {
                    for (int x = 1; x < 1001; x++)
                    {
                        if (this.check(x,y,walls))
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