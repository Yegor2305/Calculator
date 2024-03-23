using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class ApplicationState
    {
        public string date = "";
        public string inputFieldData = "";
        public int cursorPos;
        public ApplicationState(int cursorPos, string date = "", string iFD = "")
        {
            this.date = date;
            inputFieldData = iFD;
            this.cursorPos = cursorPos;
        }
    }
}
