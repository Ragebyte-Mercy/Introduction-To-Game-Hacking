using System;
using System.Diagnostics;
using System.Windows.Forms;
using Memory;

namespace Assault_Cube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Mem m = new Mem();

        // { PUT FUNCTION NAMES HERE TO MAKE EASIER TO FIND }

        // ==================================================================================

        // God Mode + Zombies Ignore + Unlimited Health 

        string godAddress = ""; // 1000 = Unlimited Health
        string zombiesIgnore = ""; // 0 = Dead { Zombies Will Ignore Player Will Still Be Alive }

        // These Address's Are The Same.

        // ==================================================================================

        // Camo Address { Camo Swapper }

        string camoAddress = ""; // Class 1 Primary Camo Swap Offset
        string camoAddress1 = ""; // Class 1 Secondary Camo Swap Offset

        // These Address's Are Never The Same

        // ==================================================================================

        // Super Speed + Freeze Player 

        string speedAddress = "";  // Put Speed Value To Whatever
        string FreezeAddress = ""; // Put Speed Value To 0

        // These Address's Are The Same

        // ==================================================================================

        // Unlimited Points + Unlimited Score

        string pointsAddress = "";
        string scoreAddress = "";

        // These Address's Are Not Always The Same.

        // ==================================================================================

        // Colored Classes + Invalid Char Bypass + Invalid Menu_ Bypass
        string coloredClasses1 = "";
        string invalidchar = "";
        string invalidmenu = "";

        // Invalid Char + Invalid Menu Are NEVER THE SAME as Colored Class 1 Offset.

        // ==================================================================================

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
             
            if (checkbox1.Checked = true) // Just An Exmaple Of How To Setup Functions That Run On A Loop.
            {
                m.writememory(godAddress, "int", "999");
                m.writememory(camoAddress, "byte", "999");
                m.writememory(speedAddress, "float", "999");
                m.writememory(pointsAddress, "double", "999");
                m.writememory(coloredClasses1, "string[10]", "^2Ragebyte");
            }

            else 
            {
               // Nothing Needed Here. Unless You Want To Revert Changes, 
            }

            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int PID = m.GetProcIdFromName("game.exe"); // Put Your Game Name Here

            if (PID > 0) // If Game = Open Then Attach
            {
                m.OpenProcess(PID);
                label1.Text = "Connected Status : Connected";  // If Game = Open Then Successfully Attaches Text Updates To Inform User Tool Is Connected.
                timer1.Start();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Label1 Is Connection Status No Code Needed Here Besides Whats Seen Inside Form1_Load
        }
    }
}
