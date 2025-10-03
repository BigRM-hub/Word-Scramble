using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryApp
{
    public partial class frmMemory : Form
    {
        List<Button> lstButtons;
        List<String> lstCards;
        List<string> lst;
        private enum TurnEnum { One, Two }
        string Turn = TurnEnum.One.ToString();
        Random rnd = new();
        String Guess1 = "NO";
        String Guess2 = "GO";
        int ClickCount = 0;
        int Score1 = 0;
        int Score2 = 0;

        public frmMemory()
        {
            InitializeComponent();
            btnStart.Click += BtnStart_Click;
            btn1.Click += BtnClick;
            btn2.Click += BtnClick;
            btn3.Click += BtnClick;
            btn4.Click += BtnClick;
            btn5.Click += BtnClick;
            btn6.Click += BtnClick;
            btn7.Click += BtnClick;
            btn8.Click += BtnClick;
            btn9.Click += BtnClick;
            btn10.Click += BtnClick;
            btn11.Click += BtnClick;
            btn12.Click += BtnClick;
            btn13.Click += BtnClick;
            btn14.Click += BtnClick;
            btn15.Click += BtnClick;
            btn16.Click += BtnClick;
            btn17.Click += BtnClick;
            btn18.Click += BtnClick;
            btn19.Click += BtnClick;
            btn20.Click += BtnClick;
            lstButtons = new() { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btn16, btn17, btn18, btn19, btn20 };
            lstCards = new() { "Bu", "Bu", "20", "20", "XI", "XI", "66", "66", "tt", "tt", "Pr", "Pr", "Fn", "Fn", "!,", "!,", "10", "10", "Me", "Me" };
            lst = new() { "Bu", "Bu", "20", "20", "XI", "XI", "66", "66", "tt", "tt", "Pr", "Pr", "Fn", "Fn", "!,", "!,", "10", "10", "Me", "Me" };
            //ShuffleList();
        }

        private void ShuffleList()
        {
            lst = lstCards.OrderBy(x => rnd.Next()).ToList();
        }

        private void ShowSymbol(Button btn, int n)
        {
            btn.Text = lst[n].ToString();
            SaveResult(lst[n].ToString());
        }

        private void AssignButton(Button btn)
        {
            if (btn == btn1)
            {
                ShowSymbol(btn, 0);
            }
            if (btn == btn2)
            {
                ShowSymbol(btn, 1);
            }
            if (btn == btn3)
            {
                ShowSymbol(btn, 2);
            }
            if (btn == btn4)
            {
                ShowSymbol(btn, 3);
            }
            if (btn == btn5)
            {
                ShowSymbol(btn, 4);
            }
            if (btn == btn6)
            {
                ShowSymbol(btn, 5);
            }
            if (btn == btn7)
            {
                ShowSymbol(btn, 6);
            }
            if (btn == btn8)
            {
                ShowSymbol(btn, 7);
            }
            if (btn == btn9)
            {
                ShowSymbol(btn, 8);
            }
            if (btn == btn10)
            {
                ShowSymbol(btn, 9);
            }
            if (btn == btn11)
            {
                ShowSymbol(btn, 10);
            }
            if (btn == btn12)
            {
                ShowSymbol(btn, 11);
            }
            if (btn == btn13)
            {
                ShowSymbol(btn, 12);
            }
            if (btn == btn14)
            {
                ShowSymbol(btn, 13);
            }
            if (btn == btn15)
            {
                ShowSymbol(btn, 14);
            }
            if (btn == btn16)
            {
                ShowSymbol(btn, 15);
            }
            if (btn == btn17)
            {
                ShowSymbol(btn, 16);
            }
            if (btn == btn18)
            {
                ShowSymbol(btn, 17);
            }
            if (btn == btn19)
            {
                ShowSymbol(btn, 18);
            }
            if (btn == btn20)
            {
                ShowSymbol(btn, 19);
            }
        }

        private void SwitchTurn()
        {
            Turn = Turn == "One" ? TurnEnum.Two.ToString() : TurnEnum.One.ToString();
        }

        private void TallyScore()
        {
            if (Turn == "One")
            {
                Score1++;
            }
            else
            {
                Score2++;
            }
        }

        private void DetectMatch()
        {
            if (Guess1 == Guess2)
            {
                //Score + 1
                TallyScore();
                lstButtons.Where(b => b.Text != "").ToList().ForEach(b => b.Enabled = false);
            }
            else
            {
                lstButtons.Where(b => (b.Text != "" && b.Enabled == true)).ToList().ForEach(b => b.Text = "");
                SwitchTurn();
            }
            Guess1 = "NO";
            Guess2 = "GO";
        }

        private void SaveResult(String s)
        {
            if (Guess1 == "NO")
            {
                Guess1 = s;
            }
            else
            {
                Guess2 = s;
            }
        }

        private void DoTurn()
        {
            ClickCount = ClickCount + 1;
            if (ClickCount == 2)
            {
                
                DetectMatch();
                ClickCount = 0;
                //SwitchTurn();
            }
        }

        private void ClearTiles()
        {
            lstButtons.ForEach(b => b.Text = "");
            lstButtons.ForEach(b => b.Enabled = true);
            Guess1 = "NO";
            Guess2 = "GO";
        }

        private void DisplayStatus()
        {
            lblP1Score.Text = Score1.ToString();
            lblP2Score.Text = Score2.ToString();
            lblPlayerTurn.Text = "Player " + Turn;
        }

        private void Reset()
        {
            lblPlayer1.Text = txtPlayer1.Text + ":";
            lblPlayer2.Text = txtPlayer2.Text + ":";
            Score1 = 0; Score2 = 0;
            lblP1Score.Text = "";
            lblP2Score.Text = "";
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            ClearTiles();
            ShuffleList();
            Reset();
            lblPlayerTurn.Text = "Player " + Turn;
        }

        private void BtnClick(object? sender, EventArgs e)
        {

            if (sender is Button)
            {
                Button btn = (Button)sender;
                AssignButton(btn);
                
                DoTurn();
                DisplayStatus();
            }

        }
    }
}
