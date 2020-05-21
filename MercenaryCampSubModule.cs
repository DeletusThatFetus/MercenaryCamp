using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace MercenaryCamp
{
	public class MercenaryCampSubModule : MBSubModuleBase
	{
		protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
		{
			if (!(game.GameType is Campaign))
				return;
			gameStarterObject.AddModel(new MercenaryCampModel());
		}
	}
}