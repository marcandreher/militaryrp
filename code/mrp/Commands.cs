using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.mrp
{
	internal class Commands
	{
		// TODO - delete me
		[ConCmd.Admin( "givemoney" )]
		public static void GiveAll()
		{
			
			var player = ConsoleSystem.Caller.Pawn as SandboxPlayer;
			player.Health = 60;
			player.money = 1000;


		}

		[ConCmd.Admin( "checkmoney" )]
		public static void CheckMoney()
		{

			var player = ConsoleSystem.Caller.Pawn as SandboxPlayer;
			Log.Info(player.money);


		}

		// TODO - delete me
		[ConCmd.Admin( "givejob" )]
		public static void GiveJob()
		{

			var player = ConsoleSystem.Caller.Pawn as SandboxPlayer;
			PlayerJob army = new PlayerJob();
			army.salary = 5;
			army.name = "Army";
			army.id = 1;
			player.playerJob = army;
			player.money = 1000;
		}
	}
}
