using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PikoPiko.Forms
{
    public partial class Move : BaseUserControl
    {
        private PlayMove move;
        private DiceGroup DiceGroup => MainTable.Controls.OfType<DiceGroup>().FirstOrDefault();

        public int Minimun { get; set; }
        public int Points => move.Points;

        public event EventHandler OnMoveFinished;

        public Move()
        {
            InitializeComponent();

            Lvw.BackColor = BackColor;
            ButtonRoll.Visible = ButtonStop.Visible = false;
        }

        public void Prepare()
        {
            MainTable.Controls.Remove(DiceGroup);
            MainTable.Controls.Add(new DiceGroup(), 0, 1);
            DiceGroup.OnDiceClicked += DiceClicked;
            DiceGroup.OnStartClicked += StartMove;
            Lvw.Items.Clear();
        }

        public void End() => MainTable.Controls[0].Enabled = false;

        public void StartMove(object sender, EventArgs e)
        {
            move = new PlayMove();
            DiceGroup.SetResults(move.CurrentRoll.Results.ToList());
            DiceGroup.RollDices();
            ButtonStop.Text = "";

            ButtonRoll.Enabled = ButtonStop.Enabled = false;
            ButtonRoll.Visible = ButtonStop.Visible = true;
        }

        private void DiceClicked(object sender, EventArgs e)
        {
            var result = (sender as Dice).Result;
            ButtonRoll.Enabled = move.CanKeepRolling() && move.CanSave(result);

            ButtonStop.Enabled = CanStop(result);
        }

        private bool CanStop(IResult result)
        {
            if (!move.CanSave(result))
                return false;

            if (!result.IsWorm && !move.HasWormSaved)
                return false;

            return move.WhatIf(result) >= Minimun;
        }

        private void ButtonRoll_Click(object sender, EventArgs e)
        {
            Save(DiceGroup.SelectedResult);
            move.Roll();
            DiceGroup.SetResults(move.CurrentRoll.Results);
            DiceGroup.RollDices();

            if (!move.CanKeepRolling())
                Finish();
        }

        private void ButonStop_Click(object sender, EventArgs e)
        {
            Save(DiceGroup.SelectedResult);
            move.Stop();
            Finish();
        }

        private void Save(IResult result)
        {
            move.Save(result);
            ButtonStop.Text = move.VirtualPoints.ToString();
            ButtonRoll.Enabled = ButtonStop.Enabled = false;
            FillLvw();
        }

        private void FillLvw()
        {
            Lvw.Items.Clear();
            foreach (var rollEntry in move.GetSavedRollEntries)
            {
                var item = new ListViewItem($"{rollEntry.Result.ToString()} x {rollEntry.Quantity.ToString()}");
                Lvw.Items.Add(item);
            }
        }

        private void Finish()
        {
            ButtonRoll.Enabled = ButtonStop.Enabled = false;
            ButtonStop.Text = move.Points.ToString();
            OnMoveFinished?.Invoke(move, EventArgs.Empty);
        }

        public void SetPlayerInfo(Player player)
        {
            MoveHeader.Title = player.ToString();
            PlayerInfo.SetPlayer(player);
        }

        public void Setinfo(string info) => InfoLabel.Text = info;
    }
}
