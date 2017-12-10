using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public class TetrisController
    {
        private TetrisModel tm;
        private TetrisView tv;
        public String MoveLeftCommand = "left";
        public String MoveRightCommand = "right";
        public String MoveDownFastCommand = "down_f";
        public String MoveDownSlowCommand = "down_s";
        public String RotateCommand = "rotate";

        public TetrisController(TetrisView tv)
        {
            this.tv = tv;
            this.tm = new TetrisModel(tv);
        }
        // if user has inputed, then do the responding work
        public void userHasInput(string userInput)
        {
            if (userInput.Equals(MoveLeftCommand))
            {
                tm.setState(tm.MoveLeftState);
                tm.MoveLeft(tv.GetNowBlock());
            }
            else if (userInput.Equals(MoveLeftCommand))
            {
                tm.setState(tm.MoveRightState);
                tm.MoveRight(tv.GetNowBlock(),tv.GetAllBlocks());
            }
            else if (userInput.Equals(MoveDownFastCommand))
            {
                tm.setState(tm.MoveDownFastState);
                tm.DropDownFast(tv.GetNowBlock(), tv.GetAllBlocks());
            }
            else if (userInput.Equals(RotateCommand))
            {
                tm.setState(tm.RotateState);
                tm.Rotate(tv.GetNowBlock(), tv.GetAllBlocks());
            }
        }
        // let game start
        public void start()
        {
            tm.setState(tm.IdleState);
        }
    }
}
