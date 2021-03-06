namespace yigame.epoker
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using uFrame.Kernel;
	using uFrame.MVVM;
	using uFrame.MVVM.Services;
	using uFrame.MVVM.Bindings;
	using uFrame.Serialization;
	using uFrame.IOC;
	using UniRx;
	using UnityEngine;
	using UnityEngine.UI;
	using yigame.epoker;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using Unity.Linq;

    
	public class PlayerView : PlayerViewBase
	{
		[Inject] public GameService GameService;

		public Button ReadyButton;
		public Button StartButton;
		public Button DealButton;
		public Text DealButtonText;

		public Text RankText;

		public GameObject WaitingNode;
		public GameObject PlayingNode;
		public GameObject PlayingCanvasNode;
		public GameObject WinNode;

		protected override void InitializeViewModel (uFrame.MVVM.ViewModel model)
		{
			base.InitializeViewModel (model);
		}

		protected override void PreBind ()
		{
			base.PreBind ();
		}

		public override void Bind ()
		{
			base.Bind ();
		}

		public override void AfterBind ()
		{
			base.AfterBind ();
		}

		#region Status Changed

		public override void StatusChanged (Invert.StateMachine.State arg1)
		{
			PlayingCanvasNode.SetActive (false);

			base.StatusChanged (arg1);
		}

		public override void OnInit ()
		{
			base.OnInit ();

			ReadyButton.gameObject.SetActive (false);
			StartButton.gameObject.SetActive (false);

			Player.PlayerNodeMode = PlayerNodeMode.Waiting;

			// 忽略初始设计用的 Player
			if (string.IsNullOrEmpty (Player.PlayerName))
				return;

			Player.ReadyStatusText = "Initializing...";
			Observable.Timer (TimeSpan.FromSeconds (1)).Subscribe (_ => {
				Player.ExecuteInitOK ();
				Player.ExecuteRefreshPlayer ();
			}).DisposeWhenChanged (Player.StatusProperty);
		}

		public override void OnWait ()
		{
			base.OnWait ();
			Player.ReadyStatusText = string.Format ("{0}|{1} Wait...", Player.ActorId, Player.PlayerName);
			ReadyButton.gameObject.Child ("Text").GetComponent<Text> ().text = "Ready";
		}

		public override void OnReady ()
		{
			base.OnReady ();
			Player.ReadyStatusText = string.Format ("{0}|{1} Ready!", Player.ActorId, Player.PlayerName);
			ReadyButton.gameObject.Child ("Text").GetComponent<Text> ().text = "Cancel";
		}

		public override void OnMatchPrepare ()
		{
			base.OnMatchPrepare ();
			Player.PlayerNodeMode = PlayerNodeMode.Playing;


			bool my_turn = Convert.ToBoolean (Player.LBPlayer.CustomProperties ["my_turn"]);
			if (my_turn) {
				Player.ExecuteBeganToPlay ();
			} else {
				Player.ExecuteBeganToWait ();
			}
		}

		public override void OnMatchDeal ()
		{
			if (Player.IsSelf) {
				PlayingCanvasNode.SetActive (true);
			}
			base.OnMatchDeal ();
		}

		public override void OnMatchIdle ()
		{
			base.OnMatchIdle ();
		}

		public override void OnMatchWin ()
		{
			base.OnMatchWin ();
			Player.PlayerNodeMode = PlayerNodeMode.WinWaiting;
		}

		public override void OnMatchOver ()
		{
			base.OnMatchOver ();
			Player.PlayerNodeMode = PlayerNodeMode.Waiting;
			Player.ReadyStatusText = string.Format ("{0}|{1} Wait...", Player.ActorId, Player.PlayerName);
			ReadyButton.gameObject.Child ("Text").GetComponent<Text> ().text = "Ready";

			if (Player.IsSelf) {
				Player.CoreGameRoot.ShowSummary = true;
			}
		}

		#endregion

		public override void PosIdChanged (String arg1)
		{
			SetPanelPosByPosId ();
		}

		public void SetPanelPosByPosId ()
		{
			if (string.IsNullOrEmpty (Player.PosId)) {
				return;
			}

			string pos_obj_name = string.Format ("PlayerPos{0}", Player.PosId);

			Vector3 pos = Player.CoreGameRoot.PosIdPosition [pos_obj_name];
			transform.position = pos;

//			Debug.Log (pos_obj_name + pos.ToString ());
		}

		public override void IsSelfChanged (Boolean arg1)
		{
			if (arg1) {
				gameObject.Descendants ("Button_Ready").Single ().SetActive (true);
			} else {
				gameObject.Descendants ("Button_Ready").Single ().SetActive (false);
			}
		}

		public override void RefreshPlayerExecuted (RefreshPlayerCommand command)
		{
			if (Player.PlayerRoomIdentity == RoomIdentity.RoomMaster) {
				if (Player.IsSelf) {
					if (Player.CoreGameRoot.CanMatchBegan) {
						StartButton.gameObject.SetActive (true);
					} else {
						StartButton.gameObject.SetActive (false);
					}
				} else {
					StartButton.gameObject.SetActive (false);
				}
			} else {
				StartButton.gameObject.SetActive (false);
			}
		}

    
		public override uFrame.MVVM.ViewBase HandCardsCreateView (uFrame.MVVM.ViewModel viewModel)
		{
			GameObject prefab = Resources.Load<GameObject> ("_Card_Blue_");
			return InstantiateView (prefab, viewModel);
		}

		public override void HandCardsAdded (uFrame.MVVM.ViewBase view)
		{
		}

		public override void HandCardsRemoved (uFrame.MVVM.ViewBase view)
		{
			Destroy (view.gameObject);
		}

		public override void PlayerNodeModeChanged (PlayerNodeMode arg1)
		{
			switch (arg1) {
			case PlayerNodeMode.Waiting:
				WaitingNode.SetActive (true);
				PlayingNode.SetActive (false);
				WinNode.SetActive (false);
				break;
			case PlayerNodeMode.Playing:
				WaitingNode.SetActive (false);
				PlayingNode.SetActive (true);
				WinNode.SetActive (false);
				break;
			case PlayerNodeMode.WinWaiting:
				WaitingNode.SetActive (false);
				PlayingNode.SetActive (false);
				WinNode.SetActive (true);
				break;
			default:
				throw new ArgumentOutOfRangeException ();
			}
		}

		public override void RankChanged (Int32 arg1)
		{
			if (arg1 <= 0) {
				RankText.text = "";
			} else {
				RankText.text = string.Format ("Rank:{0}", arg1);
			}
		}

		public override void ButtonDealEnableChanged (Boolean arg1)
		{
			DealButton.interactable = arg1;
		}
	}
}
