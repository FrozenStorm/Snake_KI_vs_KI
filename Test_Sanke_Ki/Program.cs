using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Drawing;

namespace Test_Pong_Ki
{
    class Program
    {
        List<Point> Pathpoints = new List<Point>();

        readonly int mo_player_left_head = 1;
        readonly int mo_player_left_body = 2;
        readonly int mo_player_right_head = 3;
        readonly int mo_player_right_body = 4;
        readonly int mo_wall = 9;
        readonly int mo_nothing = 0;
        readonly int mo_egg = 8;

        int[,] map;
        int player_nummer;
        Point player;
        Point end;
        int size_x;
        int size_y;
        String s="";

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            while (true)
            {
                myProgram.s = System.Console.ReadLine();
                if (myProgram.s == "end") return;
                myProgram.init();
                System.Console.Out.WriteLine(myProgram.pathfinding(myProgram.map, myProgram.player, myProgram.end));
            }
        }
        private void init()
        {//spieler x y 1,2,3,4,5,5,6
            String temp = "";

            temp = s[0].ToString() + s[1].ToString();
            player_nummer = Convert.ToInt16(temp);
            s = s.Remove(0, 3);

            temp = s[0].ToString() + s[1].ToString();
            size_x = Convert.ToInt16(temp);
            s = s.Remove(0, 3);

            temp = s[0].ToString() + s[1].ToString();
            size_y = Convert.ToInt16(temp);
            s = s.Remove(0, 3);
            map = new int[size_x,size_y];
            for (int y = 0; y < size_y; y++)
            {
                for (int x = 0; x < size_x; x++)
                {
                    temp = s[0].ToString() + s[1].ToString();
                    map[x, y] = Convert.ToInt16(temp);
                    if (map[x, y] == player_nummer) player = new Point(x, y);
                    if (map[x, y] == mo_egg) end = new Point(x, y);
                    s = s.Remove(0, 3);
                }
            }/*
            for (int y = 0; y < size_y; y++)
            {
                for (int x = 0; x < size_x; x++)
                {
                    if (player_nummer == mo_player_left_head)
                    {
                        if (map[x, y] == mo_player_right_head)
                        {
                            if (map[x + 1, y] == mo_nothing) map[x + 1, y] = mo_player_right_body;
                            if (map[x - 1, y] == mo_nothing) map[x - 1, y] = mo_player_right_body;
                            if (map[x, y + 1] == mo_nothing) map[x, y + 1] = mo_player_right_body;
                            if (map[x, y - 1] == mo_nothing) map[x, y - 1] = mo_player_right_body;
                        }
                    }
                    if (player_nummer == mo_player_right_head)
                    {
                        if (map[x, y] == mo_player_left_head)
                        {
                            if (map[x + 1, y] == mo_nothing) map[x + 1, y] = mo_player_left_body;
                            if (map[x - 1, y] == mo_nothing) map[x - 1, y] = mo_player_left_body;
                            if (map[x, y + 1] == mo_nothing) map[x, y + 1] = mo_player_left_body;
                            if (map[x, y - 1] == mo_nothing) map[x, y - 1] = mo_player_left_body;
                        }
                    }
                }
            }*/
        }
        private string pathfinding(int[,] Map, Point Beginn, Point Finish)
        {
            int x;
            int y;
            int z = 0;
            int lastindex = 0;
            bool foundway = false;
            List<Knoten> myKnoten = new List<Knoten>();
            Pathpoints = new List<Point>();
            myKnoten.Add(new Knoten(z, Beginn.X, Beginn.Y));
            try
            {
                while (foundway == false)
                {
                    
                    x = myKnoten[z].Now_x;
                    y = myKnoten[z].Now_y;
                    if (new Point(x,y) == Finish)
                    {
                        foundway = true;
                    }
                    else
                    {
                        try
                        {
                            if (((Map[x + 1, y] == mo_nothing) || (Map[x + 1, y] == mo_egg)) && (knotenschonvorhanden(myKnoten, x + 1, y, lastindex) == false))
                            {
                                myKnoten.Add(new Knoten(z, x + 1, y));
                                lastindex++;
                            }
                        }
                        catch { }
                        try
                        {
                            if (((Map[x - 1, y] == mo_nothing) || (Map[x - 1, y] == mo_egg)) && (knotenschonvorhanden(myKnoten, x - 1, y, lastindex) == false))
                            {
                                myKnoten.Add(new Knoten(z, x - 1, y));
                                lastindex++;
                            }
                        }
                        catch { }
                        try
                        {
                            if (((Map[x, y + 1] == mo_nothing) || (Map[x, y + 1] == mo_egg)) && (knotenschonvorhanden(myKnoten, x, y + 1, lastindex) == false))
                            {
                                myKnoten.Add(new Knoten(z, x, y + 1));
                                lastindex++;
                            }
                        }
                        catch { }
                        try
                        {
                            if (((Map[x, y - 1] == mo_nothing) || (Map[x, y - 1] == mo_egg)) && (knotenschonvorhanden(myKnoten, x, y - 1, lastindex) == false))
                            {
                                myKnoten.Add(new Knoten(z, x, y - 1));
                                lastindex++;
                            }
                        }
                        catch { }
                        if (z < lastindex) z++;
                        else return "not found";
                    }
                }
            }
            catch { }
            int zcopy = 0;
            while (z > 0)
            {
                Pathpoints.Add(new Point(myKnoten[z].Now_x, myKnoten[z].Now_y));
                z = myKnoten[z].From_z;
                zcopy++;
            }
            Pathpoints.Add(Beginn);
            if (Pathpoints[zcopy].X > Pathpoints[zcopy - 1].X) return "left";
            if (Pathpoints[zcopy].X < Pathpoints[zcopy - 1].X) return "right";
            if (Pathpoints[zcopy].Y > Pathpoints[zcopy - 1].Y) return "up";
            if (Pathpoints[zcopy].Y < Pathpoints[zcopy - 1].Y) return "down";

            return "not found";
        }
        private bool knotenschonvorhanden(List<Knoten> myKnoten, int x, int y, int lastindex)
        {
            for (; lastindex >= 0; lastindex--)
            {
                if ((myKnoten[lastindex].Now_x == x) && (myKnoten[lastindex].Now_y == y))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
