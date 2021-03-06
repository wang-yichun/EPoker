namespace yigame.epoker
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using uFrame.IOC;
	using uFrame.Kernel;
	using uFrame.MVVM;
	using uFrame.MVVM.Bindings;
	using uFrame.Serialization;
	using UnityEngine;
	using UniRx;
	using yigame.epoker;

    
	public partial class PlayerViewModel : PlayerViewModelBase
	{
		[Inject ("CoreGameRoot")] public CoreGameRootViewModel CoreGameRoot;

		public List<CardInfo> CurrentSelectedCards {
			get {
				return HandCards.Where (cardVM => cardVM.IsSelected).Select (_ => _.Info).ToList ();
			}
		}
	}
}
