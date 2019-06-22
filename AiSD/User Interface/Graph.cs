using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business_logic_3_;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace User_Interface
{
   public class Graph 
    {
        /*Задача 48.
В картинной галерее каждый сторож работает в течение некоторого непрерывного отрезка времени.
Расписанием стражи называется множество пар [Т1(i), Т2(i)] - моментов начала и конца дежурства i-го сторожа из интервала [0,EndTime].
Для заданного расписания стражи требуется:
(а) проверить, в любой ли момент в галерее находится не менее двух сторожей.
Если условие (а) не выполнено, то:
(б) перечислить все интервалы времени с недостаточной охраной (менее 2 сторожей).

            ВХОДНЫЕ ДАННЫЕ:
(Все моменты времени задаются в целых минутах.)
EndTime - момент окончания стражи, т.е. охраняется отрезок времени [0, EndTime].
N -число сторожей.
T1[i], T2[i], i=1,..N - моменты начала и окончания дежурства i-го сторожа.
Length - длительность дежурства каждого дополнительного сторожа.
ВЫХОДНЫЕ ДАННЫЕ:
(1) Ответ на пункт (а) в форме да/нет.
(2) При ответе "нет" на п. (а) - список пар (k,l) - начал и концов всех малоохраняемых интервалов с указанием числа сторожей в каждом (0 или 1).

*/
        public List<NodeGraph> NodeList { get; set; }
        
        public int PanelWidth { get; set; }
        public int PanelHeight { get; set; }


        public Graph(List<NodeGraph> p, int panelWidth, int panelHeight)
        {
            PanelWidth = panelWidth;
            PanelHeight = panelHeight;
            NodeList = new List<NodeGraph>();
            NodeList = p;
            SetCoordinates();
        }
        public Bitmap DrawGraph()
        {
            Bitmap gBitmap = new Bitmap(PanelWidth, PanelHeight);
            Graphics gGraphics = Graphics.FromImage(gBitmap);
            gGraphics.Clear(Color.White);

            StringFormat centreNum = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Pen pen = new Pen(Color.Black, 3);
            pen.EndCap = LineCap.ArrowAnchor;

            for (int i = 0; i < NodeList.Count; i++)
            {
                for (int j = 0; j < NodeList[i].WorkTime.Length; j++)
                {
                    Rectangle start = new Rectangle(NodeList[i].Coordinates[j][0], NodeList[i].Coordinates[j][1],70,40);
                    gGraphics.DrawRectangle(new Pen(Color.Black, 3), start);
                    gGraphics.DrawString(NodeList[i].Name.ToString(), SystemFonts.DefaultFont, Brushes.Black, start, centreNum);

                    bool checkEnd = false;
                    for (int k = 0; k < NodeList.Count; k++)
                    {
                        for (int h = 0; h < NodeList[k].WorkTime.Length; ++h)
                        {
                            if(NodeList[i].WorkTime[j][1]==NodeList[k].WorkTime[h][0])
                                checkEnd= true;
                        }
                    }

                    if (!checkEnd)
                    {
                        Rectangle end = new Rectangle(NodeList[i].Coordinates[j][2]+35, NodeList[i].Coordinates[j][3], 70, 40);
                        gGraphics.DrawRectangle(new Pen(Color.Black, 3), end);
                        gGraphics.DrawLine(pen, NodeList[i].Coordinates[j][0] + 35,
                        NodeList[i].Coordinates[j][1] + 40, NodeList[i].Coordinates[j][2] + 35+35, NodeList[i].Coordinates[j][3]);
                    }
                    else
                    {
                        gGraphics.DrawLine(pen, NodeList[i].Coordinates[j][0] + 35,
                        NodeList[i].Coordinates[j][1] + 40, NodeList[i].Coordinates[j][2] + 35, NodeList[i].Coordinates[j][3]);
                    }
                }
            }
            gGraphics.Dispose();
            return gBitmap;
        }
        public Bitmap ShowWeight(Bitmap Gbitmap)
        {
            for (int i = 0; i < NodeList.Count; i++)
            {
                for (int j = 0; j < NodeList[i].Time.Count; j++)
                {

                    Graphics gGraphics = Graphics.FromImage(Gbitmap);
                    gGraphics.FillRectangle(Brushes.White, 
                        NodeList[i].Coordinates[j][0]+(NodeList[i].Coordinates[j][2]- NodeList[i].Coordinates[j][0])/2,
                        NodeList[i].Coordinates[j][1] + (NodeList[i].Coordinates[j][3] - NodeList[i].Coordinates[j][1]) / 2
                        , 25, 20);

                    gGraphics.DrawString(NodeList[i].Time[j].ToString(), SystemFonts.DefaultFont, Brushes.Black,
                         NodeList[i].Coordinates[j][0] + (NodeList[i].Coordinates[j][2] - NodeList[i].Coordinates[j][0]) / 2,
                        NodeList[i].Coordinates[j][1] + (NodeList[i].Coordinates[j][3] - NodeList[i].Coordinates[j][1]) / 2);
                }
            }

            return Gbitmap;
        }

        public  void SetCoordinates()
        {
        Dictionary<int, int> VisitArr = new Dictionary<int, int>();

            for (int i = 0; i < NodeList.Count; i++)
            {
                for (int j = 0; j < NodeList[i].WorkTime.Length; j++)
                {
                    if ((NodeList[i].WorkTime[j][0] < 300) || ((NodeList[i].WorkTime[j][0] > 600) && (NodeList[i].WorkTime[j][0] < 900)))
                    {
                        if (VisitArr.ContainsKey(NodeList[i].WorkTime[j][0]))
                            VisitArr[NodeList[i].WorkTime[j][0]]++;
                        else VisitArr.Add(NodeList[i].WorkTime[j][0], 0);

                        NodeList[i].Coordinates[j][0] = 150+100*VisitArr[NodeList[i].WorkTime[j][0]];
                        NodeList[i].Coordinates[j][1] = NodeList[i].WorkTime[j][0]; //y1
                    }
                    else
                    {
                        if (VisitArr.ContainsKey(NodeList[i].WorkTime[j][0]))
                            VisitArr[NodeList[i].WorkTime[j][0]]++;
                        else VisitArr.Add(NodeList[i].WorkTime[j][0], 0);

                        NodeList[i].Coordinates[j][0] = 350 + 100 * VisitArr[NodeList[i].WorkTime[j][0]];//x1
                        NodeList[i].Coordinates[j][1] = NodeList[i].WorkTime[j][0]; //y1
                    }

                    if ((NodeList[i].WorkTime[j][1] < 300) || ((NodeList[i].WorkTime[j][1] > 600) && (NodeList[i].WorkTime[j][1] < 900)))
                    {
                        NodeList[i].Coordinates[j][2] = 150;//x2
                        NodeList[i].Coordinates[j][3] = NodeList[i].WorkTime[j][1]; //y2
                    }
                    else
                    {
                        NodeList[i].Coordinates[j][2] = 350;//x2
                        NodeList[i].Coordinates[j][3] = NodeList[i].WorkTime[j][1]; //y2

                    }
                }
            }
        }
    }
}
