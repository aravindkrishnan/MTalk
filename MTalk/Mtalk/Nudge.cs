/////////////////////////////////////////////////////////////
///Author: Polis Pilavas
///Date: 15/04/2005
///
///Class Nudge will simulate a MSN-style nudge for a winform 
/////////////////////////////////////////////////////////////

using System;
using System.Windows.Forms;

namespace NudgeFormSolution
{
	/// <summary>
	/// A small class responsible for simulating the "Nudge" effect available on the
	/// latest version of MSN Messenger v7
	/// </summary>
	public class Nudge
	{
		private Form tmpFrm;
		
		/// <summary>
		/// Pass the form you want to nudge as 
		/// a parameter to the constructor
		/// </summary>
		/// <param name="theForm"></param>
		public Nudge(Form theForm)
		{
			this.tmpFrm = theForm;
		}

		/// <summary>
		/// Call this method to get the "nudge" effect
		/// </summary>
		public void NudgeMe()
		{
			int xCoord = this.tmpFrm.Left;
			int yCoord = this.tmpFrm.Top;
			int rnd = 0;

			Random RandomClass = new Random();

			for (int i = 0;  i <= 1300; i++)
			{
                if (i > 1000)
                {
                    rnd = RandomClass.Next(xCoord + 1, xCoord + 15);
                    this.tmpFrm.Left = rnd;
                    rnd = RandomClass.Next(yCoord + 1, yCoord + 15);
                    this.tmpFrm.Top = rnd;
                }
			}

			this.tmpFrm.Left = xCoord;
			this.tmpFrm.Top = yCoord;
		}
	}
}
